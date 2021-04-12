
namespace LibraryManagementSystemClient.StudentForms
{
    partial class FrmStudents
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
            this.De_Begin = new DevExpress.XtraEditors.DateEdit();
            this.Te_Name = new DevExpress.XtraEditors.TextEdit();
            this.Sb_Close = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Query = new DevExpress.XtraEditors.SimpleButton();
            this.Gc_Students = new DevExpress.XtraGrid.GridControl();
            this.Gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_StudentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Class = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Contact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_CreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_IsRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.De_End = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.De_End);
            this.layoutControl1.Controls.Add(this.De_Begin);
            this.layoutControl1.Controls.Add(this.Te_Name);
            this.layoutControl1.Controls.Add(this.Sb_Close);
            this.layoutControl1.Controls.Add(this.Sb_Update);
            this.layoutControl1.Controls.Add(this.Sb_Add);
            this.layoutControl1.Controls.Add(this.Sb_Query);
            this.layoutControl1.Controls.Add(this.Gc_Students);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(897, 466);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // De_Begin
            // 
            this.De_Begin.EditValue = null;
            this.De_Begin.Location = new System.Drawing.Point(70, 6);
            this.De_Begin.Name = "De_Begin";
            this.De_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Size = new System.Drawing.Size(178, 20);
            this.De_Begin.StyleController = this.layoutControl1;
            this.De_Begin.TabIndex = 8;
            // 
            // Te_Name
            // 
            this.Te_Name.Location = new System.Drawing.Point(533, 6);
            this.Te_Name.Name = "Te_Name";
            this.Te_Name.Size = new System.Drawing.Size(108, 20);
            this.Te_Name.StyleController = this.layoutControl1;
            this.Te_Name.TabIndex = 2;
            // 
            // Sb_Close
            // 
            this.Sb_Close.Location = new System.Drawing.Point(767, 4);
            this.Sb_Close.Name = "Sb_Close";
            this.Sb_Close.Size = new System.Drawing.Size(116, 22);
            this.Sb_Close.StyleController = this.layoutControl1;
            this.Sb_Close.TabIndex = 4;
            this.Sb_Close.Text = "关闭";
            this.Sb_Close.Click += new System.EventHandler(this.Sb_Close_Click);
            // 
            // Sb_Update
            // 
            this.Sb_Update.Location = new System.Drawing.Point(777, 440);
            this.Sb_Update.Name = "Sb_Update";
            this.Sb_Update.Size = new System.Drawing.Size(116, 22);
            this.Sb_Update.StyleController = this.layoutControl1;
            this.Sb_Update.TabIndex = 7;
            this.Sb_Update.Text = "修改";
            this.Sb_Update.Click += new System.EventHandler(this.Sb_Update_Click);
            // 
            // Sb_Add
            // 
            this.Sb_Add.Location = new System.Drawing.Point(657, 440);
            this.Sb_Add.Name = "Sb_Add";
            this.Sb_Add.Size = new System.Drawing.Size(116, 22);
            this.Sb_Add.StyleController = this.layoutControl1;
            this.Sb_Add.TabIndex = 6;
            this.Sb_Add.Text = "新增";
            this.Sb_Add.Click += new System.EventHandler(this.Sb_Add_Click);
            // 
            // Sb_Query
            // 
            this.Sb_Query.Location = new System.Drawing.Point(647, 4);
            this.Sb_Query.Name = "Sb_Query";
            this.Sb_Query.Size = new System.Drawing.Size(116, 22);
            this.Sb_Query.StyleController = this.layoutControl1;
            this.Sb_Query.TabIndex = 3;
            this.Sb_Query.Text = "查询";
            this.Sb_Query.Click += new System.EventHandler(this.Sb_Query_Click);
            // 
            // Gc_Students
            // 
            this.Gc_Students.Location = new System.Drawing.Point(4, 32);
            this.Gc_Students.MainView = this.Gv_Students;
            this.Gc_Students.Name = "Gc_Students";
            this.Gc_Students.Size = new System.Drawing.Size(889, 404);
            this.Gc_Students.TabIndex = 5;
            this.Gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Students});
            // 
            // Gv_Students
            // 
            this.Gv_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gc_Id,
            this.Gc_StudentName,
            this.Gc_StudentNo,
            this.Gc_Sex,
            this.Gc_Class,
            this.Gc_Age,
            this.Gc_Department,
            this.Gc_Contact,
            this.Gc_Email,
            this.Gc_CreateTime,
            this.Gc_IsRemove});
            this.Gv_Students.GridControl = this.Gc_Students;
            this.Gv_Students.Name = "Gv_Students";
            this.Gv_Students.OptionsBehavior.Editable = false;
            this.Gv_Students.OptionsView.ColumnAutoWidth = false;
            this.Gv_Students.OptionsView.ShowGroupPanel = false;
            this.Gv_Students.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.Gv_Students_RowClick);
            // 
            // Gc_Id
            // 
            this.Gc_Id.Caption = "编号";
            this.Gc_Id.FieldName = "Id";
            this.Gc_Id.Name = "Gc_Id";
            this.Gc_Id.Visible = true;
            this.Gc_Id.VisibleIndex = 0;
            // 
            // Gc_StudentName
            // 
            this.Gc_StudentName.Caption = "姓名";
            this.Gc_StudentName.FieldName = "StudentName";
            this.Gc_StudentName.Name = "Gc_StudentName";
            this.Gc_StudentName.Visible = true;
            this.Gc_StudentName.VisibleIndex = 1;
            // 
            // Gc_StudentNo
            // 
            this.Gc_StudentNo.Caption = "学号";
            this.Gc_StudentNo.FieldName = "StudentNo";
            this.Gc_StudentNo.Name = "Gc_StudentNo";
            this.Gc_StudentNo.Visible = true;
            this.Gc_StudentNo.VisibleIndex = 2;
            // 
            // Gc_Sex
            // 
            this.Gc_Sex.Caption = "性别";
            this.Gc_Sex.FieldName = "Sex";
            this.Gc_Sex.Name = "Gc_Sex";
            this.Gc_Sex.Visible = true;
            this.Gc_Sex.VisibleIndex = 3;
            // 
            // Gc_Class
            // 
            this.Gc_Class.Caption = "班级";
            this.Gc_Class.FieldName = "Class";
            this.Gc_Class.Name = "Gc_Class";
            this.Gc_Class.Visible = true;
            this.Gc_Class.VisibleIndex = 4;
            // 
            // Gc_Age
            // 
            this.Gc_Age.Caption = "年龄";
            this.Gc_Age.FieldName = "Age";
            this.Gc_Age.Name = "Gc_Age";
            this.Gc_Age.Visible = true;
            this.Gc_Age.VisibleIndex = 5;
            // 
            // Gc_Department
            // 
            this.Gc_Department.Caption = "系部";
            this.Gc_Department.FieldName = "DepartmentName";
            this.Gc_Department.Name = "Gc_Department";
            this.Gc_Department.Visible = true;
            this.Gc_Department.VisibleIndex = 6;
            // 
            // Gc_Contact
            // 
            this.Gc_Contact.Caption = "联系方式";
            this.Gc_Contact.FieldName = "Contact";
            this.Gc_Contact.Name = "Gc_Contact";
            this.Gc_Contact.Visible = true;
            this.Gc_Contact.VisibleIndex = 7;
            // 
            // Gc_Email
            // 
            this.Gc_Email.Caption = "邮箱";
            this.Gc_Email.FieldName = "Email";
            this.Gc_Email.Name = "Gc_Email";
            this.Gc_Email.Visible = true;
            this.Gc_Email.VisibleIndex = 8;
            // 
            // Gc_CreateTime
            // 
            this.Gc_CreateTime.Caption = "创建时间";
            this.Gc_CreateTime.FieldName = "CreateTime";
            this.Gc_CreateTime.Name = "Gc_CreateTime";
            this.Gc_CreateTime.Visible = true;
            this.Gc_CreateTime.VisibleIndex = 9;
            // 
            // Gc_IsRemove
            // 
            this.Gc_IsRemove.Caption = "是否作废";
            this.Gc_IsRemove.FieldName = "IsRemove";
            this.Gc_IsRemove.Name = "Gc_IsRemove";
            this.Gc_IsRemove.Visible = true;
            this.Gc_IsRemove.VisibleIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(897, 466);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Gc_Students;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(893, 408);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.Sb_Add;
            this.layoutControlItem8.Location = new System.Drawing.Point(653, 436);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.Sb_Update;
            this.layoutControlItem9.Location = new System.Drawing.Point(773, 436);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 436);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(653, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Sb_Query;
            this.layoutControlItem3.Location = new System.Drawing.Point(643, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(120, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.Sb_Close;
            this.layoutControlItem10.Location = new System.Drawing.Point(763, 0);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(120, 28);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextToControlDistance = 0;
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Te_Name;
            this.layoutControlItem2.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(173, 28);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Text = "学生姓名:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(883, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.De_Begin;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(250, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(250, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(250, 28);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Text = "创建时间:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
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
            this.De_End.TabIndex = 9;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.De_End;
            this.layoutControlItem5.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 28);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem5.Text = "至";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(12, 14);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 466);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmStudents";
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl Gc_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Students;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton Sb_Query;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton Sb_Update;
        private DevExpress.XtraEditors.SimpleButton Sb_Add;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton Sb_Close;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_StudentNo;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Sex;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Class;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Age;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Department;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Contact;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Email;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_CreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_IsRemove;
        private DevExpress.XtraEditors.TextEdit Te_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit De_Begin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit De_End;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}