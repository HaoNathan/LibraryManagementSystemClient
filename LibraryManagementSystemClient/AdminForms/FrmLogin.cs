using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemApiRequest;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemClient.AdminForms
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();

            _api = new AdminApi();
        }

        /// <summary>
        /// 请求接口
        /// </summary>
        private readonly AdminApi _api;

        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Sb_Authentication_Click(object sender, EventArgs e)
        {
            Sb_Authentication.Enabled = false;
            Sb_Cancel.Enabled = true;
            Xtc_Tabs.Enabled = false;
            var flag = false;
            try
            {
                var token = _cts.Token;
                while (!flag)
                {
                    await Task.Run(async () => { flag = await _api.Login(Cam_Camera.TakeSnapshot()); }, token);
                    if (!flag) continue;
                    Cam_Camera.Stop();
                    ShowLoadForm();
                }
            }
            catch (Exception exception)
            {
                LogHelper.Error(exception.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Xtc_Tabs_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            if (e.PageIndex != 1)
            {
                Cam_Camera.Device.Stop();
                Lci_Authen.Visibility = LayoutVisibility.Never;
                Lci_Cancel.Visibility = LayoutVisibility.Never;
                return;
            }

            Lci_Authen.Visibility = LayoutVisibility.Always;
            Lci_Cancel.Visibility = LayoutVisibility.Always;

            var info = CameraControl.GetDevices().FirstOrDefault();
            if (info == null)
            {
                XtraMessageBox.Show(this, "未找到输入设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cam_Camera.Start(CameraControl.GetDevice(info));
        }

        private void Sb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Sb_Login_Click(object sender, EventArgs e)
        {
            var res = await _api.Login(new Admin
            {
                AdminName = TeAccount.Text,
                AdminPassword = TePassword.Text
            });

            if (!res)
            {
                XtraMessageBox.Show("登陆失败！", "提示", MessageBoxButtons.OK);
                return;
            }

            XtraMessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK);
            ShowLoadForm();
        }

        private async void ShowLoadForm()
        {
            var op = new FluentSplashScreenOptions
            {
                Opacity = 100,
                Title = $"Hi ~ 【{GlobalCache.Admin.AdminName}】,欢迎回来！",
                Subtitle = "正在为您加载数据,请稍后!",
                RightFooter = "Starting...",
                LeftFooter =
                    $"Copyright © 2021.1 - 2021.2 XIANG HAO.{Environment.NewLine} All Rights reserved.",
                LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
                OpacityColor = Color.Gray,
                LogoImageOptions =
                {
                    SvgImage = SvgImage.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resource/管理员.svg"),
                    SvgImageColorizationMode = SvgImageColorizationMode.Default, SvgImageSize = new Size(60, 60)
                }
            };

            this.Hide();
            SplashScreenManager.ShowFluentSplashScreen(
                op,
                parentForm: this,
                useFadeIn: true,
                useFadeOut: true
            );
            var admin = await _api.GetAdminInfo(new Admin
            { AdminName = GlobalCache.Admin.AdminName, AdminPassword = GlobalCache.Admin.AdminPassword });
            GlobalCache.Admin = admin;
            Thread.Sleep(2500);

            //关闭加载窗体
            SplashScreenManager.CloseForm();

            new FrmMain().Show();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Sb_Cancel_Click(object sender, EventArgs e)
        {
            _cts.Token.Register(() => { XtraMessageBox.Show("已停止识别！"); });
            _cts.Cancel(true);
            Cam_Camera.Stop();
            Sb_Cancel.Enabled = false;
            Sb_Authentication.Enabled = true;
            Xtc_Tabs.Enabled = true;
        }
    }
}