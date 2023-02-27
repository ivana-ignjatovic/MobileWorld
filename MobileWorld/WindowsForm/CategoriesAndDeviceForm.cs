using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Encoder = System.Drawing.Imaging.Encoder;

namespace MobileWorld
{
    public partial class CategoriesAndDeviceForm : Form
    {
        
        public OpenFileDialog dialog;
        public Image img;
        public byte[] byteimg;
        public CategoriesAndDeviceForm()
        {
            InitializeComponent();
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            RefreshData();
            using (MOBILESTOREDBEContext context = new MOBILESTOREDBEContext())
            {
                var categories = context.Categories.ToList();
                foreach (var category in categories)
                {
                    comboBox1.Items.Add(category.CategoryName);
                }
            }

        }
        private void RefreshData()
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            dataGridView1.DataSource = context.Categories.ToList();
            MainForm form= new MainForm();
            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CategoryID"].Value.ToString());
            Category category = context.Categories.Where(c=> c.CategoryID == idSelect).FirstOrDefault();
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
                RefreshData();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CategoryID"].Value.ToString());
            Category category = context.Categories.Where(c => c.CategoryID == idSelect).FirstOrDefault();
            if (category != null)
            {
                category.CategoryName = dataGridView1.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                category.CategoryDescription = dataGridView1.SelectedRows[0].Cells["CategoryDescription"].Value.ToString();
        
                context.SaveChanges();
                RefreshData();
            }
        }

    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        var codecs = ImageCodecInfo.GetImageDecoders();
        return codecs.FirstOrDefault(codec => codec.FormatID == format.Guid);
    }

    private void button1_Click(object sender, EventArgs e)
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
        byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            Device device= new Device();
            if(textBoxDeviceName.Text=="" ||
                textBoxDevicePrice.Text=="" )
            {
                MessageBox.Show("Morate uneti sva polja!");
            }
            else
            {
                device.DeviceName = textBoxDeviceName.Text;
                device.DevicePrice = textBoxDevicePrice.Text;
                device.DeviceCharact = richTextBox1.Text;
                int selectedCategoryID = 0;
                foreach (var category in context.Categories)
                {
                    if (category.CategoryName == comboBox1.SelectedItem.ToString())
                    {
                        selectedCategoryID = category.CategoryID;
                        break;
                    }
                }
                device.DeviceCategory = selectedCategoryID;
                if (byteimg != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(lblFileName.Text);
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    device.DeviceImage = base64ImageRepresentation;
                }
                context.Devices.Add(device);
                context.SaveChanges();
                MessageBox.Show("Uspesno ste uneli uredjaj!");
                textBoxDeviceName.Text = string.Empty;
                textBoxDevicePrice.Text = string.Empty;
                richTextBox1.Text = string.Empty;
                pictureBox1.Image = null;
                RefreshData();
            }
         
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBoxCategoryName.Text;
            category.CategoryDescription = textBoxDescription.Text;
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            context.Categories.Add(category);
            context.SaveChanges();
            RefreshData();
        }

    
    }
}
