using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_LR1
{
    public partial class Form1 : Form
    {
        int statesCount;
        int strategiesCount;
        int stagesCount;

        public Form1()
        {
            InitializeComponent();

            statesCount = Convert.ToInt32(numericUpDownN.Value);
            strategiesCount = Convert.ToInt32(numericUpDownS.Value);
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);
            RecreateTable(statesCount, strategiesCount);
        }
        private void RecreateTable(int N, int S)
        {
            statesCount = N;
            strategiesCount = S;

            // столбцы (стратегии)
            grid.Columns.Clear();

            for (int i = 1; i <= S; i++)
            {
                grid.Columns.Add($"P{i}", $"P{i}");
                grid.Columns.Add($"R{i}", $"R{i}");
            }
            grid.RowHeadersWidth = 80;
            // строки (стратегии)
            grid.Rows.Clear();
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    var idx = grid.Rows.Add();
                    grid.Rows[idx].HeaderCell.Value = $"{i}->{j}";
                }
            }

            //автозаполнение нулями
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    grid.Rows[i].Cells[j].Value = "0";
                }
            }
        }

        private void buttonRecreateTable_Click(object sender, EventArgs e)
        {
            statesCount = Convert.ToInt32(numericUpDownN.Value);
            strategiesCount = Convert.ToInt32(numericUpDownS.Value);
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);

            RecreateTable(statesCount, strategiesCount);
        }

        private Model createModel()
        {
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);

            var strategies = new List<Strategy>();
            for (int str = 0; str < strategiesCount; str++)
            {
                var P = new double[statesCount, statesCount];
                var R = new double[statesCount, statesCount];
                for (int i = 0; i < statesCount; i++)
                {
                    for (int j = 0; j < statesCount; j++)
                    {
                        try
                        {
                            P[i, j] = Convert.ToDouble(grid.Rows[i * statesCount + j].Cells[str * 2].Value);
                            R[i, j] = Convert.ToDouble(grid.Rows[i * statesCount + j].Cells[str * 2 + 1].Value);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Ошибка заполнения в строке {i}->{j}, номер стратегии - {str + 1}");
                            return null;
                        }
                    }
                }

                strategies.Add(new Strategy(R, P, statesCount));
            }

            var model = new Model() { stages = stagesCount, strategies = strategies };
            model.calculate();
            return model;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count != 0)
            {
                var model = createModel();
                if (model != null)
                {
                    Form2 newForm = new Form2(model);
                    newForm.ShowDialog();
                }

            }
        }

        // открыть
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(ofd.FileName))
                {
                    var N = Convert.ToInt32(sr.ReadLine());
                    var S = Convert.ToInt32(sr.ReadLine());
                    numericUpDownN.Value = N;
                    numericUpDownS.Value = S;

                    RecreateTable(N, S);

                    List<double> numbers;
                    for (int s = 0; s < S; s++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            numbers = readNums(sr.ReadLine());
                            for (int j = 0; j < N; j++)
                            {
                                grid.Rows[i * N + j].Cells[s * 2].Value = numbers[j];
                            }
                        }

                        for (int i = 0; i < N; i++)
                        {
                            numbers = readNums(sr.ReadLine());
                            for (int j = 0; j < N; j++)
                            {
                                grid.Rows[i * N + j].Cells[s * 2 + 1].Value = numbers[j];
                            }
                        }
                    }
                }
            }
        }

        List<double> readNums(string str)
        {
            return str.Trim().Split(' ').Select((s) => Convert.ToDouble(s)).ToList();
        }

        // сохранить
        private void button2_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(statesCount);
                    sw.WriteLine(strategiesCount);
                    for (int s = 0; s < strategiesCount; s++)
                    {
                        for (int i = 0; i < statesCount; i++)
                        {
                            for (int j = 0; j < statesCount; j++)
                            {
                                sw.Write(grid.Rows[i * statesCount + j].Cells[s * 2].Value);
                                sw.Write(' ');
                            }
                            sw.Write('\n');
                        }

                        for (int i = 0; i < statesCount; i++)
                        {
                            for (int j = 0; j < statesCount; j++)
                            {
                                sw.Write(grid.Rows[i * statesCount + j].Cells[s * 2 + 1].Value);
                                sw.Write(' ');
                            }
                            sw.Write('\n');
                        }
                    }
                }
            }
        }

    }
}
