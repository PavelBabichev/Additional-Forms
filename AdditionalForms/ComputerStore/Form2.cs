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
    public partial class Form2 : Form
    {
        ComputerPart part;
        bool addNew;
        public Form2(ComputerPart _part,bool _addNew)
        {
            InitializeComponent();
            part = _part;
            addNew = _addNew;
            if (addNew == false)
            {
                txtName.Text = _part.Name;
                txtCharact.Text = _part.Characteristic;
                txtDescrip.Text = _part.Description;
                txtPrice.Text = _part.Price.ToString();
                this.Text = "Редактирование товара";
            }
            else
                this.Text = "Добавление товара";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text)||string.IsNullOrWhiteSpace(txtCharact.Text)
                || string.IsNullOrWhiteSpace(txtDescrip.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Не все поля заполнены.");
                return;
            }
            part.Name = txtName.Text;
            part.Characteristic = txtCharact.Text;
            part.Description = txtDescrip.Text;
            try
            {
                part.Price = Convert.ToDouble(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("Цена введена не верно.");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
