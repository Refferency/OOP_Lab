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
            //createComputerScene(false);
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
        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        label2.Text = "У вас есть 4 варианта добавления компьютера";
        //        label3.Visible = false;
        //        button1.Visible = false;
        //        button2.Visible = false;

        //        //функция создания компьютера
        //        createComputerScene(true);
        //    }

        //    private void button2_Click(object sender, EventArgs e)
        //    {
        //        Close();
        //    }

        //    //компьютер с процессором
        //    private void button5_Click(object sender, EventArgs e)
        //    {
        //        Computer computer = new Computer();
        //        computers.Add(computer);
        //    }

        //    //укомплектованный компьютер
        //    private void button6_Click(object sender, EventArgs e)
        //    {
        //        Computer computer = new Computer();
        //        computers.Add(computer);
        //    }

        //    //пустой компьютер с ценой
        //    private void button4_Click(object sender, EventArgs e)
        //    {
        //        createComputerScene(false);

        //        label2.Text = "Чтобы создать такой компьютер необходимо указать его цену";
        //        label4.Visible = true;
        //        textBox1.Visible = true;






        //    }
        //    //пустой компьютер
        //    private void button3_Click(object sender, EventArgs e)
        //    {
        //        Computer computer = new Computer();
        //        computers.Add(computer);

        //        createComputerScene(false);
        //        label2.Text = $"Добавлен пустой компьютер c ID:{computer.ComputerID}";
        //        button7.Visible = true;

        //    }


        //    //методы - переключатели сцен
        //    private void createComputerScene(bool onOff)
        //    {
        //        if (!onOff)
        //        {
        //            button3.Visible = false;
        //            button4.Visible = false;
        //            button5.Visible = false;
        //            button6.Visible = false;
        //        }
        //        else
        //        {
        //            button3.Visible = true;
        //            button4.Visible = true;
        //            button5.Visible = true;
        //            button6.Visible = true;
        //        }
        //    }
        //    private void button7_Click(object sender, EventArgs e)
        //    {
        //        button7.Visible = false;
        //        computerAction();
        //    }
        //    private void button7_Click(object sender, EventArgs e, String where)
        //    {
        //        if(where == "1") //computerAction - действия с компьютером
        //        {

        //        }
        //        else if(where == "2") //создать комп с ценой
        //        {

        //        }
        //        button7.Visible = false;
        //        computerAction();
        //    }

        //    private void computerAction()
        //    {
        //        label2.Text = "nuda";
        //    }

        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {
        //        String computerPrice = textBox1.Text;
        //        Computer computer = new Computer(Convert.ToInt32(computerPrice));
        //        computers.Add(computer);
        //        label2.Text = $"Добавлен пустой компьютер c ID:{computer.ComputerID} и " +
        //            $"ценой {computer.ComputerCost}";
        //    }

        //    private void button1_Click_1(object sender, EventArgs e)
        //    {

        //    }
    }

    ////чекнуть messagebox
}
