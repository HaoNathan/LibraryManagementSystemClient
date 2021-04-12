
namespace LibraryManagementSystemClient.AdminForms
{
    partial class FrmEmpower
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.Gc_Admins = new DevExpress.XtraGrid.GridControl();
            this.Gv_Admins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.Sb_Empower = new DevExpress.XtraEditors.SimpleButton();
            this.Tl_Data = new DevExpress.XtraTreeList.TreeList();
            this.Tlc_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tlc_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tlc_CreateTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tlc_State = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Sb_Close = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tl_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(713, 412);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(705, 404);
            this.splitContainerControl1.SplitterPosition = 277;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.Gc_Admins);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(277, 404);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // Gc_Admins
            // 
            this.Gc_Admins.Location = new System.Drawing.Point(4, 4);
            this.Gc_Admins.MainView = this.Gv_Admins;
            this.Gc_Admins.Name = "Gc_Admins";
            this.Gc_Admins.Size = new System.Drawing.Size(269, 396);
            this.Gc_Admins.TabIndex = 4;
            this.Gc_Admins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Admins});
            // 
            // Gv_Admins
            // 
            this.Gv_Admins.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.Gv_Admins.GridControl = this.Gc_Admins;
            this.Gv_Admins.Name = "Gv_Admins";
            this.Gv_Admins.OptionsBehavior.Editable = false;
            this.Gv_Admins.OptionsView.ColumnAutoWidth = false;
            this.Gv_Admins.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "管理员";
            this.gridColumn1.FieldName = "AdminName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "使用标志";
            this.gridColumn2.FieldName = "IsRemove";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "创建时间";
            this.gridColumn3.FieldName = "CreateTime";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(277, 404);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Gc_Admins;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(273, 400);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.Sb_Close);
            this.layoutControl2.Controls.Add(this.Sb_Empower);
            this.layoutControl2.Controls.Add(this.Tl_Data);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(418, 404);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // Sb_Empower
            // 
            this.Sb_Empower.Location = new System.Drawing.Point(4, 378);
            this.Sb_Empower.Name = "Sb_Empower";
            this.Sb_Empower.Size = new System.Drawing.Size(116, 22);
            this.Sb_Empower.StyleController = this.layoutControl2;
            this.Sb_Empower.TabIndex = 5;
            this.Sb_Empower.Text = "保存";
            this.Sb_Empower.Click += new System.EventHandler(this.Sb_Empower_Click);
            // 
            // Tl_Data
            // 
            this.Tl_Data.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Tlc_Id,
            this.Tlc_Name,
            this.Tlc_CreateTime,
            this.Tlc_State});
            this.Tl_Data.Location = new System.Drawing.Point(4, 4);
            this.Tl_Data.Name = "Tl_Data";
            this.Tl_Data.BeginUnboundLoad();
            this.Tl_Data.AppendNode(new object[] {
            null,
            null,
            null,
            null}, -1);
            this.Tl_Data.EndUnboundLoad();
            this.Tl_Data.OptionsBehavior.Editable = false;
            this.Tl_Data.OptionsBehavior.PopulateServiceColumns = true;
            this.Tl_Data.OptionsView.AnimationType = DevExpress.XtraTreeList.TreeListAnimationType.AnimateAllContent;
            this.Tl_Data.OptionsView.AutoWidth = false;
            this.Tl_Data.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.Tl_Data.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.Check;
            this.Tl_Data.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.Tl_Data.Size = new System.Drawing.Size(410, 370);
            this.Tl_Data.TabIndex = 4;
            this.Tl_Data.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.Tl_Data_AfterCheckNode);
            // 
            // Tlc_Id
            // 
            this.Tlc_Id.Caption = "编号";
            this.Tlc_Id.FieldName = "Id";
            this.Tlc_Id.Name = "Tlc_Id";
            this.Tlc_Id.OptionsColumn.AllowEdit = false;
            this.Tlc_Id.Width = 162;
            // 
            // Tlc_Name
            // 
            this.Tlc_Name.Caption = "权限名称";
            this.Tlc_Name.FieldName = "Authorities";
            this.Tlc_Name.Name = "Tlc_Name";
            this.Tlc_Name.Visible = true;
            this.Tlc_Name.VisibleIndex = 0;
            this.Tlc_Name.Width = 247;
            // 
            // Tlc_CreateTime
            // 
            this.Tlc_CreateTime.Caption = "创建时间";
            this.Tlc_CreateTime.FieldName = "CreateTime";
            this.Tlc_CreateTime.Format.FormatString = "G";
            this.Tlc_CreateTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Tlc_CreateTime.Name = "Tlc_CreateTime";
            this.Tlc_CreateTime.Visible = true;
            this.Tlc_CreateTime.VisibleIndex = 1;
            this.Tlc_CreateTime.Width = 130;
            // 
            // Tlc_State
            // 
            this.Tlc_State.Caption = "是否作废";
            this.Tlc_State.FieldName = "IsRemove";
            this.Tlc_State.Name = "Tlc_State";
            this.Tlc_State.Visible = true;
            this.Tlc_State.VisibleIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(418, 404);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Tl_Data;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(414, 374);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Sb_Empower;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 374);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(713, 412);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.splitContainerControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(709, 408);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Sb_Close
            // 
            this.Sb_Close.Location = new System.Drawing.Point(124, 378);
            this.Sb_Close.Name = "Sb_Close";
            this.Sb_Close.Size = new System.Drawing.Size(116, 22);
            this.Sb_Close.StyleController = this.layoutControl2;
            this.Sb_Close.TabIndex = 6;
            this.Sb_Close.Text = "关闭";
            this.Sb_Close.Click += new System.EventHandler(this.Sb_Close_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Sb_Close;
            this.layoutControlItem5.Location = new System.Drawing.Point(120, 374);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(240, 374);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(174, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmEmpower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 412);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmEmpower";
            this.Text = "管理员赋权";
            this.Load += new System.EventHandler(this.FrmEmpower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tl_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraGrid.GridControl Gc_Admins;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Admins;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraTreeList.TreeList Tl_Data;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton Sb_Empower;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tlc_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tlc_Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tlc_CreateTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tlc_State;
        private DevExpress.XtraEditors.SimpleButton Sb_Close;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}