using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form2 : Form
    {
        private static Random random = new Random();
        int userNumber;
        double count;

        int compNumb;
        public Form2()
        {
            InitializeComponent();
            GameState();
        }

        private void GameState()
        {
             compNumb = random.Next(101);
            userNumber = 0;
            usNumb.Text = userNumber.ToString();
            textBox1.Text = "0";
            count = 0;
            labelCount2.Text = $"Количество попыток {count}";

        }


        private void buttonEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы печально завершили игру!", "КОМПЬЮТЕР", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            Close();

        }

        

        private void Ok1_Click(object sender, EventArgs e)
        {

            bool w = false;
            w = int.TryParse(textBox1.Text, out userNumber);

            if (w == false)
            {
                userNumber = 0;

            }


            if (userNumber == compNumb)
            {
                count = count + 1;
                labelCount2.Text = $"Количество попыток {count}";

                if (MessageBox.Show("Вы угадали! Желаете сыграть еще раз?", "Компьютер", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GameState();

                }
                else
                {
                    Close();
                }

            }

            

            if (userNumber < compNumb)
            {
                labelinf.Text = "Загаданное число больше";
                usNumb.Text = userNumber.ToString();

            }

            if (userNumber > compNumb)
            {
                labelinf.Text = "Загаданное число меньше";
                usNumb.Text = userNumber.ToString();


            }
            count = count + 0.5;
            labelCount2.Text = $"Количество попыток {count}";

        }


    }
}
