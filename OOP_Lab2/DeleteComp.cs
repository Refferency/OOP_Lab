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
    public partial class DeleteComp : Form
    {
        public DeleteComp()
        {
            InitializeComponent();
        }

        private void DeleteComp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //регулярка
            bool isId = false;
            
            foreach (Computer computer in Computer.computers)
            {

                if (computer.ComputerID == textBox1.Text)
                {
                    label2.Visible = true;
                    label2.Text = $"Успешно удален компьютер с ID:{textBox1.Text}";
                    Computer.computers.Remove(computer);
                    isId = true;
                    break;
                }                
            }

            if (!isId)
            {
                label2.Visible = true;
                label2.Text = "Компьютер с данным ID не найден";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerUI ui = new ComputerUI();
            ui.Show();
        }
    }
}
