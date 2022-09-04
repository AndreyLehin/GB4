using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Game : Form
    {
        TrueFalseEngine qw;
        private Random randomQw = new Random();
        private Random random1 = new Random();
        private int count = 0;
        private int [] arr1= new int[5];
        private int n;
        
        public Game()
        {

            InitializeComponent();
            

            
        }

        private void Ran()
        {
            int t = 1;
            arr1[0] = randomQw.Next(10);
            if (arr1[0] == 1 || arr1[0] == 0)
            {
                arr1[0] = 0;
                arr1[1] = 1;
                t = 2;
            }


            for (int i = t; i < 5; i++)
            {
                
                int r = randomQw.Next(10);
                for (int j = 0; j < i; j++)
                {
                    if (arr1[j] == r)
                    {
                        r = randomQw.Next(10);
                        j = 0;
                    }
                }
                arr1[i] = r;
                if (arr1[i] == 1 || arr1[i] == 0)
                {
                    arr1[i-1] = 0;
                    arr1[i] = 1;
                    
                }


            }
            n = -1;
            count = 0;

            



        }

        private void Show()
        {
            n = n + 1;
            
            labelQ1.Text = qw[arr1[n]].Text;
        }


        private void toolStripQw_Click(object sender, EventArgs e)
        {
            Main newMain = new Main();
            newMain.Show();
        }

        private void toolStripGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                qw = new TrueFalseEngine(dlg.FileName);
                qw.Load();
                
            }
            Ran();
            Show();
        }

        private void toolStripEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void True_Click(object sender, EventArgs e)
        {
            if (qw != null)
            {
                if (qw[arr1[n]].TrueFalse == true)
                {
                    count++;
                }

                if (arr1[n] == 9 & count == 1)
                {
                    count--;
                }
                if (n == 4)
                {
                    if (MessageBox.Show($"Все! Вы набрали {count} из 5.\n" +
                        $"Желаете сыграть еще раз?", "Игра", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Ran();

                    }
                    else
                    {
                        n--;
                        Close();
                    }
                }
                Show();
            }
            else
            {
                labelQ1.Text = "Нажмите сначала: НОВАЯ ИГРА";
            }
        }

        private void False_Click(object sender, EventArgs e)
        {
            if (qw != null)
            {

                if (qw[arr1[n]].TrueFalse == false)
                {
                    count++;
                }

                if (arr1[n] == 9 & count == 0)
                {
                    count++;
                }
                if (n == 4)
                {
                    if (MessageBox.Show($"Все! Вы набрали {count} из 5.\n" +
                        $"Желаете сыграть еще раз?", "Игра", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Ran();
                    }
                    else
                    {
                        n--;
                        Close();
                    }
                }
                Show();
            }
            else
            {
                labelQ1.Text = "Нажмите сначала: НОВАЯ ИГРА";
            }
        }
    }
}
