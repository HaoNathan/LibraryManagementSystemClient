using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.BookForms
{
    public partial class FrmBooks : XtraForm
    {
        public FrmBooks()
        {
            _api = new BookApi();
            InitializeComponent();
        }

        private readonly BookApi _api;

        private void Iv_data_CardClick(object sender, CardClickEventArgs e)
        {
            if (e.Clicks == 1) return;
            var data = Iv_data.GetRowCellValue(e.RowHandle, "Id").ToString();
            XtraMessageBox.Show(data);
        }

        private void Iv_data_CustomDrawCardFieldValue(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName.Equals("BookPhoto"))
            //{
            //    var image = Image.FromFile(e.CellValue.ToString());
            //    e.CellValue = null;
            //    e.CellValue = image;
            //}
        }

        private void Iv_data_CustomCardStyle(object sender, LayoutViewCardStyleEventArgs e)
        {
            var item = (LayoutView) sender;
            item.CardCaptionFormat = @"No:{0}/{1}";

            //var column = item.Columns["BookState"];
            //var state =Convert.ToInt32(item.GetListSourceRowCellValue(e.RowHandle, column));
            //var color = Color.White;
            //switch (state)
            //{
            //    case 1:
            //        color = Color.Orange;
            //        break;
            //    case 2:
            //        color = Color.Blue;
            //        break;
            //}

            //e.Appearance.BorderColor = color;
        }

        private IOverlaySplashScreenHandle _handle;

        private async void Sb_Query_Click(object sender, EventArgs e)
        {
            try
            {
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                var dic = new Dictionary<string, object>()
                {
                    {"CreateTime",$"{De_Begin.DateTime}" },
                    {"BookName",Te_BookName.Text }
                };
                var data = await _api.GetBooks(dic);

                foreach (var book in data)
                {
                    book.Photo = Image.FromFile(book.BookPhoto);
                }

                Gc_Data.DataSource = data;
            }
            catch (Exception ex)
            {
                PopupProvider.Error("获取数据异常！", ex);
            }
            finally
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
            }
        }

        private async void FrmBooks_Load(object sender, EventArgs e)
        {
            CommonClass.SetDateEditProperties(De_Begin,De_End,30);
            await BindData();
        }

        public async Task BindData()
        {
            try
            {
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                var data = await _api.GetBooks(false);

                foreach (var book in data)
                {
                    book.Photo = Image.FromFile(book.BookPhoto);
                }

                Gc_Data.DataSource = data;
            }
            catch (Exception ex)
            {
                PopupProvider.Error("获取数据异常！", ex);
            }
            finally
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
            }
        }
    }
}