using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemApiRequest;

namespace LibraryManagementSystemClient.BorrowingForms
{
    public partial class FrmFinePayments : XtraForm
    {
        public FrmFinePayments()
        {
            InitializeComponent();
            _api = new FinePaymentApi();
        }

        private readonly FinePaymentApi _api;

        private async void FrmFinePayments_Load(object sender, EventArgs e)
        {
            await BindFinePayments();
        }

        private async Task BindFinePayments()
        {
            var data = await _api.GetFinePayments(true);
            Gc_FinePayments.DataSource = data;
        }
    }
}