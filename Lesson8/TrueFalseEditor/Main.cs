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
    public partial class Main : Form
    {

        TrueFalseEngine engine;

        public Main()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudNumber.Value > 0)
            {
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;

                engine.Add($"  {engine.Count + 1}.", true);
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = engine.Count;
            }
            else
            {
                MessageBox.Show("Создайте новый файл или загрузите существующий", "Самый главный", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Value == 0)
            {
                MessageBox.Show("Нечего удалять", "Самый главный", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }

            if (nudNumber.Value > 1)
            {
                engine.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1)
                {
                    nudNumber.Value--;
                }
            }
            else if (nudNumber.Value == 1)
            {
                MessageBox.Show("Нельзя удалиь первый вопрос", "Самый главный", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

            }
        }

        

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (nudNumber.Value > 0)
            {
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;

                engine.Save();
            }
            else
            {
                MessageBox.Show("Нечего сохранять", "Самый главный", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumber.Value > 0)
            {
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                if (nudNumber.Value > 0)
                {
                    labelCount.Text = $"Количество вопросов: {engine.Count}";
                }
                else
                {
                    labelCount.Text = $"Количество вопросов: 0";

                }
            }
        }

        private void cbTrue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
