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
    public partial class CategoryPanel : UserControl
    {
        public event EventHandler ButtonClick;
        public Category currentCategory { get; set; }
        public CategoryPanel(Category category)
        {
            currentCategory= category;
            InitializeComponent();
            lblCategoryId.Visible= false;
            labelCategory.Text = category.CategoryName;
            lblCategoryId.Text = category.CategoryID.ToString();
        }

        private void CategoryPanel_Load(object sender, EventArgs e)
        {

        }

        private void labelCategory_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
