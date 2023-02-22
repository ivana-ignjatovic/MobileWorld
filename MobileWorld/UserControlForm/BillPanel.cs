using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class BillPanel : UserControl
    {
        public event EventHandler ButtonClick;
        public Bill currentBill { get; set; }
        public BillPanel(Bill b)
        {
            InitializeComponent();
            labelDateTime.Text = b.BillDateTime.ToString();
            lblDeviceID.Text = b.BillID.ToString();
            currentBill= b;
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
        private void BillPanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            OneBillForm oneBill = new OneBillForm(currentBill);
            oneBill.ShowDialog();
        }
    }
}
