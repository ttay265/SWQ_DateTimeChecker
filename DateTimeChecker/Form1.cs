using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private byte CheckDate()
        {
            byte date;
            try
            {
                date = Convert.ToByte(txtDate.Text);
                if (date < 1 || date > 31)
                {
                    throw new Exception("Input data for Day is out of range!");

                }
                return date;
            }
            catch (FormatException)
            {
                throw new Exception("Input data for Day is incorrect format!");

            }

        }

        private byte CheckMonth()
        {
            byte month;
            try
            {
                month = Convert.ToByte(txtMonth.Text);
                if (month < 1 || month > 12)
                {
                    throw new Exception("Input data for Month is out of range!");

                }
                return month;
            }
            catch (FormatException)
            {
                throw new Exception("Input data for Month is incorrect format!");

            }
        }

        private short CheckYear()
        {
            short year;
            try
            {
                year = Convert.ToInt16(txtYear.Text);
                if (year < 1000 || year > 3000)
                {
                    throw new Exception("Input data for Year is out of range!");
                }
                return year;
            }
            catch (FormatException)
            {
                throw new Exception("Input data for Year is incorrect format!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte date = CheckDate();
                byte month = CheckMonth();
                short year = CheckYear();
                bool result = Checker.IsValidDate(year, month, date);
                string resultMess = txtDate.Text + "/" + txtMonth.Text + "/" + txtYear.Text;
                if (result)
                {
                    resultMess += " is correct date time!";
                }
                else
                {
                    resultMess += " is NOT correct date time!";
                }
                MessageBox.Show(resultMess, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
