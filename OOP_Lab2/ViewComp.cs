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
    public partial class ViewComp : Form
    {
        public ViewComp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerUI ui = new ComputerUI();
            ui.Show();
        }

        private void ViewComp_Load(object sender, EventArgs e)
        {
            String comp_str = "Пока что не добавлено ни одного компьютера";
            bool isComp = false;


            if(Computer.computers.Count != 0)
            {
                comp_str = " | ";
            }

            foreach (Computer computer in Computer.computers)
            {
                
                comp_str += computer.ComputerID + " | ";
            }
            
            label2.Text = comp_str;
        }
    }
}
