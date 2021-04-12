
namespace LibraryManagementSystemClient.MainForms
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Tb_Bar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.Tbi_Books = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.Tbi_Students = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.Tbi_Employees = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.Ct_BookCategorySum = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Ct_Bar = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Tbi_Borrows = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.Tbi_Reservations = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_BookCategorySum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Tb_Bar);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.Ct_Bar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(976, 495);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Tb_Bar
            // 
            this.Tb_Bar.AllowSelectedItem = true;
            this.Tb_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Bar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.Tb_Bar.Groups.Add(this.tileBarGroup2);
            this.Tb_Bar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tb_Bar.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.Tb_Bar.Location = new System.Drawing.Point(4, 4);
            this.Tb_Bar.MaxId = 8;
            this.Tb_Bar.Name = "Tb_Bar";
            this.Tb_Bar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar;
            this.Tb_Bar.ShowItemShadow = true;
            this.Tb_Bar.Size = new System.Drawing.Size(968, 121);
            this.Tb_Bar.TabIndex = 7;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.Tbi_Books);
            this.tileBarGroup2.Items.Add(this.Tbi_Borrows);
            this.tileBarGroup2.Items.Add(this.Tbi_Reservations);
            this.tileBarGroup2.Items.Add(this.Tbi_Students);
            this.tileBarGroup2.Items.Add(this.Tbi_Employees);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // Tbi_Books
            // 
            this.Tbi_Books.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.Tbi_Books.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.Tbi_Books.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement1.ImageOptions.SvgImage = global::LibraryManagementSystemClient.Properties.Resources.shuji1;
            tileItemElement1.Text = "藏书数量";
            tileItemElement2.Text = "0";
            this.Tbi_Books.Elements.Add(tileItemElement1);
            this.Tbi_Books.Elements.Add(tileItemElement2);
            this.Tbi_Books.Id = 2;
            this.Tbi_Books.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.Tbi_Books.Name = "Tbi_Books";
            // 
            // Tbi_Students
            // 
            this.Tbi_Students.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement7.ImageOptions.SvgImage = global::LibraryManagementSystemClient.Properties.Resources.xuesheng;
            tileItemElement7.Text = "学生数量";
            tileItemElement8.Text = "0";
            this.Tbi_Students.Elements.Add(tileItemElement7);
            this.Tbi_Students.Elements.Add(tileItemElement8);
            this.Tbi_Students.Id = 6;
            this.Tbi_Students.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.Tbi_Students.Name = "Tbi_Students";
            // 
            // Tbi_Employees
            // 
            this.Tbi_Employees.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement9.ImageOptions.SvgImage = global::LibraryManagementSystemClient.Properties.Resources.yuangongliebiao;
            tileItemElement9.Text = "员工数量";
            tileItemElement10.Text = "0";
            this.Tbi_Employees.Elements.Add(tileItemElement9);
            this.Tbi_Employees.Elements.Add(tileItemElement10);
            this.Tbi_Employees.Id = 7;
            this.Tbi_Employees.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.Tbi_Employees.Name = "Tbi_Employees";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.Ct_BookCategorySum);
            this.layoutControl2.Location = new System.Drawing.Point(489, 129);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(483, 362);
            this.layoutControl2.TabIndex = 6;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // Ct_BookCategorySum
            // 
            this.Ct_BookCategorySum.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.Ct_BookCategorySum.Legend.Name = "Default Legend";
            this.Ct_BookCategorySum.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.Ct_BookCategorySum.Location = new System.Drawing.Point(6, 6);
            this.Ct_BookCategorySum.Name = "Ct_BookCategorySum";
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Label = pieSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Series 1";
            pieSeriesView1.TotalLabel.Visible = true;
            series1.View = pieSeriesView1;
            this.Ct_BookCategorySum.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.Ct_BookCategorySum.Size = new System.Drawing.Size(471, 350);
            this.Ct_BookCategorySum.TabIndex = 4;
            this.Ct_BookCategorySum.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(483, 362);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Ct_BookCategorySum;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(479, 358);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Ct_Bar
            // 
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.Ct_Bar.Diagram = xyDiagram1;
            this.Ct_Bar.Legend.Name = "Default Legend";
            this.Ct_Bar.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.Ct_Bar.Location = new System.Drawing.Point(6, 131);
            this.Ct_Bar.Name = "Ct_Bar";
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Series 1";
            sideBySideBarSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesView1.ColorEach = true;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series2.View = sideBySideBarSeriesView1;
            this.Ct_Bar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.Ct_Bar.Size = new System.Drawing.Size(477, 358);
            this.Ct_Bar.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(976, 495);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Ct_Bar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 125);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(485, 366);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.layoutControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(485, 125);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(487, 366);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Tb_Bar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(972, 125);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Tbi_Borrows
            // 
            this.Tbi_Borrows.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = global::LibraryManagementSystemClient.Properties.Resources.biaodanwancheng1;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement3.Text = "借阅数量";
            tileItemElement4.Text = "0";
            this.Tbi_Borrows.Elements.Add(tileItemElement3);
            this.Tbi_Borrows.Elements.Add(tileItemElement4);
            this.Tbi_Borrows.Id = 4;
            this.Tbi_Borrows.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.Tbi_Borrows.Name = "Tbi_Borrows";
            // 
            // Tbi_Reservations
            // 
            this.Tbi_Reservations.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = global::LibraryManagementSystemClient.Properties.Resources.biaodan1;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None;
            tileItemElement5.Text = "预约数量";
            tileItemElement6.Text = "0";
            this.Tbi_Reservations.Elements.Add(tileItemElement5);
            this.Tbi_Reservations.Elements.Add(tileItemElement6);
            this.Tbi_Reservations.Id = 5;
            this.Tbi_Reservations.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.Tbi_Reservations.Name = "Tbi_Reservations";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 495);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmHome";
            this.Text = "主页";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_BookCategorySum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraCharts.ChartControl Ct_Bar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraCharts.ChartControl Ct_BookCategorySum;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Navigation.TileBar Tb_Bar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem Tbi_Books;
        private DevExpress.XtraBars.Navigation.TileBarItem Tbi_Borrows;
        private DevExpress.XtraBars.Navigation.TileBarItem Tbi_Reservations;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem Tbi_Students;
        private DevExpress.XtraBars.Navigation.TileBarItem Tbi_Employees;
    }
}