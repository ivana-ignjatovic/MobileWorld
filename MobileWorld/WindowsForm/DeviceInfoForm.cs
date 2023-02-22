using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class DeviceInfoForm : Form
    {
        public OpenFileDialog dialog;
        public Image img;
        public byte[] byteimg;
        private Label lblFileName;
        public Device currentDevice { get; set; }
        public DeviceInfoForm(Device device)
        {
            InitializeComponent();
            textBoxName.Text = device.DeviceName;
            textBoxPrice.Text=device.DevicePrice.ToString();
            richTextBox1.Text=device.DeviceCharact.ToString();
            if (device.DeviceImage != null)
            {

                pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(Convert.FromBase64String(device.DeviceImage)));

            }
            currentDevice= device;
        }

        private void DeviceInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void labelDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserId == 4)
            {
                string message = "Da li zaista zelite da izbrisete ovaj uredjaj?";
                string title = "Izbrisi uredjaj";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
                    context.Devices.Remove(currentDevice);
                    context.SaveChanges();
                }
                else
                {
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Nemate privilegiju za brisanje uredjaja!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserId == 4)
            {

            
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            currentDevice.DeviceName= textBoxName.Text;
            currentDevice.DevicePrice = textBoxPrice.Text;
            currentDevice.DeviceCharact = richTextBox1.Text;
            if (byteimg != null)
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(lblFileName.Text);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                currentDevice.DeviceImage = base64ImageRepresentation;
            }
            context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nemate privilegiju za izmenu uredjaja!");
            }
        }
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...", ValidateNames = true, Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    lblFileName.Visible = false;
                    lblFileName.Text = openFile.FileName;
                    img = Image.FromFile(lblFileName.Text);
                    byteimg = ReadFile(openFile.FileName);
                    pictureBox1.Image = img;

                }
            }
        }
    }
}
