using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPR_LR1
{

    public partial class Form2 : Form
    {
        Model model;


        public Form2(Model model)
        {
            InitializeComponent();

            this.model = model;

            int N = model.strategies[0].N;
            int S = model.strategies.Count;

            for (int i = 0; i < model.stages; i++)
            {
                comboBox.Items.Add($"{i}->{i + 1}");
            }
            for (int i = 0; i < S; i++)
            {
                var item = new Legend()
                {
                    ItemColor = colors[i],
                    Message = $"Стратегия №{i + 1}"
                };
                legend.Items.Add(item);
            }
            comboBox.SelectedIndex = 0;

            RecreateTableQ(N, S, model);
            RecreateTableF(N, S, model);

            legend.Invalidate();
        }
        private void RecreateTableQ(int N, int S, Model model)
        {
            gridQ.Columns.Clear();

            // столбцы
            gridQ.Columns.Add("N", "Состояния");
            gridQ.Columns.Add("S", "Стратегии");
            gridQ.Columns.Add("D", "Ожидаемые доходности");

            // строки
            gridQ.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < model.strategies.Count; j++)
                {
                    var idx = gridQ.Rows.Add();
                    gridQ.Rows[idx].Cells[0].Value = i + 1;
                    gridQ.Rows[idx].Cells[1].Value = j + 1;
                    gridQ.Rows[idx].Cells[2].Value = string.Format("{0:0.00}", model.Q[j, i]);
                }
            }
        }
        private void RecreateTableF(int N, int S, Model model)
        {
            gridF.Columns.Clear();

            // столбцы
            for (int i = 0; i <= model.stages; i++)
            {
                gridF.Columns.Add($"n{i}", $"{i}");
            }

            gridF.RowHeadersWidth = 80;
            // строки
            gridF.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                var idV = gridF.Rows.Add();
                gridF.Rows[idV].HeaderCell.Value = $"V{i + 1}(n)";
                for (int j = 0; j <= model.stages; j++)
                {
                    gridF.Rows[idV].Cells[j].Value = string.Format("{0:0.00}", model.V[i, j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                var idD = gridF.Rows.Add();
                gridF.Rows[idD].HeaderCell.Value = $"d{i + 1}(n)";
                for (int j = 0; j <= model.stages; j++)
                {
                    if (model.D[i, j] == -1)
                    {
                        gridF.Rows[idD].Cells[j].Value = "-";
                    }
                    else
                    {
                        gridF.Rows[idD].Cells[j].Value = model.D[i, j] + 1;
                    }
                }
            }
        }

        static Color[] colors = new Color[] {
            Color.Red, Color.Blue, Color.Green,
            Color.DarkOrange, Color.DarkOliveGreen, Color.DarkGoldenrod,
            Color.DarkCyan, Color.Bisque, Color.Black
        };

        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // размеры
            float offset = 16;
            float width = 400;
            float height = 48;
            float size = 40;

            // набор для рисования
            var g = e.Graphics;
            var penBlack = new Pen(Brushes.Black, 2);
            Pen pen;
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            var stage = comboBox.SelectedIndex + 1; // этап -> этап+1
            var N = model.strategies[0].N;

            // линии
            for (int i = 0; i < N; i++)
            {
                var optimal = model.D[i, stage];
                var strategy = model.strategies[optimal];

                for (int j = 0; j < N; j++)
                {
                    var p = strategy.P[i, j];

                    if (true)
                    {
                        // цвет линии согласно стратегии
                        pen = new Pen(colors[optimal % colors.Length], 2);

                        float x1 = offset + (size / 2);
                        float y1 = offset + (i + 1) * (height + size) - (size / 2);
                        float x2 = offset + width + (size / 2);
                        float y2 = offset + (j + 1) * (height + size) - (size / 2);

                        //float centerX = x1 - ((x1 - x2) / 3);
                        //float centerY = y1 - ((y1 - y2) / 3);

                        g.DrawLine(pen, x1, y1, x2, y2);

                        //g.DrawString(
                        //    $"{strategy.P[i, j]} ({strategy.R[i, j]})",
                        //    font,
                        //    Brushes.Black,
                        //    new PointF(centerX - 14, centerY - 8)
                        //    );
                    }
                }
            }

            // элементы
            for (int state = 0; state < N; state++)
            {
                // левый
                float x1 = offset;
                float y1 = offset + (state + 1) * (height + size) - size;

                // правый
                float x2 = offset + width;
                float y2 = offset + (state + 1) * (height + size) - size;

                g.FillEllipse(Brushes.White, x1, y1, size, size);
                g.DrawEllipse(penBlack, x1, y1, size, size);
                g.DrawString($"{alphabet[state]}", font, Brushes.Black,
                    x1 + (size / 2) - 8, y1 + (size / 2) - 8);

                g.FillEllipse(Brushes.White, x2, y2, size, size);
                g.DrawEllipse(penBlack, x2, y2, size, size);
                g.DrawString($"{alphabet[state]}", font, Brushes.Black,
                    x2 + (size / 2) - 8, y2 + (size / 2) - 8);
            }
        }

        private void StrNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            panel.Invalidate();
        }

        private void legend_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var item = legend.Items[e.Index] as Legend; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    legend.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * legend.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }
    }
}
