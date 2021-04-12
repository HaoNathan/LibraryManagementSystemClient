using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;

namespace LibraryManagementSystemClient.AdminForms
{
    public partial class FrmEmpower : XtraForm
    {
        public FrmEmpower()
        {
            InitializeComponent();

            _api = new SystemSettingApi();

            _adminApi = new AdminApi();
        }

        private List<TreeListNode> _nodes;
        private readonly SystemSettingApi _api;

        private readonly AdminApi _adminApi;

        private async void Sb_Empower_Click(object sender, EventArgs e)
        {
            _nodes = new List<TreeListNode>();
            RecursiveNode(Tl_Data.Nodes);
            var permissions = _nodes.Aggregate(string.Empty, (current, node) => current + $"{node["AuthorityNum"]},");
            var id = Guid.Parse(Gv_Admins.GetFocusedRowCellValue("Id").ToString());
            var result = await _adminApi.UpdateAdminPower(id, permissions);
            if (!result)
            {
                PopupProvider.Warning("赋权失败!");
                return;
            }

            PopupProvider.Success("赋权成功!");
        }

        private async void FrmEmpower_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定权限数据
                var data = await _api.GetAuthorities(false);
                Tl_Data.KeyFieldName = "AuthorityNum";
                Tl_Data.ParentFieldName = "AuthorityParent";
                Tl_Data.DataSource = data;

                //绑定管理员数据
                var admins = await _adminApi.GetAdmins(true);
                Gc_Admins.DataSource = admins;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void Tl_Data_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            RecursiveNodeSetCheck(e.Node);
        }

        #region TreeList递归

        private void RecursiveNodeSetCheck(TreeListNode node)
        {
            foreach (TreeListNode item in node.Nodes)
            {
                item.CheckState = node.CheckState;
                if (item.HasChildren)
                {
                    RecursiveNodeSetCheck(item);
                }
            }
        }

        private void RecursiveNode(TreeListNodes nodes)
        {
            foreach (TreeListNode item in nodes)
            {
                if (!item.Checked) continue;
                _nodes.Add(item);
                if (item.HasChildren)
                {
                    RecursiveNode(item.Nodes);
                }
            }
        }
        #endregion

        private void Sb_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}