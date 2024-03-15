using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Zgrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private class Neboder
        {
            public int visina, brojKatova;

            public void setVisina(int visina)
            {
                this.visina = visina;
            }
            public int getVisina()
            {
                return this.visina;
            }
            public void setBrojKatova(int brojKatova)
            {
                this.brojKatova = brojKatova;
            }
            public int getBrojKatova()
            {
                return this.brojKatova;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { 

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            Neboder neboder = new Neboder();
            int brojKatova;
            int visina = 0;
            try
            {
                brojKatova = Convert.ToInt32(unosBrojaKatova.Text);
                neboder.setVisina(visina);
                neboder.setBrojKatova(brojKatova);
                if (brojKatova <= 0)
                {
                    MessageBox.Show("Broj katova ne može iznositi 0 " +
                        "ili biti negativan broj!", "KRIVI UNOS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    visina = brojKatova * 3;
                    ispisVisine.Text = visina.ToString();
                }
            }

            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
