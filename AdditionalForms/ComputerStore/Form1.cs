using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Form1 : Form
    {
        double totalSum = 0;
        List<ComputerPart> list = new List<ComputerPart>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            list.AddRange(new ComputerPart[]{
                new ComputerPart("Видеокарта","11 Гб","NVIDIA GDDR5X",36128.00),
                new ComputerPart("Накопитель","120 Гб","SSD 2.5",1197.00),
                new ComputerPart("Модуль памяти","4 Гб","LEVEN DDR4",1109.00)
            });
            foreach (var item in list)
            {
                this.ccmbBoxItems.Items.Add(item);
            }
            ccmbBoxItems.SelectedIndex = 0;
            //this.ccmbBoxItems.DataSource = list;
            //this.ccmbBoxItems.SelectedIndex = 0;
            txtTotal.Text = totalSum.ToString();
        }

        private void ccmbBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text= list[ccmbBoxItems.SelectedIndex].Price.ToString();
        }

        private void btnAddToSelling_Click(object sender, EventArgs e)
        {
            lstBoxSelling.Items.Add(list[ccmbBoxItems.SelectedIndex]);
            totalSum += list[ccmbBoxItems.SelectedIndex].Price;
            txtTotal.Text = totalSum.ToString();
        }

        private void btnDeleteParts_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                list.RemoveAt(ccmbBoxItems.SelectedIndex);
                updateSource();
            }
            else
            {
                MessageBox.Show("Список пуст!!!");
                ccmbBoxItems.Items.Clear();
            }
        }
        void updateSource()
        {
            //this.ccmbBoxItems.DataSource=null;
            //this.ccmbBoxItems.DataSource=list;
            //this.ccmbBoxItems.SelectedIndex = 0;
            this.ccmbBoxItems.Items.Clear();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    this.ccmbBoxItems.Items.Add(item);
                }
                ccmbBoxItems.SelectedIndex = 0;
            }
        }

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            ComputerPart part = new ComputerPart();
            Form2 form2 = new Form2(part, true);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                list.Add(part);
                updateSource();
            }
        }

        private void btnEditParts_Click(object sender, EventArgs e)
        {
            if (list.Count < 1)
            {
                MessageBox.Show("Список пуст!!!");
                return;
            }
            ComputerPart part = (ComputerPart)ccmbBoxItems.SelectedItem;
            Form2 form2 = new Form2(part, false);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                updateSource();
            }
        }
    }
}
