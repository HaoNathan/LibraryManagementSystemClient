using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.SystemSettingForms
{
    public partial class FrmBookCategory : XtraForm
    {
        public FrmBookCategory()
        {
            InitializeComponent();

            _api = new BookInfoApi();

            _propertiesApi = new BookPropertiesApi();
        }

        private readonly BookInfoApi _api;
        private readonly BookPropertiesApi _propertiesApi;

        private async void Sb_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var result = XtraInputBox.Show(this, "请输入", "新增书籍类别信息", "", MessageBoxButtons.OK);
                if (string.IsNullOrEmpty(result)) return;
                var resultMessage = await _api.CreateBookCategory(new BookCategory {CategoryName = result});
                if (resultMessage.ResultCode!=1)
                {
                    PopupProvider.Warning(resultMessage.ResultMessage);
                    return;
                }
                PopupProvider.Success(resultMessage.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("新增异常!", exception);
            }

        }

        private async void FrmBookCategory_Load(object sender, EventArgs e)
        {
            await BindData();
        }


        private async void Sb_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Gv_Categories.FocusedRowHandle < 0) return;
                var id = Gv_Categories.GetFocusedRowCellValue("Id").ToString();
                var categoryName = Gv_Categories.GetFocusedRowCellDisplayText("CategoryName");
                var result = XtraInputBox.Show(this, "请输入", "修改书籍类别信息", categoryName, MessageBoxButtons.YesNo);
                if (string.IsNullOrEmpty(result)) return;
                var resultMessage = await _propertiesApi.UpdateCategory(id, result);
                if (resultMessage.ResultCode != 1)
                {
                    PopupProvider.Warning(resultMessage.ResultMessage);
                    return;
                }

                PopupProvider.Success(resultMessage.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("修改异常!", exception);
            }
        }

        private async void Rits_Toggle_Toggled(object sender, EventArgs e)
        {
            try
            {
                var id = Guid.Parse(Gv_Categories.GetFocusedRowCellValue("Id").ToString());
                var toggle = (ToggleSwitch) sender;
                var result = await _propertiesApi.UpdateBookCategory(id, Convert.ToBoolean(toggle.EditValue));
                if (result.ResultCode != 1)
                {
                    PopupProvider.Warning(result.ResultMessage);
                    return;
                }

                PopupProvider.Success(result.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("修改状态异常!", exception);
            }
        }

        public async Task BindData()
        {
            try
            {
                var data = await _api.GetBookCategories();
                Gc_Categories.DataSource = data;
            }
            catch (Exception e)
            {
                PopupProvider.Error("获取数据异常!", e);
            }
        }
    }
}