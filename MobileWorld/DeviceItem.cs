using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class DeviceItem : UserControl
    {
        public Device currentDevice { get; set; }

        public DeviceItem(Device device)
        {
           
            
            InitializeComponent();
            currentDevice= device;
            label1.Text = device.DeviceName;
            label2.Text = device.DevicePrice;
            labelId.Text = device.DeviceID.ToString();

            if (device.DeviceImage!= null)
            {

                panelImage.BackgroundImage= Image.FromStream(new MemoryStream(Convert.FromBase64String(device.DeviceImage)));
              
            }
         
             
        }
        Image ConvertBinaryToImage(byte [] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }

        private void DeviceItem_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToBill_Click(object sender, EventArgs e)
        {
            //Form1 form= new Form1();
            
        }

        internal void buttonAddToBill_Click(object v, object sender, EventArgs eventArgs, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
