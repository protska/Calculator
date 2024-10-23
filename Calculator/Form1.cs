using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2_Resize(sender, e); // расположение кнопок
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            button1.Height = panel2.Height / 5;
            button2.Height = panel2.Height / 5;
            button3.Height = panel2.Height / 5;
            button4.Height = panel2.Height / 5;
            button5.Height = panel2.Height / 5;
            button7.Height = panel2.Height / 5;
            button8.Height = panel2.Height / 5;
            button9.Height = panel2.Height / 5;
            button10.Height = panel2.Height / 5;
            button11.Height = panel2.Height / 5;
            button13.Height = panel2.Height / 5;
            button14.Height = panel2.Height / 5;
            button15.Height = panel2.Height / 5;
            button16.Height = panel2.Height / 5;
            button17.Height = panel2.Height / 5;
            button19.Height = panel2.Height / 5;
            button20.Height = panel2.Height / 5;
            button22.Height = panel2.Height / 5;
            button23.Height = panel2.Height / 5;
            button24.Height = panel2.Height / 5;
            button25.Height = panel2.Height / 5;
            button26.Height = panel2.Height / 5;
            button27.Height = panel2.Height / 5;
            button28.Height = panel2.Height / 5;
            button30.Height = panel2.Height / 5;

            button1.Width = panel2.Width / 5;
            button2.Width = panel2.Width / 5;
            button3.Width = panel2.Width / 5;
            button4.Width = panel2.Width / 5;
            button5.Width = panel2.Width / 5;
            button7.Width = panel2.Width / 5;
            button8.Width = panel2.Width / 5;
            button9.Width = panel2.Width / 5;
            button10.Width = panel2.Width / 5;
            button11.Width = panel2.Width / 5;
            button13.Width = panel2.Width / 5;
            button14.Width = panel2.Width / 5;
            button15.Width = panel2.Width / 5;
            button16.Width = panel2.Width / 5;
            button17.Width = panel2.Width / 5;
            button19.Width = panel2.Width / 5;
            button20.Width = panel2.Width / 5;
            button22.Width = panel2.Width / 5;
            button23.Width = panel2.Width / 5;
            button24.Width = panel2.Width / 5;
            button25.Width = panel2.Width / 5;
            button26.Width = panel2.Width / 5;
            button27.Width = panel2.Width / 5;
            button28.Width = panel2.Width / 5;
            button30.Width = panel2.Width / 5;

            button1.Top = 0;
            button2.Top = 0;
            button3.Top = 0;
            button4.Top = 0;
            button5.Top = 0;

            button7.Top = panel2.Height / 5;
            button8.Top = panel2.Height / 5;
            button9.Top = panel2.Height / 5;
            button10.Top = panel2.Height / 5;
            button11.Top = panel2.Height / 5;

            button13.Top = panel2.Height * 2 / 5;
            button14.Top = panel2.Height * 2 / 5;
            button15.Top = panel2.Height * 2 / 5;
            button16.Top = panel2.Height * 2 / 5;
            button17.Top = panel2.Height * 2 / 5;

            button19.Top = panel2.Height * 3 / 5;
            button20.Top = panel2.Height * 3 / 5;
            button22.Top = panel2.Height * 3 / 5;
            button23.Top = panel2.Height * 3 / 5;
            button24.Top = panel2.Height * 3 / 5;

            button25.Top = panel2.Height * 4 / 5;
            button26.Top = panel2.Height * 4 / 5;
            button27.Top = panel2.Height * 4 / 5;
            button28.Top = panel2.Height * 4 / 5;
            button30.Top = panel2.Height * 4 / 5;

            button1.Left = 0;
            button7.Left = 0;
            button13.Left = 0;
            button19.Left = 0;
            button25.Left = 0;

            button2.Left = panel2.Width / 5;
            button8.Left = panel2.Width / 5;
            button14.Left = panel2.Width / 5;
            button20.Left = panel2.Width / 5;
            button26.Left = panel2.Width / 5;

            button3.Left = panel2.Width * 2 / 5;
            button9.Left = panel2.Width * 2 / 5;
            button15.Left = panel2.Width * 2 / 5;
            button22.Left = panel2.Width * 2 / 5;
            button27.Left = panel2.Width * 2 / 5;

            button4.Left = panel2.Width * 3 / 5;
            button10.Left = panel2.Width * 3 / 5;
            button16.Left = panel2.Width * 3 / 5;
            button23.Left = panel2.Width * 3 / 5;
            button28.Left = panel2.Width * 3 / 5;

            button5.Left = panel2.Width * 4 / 5;
            button11.Left = panel2.Width * 4 / 5;
            button17.Left = panel2.Width * 4 / 5;
            button24.Left = panel2.Width * 4 / 5;
            button30.Left = panel2.Width * 4 / 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text == ",") // ограничение для запятой
            {
                return;
            }
            textBox1.Text = textBox1.Text + b.Text;

        }

        private void button28_Click(object sender, EventArgs e) // очистка
        {
            textBox1.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)textBox1.Text);
        }

        String action;
        String number1;

        private void panel2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "")
                {
                    textBox1.Text = "-";
                }
                else
                {
                    System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender; // объект, вызвавший событие
                    action = b.Text;
                    number1 = textBox1.Text;
                    textBox1.Text = "";
                }
            }
            catch { textBox1.Text = "ошибка"; }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (action == "^") // ряд возведения в степень
                {
                    int m = 1; // член суммы, степень числа
                    int sum = 0;
                    for (int pow = 1; pow <= Convert.ToDouble(textBox1.Text); pow += 1)
                    {
                        m *= (Convert.ToInt32(number1));
                        sum += m;
                    }
                    textBox1.Text = sum.ToString();
                }
                action = "";
            }
            catch { textBox1.Text = "Ошибка! Введите целое положительноеы число"; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button25_Click(object sender, EventArgs e) // кубический корень
        {
            if (Convert.ToDouble(textBox1.Text) < 0)
            {
                textBox1.Text = "-" + (Math.Pow(Convert.ToDouble(textBox1.Text.Trim(new char[] { '-' })), 1.0 / 3.0)).ToString(); // обрезка строки
            }
            else { textBox1.Text = (Math.Pow(Convert.ToDouble(textBox1.Text), 1.0 / 3.0)).ToString(); ; }
        }


        /*        private void button1_Click(object sender, EventArgs e) // объект, вызвавший событие; аргумент с-я
                {
                    textBox1.Text = (Math.Asin(Convert.ToDouble(textBox1.Text))).ToString();
                }*/



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Asin(Convert.ToDouble(textBox1.Text)).ToString();
        }



        /*        private void button2_Click(object sender, EventArgs e)
                {
                    textBox1.Text = (Math.Sin(Convert.ToDouble(textBox1.Text))).ToString();
                }*/



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Sin(Convert.ToDouble(textBox1.Text)).ToString();
        }


        /*        private void button7_Click(object sender, EventArgs e)
                {
                    textBox1.Text = (Math.Acos(Convert.ToDouble(textBox1.Text))).ToString();
                }*/


        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Acos(Convert.ToDouble(textBox1.Text)).ToString();
        }


        /*        private void button8_Click(object sender, EventArgs e)
                {
                    textBox1.Text = (Math.Cos(Convert.ToDouble(textBox1.Text))).ToString();
                }*/


        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Cos(Convert.ToDouble(textBox1.Text)).ToString();
        }


        /*        private void button13_Click(object sender, EventArgs e)
                {
                    textBox1.Text = (Math.Atan(Convert.ToDouble(textBox1.Text))).ToString();
                }*/

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Atan(Convert.ToDouble(textBox1.Text)).ToString();
        }

        /*        private void button14_Click(object sender, EventArgs e)
                {
                    textBox1.Text = (Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();
                }*/



        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Tan(Convert.ToDouble(textBox1.Text)).ToString();
        }


        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // событие обработано
            }

            // только одна запятая
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        Calculator calc = new Calculator();



    }

    public interface ICalculator
    {
        double Tan(double i);
        double Atan(double i);
        double Cos(double i);
        double Acos(double i);
        double Sin(double i);
        double Asin(double i);
    }


    public class Calculator : ICalculator
    { 
        public double Tan(double i)
        {
            return Math.Tan(i);
        }

        public double Atan(double i)
        {
            return Math.Atan(i);
        }

        public double Cos(double i)
        {
            return Math.Cos(i);
        }

        public double Acos(double i)
        {
            return Math.Acos(i);
        }

        public double Sin(double i)
        {
            return Math.Sin(i);
        }

        public double Asin(double i)
        {
            return Math.Asin(i);
        }
    }
}
