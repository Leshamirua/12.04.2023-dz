using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_homework
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            comboBox1.Items.Add("AMD Ryzen 5 5600X");
            comboBox1.Items.Add("INTEL Core i5-12600K");
            comboBox1.Items.Add("AMD Ryzen 5 5600");
            comboBox1.Items.Add("AMD Ryzen 9 5900X");
            comboBox1.Items.Add("INTEL Core i7-12700K");
        }

        public double TotalSum = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            object obj = comboBox1.SelectedItem;
            string str = obj as string;
            switch (str) {
                case "AMD Ryzen 5 5600X":
                    textBox1.Text = "184,00";
                    break;

                case "INTEL Core i5-12600K":
                    textBox1.Text = "274,00";
                    break;

                case "AMD Ryzen 5 5600":
                    textBox1.Text = "150,00";
                    break;

                case "AMD Ryzen 9 5900X":
                    textBox1.Text = "361,00";
                    break;

                case "INTEL Core i7-12700K":
                    textBox1.Text = "358,00";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            TotalSum += Convert.ToDouble(textBox1.Text);
            textBox2.Text = TotalSum.ToString();

            listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
