using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_homework
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        public string Value {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void load_Click(object sender, EventArgs e) {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\Users\\danya\\OneDrive\\Рабочий стол";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = openFileDialog1.FileName;
                edit.Enabled = true;
            }
        }

        private void edit_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.MainForm = this;
            form2.Dialog = Value;
            form2.Show();
        }


    }
}
