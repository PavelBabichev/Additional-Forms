using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalForms
{
    public partial class Form2 : Form
    {
        public Form2(List<string> list)
        {
            InitializeComponent();
            foreach (string item in list)
            {
                this.txtListFiles.Text += item;
                this.txtListFiles.Text += Environment.NewLine;
            }
            
        }
    }
}
