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

namespace AdditionalForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = path.SelectedPath;
            }
            if (!string.IsNullOrWhiteSpace(txtPath.Text) && !string.IsNullOrWhiteSpace(txtMask.Text))
            {
                btnSearch.Enabled = true;
            }
        }

        private void txtMask_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPath.Text) && !string.IsNullOrWhiteSpace(txtMask.Text))
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (!Directory.Exists(txtPath.Text))
            {
                return;
            }
            else
            {
                string[] files = Directory.GetFiles(txtPath.Text);
                FileInfo fInfo;
                foreach (string item in files)
                {
                    fInfo = new FileInfo(item);
                    if (fInfo.Extension == txtMask.Text.TrimStart('*'))
                    {
                    
                        list.Add(fInfo.Name);
                    }
                }
                Form2 form2 = new Form2(list);
                form2.Show();
            }
           
        }
    }
}
