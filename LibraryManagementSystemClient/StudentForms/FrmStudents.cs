using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemClient.UserControls;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.StudentForms
{
    public partial class FrmStudents : XtraForm
    {
        public FrmStudents()
        {
            InitializeComponent();

            _api = new StudentApi();
        }

        private readonly StudentApi _api;

        private async void FrmStudents_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);
            await BindData();
        }

        private void Sb_Add_Click(object sender, EventArgs e)
        {
            ShowStudentInfoForm(true);
        }

        private void Gv_Students_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks != 2) return;
            var id = Guid.Parse(Gv_Students.GetFocusedRowCellValue("Id").ToString());
            ShowStudentInfoForm(false, id);
        }

        /// <summary>
        /// 显示学生信息编辑窗体
        /// </summary>
        /// <param name="addOrUpdate">True 添加;False 修改</param>
        /// <param name="id">Id</param>
        private void ShowStudentInfoForm(bool addOrUpdate, Guid id = new Guid())
        {
            if (!addOrUpdate)
            {
                XucStudentInfo.Id = id;
            }

            var ucStudentInfo = new XucStudentInfo(addOrUpdate);
            var form = new XtraDialogForm
            {
                Dock = DockStyle.Fill,
                MaximizeBox = false,
                AutoSize = true,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                CloseBox = false,
                MaximumClientSize = ucStudentInfo.Size
            };
            form.AddControl(ucStudentInfo);
            var dialog = form.ShowDialog();
            if (dialog != DialogResult.Yes) return;
            form.Close();
        }

        private void Sb_Update_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(Gv_Students.GetFocusedRowCellValue("Id").ToString());
            ShowStudentInfoForm(false, id);
        }

        public async Task BindData()
        {
            try
            {
                var data = await _api.GetStudents(true);
                Gc_Students.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取学生信息数据异常！",exception);
            }
        }

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = new Dictionary<string, object>
                {
                    {"CreateTime", $"{De_Begin.DateTime}~{De_End.DateTime}"},
                    {"StudentName%", Te_Name.Text}
                };
                if (string.IsNullOrEmpty(Te_Name.Text))
                {
                    dic.Remove("StudentName%");
                }
                var data = await _api.GetStudents(dic);
                Gc_Students.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询学生数据异常!", exception);
            }
        }
    }
}