
namespace LibraryManagementSystemClient.AdminForms
{
    partial class FrmAdmins
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
            this.Gc_Admins = new DevExpress.XtraGrid.GridControl();
            this.Gv_Admins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.De_Begin = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.De_End = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Te_AdminName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Sb_Query = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Gc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_CreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gc_State = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_AdminName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Sb_Query);
            this.layoutControl1.Controls.Add(this.Te_AdminName);
            this.layoutControl1.Controls.Add(this.De_End);
            this.layoutControl1.Controls.Add(this.De_Begin);
            this.layoutControl1.Controls.Add(this.Gc_Admins);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(899, 437);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Gc_Admins
            // 
            this.Gc_Admins.Location = new System.Drawing.Point(4, 34);
            this.Gc_Admins.MainView = this.Gv_Admins;
            this.Gc_Admins.Name = "Gc_Admins";
            this.Gc_Admins.Size = new System.Drawing.Size(891, 399);
            this.Gc_Admins.TabIndex = 8;
            this.Gc_Admins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Admins});
            // 
            // Gv_Admins
            // 
            this.Gv_Admins.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gc_Id,
            this.Gc_Name,
            this.Gc_CreateTime,
            this.Gc_State});
            this.Gv_Admins.GridControl = this.Gc_Admins;
            this.Gv_Admins.Name = "Gv_Admins";
            this.Gv_Admins.OptionsBehavior.Editable = false;
            this.Gv_Admins.OptionsView.ColumnAutoWidth = false;
            this.Gv_Admins.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(899, 437);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Gc_Admins;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(895, 403);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // De_Begin
            // 
            this.De_Begin.EditValue = null;
            this.De_Begin.Location = new System.Drawing.Point(63, 6);
            this.De_Begin.Name = "De_Begin";
            this.De_Begin.Properties.BeepOnError = false;
            this.De_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.De_Begin.Properties.DisplayFormat.FormatString = "G";
            this.De_Begin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.De_Begin.Properties.EditFormat.FormatString = "G";
            this.De_Begin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.De_Begin.Properties.MaskSettings.Set("mask", "G");
            this.De_Begin.Size = new System.Drawing.Size(185, 20);
            this.De_Begin.StyleController = this.layoutControl1;
            this.De_Begin.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.De_Begin;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(250, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(250, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 30);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.Text = "创建时间:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 14);
            this.layoutControlItem1.TextToControlDistance = 5;
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
            this.De_End.Properties.DisplayFormat.FormatString = "G";
            this.De_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.De_End.Properties.EditFormat.FormatString = "G";
            this.De_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.De_End.Properties.MaskSettings.Set("mask", "G");
            this.De_End.Size = new System.Drawing.Size(185, 20);
            this.De_End.StyleController = this.layoutControl1;
            this.De_End.TabIndex = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.De_End;
            this.layoutControlItem3.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(210, 30);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem3.Text = "至";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(12, 14);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // Te_AdminName
            // 
            this.Te_AdminName.Location = new System.Drawing.Point(499, 6);
            this.Te_AdminName.Name = "Te_AdminName";
            this.Te_AdminName.Size = new System.Drawing.Size(250, 20);
            this.Te_AdminName.StyleController = this.layoutControl1;
            this.Te_AdminName.TabIndex = 11;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Te_AdminName;
            this.layoutControlItem4.Location = new System.Drawing.Point(460, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(291, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(291, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(291, 30);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Text = "名称:";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(28, 14);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // Sb_Query
            // 
            this.Sb_Query.Location = new System.Drawing.Point(757, 6);
            this.Sb_Query.Name = "Sb_Query";
            this.Sb_Query.Size = new System.Drawing.Size(112, 22);
            this.Sb_Query.StyleController = this.layoutControl1;
            this.Sb_Query.TabIndex = 12;
            this.Sb_Query.Text = "查询";
            this.Sb_Query.Click += new System.EventHandler(this.Sb_Query_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Sb_Query;
            this.layoutControlItem5.Location = new System.Drawing.Point(751, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(120, 30);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(120, 30);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(871, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(24, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Gc_Id
            // 
            this.Gc_Id.Caption = "编号";
            this.Gc_Id.FieldName = "Id";
            this.Gc_Id.Name = "Gc_Id";
            this.Gc_Id.Visible = true;
            this.Gc_Id.VisibleIndex = 0;
            // 
            // Gc_Name
            // 
            this.Gc_Name.Caption = "名称";
            this.Gc_Name.FieldName = "AdminName";
            this.Gc_Name.Name = "Gc_Name";
            this.Gc_Name.Visible = true;
            this.Gc_Name.VisibleIndex = 1;
            // 
            // Gc_CreateTime
            // 
            this.Gc_CreateTime.Caption = "创建时间";
            this.Gc_CreateTime.FieldName = "CreateTime";
            this.Gc_CreateTime.Name = "Gc_CreateTime";
            this.Gc_CreateTime.Visible = true;
            this.Gc_CreateTime.VisibleIndex = 2;
            // 
            // Gc_State
            // 
            this.Gc_State.Caption = "使用状态";
            this.Gc_State.FieldName = "IsRemove";
            this.Gc_State.Name = "Gc_State";
            this.Gc_State.Visible = true;
            this.Gc_State.VisibleIndex = 3;
            // 
            // FrmAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 437);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmAdmins";
            this.Text = "管理员信息列表";
            this.Load += new System.EventHandler(this.FrmAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.De_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_AdminName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl Gc_Admins;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Admins;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton Sb_Query;
        private DevExpress.XtraEditors.TextEdit Te_AdminName;
        private DevExpress.XtraEditors.DateEdit De_End;
        private DevExpress.XtraEditors.DateEdit De_Begin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_CreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Gc_State;
    }
}