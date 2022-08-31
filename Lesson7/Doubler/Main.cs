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
    public partial class Main : Form
    {

        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        //private int count = 0;
        Stack<int> step = new Stack<int>();
        public Main()
        {
            InitializeComponent();

            UpdateGameState(userNumber, random.Next(20));
        }

        private void UpdateGameState(int userNumber)
        {
            labelUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
           
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //userNumber = 0;
            UpdateGameState(userNumber *= 0, random.Next(20));
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber * 2;
            UpdateGameState(userNumber *= 2);
            CheckWin();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber + 1;
            UpdateGameState(++userNumber);
            CheckWin();
        }

        int count = 0;

        private void CheckWin()
        {
            step.Push(userNumber);
            count++;
            labelCount.Text = $"Колличество попыток {count}";
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Удвоитель", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if(MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateGameState(userNumber *= 0, random.Next(20));
                }
                else
                {
                    Close();
                }
            }
            else if (userNumber > computerNumber)
            {
                //TODO: ...
            }


           

        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            int a = step.Pop();
            userNumber = step.Peek();
            UpdateGameState( userNumber);
        }
    }
}
