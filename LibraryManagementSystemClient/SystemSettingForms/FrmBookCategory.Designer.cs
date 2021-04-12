
namespace LibraryManagementSystemClient.SystemSettingForms
{
    partial class FrmBookCategory
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
            this.Sb_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Gc_Categories = new DevExpress.XtraGrid.GridControl();
            this.Gv_Categories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gc_CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_CreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_IsRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rits_Toggle = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.Gc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rits_Toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Sb_Update);
            this.layoutControl1.Controls.Add(this.Sb_Add);
            this.layoutControl1.Controls.Add(this.Gc_Categories);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Sb_Update
            // 
            this.Sb_Update.Location = new System.Drawing.Point(608, 4);
            this.Sb_Update.Name = "Sb_Update";
            this.Sb_Update.Size = new System.Drawing.Size(116, 22);
            this.Sb_Update.StyleController = this.layoutControl1;
            this.Sb_Update.TabIndex = 6;
            this.Sb_Update.Text = "修改";
            this.Sb_Update.Click += new System.EventHandler(this.Sb_Update_Click);
            // 
            // Sb_Add
            // 
            this.Sb_Add.Location = new System.Drawing.Point(488, 4);
            this.Sb_Add.Name = "Sb_Add";
            this.Sb_Add.Size = new System.Drawing.Size(116, 22);
            this.Sb_Add.StyleController = this.layoutControl1;
            this.Sb_Add.TabIndex = 5;
            this.Sb_Add.Text = "添加";
            this.Sb_Add.Click += new System.EventHandler(this.Sb_Add_Click);
            // 
            // Gc_Categories
            // 
            this.Gc_Categories.Location = new System.Drawing.Point(4, 30);
            this.Gc_Categories.MainView = this.Gv_Categories;
            this.Gc_Categories.Name = "Gc_Categories";
            this.Gc_Categories.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Rits_Toggle});
            this.Gc_Categories.Size = new System.Drawing.Size(720, 420);
            this.Gc_Categories.TabIndex = 4;
            this.Gc_Categories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Categories});
            // 
            // Gv_Categories
            // 
            this.Gv_Categories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gc_CategoryName,
            this.Gc_CreateTime,
            this.Gc_IsRemove,
            this.Gc_Id});
            this.Gv_Categories.GridControl = this.Gc_Categories;
            this.Gv_Categories.Name = "Gv_Categories";
            this.Gv_Categories.OptionsView.ColumnAutoWidth = false;
            this.Gv_Categories.OptionsView.ShowGroupPanel = false;
            // 
            // Gc_CategoryName
            // 
            this.Gc_CategoryName.Caption = "类别名称";
            this.Gc_CategoryName.FieldName = "CategoryName";
            this.Gc_CategoryName.Name = "Gc_CategoryName";
            this.Gc_CategoryName.OptionsColumn.AllowEdit = false;
            this.Gc_CategoryName.Visible = true;
            this.Gc_CategoryName.VisibleIndex = 0;
            // 
            // Gc_CreateTime
            // 
            this.Gc_CreateTime.Caption = "创建时间";
            this.Gc_CreateTime.DisplayFormat.FormatString = "G";
            this.Gc_CreateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Gc_CreateTime.FieldName = "CreateTime";
            this.Gc_CreateTime.Name = "Gc_CreateTime";
            this.Gc_CreateTime.OptionsColumn.AllowEdit = false;
            this.Gc_CreateTime.Visible = true;
            this.Gc_CreateTime.VisibleIndex = 1;
            // 
            // Gc_IsRemove
            // 
            this.Gc_IsRemove.Caption = "是否使用";
            this.Gc_IsRemove.ColumnEdit = this.Rits_Toggle;
            this.Gc_IsRemove.FieldName = "IsRemove";
            this.Gc_IsRemove.Name = "Gc_IsRemove";
            this.Gc_IsRemove.Visible = true;
            this.Gc_IsRemove.VisibleIndex = 2;
            // 
            // Rits_Toggle
            // 
            this.Rits_Toggle.AutoHeight = false;
            this.Rits_Toggle.AutoWidth = true;
            this.Rits_Toggle.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.Rits_Toggle.Name = "Rits_Toggle";
            this.Rits_Toggle.OffText = "禁用";
            this.Rits_Toggle.OnText = "使用";
            this.Rits_Toggle.ValueOff = true;
            this.Rits_Toggle.ValueOn = false;
            this.Rits_Toggle.Toggled += new System.EventHandler(this.Rits_Toggle_Toggled);
            // 
            // Gc_Id
            // 
            this.Gc_Id.Caption = "Id";
            this.Gc_Id.FieldName = "Id";
            this.Gc_Id.Name = "Gc_Id";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(728, 454);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Gc_Categories;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(724, 424);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Sb_Add;
            this.layoutControlItem2.Location = new System.Drawing.Point(484, 0);
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
            this.layoutControlItem3.Control = this.Sb_Update;
            this.layoutControlItem3.Location = new System.Drawing.Point(604, 0);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(484, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmBookCategory";
            this.Text = "书籍类别维护";
            this.Load += new System.EventHandler(this.FrmBookCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rits_Toggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton Sb_Update;
        private DevExpress.XtraEditors.SimpleButton Sb_Add;
        private DevExpress.XtraGrid.GridControl Gc_Categories;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Categories;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_CreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_IsRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch Rits_Toggle;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Id;
    }
}