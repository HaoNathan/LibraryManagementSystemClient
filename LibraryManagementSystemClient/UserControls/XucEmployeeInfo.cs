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
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.UserControls
{
    public partial class XucEmployeeInfo : XtraUserControl
    {
        public XucEmployeeInfo(bool addOrUpdate)
        {
            InitializeComponent();

            _addOrUpdate = addOrUpdate;

            _api = new EmployeeApi();

            _propertiesApi = new SystemSettingApi();
        }

        //新增还是修改 True:新增 False:修改
        private readonly bool _addOrUpdate;
        
        //需要修改的员工信息 Id
        public static Guid Id;

        private readonly EmployeeApi _api;

        private readonly SystemSettingApi _propertiesApi;

        private async void Sb_AddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!Dvp_Validate.Validate()) return;
            var employee = new Employee
            {
                EmployeeName = Te_Name.Text,
                Age = Convert.ToInt32(Te_Age.EditValue),
                BirthDay = De_BirthDay.DateTime,
                Contact = Te_Contact.Text,
                DepartmentId = Guid.Parse(Lue_Department.EditValue.ToString()),
                Sex = Rg_Sex.SelectedIndex == 1,
            };
            try
            {
                JsonMessageResult message;
                if (_addOrUpdate)
                    message = await _api.CreateEmployee(employee);
                else
                {
                    employee.Id = Id;
                    message = await _api.UpdateEmployee(employee);
                }

                if (message.ResultCode != 1)
                {
                    XtraMessageBox.Show("修改失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseForm();
                    return;
                }

                XtraMessageBox.Show(message.ResultMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                CloseForm();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm();
            }
        }

        private void Sb_Cancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private async Task BindData()
        {
            var departments = await _propertiesApi.GetCompanyDepartments(false);
            Lue_Department.Properties.DataSource  = departments;
            Lue_Department.EditValue = departments[0].Id;

            if(_addOrUpdate)return;
            var employee = await _api.GetEmployee(Id);
            Te_Age.Text = employee.Age.ToString();
            Te_Name.Text = employee.EmployeeName;
            Lue_Department.EditValue = employee.DepartmentId;
            De_BirthDay.DateTime = employee.BirthDay;
            Rg_Sex.SelectedIndex = employee.Sex ? 1 : 0;
            Te_Contact.Text = employee.Contact;
            Sb_AddOrUpdate.Text = @"修改";
        }

        /// <summary>
        /// 关闭弹出窗体
        /// </summary>
        private void CloseForm()
        {
            var parent = (XtraDialogForm)Parent;
            parent.DialogResult = DialogResult.Yes;
        }

        private async void XucEmployeeInfo_Load(object sender, EventArgs e)
        {
           await BindData();
        }
    }
}
