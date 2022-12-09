using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Animal_Catcher
{
    public partial class Form3 : Form
    {
        public Form3(string animal)
        {
            InitializeComponent(); 
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            label1.Text = "Brawo wygrałeś i znalazłeś swojego "+animal.ToLower()+"ka";
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            switch (animal)
            {
                case "PIES":
                    pictureBox1.Image = Properties.Resources.dog; break;
                case "KOT":
                    pictureBox1.Image= Properties.Resources.cat; break;
                case "KROKODYL":
                    var random = new Random();
                    int los = random.Next(list.Count);
                    switch (los)
                    {
                        case 0:
                            pictureBox1.Image = Properties.Resources.crocodile;
                            break;
                        case 1:
                            pictureBox1.Image = Properties.Resources.badcrocodile;
                            label1.Text = "Zostałeś przekąską krokodyla :(";
                            break;
                    }
                    break;
                case "KAPIBAR":
                    pictureBox1.Image = Properties.Resources.capibara;
                    break;  
            }

            //PIES
            //KOT
            //KROKODYL
            //KAPIBARA
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
