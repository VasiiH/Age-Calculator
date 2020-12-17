using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image image;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Year; // stores year
            int b = dateTimePicker1.Value.Month; // stores months
            int c = dateTimePicker1.Value.Day; // stores days 
            DateTime dob = new DateTime(a,b,c);

            int x = dateTimePicker2.Value.Year; // stores year
            int y = dateTimePicker2.Value.Month; // stores months
            int z = dateTimePicker2.Value.Day; // stores days 
            DateTime present = new DateTime(x,y,z);

            String age = (present - dob).TotalDays.ToString(); // calculating the age

            int totalDays = Convert.ToInt32(age);
            int year = totalDays / 365; // no of years
            int remainingDays = totalDays % 365;
            int months = remainingDays / 30; // no of months
            remainingDays = remainingDays % 30; // no of days

            String calAge = year + " Years " + months + " Months and " + remainingDays + " Days"; // reformate to the age





            MessageBox.Show("Name is " + textBoxName.Text + "\n" + "\n" + // displays the name
                            "Date of Birth is " + dateTimePicker1.Value.ToString() + "\n" + "\n" + // displays the date of birth
                            "Age as of " + dateTimePicker2.Value.ToString() + " is " + calAge + "\n"  // dispalys the age
                );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Photos";
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; //"jpg files (*.jpg)" + "|*.jpg|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(file.OpenFile());
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    image = pictureBox1.Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex.Message);
                }
            }

        }
    }
}
