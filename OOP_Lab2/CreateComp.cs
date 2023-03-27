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
    public partial class CreateComp : Form
    {
        public CreateComp()
        {
            InitializeComponent();
        }

        private void CreateComp_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Успешно добавлен пустой компьютер с ID:";
            Computer computer = new Computer();
            Computer.computers.Add(computer);
            label1.Visible = true;
            label1.Text += computer.ComputerID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();


            CreateCompMore ccm = new CreateCompMore("price");



            ccm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCompMore ccm = new CreateCompMore("processor");
            ccm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCompMore ccm = new CreateCompMore("fullComp");
            ccm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerUI ui = new ComputerUI();
            ui.Show();
        }
    }
}
