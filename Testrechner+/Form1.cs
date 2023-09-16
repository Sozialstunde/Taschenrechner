using System;
using System.Drawing;
using System.Windows.Forms;

namespace Testrechner_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb( 63, 63, 63 );
            //this.Size = new Size( 320, 480 );
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Rechner";
            this.Icon = new Icon("taschenrechner.ico");
            this.BackColor = Color.FromArgb( 63, 63, 63 );
            this.ForeColor = Color.FromArgb( 255, 255, 255, 255 );
            this.ShowIcon = true;

            //this.Font = new Font("Arial", 20);
            //this.Location = new Point( 0, 0 );
            button1.BackColor = Color.FromArgb( 63, 63, 63 );
            button2.BackColor = Color.FromArgb( 63, 63, 63 );
            button3.BackColor = Color.FromArgb( 63, 63, 63 );
            button4.BackColor = Color.FromArgb( 63, 63, 63 );
            button5.BackColor = Color.FromArgb( 63, 63, 63 );
            button6.BackColor = Color.FromArgb( 63, 63, 63 );
            button7.BackColor = Color.FromArgb( 63, 63, 63 );
            button8.BackColor = Color.FromArgb( 63, 63, 63 );
            button9.BackColor = Color.FromArgb( 63, 63, 63 );
            button10.BackColor = Color.FromArgb( 63, 63, 63 );
            button11.BackColor = Color.FromArgb( 63, 63, 63 );
            button12.BackColor = Color.FromArgb( 63, 63, 63 );
            button13.BackColor = Color.FromArgb( 63, 63, 63 );
            button14.BackColor = Color.FromArgb( 63, 63, 63 );
            button15.BackColor = Color.FromArgb( 63, 63, 63 );

            textBox1.Text = "";
            textBox1.BackColor = Color.FromArgb( 63, 63, 63 );
            textBox1.ForeColor = Color.FromArgb( 255, 255, 255, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 20);
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.Location = new Point(10, 10);
            textBox1.Size = new Size(300, 50);
           
            textBox1.Multiline = true;
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
            textBox1.TabStop = false;
            textBox1.Text = "";

            BackColor = Color.FromArgb(63, 63, 63);
            base.Text = "Rechner";
            button1.Text = "1";
            //button1.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = "+";
            button11.Font = new Font("Arial", 13);
            button12.Text = "-";
            button12.Font = new Font("Arial", 13);
            button13.Text = "*";
            button13.Font = new Font("Arial", 13);
            button14.Text = "/";
            button14.Font = new Font("Arial", 13);
            button15.Text = "=";
            button15.Font = new Font("Arial", 13);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int one = 1;
            textBox1.Text = textBox1.Text + one;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int zero = 0;
            textBox1.Text = textBox1.Text + zero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int two = 2;
            textBox1.Text = textBox1.Text + two;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int three = 3;
            textBox1.Text = textBox1.Text + three;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int four = 4;
            textBox1.Text = textBox1.Text + four;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int five = 5;
            textBox1.Text = textBox1.Text + five;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int six = 6;
            textBox1.Text = textBox1.Text + six;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int seven = 7;
            textBox1.Text = textBox1.Text + seven;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int eight = 8;
            textBox1.Text = textBox1.Text + eight;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int nine = 9;
            textBox1.Text = textBox1.Text + nine;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            /*
             * + Button
             */
            bool gedrückt = false;
            int zahl1 = 0;
            int zahl2 = 0;
            if (! gedrückt)
            {
                try
                {
                    zahl1 = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    return;
                    throw;
                }
            }
            else
            {
                try
                {
                    zahl2 = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    return;
                    throw;
                }
                textBox1.Text = "";
                //ergebnissss = zahl1 * zahl2;
                textBox1.Text = $"{zahl1 + zahl2}";
                textBox1.Text = Convert.ToString(zahl1 + zahl2);
            }
        }

        public void button15_Click(object sender, EventArgs e)
        {
            int ergebniss;
            try
            {
                ergebniss = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                return;
                throw;
            }
            textBox1.Text = "";
        }

    }
}
