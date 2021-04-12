using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.SystemSettingForms
{
    public partial class FrmPublishingHouse : XtraForm
    {
        public FrmPublishingHouse()
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
                var result = XtraInputBox.Show("请输入", "新增出版社信息", string.Empty);
                if (string.IsNullOrEmpty(result)) return;
                var resultMessage = await _api.CreatePublishingHouse(new PublishingHouse {PublishingName = result});
                if (resultMessage.ResultCode != 1)
                {
                    PopupProvider.Warning(resultMessage.ResultMessage);
                    return;
                }

                PopupProvider.Success(resultMessage.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("添加异常!", exception);
            }
        }

        private async void FrmPublishingHouse_Load(object sender, EventArgs e)
        {
            await BindData();
        }

        public async Task BindData()
        {
            try
            {
                var data = await _api.GetPublishingHouses();
                Gc_PublishingHouses.DataSource = data;
            }
            catch (Exception e)
            {
                PopupProvider.Error("获取出版社信息异常!", e);
            }
        }

        private async void Sb_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Gv_PublishingHouses.FocusedRowHandle < 0) return;
                var name = Gv_PublishingHouses.GetFocusedRowCellDisplayText("PublishingName");
                var id = Gv_PublishingHouses.GetFocusedRowCellDisplayText("Id");
                var result = XtraInputBox.Show("请输入", "修改出版社信息", name);
                if (string.IsNullOrEmpty(result)) return;
                var resultMessage = await _propertiesApi.UpdatePublishingHouse(id, result);
                if (resultMessage.ResultCode != 1)
                {
                    PopupProvider.Warning(resultMessage.ResultMessage);
                    return;
                }

                PopupProvider.Success(resultMessage.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("添加异常!", exception);
            }
        }
    }
}