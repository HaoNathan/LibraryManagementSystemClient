using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.UserControls
{
    public partial class XucStudentInfo : XtraUserControl
    {
        public XucStudentInfo(bool addOrUpdate)
        {
            InitializeComponent();

            _addOrUpdate = addOrUpdate;

            _api = new StudentApi();

            _propertiesApi = new SystemSettingApi();
        }

        private readonly StudentApi _api;

        private readonly SystemSettingApi _propertiesApi;

        public static Guid Id;

        //新增还是修改 True:新增 False:修改
        private readonly bool _addOrUpdate;

        private async void Sb_AddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!Dvp_Validate.Validate()) return;
            var student = new Student
            {
                StudentName = Te_Name.Text,
                Age = Convert.ToInt32(Te_Age.EditValue),
                BirthDay = De_BirthDay.DateTime,
                Class = Te_Class.Text,
                Contact = Te_Phone.Text,
                DepartmentId = Guid.Parse(Lue_Department.EditValue.ToString()),
                Email = Te_Email.Text,
                Sex = Rg_Sex.SelectedIndex == 1,
                StudentNo = Te_StudentNo.Text
            };
            try
            {
                JsonMessageResult message;
                if (_addOrUpdate)
                    message = await _api.CreateStudent(student);
                else
                {
                    student.Id = Id;
                    message = await _api.UpdateStudent(student);
                }

                if (message.ResultCode != 1)
                {
                    XtraMessageBox.Show(message.ResultMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CloseForm();
                XtraMessageBox.Show(message.ResultMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void XucStudentInfo_Load(object sender, EventArgs e)
        {
            await BindData();
        }

        private async Task BindData()
        {
            try
            {
                var data = await _propertiesApi.GetDepartments(false);
                Lue_Department.Properties.DataSource = data;
                Lue_Department.EditValue = data[0].Id;
                
                #region Update 操作进行数据加载

                if (_addOrUpdate) return;
                var student = await _api.GetStudent(Id);
                Te_Age.Text = student.Age.ToString();
                Te_Class.Text = student.Class;
                Te_Email.Text = student.Email;
                Te_Name.Text = student.StudentName;
                Te_Phone.Text = student.Contact;
                Te_StudentNo.Text = student.StudentNo;
                De_BirthDay.DateTime = student.BirthDay;
                Lue_Department.EditValue = student.DepartmentId;
                Rg_Sex.SelectedIndex = student.Sex ? 1 : 0;
                Sb_AddOrUpdate.Text = @"修改";

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 关闭弹出窗体
        /// </summary>
        private void CloseForm()
        {
            var parent = (XtraDialogForm)Parent;
            parent.DialogResult = DialogResult.Yes;
        }

        private void Sb_Cancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
