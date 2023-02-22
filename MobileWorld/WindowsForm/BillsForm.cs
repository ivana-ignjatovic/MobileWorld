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
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
          
            List <Bill> bills = new List <Bill>();
            int x = 10;
            int y = 10;
            int counter = 0;
            bills = context.Bills.ToList();
            panel1.AutoScroll= true;
            foreach (var bill in bills)
            {
                var billPanel = new BillPanel(bill); 
                billPanel.Location=new Point(x, y);
                panel1.Controls.Add(billPanel);
                x += billPanel.Width + 10;
               // y += billPanel.Height + 50;
                counter++;
                if (counter % 5 == 0)
                {
                    x = 10;
                    y += billPanel.Height + 10;
                }
            }
   
        }

    }
}
