using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void add_Data(object sender, EventArgs e)
        {
            
        }

            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "Name";
            dataGridView2.Columns[2].Name = "Object";
            dataGridView2.Columns[3].Name = "Year";

            string[] row = new string[] { "1", "Peshkun", "1C", "1977" };
            dataGridView2.Rows.Add(row);
            row = new string[] { "2", "Gustov", "c#", "2023" };
            dataGridView2.Rows.Add(row);
            row = new string[] { "3", "Perelygin", "Swift", "2019" };
            dataGridView2.Rows.Add(row);
        }
    }
}