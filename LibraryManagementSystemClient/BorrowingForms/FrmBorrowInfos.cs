using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystem.MODEL;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemClient.BorrowingForms
{
    public partial class FrmBorrowInfos : XtraForm
    {
        public FrmBorrowInfos()
        {
            InitializeComponent();
            _borrowApi = new BorrowApi();
            _finePaymentApi = new FinePaymentApi();
            _bookApi = new BookApi();
        }

        private readonly BorrowApi _borrowApi;
        private readonly FinePaymentApi _finePaymentApi;
        private readonly BookApi _bookApi;
        private static IOverlaySplashScreenHandle _handle;

        private async void FrmBorrowInfos_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);
            await BindData();
        }

        private async void Sb_PayFine_Click(object sender, EventArgs e)
        {

            await FinePayment();
        }

        private async void Gv_Borrows_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (Gv_Borrows.FocusedRowHandle < 0) return;
                var isExpired = Convert.ToBoolean(Gv_Borrows.GetFocusedRowCellValue("IsExpired"));
                Sb_PayFine.Enabled = isExpired;
                var id = Guid.Parse(Gv_Borrows.GetFocusedRowCellValue("BookId").ToString());
                var book = await _bookApi.GetBook(id);
                book.Photo = Image.FromFile(book.BookPhoto);
                Pe_Photo.Image = book.Photo;
                Te_BookId.EditValue = book.Id;
                Te_BookName.Text = book.BookName;
                Te_Author.Text = book.Author;
                Te_PublishingHouse.Text = book.PublishingName;
                Te_Category.Text = book.CategoryName;
                Te_Price.EditValue = book.Price;
                Te_ISBN.Text = book.ISBN;
                Te_ReleaseTime.EditValue = book.ReleaseDate;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取借阅书籍信息异常！", exception);
            }
        }

        private async Task FinePayment()
        {
            try
            {
                var borrowId = Guid.Parse(Gv_Borrows.GetFocusedRowCellValue("Id").ToString());
                var penalty = Convert.ToDouble(Gv_Borrows.GetFocusedRowCellValue("Fine"));
                var result = await _finePaymentApi.CreateFinePayment(new FinePayment
                {
                    BorrowId = borrowId,
                    Fine = penalty,
                    IsPay = true,
                    PayType = "移动支付",
                    AdminId = GlobalCache.Admin.Id
                });

                if (result.ResultCode != 1)
                {
                    PopupProvider.Warning(result.ResultMessage);
                    return;
                }

                PopupProvider.Success(result.ResultMessage);
            }
            catch (Exception e)
            {
                PopupProvider.Error("新增罚款登记单异常！！", e);
            }
        }

        private async void Ribe_Return_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (!Gv_Borrows.GetFocusedRowCellDisplayText("ReturnState").Equals("未归还"))
                {
                    PopupProvider.Warning("该书已归还!");
                    return;
                }

                var dialogResult = XtraMessageBox.Show("确认归还?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes) return;
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                var id = Gv_Borrows.GetFocusedRowCellDisplayText("Id");
                var result = await _borrowApi.ReturnBook(id);
                OverlayScreenForm.CloseProgressPanel(_handle);
                if (result.ResultCode != 1)
                {
                    PopupProvider.Warning(result.ResultMessage);
                }

                PopupProvider.Success(result.ResultMessage);

                await BindData();
            }
            catch (Exception exception)
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
                PopupProvider.Error(exception.Message, exception);
            }
        }

        public async Task BindData()
        {
            try
            {
                var data = await _borrowApi.GetBorrows(true);
                foreach (var borrow in data)
                {
                    borrow.ReturnState = borrow.BackTime.ToString("yyyy-MM-dd HH:mm:ss")
                        .Equals(DateTime.MaxValue.ToString("yyyy-MM-dd HH:mm:ss"))
                        ? "未归还"
                        : borrow.BackTime.ToString("yyyy-MM-dd HH:mm:ss");
                }

                Gc_Borrows.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取借阅信息异常！", exception);
            }
        }

        private async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = new Dictionary<string, object>
                {
                    {"BeginDate", De_Begin.DateTime},
                    {"EndDate", De_End.DateTime},
                    {"SearchPara", Te_SearchPara.Text}
                };
                var data = await _borrowApi.GetBorrows(dic);
                Gc_Borrows.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询异常!", exception);
            }
        }
    }
}