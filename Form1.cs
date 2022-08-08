using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fahrenheight_Click(object sender, EventArgs e)
        {
            convertFromFahrenheight();
        }

        private void convertFromFahrenheight()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_fahrenheight.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float c = 5f / 9 * (f - 32);
            float k = c + 273;

            txt_celcius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();

        }

        private void btn_celcius_Click(object sender, EventArgs e)
        {
            convertFromCelcius();
        }

        private void convertFromCelcius()
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celcius.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float f = (9 / 5 * c) + 32;
            float k = (5 / 9 * (f - 32)) + 273;

            txt_kelvin.Text = k.ToString();
            txt_fahrenheight.Text = f.ToString();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromKelvin()
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float c = k - 273;
            float f = (9 / 5 * (k - 273)) + 32;

            txt_celcius.Text = c.ToString();
            txt_fahrenheight.Text = f.ToString();
        }

    }
}
