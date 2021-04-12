using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemClient.UserControls;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.EmployeeForms
{
    public partial class FrmEmployees : XtraForm
    {
        public FrmEmployees()
        {
            InitializeComponent();

            _api = new EmployeeApi();
        }

        private readonly EmployeeApi _api;

        private async void FrmEmployees_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);
            await BindData();
        }

        private void Sb_Update_Click(object sender, EventArgs e)
        {
            if (Gv_Employees.FocusedRowHandle<0) return;
            var id = Guid.Parse(Gv_Employees.GetFocusedRowCellValue("Id").ToString());
            ShowEmployeeInfoForm(false, id);
        }

        private void Sb_Add_Click(object sender, EventArgs e)
        {
            ShowEmployeeInfoForm(true);
        }

        /// <summary>
        /// 显示员工信息编辑窗体
        /// </summary>
        /// <param name="addOrUpdate">True 添加;False 修改</param>
        /// <param name="id">Id</param>
        private void ShowEmployeeInfoForm(bool addOrUpdate, Guid id = new Guid())
        {
            if (!addOrUpdate)
            {
                XucEmployeeInfo.Id = id;
            }

            var ucEmployeeInfo = new XucEmployeeInfo(addOrUpdate);
            var form = new XtraDialogForm
            {
                Dock = DockStyle.Fill,
                MaximizeBox = false,
                AutoSize = true,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                CloseBox = false,
                MaximumClientSize = ucEmployeeInfo.Size
            };
            form.AddControl(ucEmployeeInfo);
            var dialog = form.ShowDialog();
            if (dialog != DialogResult.Yes) return;
            form.Close();
        }

        public async Task BindData()
        {
            try
            {
                var data = await _api.GetEmployees(true);
                Gc_Employees.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取员工数据异常!", exception);
            }
        }

        private async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = new Dictionary<string, object>
                {
                    {"CreateTime", $"{De_Begin.DateTime}~{De_End.DateTime}"},
                    {"EmployeeName%", Te_Name.Text}
                };
                if (string.IsNullOrEmpty(Te_Name.Text))
                {
                    dic.Remove("EmployeeName%");
                }
                var data = await _api.GetEmployees(dic);
                Gc_Employees.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询员工数据异常!",exception);
            }
            
        }

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}