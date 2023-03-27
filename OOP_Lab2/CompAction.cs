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
    public partial class CompAction : Form
    {
        public CompAction()
        {
            InitializeComponent();
        }

        public CompAction(string id)
        {
            InitializeComponent();
            textBox1.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isFindID = false;
            foreach (Computer computer in Computer.computers)
            {
                if (computer.ComputerID == textBox1.Text)
                {
                    isFindID = true;
                }


                if (!isFindID)
                {
                    label2.Visible = true;
                    label2.Text = "Компьютер по такому ID не найден";
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = computer.ToString();
                }

            }

            if (!isFindID)
            {
                label2.Visible = true;
                label2.Text = "Компьютер по такому ID не найден";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isFindID = false;
            foreach (Computer computer in Computer.computers)
            {
                if (computer.ComputerID == textBox1.Text)
                {
                    isFindID = true;
                }


                if (!isFindID)
                {
                    label2.Visible = true;
                    label2.Text = "Компьютер по такому ID не найден";
                }
                else
                {
                    this.Hide();
                    EditComp ec = new EditComp(textBox1.Text);
                    ec.Show();
                }
            }

            if (!isFindID)
            {
                label2.Visible = true;
                label2.Text = "Компьютер по такому ID не найден";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isFindID = false;
            foreach (Computer computer in Computer.computers)
            {
                if (computer.ComputerID == textBox1.Text)
                {
                    isFindID = true;
                }


                if (!isFindID)
                {
                    label2.Visible = true;
                    label2.Text = "Компьютер по такому ID не найден";
                }
                else
                {
                    string localId = computer.ComputerID;
                    label2.Visible = true;
                    computer.idConvertor();
                    label2.Text = $"ID компьютера {localId} преобразовано в ID:{computer.ComputerID}";
                }
            }

            if (!isFindID)
            {
                label2.Visible = true;
                label2.Text = "Компьютер по такому ID не найден";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerUI ui = new ComputerUI();
            ui.Show();
        }

        private void CompAction_Load(object sender, EventArgs e)
        {

        }
    }
}
