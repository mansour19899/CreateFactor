using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar.Controls;

namespace CreateFactor
{
    public partial class Form1 : Form
    {
        private List<Order> orders=null;
        private Order order;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            order = new Order();
            orders = new List<Order>();
            string t = DateTime.Now.ToPersianDateString();
            txtDate.Text = t;
           List<string> ss=new List<string>();
           StreamReader sr=new StreamReader("NameList.txt");
            string line;
            while ((line=sr.ReadLine()) != null)
            {
                ss.Add(line);
            }

            cmbPart.DataSource = ss;


        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            orders.Clear();
            for (int i = 0; i < dataGridViewX1.RowCount - 1; i++)
            {
                orders.Add(new Order()
                {
                    Description = dataGridViewX1.Rows[i].Cells[0].Value.ToString(),
                    Count = dataGridViewX1.Rows[i].Cells[1].Value.ToString(),
                    Unit = dataGridViewX1.Rows[i].Cells[2].Value.ToString()
                });


            }



            stiReport1.Load("Report.mrt");
            stiReport1.Dictionary.Variables["date"].Value = txtDate.Text;
            stiReport1.Dictionary.Variables["part"].Value = cmbPart.GetItemText(cmbPart.SelectedItem);
            stiReport1.Dictionary.Variables["number"].Value = txtNumber.Text;

            stiReport1.RegBusinessObject("Orders", orders);
            stiReport1.Show();



            int x = 0;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
