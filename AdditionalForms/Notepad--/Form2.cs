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

namespace Notepad__
{
    public partial class Form2 : Form
    {
        TextBox temp;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            foreach (var item in form1.Controls)
            {
                if (item is TextBox)
                {
                    temp = item as TextBox;
                }
            }
            this.txtEdit.Text = temp.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(txtEdit.Text);
                writer.Close();
                temp.Text = txtEdit.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
