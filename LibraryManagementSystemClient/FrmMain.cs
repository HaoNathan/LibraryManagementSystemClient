using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemClient.AdminForms;
using LibraryManagementSystemClient.BookForms;
using LibraryManagementSystemClient.BorrowingForms;
using LibraryManagementSystemClient.EmployeeForms;
using LibraryManagementSystemClient.MainForms;
using LibraryManagementSystemClient.StudentForms;
using LibraryManagementSystemClient.SystemSettingForms;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemClient
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //SplashScreen 公共方法回调[执行完毕标志]
        private IOverlaySplashScreenHandle _handle;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActivationFunction();
            Tm_UpdateTime.Start();
            GlobalCache.FlyPanel = Fp_MsgRemind;
            GlobalCache.Form = this;
            Bbi_AdminName.Caption = GlobalCache.Admin.AdminName;
            new FrmHome { MdiParent = this }.Show();
            Tv_FormView.Documents[0].Properties.AllowClose = DefaultBoolean.False;
            Tv_FormView.Documents[0].Properties.AllowFloat = DefaultBoolean.False;
        }

        /// <summary>
        /// 根据账号权限来启用功能
        /// </summary>
        private void ActivationFunction()
        {
            var admin = GlobalCache.Admin;
            var splitStr = admin.AdministratorRights.Split(',');

            foreach (NavBarGroup group in Nbc_Menu.Groups)
            {
                group.Visible = splitStr.Contains(group.Tag);

                foreach (NavBarItemLink navItem in group.ItemLinks)
                {
                    navItem.Visible = splitStr.Contains(navItem.Item.Tag);
                }
            }

            Bbi_Borrow.Visibility = splitStr.Contains("101") ? BarItemVisibility.Always : BarItemVisibility.Never;
            Bbi_Reservation.Visibility = splitStr.Contains("102") ? BarItemVisibility.Always : BarItemVisibility.Never;
            Bbi_Borrows.Visibility = splitStr.Contains("103") ? BarItemVisibility.Always : BarItemVisibility.Never;
            Bbi_Reservations.Visibility = splitStr.Contains("104") ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nbc_Menu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var formName = e.Link.Item.Tag.ToString();
            XtraForm form;
            switch (formName)
            {
                case "101":
                    form = new FrmBorrow();
                    GlobalCache.Type = typeof(FrmBorrow);

                    #region Test

                    //ribbon.Pages[0].Groups[0].ItemLinks.Add(new BarButtonItem() {
                    //Caption = "test", ImageOptions = { Image = Image.FromFile(@"C:\Users\ASUS\Pictures\ICON\Exit.png") }
                    //});

                    #endregion

                    break;
                case "102":
                    form = new FrmReservation();
                    GlobalCache.Type = typeof(FrmReservation);
                    break;
                case "103":
                    form = new FrmBorrowInfos();
                    GlobalCache.Type = typeof(FrmBorrowInfos);
                    break;
                case "104":
                    form = new FrmReservationInfos();
                    GlobalCache.Type = typeof(FrmReservationInfos);
                    break;
                case "105":
                    form = new FrmFinePayments();
                    GlobalCache.Type = typeof(FrmFinePayments);
                    break;
                case "106":
                    form = new FrmBooks();
                    GlobalCache.Type = typeof(FrmBooks);
                    break;
                case "201":
                    form = new FrmBooksInfo();
                    GlobalCache.Type = typeof(FrmBooksInfo);
                    break;
                case "202":
                    form = new FrmBooks();
                    GlobalCache.Type = typeof(FrmBooks);
                    break;
                case "401":
                    form = new FrmEmployees();
                    GlobalCache.Type = typeof(FrmEmployees);
                    break;
                case "301":
                    form = new FrmStudents();
                    GlobalCache.Type = typeof(FrmStudents);
                    break;
                case "501":
                    form = new FrmAdmins();
                    GlobalCache.Type = typeof(FrmAdmins);
                    break;
                case "502":
                    form = new FrmEmpower();
                    GlobalCache.Type = typeof(FrmEmpower);
                    break;
                case "601":
                    form = new FrmPublishingHouse();
                    GlobalCache.Type = typeof(FrmPublishingHouse);
                    break;
                case "602":
                    form = new FrmBookCategory();
                    GlobalCache.Type = typeof(FrmBookCategory);
                    break;
                default:
                    form = new XtraForm();
                    break;
            }

            if (CheckIsExist(form.Text)) return;
            form.MdiParent = this;
            _handle = OverlayScreenForm.ShowProgressPanel(this);
            form.Show();
            OverlayScreenForm.CloseProgressPanel(_handle);
        }

        private void Bbi_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private bool CheckIsExist(string formName)
        {
            using (var item = Tv_FormView.Documents.FirstOrDefault(m => m.Caption.Equals(formName)))
            {
                if (item == null) return false;
                Tv_FormView.Controller.Activate(item);
                return true;
            }
        }

        private void Bbi_ExitAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            GlobalCache.Token = "Bearer ";
            new FrmLogin().Show();
        }

        private async void Fp_MsgRemind_Shown(object sender, FlyoutPanelEventArgs e)
        {
            if (!Fp_MsgRemind.IsPopupOpen) return;
            await Task.Delay(3000);
            Fp_MsgRemind.HidePopup(false);
        }

        private void Tm_UpdateTime_Tick(object sender, EventArgs e) =>
            Bbi_Time.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = XtraMessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                e.Cancel = true;
                return;
            }

            DialogResult = DialogResult.Yes;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dm_FormsManager_DocumentActivate(object sender, DocumentEventArgs e)
        {
            if (e.Document == null) return;
            GlobalCache.Type = e.Document.Form.GetType();
        }

        private void Bbi_Refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var type = GlobalCache.Type;
            var form = Dm_FormsManager.View.ActiveDocument.Form;
            var method = type.GetMethod("BindData");
            if (!(method == null)) method.Invoke(form, null);
        }

        private async void Bbi_UpdatePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var result = XtraInputBox.Show("请输入", "修改密码", "请输入新密码!");
                if (string.IsNullOrEmpty(result)) return;
                var res = await new AdminApi().UpdateAdminPassword(GlobalCache.Admin.Id, result);
                if (res.ResultCode!=1)
                {
                    PopupProvider.Warning(res.ResultMessage);
                    return;
                }
                PopupProvider.Success(res.ResultMessage);
            }
            catch (Exception exception)
            {
                PopupProvider.Error("修改异常!",exception);
            }
        }

        private void Bbi_Borrow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FrmBorrow();
            if (CheckIsExist(form.Text)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void Bbi_Reservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FrmReservation();
            if (CheckIsExist(form.Text)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void Bbi_Borrows_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FrmBorrowInfos();
            if (CheckIsExist(form.Text)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void Bbi_Reservations_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FrmReservationInfos();
            if (CheckIsExist(form.Text)) return;
            form.MdiParent = this;
            form.Show();
        }
    }
}