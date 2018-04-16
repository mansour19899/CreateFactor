using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace CreateFactor
{
    public partial class Form1 : Form
    {
        private List<Order> orders=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string t = DateTime.Now.ToPersianDateString();
            txtDate.Text = t;
            string[] s = new[] { "اجرایی", "bsaa" };
            cmbPart.DataSource = s;


        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Order order = new Order();
           orders = new List<Order>();

            for (int i = 0; i < dataGridViewX1.RowCount - 1; i++)
            {
                
                orders.Add(new Order()
                {
                    Description = dataGridViewX1.Rows[i].Cells[0].Value.ToString(),
                    Count = dataGridViewX1.Rows[i].Cells[1].Value.ToString(),
                    Unit = dataGridViewX1.Rows[i].Cells[2].Value.ToString()
                });


            }

            int x = 0;

        }
    }
}
