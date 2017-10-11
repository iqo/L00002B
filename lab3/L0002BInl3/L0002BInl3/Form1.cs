using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L0002BInl3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonCalculator person = new PersonCalculator(textBox1.Text,textBox2.Text, textBox3.Text);

            if (person.CalculateSocialSecurityNumber())
            {
                groupBox1.Text = "OK";
                label5.Text = "First name: " + person.GetFirstName() + "\n" + "Surname: " + person.GetSurName() + "\n" + "Social security number: " + person.GetSocialSecurityNumber() + "\n" + "Sex: " + person.GetSex();
            }
            else {
                groupBox1.Text = "Failure";
                label5.Text = "Invalid Social security number: " + "\n" + person.GetSocialSecurityNumber();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
            groupBox1.Text = "Pending";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
