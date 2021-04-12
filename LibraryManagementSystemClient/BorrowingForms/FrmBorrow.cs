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
    public partial class FrmBorrow : XtraForm
    {
        public FrmBorrow()
        {
            InitializeComponent();
            _api = new StudentApi();
            _bookApi = new BookApi();
            _bookInfoApi = new BookInfoApi();
            _borrowApi = new BorrowApi();
            _reservationApi = new ReservationApi();
        }

        private readonly StudentApi _api;
        private readonly BookApi _bookApi;
        private readonly BookInfoApi _bookInfoApi;
        private static IOverlaySplashScreenHandle _handle;
        private readonly BorrowApi _borrowApi;
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
                _handle = OverlayScreenForm.ShowProgressPanel(this);
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

                #region 获取当前学生剩余可借阅数量

                var num = await _borrowApi.GetBorrowInfoTotal(Te_StudentId.Text);
                if (num != -1)
                {
                    Te_BooksNum.EditValue = 3 - num;
                }
                else
                {
                    Te_BooksNum.EditValue = 3;
                }

                #endregion

                OverlayScreenForm.CloseProgressPanel(_handle);
            }
            catch (Exception e)
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
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
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                var bookInfos = await _bookInfoApi.GetBooksInfo(false);
                bookInfos = bookInfos
                    .Where(m => m.Id.ToString().Contains(searchPara) || m.BookName.Contains(searchPara)).ToList();
                OverlayScreenForm.CloseProgressPanel(_handle);
                if (bookInfos.Count == 0)
                {
                    PopupProvider.Warning("未检索到信息！");
                    return;
                }

                //找到对应的书籍信息的已上架书籍
                var books = new List<Book>();


                foreach (var info in bookInfos)
                {
                    books.AddRange(await _bookApi.GetBooks(new Dictionary<string, object>
                    {
                        {"BookInfoId", info.Id}
                    }));
                }

              
                foreach (var item in books)
                {
                    switch (item.BookState)
                    {
                        case 0:
                            item.BookStateName = "正常";
                            break;
                        case 1:
                            item.BookStateName = "已借阅";
                            break;
                        case 2:
                            item.BookStateName = "已预约";
                            break;
                    }
                }

                //如果存在多个数据,采用列表显示,操作员自行选择.
                if (books.Count > 1)
                {
                    Gc_Books.DataSource = books;
                    Gc_Books.Visible = true;
                    Gv_Books.Focus();
                    return;
                }
                if (books.Count == 0)
                {
                    PopupProvider.Warning("未找到可借阅的相应书籍!");
                    return;
                }

                //如果只有一条数据则进行数据赋值展示
                var book = books.First();
                var reservation = await _reservationApi.GetReservations(new Dictionary<string, object>
                {
                    {"BookId", book.Id},
                    {"IsRemove", false},
                    {"StudentId",Te_StudentId.Text }
                });
                if (reservation.Count <= 0 && book.BookStateName.Equals("已预约"))
                {
                    PopupProvider.Warning($"{book.BookStateName}书籍不可借阅!");
                    return;
                }
                if (book.BookStateName.Equals("已借阅"))
                {
                    PopupProvider.Warning($"{book.BookStateName}书籍不可借阅!");
                    return;
                }
                Te_BookName.Text = book.BookName;
                Te_Author.Text = book.Author;
                Te_ReleaseTime.EditValue = book.ReleaseDate;
                Te_PublishingHouse.Text = book.PublishingName;
                Te_Category.Text = book.CategoryName;
                Pe_BookPhoto.Image = Image.FromFile(book.BookPhoto);
                Te_BookId.Text = book.Id.ToString();
                Te_ISBN.Text = book.ISBN;
                Te_ReleaseTime.Text = book.ReleaseDate.ToString("yyyy-MM-dd");
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
            var state = Gv_Books.GetFocusedRowCellDisplayText("BookStateName");
            var id = Gv_Books.GetFocusedRowCellValue("Id").ToString();
            var reservation = await _reservationApi.GetReservations(new Dictionary<string, object>()
            {
                {"BookId", id},
                {"IsRemove", false},
                {"StudentId",Te_StudentId.Text }
            });
            if (reservation.Count<=0&&state.Equals("已预约"))
            {
                PopupProvider.Warning($"{state}书籍不可借阅!");
                return;
            }
            if (state.Equals("已借阅"))
            {
                PopupProvider.Warning($"{state}书籍不可借阅!");
                return;
            }

            Te_BookId.Text = Gv_Books.GetFocusedRowCellDisplayText("Id");
            Te_BookName.Text = Gv_Books.GetFocusedRowCellDisplayText("BookName");
            Te_Author.Text = Gv_Books.GetFocusedRowCellDisplayText("Author");
            Te_ReleaseTime.EditValue = Gv_Books.GetFocusedRowCellDisplayText("ReleaseDate");
            Te_PublishingHouse.Text = Gv_Books.GetFocusedRowCellDisplayText("PublishingName");
            Te_Category.Text = Gv_Books.GetFocusedRowCellDisplayText("CategoryName");
            Te_ISBN.Text = Gv_Books.GetFocusedRowCellDisplayText("ISBN");
            Te_ReleaseTime.Text = Gv_Books.GetFocusedRowCellDisplayText("ReleaseDate");
            Pe_BookPhoto.Image = Image.FromFile(Gv_Books.GetFocusedRowCellValue("BookPhoto").ToString());
            Te_Price.Text = Gv_Books.GetFocusedRowCellValue("Price").ToString();
            Gc_Books.Visible = false;
        }

        private void Gc_Books_Leave(object sender, EventArgs e)
        {
            Gc_Books.Visible = false;
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
                    PopupProvider.Warning("已达最大可借阅数!");
                    return;
                }

                var books = (List<Borrow>)Gv_BookInfos.DataSource;
                var borrows = books.Select(m => new Borrow
                {
                    StudentId = Guid.Parse(Te_StudentId.Text),
                    AdminId = GlobalCache.Admin.Id,
                    EndTime = DateTime.Now.AddDays(21),
                    BackTime = DateTime.MaxValue,
                    BookId = m.BookId
                }).ToList();
                var res = await _borrowApi.CreateBorrows(borrows);
                if (res.ResultCode != 1)
                {
                    OverlayScreenForm.CloseProgressPanel(_handle);
                    PopupProvider.Warning(res.ResultMessage);
                    return;
                }

                OverlayScreenForm.CloseProgressPanel(_handle);
                Gc_BookInfos.DataSource = new List<Borrow>();
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

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sb_Entry_Click(object sender, EventArgs e)
        {
            var data = (List<Borrow>)Gv_BookInfos.DataSource;
            var borrow = new Borrow
            {
                BookId = Guid.Parse(Te_BookId.Text),
                CategoryName = Te_Category.Text,
                PublishingName = Te_PublishingHouse.Text,
                ISBN = Te_ISBN.Text,
                Author = Te_Author.Text,
                ReleaseDate = Convert.ToDateTime(Te_ReleaseTime.Text),
                BookName = Te_BookName.Text
            };
            data.Add(borrow);
            Gc_BookInfos.DataSource = data;
            Gc_BookInfos.RefreshDataSource();
            Clear(1);
            Sb_Save.Enabled = true;
        }

        private void FrmBorrow_Load(object sender, EventArgs e)
        {
            Gc_BookInfos.DataSource = new List<Borrow>();
        }

        private void Ribe_Delete_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var dialogResult = XtraMessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var focusHandle = Gv_BookInfos.FocusedRowHandle;
            Gv_BookInfos.DeleteRow(focusHandle);
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

        private void Te_Author_EditValueChanged(object sender, EventArgs e)
        {
            Sb_Entry.Enabled = !string.IsNullOrEmpty(Te_Author.Text);
        }

        private void Gv_BookInfos_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            var data = (List<Borrow>)Gv_BookInfos.DataSource;
            Sb_Save.Enabled = data.Count > 1;
        }
    }
}