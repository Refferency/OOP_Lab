using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Lab2
{
    public partial class CreateCompMore : Form
    {
        private string status = "";

        public CreateCompMore()
        {
            InitializeComponent();
           
        }

        public CreateCompMore(string param)
        {
            status = param;
            InitializeComponent();
            if (status == "price")
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
            else if (status == "processor")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
            }
            else if (status == "fullComp")
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Computer computer = null;
            switch (status)
            {
                case "price": //пустой с ценой
                    int computerCost = Convert.ToInt32(textBox3.Text);
                    computer = new Computer(computerCost);           
                    break;

                case "processor": //с процессором
                    String processorType = textBox1.Text;
                    double processorFrequency = Convert.ToDouble(textBox2.Text);
                    computer = new Computer(processorType, processorFrequency);    
                    break;

                case "fullComp": //полный
                    String processorType2 = textBox1.Text;
                    double processorFrequency2 = Convert.ToDouble(textBox2.Text);
                    int computerCost2 = Convert.ToInt32(textBox3.Text);
                    int memoryCapacity = Convert.ToInt32(textBox4.Text);
                    String videoCard = textBox5.Text;
                    int videoCapacity = Convert.ToInt32(textBox6.Text);
                    int powerUnit = Convert.ToInt32(textBox7.Text);
                    computer = new Computer(processorType2, processorFrequency2, memoryCapacity, computerCost2,
                        videoCard, videoCapacity, powerUnit);
                    break;
                default:
                    break;
            }
            Computer.computers.Add(computer);

            label8.Visible = true;
            label8.Text = $"Компьютер с ID:{computer.ComputerID} успешно добавлен в базу";
        }

        private void CreateCompMore_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerUI ui = new ComputerUI();
            ui.Show();
        }


        //если юзер вводит например вместо double string, объеем видеопамяти -ифыам фафы, можно подключить свой самописный exception
        //который будет очищать текстбокс и выводить юзеру сообщение о том, что он еблойд тупой, и объем видео не может быть ываиываы
    }
}
