using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.UserControls
{
    public partial class XucBookInfo : XtraUserControl
    {
        public XucBookInfo(bool addOrUpdate)
        {
            InitializeComponent();

            _addOrUpdate = addOrUpdate;

            _api = new BookInfoApi();
        }

        //新增还是修改 True:新增 False:修改
        private readonly bool _addOrUpdate;

        //接口数据
        private readonly BookInfoApi _api;

        //书籍 封面图像保存路径
        private string _imageUrl;

        //书籍信息Id
        public static Guid Id;

        private async void Sb_AddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Dvp_Validate.Validate()) return;
                JsonMessageResult messageResult;
                var bookInfo = new BookInfo
                {
                    BookName = Te_BookName.Text,
                    Author = Te_Author.Text,
                    ISBN = Te_Isbn.Text,
                    BookPhoto = _imageUrl,
                    PublishingId = Guid.Parse(Lue_PublishingHouse.EditValue.ToString()),
                    BookCategoryId = Guid.Parse(Lue_BookCategories.EditValue.ToString()),
                    Price = Convert.ToDecimal(Te_Price.EditValue),
                    ReleaseDate = De_ReleaseDate.DateTime
                };

                if (!_addOrUpdate)
                {
                    bookInfo.Id = Id;
                    messageResult = await _api.UpdateBookInfo(bookInfo);
                }
                else
                    messageResult = await _api.CreateBooksInfo(bookInfo);

                if (messageResult.ResultCode != 1)
                {
                    XtraMessageBox.Show(messageResult.ResultMessage);
                    return;
                }

                XtraMessageBox.Show("操作成功!");
                CloseForm();
            }
            catch (Exception exception)
            {
                PopupProvider.Error("操作异常!",exception);
            }
        }

        private async void FrmCreateBook_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = await _api.GetBookCategories(false);
                Lue_BookCategories.Properties.DataSource = categories;
                Lue_BookCategories.EditValue = categories[0].Id;

                var publishingHouses = await _api.GetPublishingHouses(false);
                Lue_PublishingHouse.Properties.DataSource = publishingHouses;
                if (!_addOrUpdate) BindData();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
                LogHelper.Error(exception.ToString());
            }
        }

        private void Pe_Photo_ImageChanged(object sender, EventArgs e)
        {
            if (Pe_Photo.Image == null) return;
            _imageUrl = $@"{Application.StartupPath}\Resource\UploadImages\{Guid.NewGuid():N}.jpg";
            Pe_Photo.Image.Save(_imageUrl, ImageFormat.Jpeg);
        }

        /// <summary>
        /// 当为修改操作时进行数据获取绑定
        /// </summary>
        private async void BindData()
        {

            Sb_AddOrUpdate.Text = @"修改";

            try
            {
                var bookInfo = await _api.GetBookInfo(Id);
                Pe_Photo.Image = Image.FromFile(bookInfo.BookPhoto);
                Te_Author.Text = bookInfo.Author;
                Te_BookName.Text = bookInfo.BookName;
                Te_Isbn.Text = bookInfo.ISBN;
                Te_Price.EditValue = bookInfo.Price;
                De_ReleaseDate.DateTime = bookInfo.ReleaseDate;
                Lue_BookCategories.EditValue = bookInfo.BookCategoryId;
                Lue_PublishingHouse.EditValue = bookInfo.PublishingId;
            }
            catch (Exception e)
            {
                LogHelper.Error(e.ToString());
                XtraMessageBox.Show("获取数据异常!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sb_Cancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        /// <summary>
        /// 关闭弹出窗体
        /// </summary>
        private void CloseForm()
        {
            var parent = (XtraDialogForm)Parent;
            parent.DialogResult = DialogResult.Yes;
        }
    }
}