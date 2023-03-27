using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class ComputerUI : Form
    {
        public ComputerUI()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewComp viewComp = new ViewComp();
            viewComp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateComp createComp = new CreateComp();
            createComp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompAction createAct = new CompAction();
            createAct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteComp dc = new DeleteComp();
            dc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                throw new StackOverflowException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //unsafe static void Boom()
        //{
        //    int* data = stackalloc int[512 * 1024]; // 2MB
            
        //}
    }
}
