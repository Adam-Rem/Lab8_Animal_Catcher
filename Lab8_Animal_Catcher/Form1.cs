using System.Security.Cryptography.X509Certificates;

namespace Lab8_Animal_Catcher
{
    public partial class Form1 : Form
    {
        public string animal;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            animal = typ.SelectedItem.ToString();
            int gridSize = Int32.Parse(rozmiar.Text.ToString().Substring(0,1));
            Form2 form2= new Form2(gridSize,animal);
            form2.ShowDialog();
            form2 = null;            
        }

        private void rozmiar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }    
    }
}