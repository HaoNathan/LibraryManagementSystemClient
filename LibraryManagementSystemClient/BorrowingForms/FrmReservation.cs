using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemClient.BorrowingForms
{
    public partial class FrmReservation : XtraForm
    {
        public FrmReservation()
        {
            InitializeComponent();
            _api = new StudentApi();
            _bookApi = new BookApi();
            _bookInfoApi = new BookInfoApi();
            _reservationApi = new ReservationApi();
        }

        private readonly StudentApi _api;
        private readonly BookApi _bookApi;
        private readonly BookInfoApi _bookInfoApi;
        private static IOverlaySplashScreenHandle _handle;
        private readonly ReservationApi _reservationApi;
        private async void Te_StudentNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            await BindStudentInfo();
        }

        /// <summary>
        /// 绑定学生信息数据
        /// </summary>
        /// <returns></returns>
        private async Task BindStudentInfo()
        {
            var studentNo = Te_StudentNo.Text;
            try
            {
                var students = await _api.GetStudents(new Dictionary<string, object>
                {
                    {"StudentNo", studentNo}
                });

                var student = students.FirstOrDefault();
                if (student == null)
                {
                    PopupProvider.Warning("未检索到信息！");
                    return;
                }

                Te_Age.EditValue = student.Age;
                Te_Name.Text = student.StudentName;
                Te_Class.Text = student.Class;
                Te_Sex.Text = student.Sex ? "女" : "男";
                Te_Department.Text = student.DepartmentName;
                Te_Phone.EditValue = student.Contact;
                Te_Email.Text = student.Email;
                Te_StudentNo.EditValue = student.StudentNo;
                Te_StudentId.Text = student.Id.ToString();

                #region 获取当前学生剩余可预约数量

                var num = await _reservationApi.GetReservationInfoTotal(Te_StudentId.Text);
                if (num != -1)
                {
                    Te_BooksNum.EditValue = 2 - num;
                }
                else
                {
                    Te_BooksNum.EditValue = 2;
                }

                #endregion
            }
            catch (Exception e)
            {
                PopupProvider.Error("获取学生信息异常！", e);
                LogHelper.Error(e.ToString());
            }
        }

        private async void Te_SearchPara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            await BindBookInfo();
        }

        private async Task BindBookInfo()
        {
            try
            {
                var searchPara = Te_SearchPara.Text.Trim();
                //获取模糊查询书籍信息
                var bookInfos = await _bookInfoApi.GetBooksInfo(new Dictionary<string, object>()
                {
                    {"%BookName",$"%{searchPara}%" },
                    {"IsRemove",false }
                });
                if (bookInfos.Count == 0)
                {
                    PopupProvider.Warning("未检索到信息！");
                    return;
                }
                if (bookInfos.Count > 1)
                {
                    Gc_Books.DataSource = bookInfos;
                    Gc_Books.Visible = true;
                    Gv_Books.Focus();
                    return;
                }
                //找到对应的书籍信息的已上架书籍
                var books = await _bookApi.GetBooks(new Dictionary<string, object>
                {
                    {"BookInfoId", bookInfos[0].Id},
                    {"IsRemove", false}
                });

                if (books.Count == 0)
                {
                    PopupProvider.Warning("该书籍还未登记上架！");
                    return;
                }
                var reservationBooks = books.Where(m => m.BookState == 1).ToList();
                var normalBooks = books.Where(m => m.BookState == 0).ToList();
                if (normalBooks.Count > 0)
                {
                    PopupProvider.Warning("该书籍还可借阅！");
                    return;
                }

                if (reservationBooks.Count == 0)
                {
                    PopupProvider.Warning("该书籍没有可预约项！");
                    return;
                }
                var book = books.First();
                var isReservationBook = await _reservationApi.GetReservationBooks();
                if (isReservationBook.Any(item => item.Equals(book.Id)))
                {
                    PopupProvider.Warning("该书籍没有可预约项！");
                    return;
                }

                //如果只有一条数据则进行数据赋值展示
                Te_BookName.Text = book.BookName;
                Te_Author.Text = book.Author;
                Te_ReleaseTime.EditValue = book.ReleaseDate;
                Te_PublishingHouse.Text = book.PublishingName;
                Te_Category.Text = book.CategoryName;
                Te_Id.Text = book.Id.ToString();
                Pe_BookPhoto.Image = Image.FromFile(book.BookPhoto);
                Sb_Input.Enabled = true;
                Te_ISBN.Text = book.ISBN;
                Te_Price.Text = book.Price.ToString("F");
            }
            catch (Exception e)
            {
                PopupProvider.Error("获取数据信息异常！", e);
            }
        }

        private async void Gv_Books_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var infoId = Guid.Parse(Gv_Books.GetFocusedRowCellValue("Id").ToString());
            try
            {

                var books = await _bookApi.GetBooks(new Dictionary<string, object>
                {
                    {"BookInfoId", infoId},
                    {"IsRemove", false}
                });
                if (books.Count == 0)
                {
                    PopupProvider.Warning("该书籍还未登记上架！");
                    return;
                }

                var reservationBooks = books.Where(m => m.BookState == 1).ToList();
                var normalBooks = books.Where(m => m.BookState == 0).ToList();
                if (normalBooks.Count > 0)
                {
                    PopupProvider.Warning("该书籍还可借阅！");
                    return;
                }

                if (reservationBooks.Count == 0)
                {
                    PopupProvider.Warning("该书籍没有可预约项！");
                    return;
                }

                var isReservationBook = await _reservationApi.GetReservationBooks();

                var canReservationBooks = reservationBooks.Where(bookItem => !isReservationBook.Contains(bookItem.Id)).ToList();

                if (canReservationBooks.Count == 0)
                {
                    PopupProvider.Warning("该书籍没有可预约项！");
                    return;
                }

                var book = canReservationBooks.First();
                Te_BookName.Text = book.BookName;
                Te_Author.Text = book.Author;
                Te_ReleaseTime.EditValue = book.ReleaseDate;
                Te_PublishingHouse.Text = book.PublishingName;
                Te_Category.Text = book.CategoryName;
                Pe_BookPhoto.Image = Image.FromFile(book.BookPhoto);
                Te_Id.Text = book.Id.ToString();
                Te_ISBN.Text = book.ISBN;
                Te_Price.Text = book.Price.ToString("F");
                Gc_Books.Visible = false;
                Sb_Input.Enabled = true;

            }
            catch (Exception exception)
            {
                PopupProvider.Error("获取预约书籍信息异常!", exception);
            }
        }

        private void Gc_Books_Leave(object sender, EventArgs e)
        {
            Gc_Books.Visible = false;
        }

        private void Sb_Input_Click(object sender, EventArgs e)
        {
            var data = (List<Book>)Gv_BookInfo.DataSource;
            data.Add(new Book
            {
                Id = Guid.Parse(Te_Id.Text.Trim()),
                Author = Te_Author.Text,
                CategoryName = Te_Category.Text,
                PublishingName = Te_PublishingHouse.Text,
                ISBN = Te_ISBN.Text,
                BookName = Te_BookName.Text
            });
            Gc_BookInfos.DataSource = data;
            Gc_BookInfos.RefreshDataSource();
            Sb_Input.Enabled = false;
            Clear(1);
        }

        private async void Sb_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Te_StudentId.Text))
                {
                    PopupProvider.Warning("请填写借阅人信息!");
                    return;
                }
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                var infosTotal = Convert.ToInt32(Te_BooksNum.Text);
                if (infosTotal <= 0)
                {
                    OverlayScreenForm.CloseProgressPanel(_handle);
                    PopupProvider.Warning("已达最大可预约数!");
                    return;
                }

                var books = (List<Book>)Gv_BookInfo.DataSource;
                var borrows = books.Select(m => new Reservation
                {
                    StudentId = Guid.Parse(Te_StudentId.Text),
                    AdminId = GlobalCache.Admin.Id,
                    BookId = m.Id
                }).ToList();
                var res = await _reservationApi.CreateReservations(borrows);
                OverlayScreenForm.CloseProgressPanel(_handle);
                if (res.ResultCode != 1)
                {
                    PopupProvider.Warning(res.ResultMessage);
                    return;
                }
                Gc_BookInfos.DataSource = new List<Book>();
                Clear(3);
                Te_BooksNum.Text = string.Empty;
                Te_StudentId.Text = string.Empty;
                PopupProvider.Success(res.ResultMessage);
            }
            catch (Exception exception)
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
                PopupProvider.Error("操作异常！", exception);
            }
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            Gc_BookInfos.DataSource = new List<Book>();
        }

        /// <summary>
        /// 清除TextEdit数据
        /// </summary>
        /// <param name="groupIndex"></param>
        private void Clear(int groupIndex)
        {
            switch (groupIndex)
            {
                case 0:
                    CommonClass.ClearInfo(Lcg_StudentInfo);
                    return;
                case 1:
                    CommonClass.ClearInfo(Lcg_BookInfo);
                    return;
                default:
                    CommonClass.ClearInfo(Lcg_BookInfo);
                    CommonClass.ClearInfo(Lcg_StudentInfo);
                    break;
            }
        }

        private void Ribe_Delete_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var dialogResult = XtraMessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var focusHandle = Gv_BookInfo.FocusedRowHandle;
            Gv_BookInfo.DeleteRow(focusHandle);
        }

        private void Gv_BookInfo_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            var data = (List<Borrow>)Gv_BookInfo.DataSource;
            Sb_Save.Enabled = data.Count > 1;
        }

        private void Te_Author_EditValueChanged(object sender, EventArgs e)
        {
            Sb_Input.Enabled = !string.IsNullOrEmpty(Te_Author.Text);
        }
    }
}