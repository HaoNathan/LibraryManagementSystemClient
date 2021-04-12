using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.AdminForms
{
    public partial class FrmAdmins : XtraForm
    {
        public FrmAdmins()
        {
            InitializeComponent();
            _api = new AdminApi();
        }

        private readonly AdminApi _api;

        private async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = new Dictionary<string, object>
                {
                    {"CreateTime", $"{De_Begin.DateTime:yyyy-MM-dd HH:mm:ss}~{De_End.DateTime:yyyy-MM-dd HH:mm:ss}"},
                    {"%AdminName", Te_AdminName.Text}
                };
                if (string.IsNullOrEmpty(Te_AdminName.Text))
                {
                    dic.Remove("%AdminName");
                }

                var data = await _api.GetAdminsByPara(dic);
                Gc_Admins.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询数据异常!", exception);
            }
        }

        private async void FrmAdmins_Load(object sender, EventArgs e)
        {
            #region 设置属性

            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);

            #endregion

            #region 加载数据

            await BindData();

            #endregion
        }

        public async Task BindData()
        {
            try
            {
                var data = await _api.GetAdmins(true);
                Gc_Admins.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("加载管理员数据异常!", exception);
            }
        }
    }
}