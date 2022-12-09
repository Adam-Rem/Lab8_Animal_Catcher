using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Animal_Catcher
{
    public partial class Form2 : Form
    {
        List<Button> buttons = new List<Button>();
        public Form2(int gridSize,string animal)
        {
            InitializeComponent();
            
            var rowCount = gridSize;
            var columnCount = gridSize;

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {

                    var button = new Button();
                    //button.Text = string.Format("{0}{1}", i, j);
                    button.Name = string.Format("button_{0}{1}", i, j);
                    button.Enabled= false;
                    buttons.Add(button);
                    button.Dock = DockStyle.Fill;
                    button.Click += (sender, e) => button.Visible=false;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
            //system wyboru przypadkowego przycisku i jego zwycięstwa

            var random = new Random(); 
            int winning_index = random.Next(buttons.Count);
            buttons[winning_index].Click += (sender, e) => {
                timer1.Stop(); Form form3= new Form3(animal);
                form3.ShowDialog();
                form3= null;
                Close();
            };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label1.Text = counter.ToString();
            if (counter == 0) { timer1.Stop();
                MessageBox.Show("Przegrałeś --> Koniec czasu", "GAMEOVER", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }            
        }//działanie na tick timera
        private int counter = 300;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var button in buttons)
            {
                button.Enabled=true;
            }
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 001;
            timer1.Tick+= new System.EventHandler(timer1_Tick);
            timer1.Start();
            label1.Text=counter.ToString();

        }//start klik

        
    }
}
