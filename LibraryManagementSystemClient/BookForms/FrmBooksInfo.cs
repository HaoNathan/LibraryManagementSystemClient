using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemClient.UserControls;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.BookForms
{
    public partial class FrmBooksInfo : XtraForm
    {
        public FrmBooksInfo()
        {
            InitializeComponent();

            _bookApi = new BookApi();
            _api = new BookInfoApi();
        }

        private readonly BookInfoApi _api;
        private readonly BookApi _bookApi;

        private async void FrmBooksInfo_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);
            await BindData();
        }

        private void Gv_BooksInfo_DoubleClick(object sender, EventArgs e)
        {
            if (Gv_BooksInfo.FocusedRowHandle < 0) return;
            var id = Guid.Parse(Gv_BooksInfo.GetFocusedRowCellValue("Id").ToString());
            ShowBookInfoForm(false, id);
        }

        private async void Sb_Shelves_Click(object sender, EventArgs e)
        {
            if (Gv_BooksInfo.FocusedRowHandle < 0 || Gv_BooksInfo.RowCount == 0) return;
            var id = Guid.Parse(Gv_BooksInfo.GetFocusedRowCellValue("Id").ToString());
            var result = await _bookApi.CreateBook(id);
            if (result.ResultCode != 1)
            {
                PopupProvider.Warning(result.ResultMessage);
                return;
            }

            PopupProvider.Success(result.ResultMessage);
        }

        private void Sb_Add_Click(object sender, EventArgs e)
        {
            ShowBookInfoForm(true);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public async Task BindData()
        {
            try
            {
                var data = await _api.GetBooksInfo();
                Gc_BooksInfo.DataSource = data;
            }
            catch (Exception e)
            {
                PopupProvider.Error("获取书籍信息异常!",e);
            }
        }

        private async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = new Dictionary<string, object>
                {
                    {"CreateTime", $"{De_Begin.DateTime}~{De_End.DateTime}"},
                    {"BookName%", Te_Name.Text}
                };
                if (string.IsNullOrEmpty(Te_Name.Text))
                {
                    dic.Remove("BookName%");
                }
                var data = await _api.GetBooksInfo(dic);
                Gc_BooksInfo.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询书籍数据异常!", exception);
            }
        }

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sb_Update_Click(object sender, EventArgs e)
        {
            if (Gv_BooksInfo.FocusedRowHandle < 0) return;
            var id = Guid.Parse(Gv_BooksInfo.GetFocusedRowCellValue("Id").ToString());
            ShowBookInfoForm(false, id);
        }

        /// <summary>
        /// 显示书籍信息编辑窗体
        /// </summary>
        /// <param name="addOrUpdate">True 添加;False 修改</param>
        /// <param name="id">Id</param>
        private void ShowBookInfoForm(bool addOrUpdate, Guid id = new Guid())
        {
            if (!addOrUpdate)
            {
                XucBookInfo.Id = id;
            }

            var ucBookInfo = new XucBookInfo(addOrUpdate);
            var form = new XtraDialogForm
            {
                Dock = DockStyle.Fill,
                MaximizeBox = false,
                AutoSize = true,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                CloseBox = false,
                MaximumClientSize = ucBookInfo.Size
            };
            form.AddControl(ucBookInfo);
            var dialog = form.ShowDialog();
            if (dialog != DialogResult.Yes) return;
            form.Close();
        }
    }
}