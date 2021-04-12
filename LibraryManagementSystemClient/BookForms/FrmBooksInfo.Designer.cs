
namespace LibraryManagementSystemClient.BookForms
{
    partial class FrmBooksInfo
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Te_Name = new DevExpress.XtraEditors.TextEdit();
            this.De_End = new DevExpress.XtraEditors.DateEdit();
            this.De_Begin = new DevExpress.XtraEditors.DateEdit();
            this.Sb_Query = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Shelves = new DevExpress.XtraEditors.SimpleButton();
            this.Gc_BooksInfo = new DevExpress.XtraGrid.GridControl();
            this.Gv_BooksInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_BookPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_BookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Author = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_BookCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Publishing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_ReleaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_ISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_IsRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_BookNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Sb_Close = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Sb_Update = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_BooksInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_BooksInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Sb_Update);
            this.layoutControl1.Controls.Add(this.Sb_Close);
            this.layoutControl1.Controls.Add(this.Te_Name);
            this.layoutControl1.Controls.Add(this.De_End);
            this.layoutControl1.Controls.Add(this.De_Begin);
            this.layoutControl1.Controls.Add(this.Sb_Query);
            this.layoutControl1.Controls.Add(this.Sb_Add);
            this.layoutControl1.Controls.Add(this.Sb_Shelves);
            this.layoutControl1.Controls.Add(this.Gc_BooksInfo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1040, 507);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Te_Name
            // 
            this.Te_Name.Location = new System.Drawing.Point(533, 6);
            this.Te_Name.Name = "Te_Name";
            this.Te_Name.Size = new System.Drawing.Size(219, 20);
            this.Te_Name.StyleController = this.layoutControl1;
            this.Te_Name.TabIndex = 13;
            // 
            // De_End
            // 
            this.De_End.EditValue = null;
            this.De_End.Location = new System.Drawing.Point(273, 6);
            this.De_End.Name = "De_End";
            this.De_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_End.Size = new System.Drawing.Size(195, 20);
            this.De_End.StyleController = this.layoutControl1;
            this.De_End.TabIndex = 12;
            // 
            // De_Begin
            // 
            this.De_Begin.EditValue = null;
            this.De_Begin.Location = new System.Drawing.Point(63, 6);
            this.De_Begin.Name = "De_Begin";
            this.De_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Size = new System.Drawing.Size(185, 20);
            this.De_Begin.StyleController = this.layoutControl1;
            this.De_Begin.TabIndex = 11;
            // 
            // Sb_Query
            // 
            this.Sb_Query.Location = new System.Drawing.Point(758, 4);
            this.Sb_Query.Name = "Sb_Query";
            this.Sb_Query.Size = new System.Drawing.Size(116, 22);
            this.Sb_Query.StyleController = this.layoutControl1;
            this.Sb_Query.TabIndex = 10;
            this.Sb_Query.Text = "查询";
            this.Sb_Query.Click += new System.EventHandler(this.Sb_Query_Click);
            // 
            // Sb_Add
            // 
            this.Sb_Add.Location = new System.Drawing.Point(920, 481);
            this.Sb_Add.Name = "Sb_Add";
            this.Sb_Add.Size = new System.Drawing.Size(116, 22);
            this.Sb_Add.StyleController = this.layoutControl1;
            this.Sb_Add.TabIndex = 6;
            this.Sb_Add.Text = "添加";
            this.Sb_Add.Click += new System.EventHandler(this.Sb_Add_Click);
            // 
            // Sb_Shelves
            // 
            this.Sb_Shelves.Location = new System.Drawing.Point(680, 481);
            this.Sb_Shelves.Name = "Sb_Shelves";
            this.Sb_Shelves.Size = new System.Drawing.Size(116, 22);
            this.Sb_Shelves.StyleController = this.layoutControl1;
            this.Sb_Shelves.TabIndex = 5;
            this.Sb_Shelves.Text = "上架";
            this.Sb_Shelves.Click += new System.EventHandler(this.Sb_Shelves_Click);
            // 
            // Gc_BooksInfo
            // 
            this.Gc_BooksInfo.Location = new System.Drawing.Point(4, 32);
            this.Gc_BooksInfo.MainView = this.Gv_BooksInfo;
            this.Gc_BooksInfo.Name = "Gc_BooksInfo";
            this.Gc_BooksInfo.Size = new System.Drawing.Size(1032, 445);
            this.Gc_BooksInfo.TabIndex = 4;
            this.Gc_BooksInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_BooksInfo});
            // 
            // Gv_BooksInfo
            // 
            this.Gv_BooksInfo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.Gv_BooksInfo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Gv_BooksInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gc_Id,
            this.Gc_BookPhoto,
            this.Gc_BookName,
            this.Gc_Author,
            this.Gc_BookCategory,
            this.Gc_Publishing,
            this.Gc_ReleaseDate,
            this.Gc_ISBN,
            this.Gc_Price,
            this.Gc_IsRemove,
            this.Gc_BookNum});
            this.Gv_BooksInfo.GridControl = this.Gc_BooksInfo;
            this.Gv_BooksInfo.Name = "Gv_BooksInfo";
            this.Gv_BooksInfo.OptionsBehavior.Editable = false;
            this.Gv_BooksInfo.OptionsView.ColumnAutoWidth = false;
            this.Gv_BooksInfo.OptionsView.ShowGroupPanel = false;
            this.Gv_BooksInfo.DoubleClick += new System.EventHandler(this.Gv_BooksInfo_DoubleClick);
            // 
            // Gc_Id
            // 
            this.Gc_Id.Caption = "编号";
            this.Gc_Id.FieldName = "Id";
            this.Gc_Id.Name = "Gc_Id";
            this.Gc_Id.Visible = true;
            this.Gc_Id.VisibleIndex = 0;
            // 
            // Gc_BookPhoto
            // 
            this.Gc_BookPhoto.Caption = "封面";
            this.Gc_BookPhoto.FieldName = "Photo";
            this.Gc_BookPhoto.Name = "Gc_BookPhoto";
            this.Gc_BookPhoto.Visible = true;
            this.Gc_BookPhoto.VisibleIndex = 1;
            // 
            // Gc_BookName
            // 
            this.Gc_BookName.Caption = "书籍名称";
            this.Gc_BookName.FieldName = "BookName";
            this.Gc_BookName.Name = "Gc_BookName";
            this.Gc_BookName.Visible = true;
            this.Gc_BookName.VisibleIndex = 2;
            // 
            // Gc_Author
            // 
            this.Gc_Author.Caption = "作者";
            this.Gc_Author.FieldName = "Author";
            this.Gc_Author.Name = "Gc_Author";
            this.Gc_Author.Visible = true;
            this.Gc_Author.VisibleIndex = 3;
            // 
            // Gc_BookCategory
            // 
            this.Gc_BookCategory.Caption = "书籍类别";
            this.Gc_BookCategory.FieldName = "CategoryName";
            this.Gc_BookCategory.Name = "Gc_BookCategory";
            this.Gc_BookCategory.Visible = true;
            this.Gc_BookCategory.VisibleIndex = 4;
            // 
            // Gc_Publishing
            // 
            this.Gc_Publishing.Caption = "出版社";
            this.Gc_Publishing.FieldName = "PublishingName";
            this.Gc_Publishing.Name = "Gc_Publishing";
            this.Gc_Publishing.Visible = true;
            this.Gc_Publishing.VisibleIndex = 5;
            // 
            // Gc_ReleaseDate
            // 
            this.Gc_ReleaseDate.Caption = "发布日期";
            this.Gc_ReleaseDate.FieldName = "ReleaseDate";
            this.Gc_ReleaseDate.Name = "Gc_ReleaseDate";
            this.Gc_ReleaseDate.Visible = true;
            this.Gc_ReleaseDate.VisibleIndex = 6;
            // 
            // Gc_ISBN
            // 
            this.Gc_ISBN.Caption = "ISBN";
            this.Gc_ISBN.FieldName = "ISBN";
            this.Gc_ISBN.Name = "Gc_ISBN";
            this.Gc_ISBN.Visible = true;
            this.Gc_ISBN.VisibleIndex = 7;
            // 
            // Gc_Price
            // 
            this.Gc_Price.Caption = "价格";
            this.Gc_Price.FieldName = "Price";
            this.Gc_Price.Name = "Gc_Price";
            this.Gc_Price.Visible = true;
            this.Gc_Price.VisibleIndex = 8;
            // 
            // Gc_IsRemove
            // 
            this.Gc_IsRemove.Caption = "是否作废";
            this.Gc_IsRemove.FieldName = "IsRemove";
            this.Gc_IsRemove.Name = "Gc_IsRemove";
            this.Gc_IsRemove.Visible = true;
            this.Gc_IsRemove.VisibleIndex = 9;
            // 
            // Gc_BookNum
            // 
            this.Gc_BookNum.Caption = "库存数量";
            this.Gc_BookNum.FieldName = "BookNum";
            this.Gc_BookNum.Name = "Gc_BookNum";
            this.Gc_BookNum.Visible = true;
            this.Gc_BookNum.VisibleIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1040, 507);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Gc_BooksInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1036, 449);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Sb_Shelves;
            this.layoutControlItem2.Location = new System.Drawing.Point(676, 477);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Sb_Add;
            this.layoutControlItem3.Location = new System.Drawing.Point(916, 477);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 477);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(676, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.Sb_Query;
            this.layoutControlItem7.Location = new System.Drawing.Point(754, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(120, 28);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.De_Begin;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(250, 28);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(250, 28);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(250, 28);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem8.Text = "创建时间:";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 14);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.De_End;
            this.layoutControlItem9.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(220, 28);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(220, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(220, 28);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem9.Text = "至";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(12, 14);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Te_Name;
            this.layoutControlItem4.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(284, 28);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(284, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(284, 28);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Text = "书籍名称:";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(994, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(42, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Sb_Close
            // 
            this.Sb_Close.Location = new System.Drawing.Point(878, 4);
            this.Sb_Close.Name = "Sb_Close";
            this.Sb_Close.Size = new System.Drawing.Size(116, 22);
            this.Sb_Close.StyleController = this.layoutControl1;
            this.Sb_Close.TabIndex = 14;
            this.Sb_Close.Text = "关闭";
            this.Sb_Close.Click += new System.EventHandler(this.Sb_Close_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Sb_Close;
            this.layoutControlItem5.Location = new System.Drawing.Point(874, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(120, 28);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Sb_Update
            // 
            this.Sb_Update.Location = new System.Drawing.Point(800, 481);
            this.Sb_Update.Name = "Sb_Update";
            this.Sb_Update.Size = new System.Drawing.Size(116, 22);
            this.Sb_Update.StyleController = this.layoutControl1;
            this.Sb_Update.TabIndex = 15;
            this.Sb_Update.Text = "修改";
            this.Sb_Update.Click += new System.EventHandler(this.Sb_Update_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Sb_Update;
            this.layoutControlItem6.Location = new System.Drawing.Point(796, 477);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FrmBooksInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 507);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmBooksInfo";
            this.Text = "书籍信息";
            this.Load += new System.EventHandler(this.FrmBooksInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Te_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_BooksInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_BooksInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl Gc_BooksInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_BooksInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton Sb_Add;
        private DevExpress.XtraEditors.SimpleButton Sb_Shelves;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton Sb_Query;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_BookPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_BookName;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Author;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_BookCategory;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Publishing;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_ReleaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_IsRemove;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_BookNum;
        private DevExpress.XtraEditors.DateEdit De_End;
        private DevExpress.XtraEditors.DateEdit De_Begin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit Te_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton Sb_Close;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton Sb_Update;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}