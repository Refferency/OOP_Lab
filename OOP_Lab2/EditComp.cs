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

    //чекбокс с полем и спарва три кнопки (редактировать выбранное поле, вывести выбранное поле, вернуться назад)
    public partial class EditComp : Form
    {
        Computer localComp;
        string localId;

        public EditComp()
        {
            InitializeComponent();
        }

        public EditComp(string ID)
        {
            InitializeComponent();
            foreach (Computer computer in Computer.computers)
            {
                if (computer.ComputerID == ID)
                {
                    localId = ID;
                    localComp = computer;
                }
            }
        }

        private void EditComp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompAction createAct = new CompAction(localId); 
            createAct.Show();       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            if (radioButton1.Checked)
            {
                label1.Visible = true;
                label1.Text = localComp.ProcessorType;
            }

            if (radioButton2.Checked)
            {
                label2.Visible = true;
                label2.Text = Convert.ToString(localComp.ProcessorFrequency);
            }

            if (radioButton3.Checked)
            {
                label3.Visible = true;
                label3.Text = Convert.ToString(localComp.MemoryCapacity);
            }

            if (radioButton4.Checked)
            {
                label4.Visible = true;
                label4.Text = localComp.VideoCard;
            }

            if (radioButton5.Checked)
            {
                label5.Visible = true;
                label5.Text = Convert.ToString(localComp.VideoCapacity);
            }

            if (radioButton6.Checked)
            {
                label6.Visible = true;
                label6.Text = Convert.ToString(localComp.PowerUnit);
            }

            if (radioButton7.Checked)
            {
                label7.Visible = true;
                label7.Text = Convert.ToString(localComp.ComputerCost);
            }
        }


        //изменить выбранные поля
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            try
            {

                if (radioButton1.Checked)
                {
                    label1.Visible = true;
                    if (textBox1.Text != "")
                    {
                        localComp.ProcessorType = MyException.isString(textBox1.Text, "поле процессор");
                        label1.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        label1.Text = "Введите новое значение!";
                    }
                }

                if (radioButton2.Checked)
                {
                    label2.Visible = true;
                    if (textBox2.Text != "")
                    {
                        localComp.ProcessorFrequency = MyException.isDouble(textBox2.Text, "поле частота процессора");
                        label2.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        label2.Text = "Введите новое значение!";
                    }
                }

                if (radioButton3.Checked)
                {
                    label3.Visible = true;
                    if (textBox3.Text != "")
                    {
                        localComp.MemoryCapacity = MyException.isInteger(textBox3.Text, "поле объем ОЗУ");
                        
                        label3.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        
                        label3.Text = "Введите новое значение!";
                    }
                }

                if (radioButton4.Checked)
                {
                    label4.Visible = true;
                    if (textBox4.Text != "")
                    {
                        localComp.VideoCard = MyException.isString(textBox4.Text, "поле тип видеокарты");
                        
                        label4.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        
                        label4.Text = "Введите новое значение!";
                    }
                }

                if (radioButton5.Checked)
                {
                    label5.Visible = true;
                    if (textBox5.Text != "")
                    {
                        localComp.VideoCapacity = MyException.isInteger(textBox5.Text, "поле объем видеопамяти");
                        label5.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        label5.Text = "Введите новое значение!";
                    }
                }

                if (radioButton6.Checked)
                {
                    label6.Visible = true;
                    if (textBox6.Text != "")
                    {
                        localComp.PowerUnit = MyException.isInteger(textBox6.Text, "поле мощность БП");
                        label6.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        label6.Text = "Введите новое значение!";
                    }
                }

                if (radioButton7.Checked)
                {
                    label7.Visible = true;
                    if (textBox7.Text != "")
                    {
                        localComp.ComputerCost = MyException.isInteger(textBox7.Text, "поле цена");
                        label7.Text = "Поле успешно изменено";
                    }
                    else
                    {
                        label7.Text = "Введите новое значение!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
        }
    }
}
