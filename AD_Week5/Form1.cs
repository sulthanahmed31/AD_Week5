using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Week5
{
    public partial class Form1 : Form
    {
        DataTable dtCategory;
        public List<string> category;
        public List<string> product;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = new List<string>
            {
                "Jas",
                "T-Shirt",
                "Rok",
                "Celana",
                "Cawat"
            };
            dtCategory = new DataTable();
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
        }
    }
}
