using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;

namespace LibraryManagementSystemClient.MainForms
{
    public partial class FrmHome : XtraForm
    {
        public FrmHome()
        {
            InitializeComponent();
            _api = new ChartApi();
        }

        private readonly ChartApi _api;
        private IOverlaySplashScreenHandle _handle;

        private async void FrmHome_Load(object sender, EventArgs e)
        {
            await BindChartData();
        }

        private async Task BindChartData()
        {
            try
            {
                _handle = OverlayScreenForm.ShowProgressPanel(this);
                #region 饼状图

                var data = await _api.GetBookChartByCategory();
                Ct_BookCategorySum.DataSource = data;
                var series = Ct_BookCategorySum.Series[0];
                series.ValueDataMembers[0] = "Number";
                series.ArgumentDataMember = "CategoryName";
                var label = (PieSeriesLabel)series.Label;
                label.TextPattern = "{A}: {VP:P0}";
                var title = new ChartTitle { Text = @"馆藏图书分类汇总", Alignment = StringAlignment.Center };
                Ct_BookCategorySum.Titles.Add(title);

                #endregion

                #region 柱状图

                var borrowCharts = await _api.GetBorrowByDayChart();
                Ct_Bar.DataSource = borrowCharts;
                var barSeries = Ct_Bar.Series[0];
                barSeries.ValueDataMembers[0] = "Number";
                barSeries.ArgumentDataMember = "CreateDate";
                var barLabel = (BarSeriesLabel)barSeries.Label;
                barLabel.TextPattern = "{A}: {V}";
                var barTitle = new ChartTitle { Text = @"近一周借阅统计", Alignment = StringAlignment.Center };
                Ct_Bar.Titles.Add(barTitle);

                #endregion

                #region 数据合计展示

                var booksTotal = await new BookApi().GetBookTotal();
                var borrowsTotal = await new BorrowApi().GetBorrowTotal();
                var studentsTotal = await new StudentApi().GetStudentTotal();
                var employeesTotal =await new EmployeeApi().GetEmployeeTotal();
                var reservationTotal = await new ReservationApi().GetReservationTotal();
                Tbi_Books.Elements[1].Text = booksTotal.ToString();
                Tbi_Borrows.Elements[1].Text = borrowsTotal.ToString();
                Tbi_Employees.Elements[1].Text = employeesTotal.ToString();
                Tbi_Students.Elements[1].Text = studentsTotal.ToString();
                Tbi_Reservations.Elements[1].Text = reservationTotal.ToString();
                #endregion
                OverlayScreenForm.CloseProgressPanel(_handle);
            }
            catch (Exception e)
            {
                OverlayScreenForm.CloseProgressPanel(_handle);
                PopupProvider.Error("获取图表数据或合计数据异常!",e);
            }
            
        }
    }
}