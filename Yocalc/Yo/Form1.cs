using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AgoraVai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int num;
        public string lastAction = null;
        public bool hadAction = false;

        private void txtResult_Click(object sender, EventArgs e)
        {

        }

        void Check_igual()
        {

            SoundPlayer hiii = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\hiii.wav");
            hiii.Play();
            if (lastAction == "Igual")
            {
                txtResult.Text = "";
                lastAction = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Check_igual();
            txtResult.Text += "0";
        }

        int Checkaction(int x)
        {
            if (lastAction == "Soma")
            {
                return num + x;
            }
            else if (lastAction == "Subt")
            {
                return num - x;
            }
            else if (lastAction == "Mult")
            {
                return num * x;
            }
            else if (lastAction == "Div")
            {
                if (x != 0)
                {
                    return num / x;
                }
                else
                {
                    SoundPlayer lag = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\lag.wav");
                    lag.Play();
                    MessageBox.Show("Erro: Divisão por 0");
                    return num;
                }
            }
            return num;
        }

        public void Padrao_botao()
        {
            if (txtResult.Text.Length != 0)
            {
                if (hadAction == false)
                {
                    num += int.Parse(txtResult.Text);
                    txtResult.Text = "";
                }
                else
                {
                    num = Checkaction(int.Parse(txtResult.Text));
                    txtResult.Text = "";
                }
                hadAction = true;
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            SoundPlayer solado = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\solado.wav");
            solado.Play();
            if (txtResult.Text.Length != 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
        }

        private void buttonSom_Click(object sender, EventArgs e)
        {
            SoundPlayer vamo = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\vamo.wav");
            vamo.Play();
            Padrao_botao();
            lastAction = "Soma";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            SoundPlayer feed = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\feed.wav");
            feed.Play();
            Padrao_botao();
            lastAction = "Subt";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            SoundPlayer fon = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\fon.wav");
            fon.Play();
            Padrao_botao();
            lastAction = "Mult";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            SoundPlayer circo = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\circo.wav");
            circo.Play();
            Padrao_botao();
            lastAction = "Div";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            SoundPlayer eoq = new SoundPlayer(@"C:\Users\Gabriel\source\repos\Yo\Yo\Resources\eoq.wav");
            eoq.Play();
            if (txtResult.Text.Length != 0)
            {
                num = Checkaction(int.Parse(txtResult.Text));
                txtResult.Text = num.ToString();
                num = 0;
                lastAction = "Igual";
                hadAction = false;
            }
        }
    }
}
