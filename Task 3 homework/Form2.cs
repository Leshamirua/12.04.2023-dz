using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_3_homework
{
    public partial class Form2 : Form
    {
        public Form1 MainForm { get; set; }

        public Form2() {
            InitializeComponent();
        }
        
        public string Dialog {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void save_Click(object sender, EventArgs e) {
            MainForm.Value = Dialog;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e) {
            Close();
        }


    }
}
