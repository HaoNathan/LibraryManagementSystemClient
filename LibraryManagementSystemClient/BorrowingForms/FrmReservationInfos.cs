using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.BorrowingForms
{
    public partial class FrmReservationInfos : XtraForm
    {
        public FrmReservationInfos()
        {
            InitializeComponent();
            _reservationApi = new ReservationApi();
            _bookApi = new BookApi();
        }

        private readonly ReservationApi _reservationApi;
        private readonly BookApi _bookApi;

        private async void FrmReservationInfos_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin, De_End, 30);
            await BindData();
        }

        private async void Gv_Reservations_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (Gv_Reservations.FocusedRowHandle < 0) return;
            var id = Guid.Parse(Gv_Reservations.GetFocusedRowCellValue("BookId").ToString());
            try
            {
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
                PopupProvider.Error("获取预约书籍信息异常！", exception);
            }
        }

        private async void Ribe_Delete_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (Gv_Reservations.FocusedRowHandle < 0) return;
            try
            {
                var isRemove = Convert.ToBoolean(Gv_Reservations.GetFocusedRowCellValue("IsRemove"));
                if (isRemove)
                {
                    PopupProvider.Warning("该预约记录已删除!");
                    return;
                }

                if (Convert.ToInt32(e.Button.Tag) == 1)
                {
                    return;
                }

                if (XtraMessageBox.Show("确认删除!", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes) return;
                var id = Gv_Reservations.GetFocusedRowCellDisplayText("Id");
                var result = await _reservationApi.DeleteReservation(id);
                if (result.ResultCode != 1)
                {
                    PopupProvider.Warning(result.ResultMessage);
                    return;
                }

                PopupProvider.Success(result.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("操作异常!", exception);
            }
        }

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public async Task BindData()
        {
            try
            {
                var data = await _reservationApi.GetReservations(true);
                Gc_Reservations.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取预约信息异常！", exception);
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
                var data = await _reservationApi.GetReservations(dic);
                Gc_Reservations.DataSource = data;
            }
            catch (Exception exception)
            {
                PopupProvider.Error("查询异常!", exception);
            }
        }
    }
}