
namespace TPR_LR1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridQ = new System.Windows.Forms.DataGridView();
            gridF = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            panel = new System.Windows.Forms.Panel();
            comboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            legend = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)gridQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridF).BeginInit();
            SuspendLayout();
            // 
            // gridQ
            // 
            gridQ.AllowUserToAddRows = false;
            gridQ.AllowUserToDeleteRows = false;
            gridQ.BackgroundColor = System.Drawing.Color.White;
            gridQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridQ.Location = new System.Drawing.Point(12, 41);
            gridQ.Name = "gridQ";
            gridQ.ReadOnly = true;
            gridQ.RowHeadersWidth = 51;
            gridQ.RowTemplate.Height = 29;
            gridQ.Size = new System.Drawing.Size(382, 628);
            gridQ.TabIndex = 0;
            // 
            // gridF
            // 
            gridF.AllowUserToAddRows = false;
            gridF.AllowUserToDeleteRows = false;
            gridF.BackgroundColor = System.Drawing.Color.White;
            gridF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridF.Location = new System.Drawing.Point(422, 43);
            gridF.Name = "gridF";
            gridF.ReadOnly = true;
            gridF.RowHeadersWidth = 51;
            gridF.RowTemplate.Height = 29;
            gridF.Size = new System.Drawing.Size(629, 243);
            gridF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(567, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(339, 19);
            label1.TabIndex = 2;
            label1.Text = "Итоговая таблица выбора стратегий";
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = System.Drawing.Color.White;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Location = new System.Drawing.Point(422, 364);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(484, 305);
            panel.TabIndex = 3;
            panel.Paint += panel_Paint;
            // 
            // comboBox
            // 
            comboBox.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new System.Drawing.Point(597, 330);
            comboBox.Name = "comboBox";
            comboBox.Size = new System.Drawing.Size(181, 25);
            comboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(422, 333);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(169, 19);
            label2.TabIndex = 5;
            label2.Text = "Выберите переход";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(940, 331);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 19);
            label3.TabIndex = 6;
            label3.Text = "Легенда";
            // 
            // legend
            // 
            legend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            legend.FormattingEnabled = true;
            legend.ItemHeight = 20;
            legend.Location = new System.Drawing.Point(919, 364);
            legend.Name = "legend";
            legend.Size = new System.Drawing.Size(132, 304);
            legend.TabIndex = 7;
            legend.DrawItem += legend_DrawItem_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(232, 247, 255);
            ClientSize = new System.Drawing.Size(1086, 708);
            Controls.Add(legend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox);
            Controls.Add(panel);
            Controls.Add(label1);
            Controls.Add(gridF);
            Controls.Add(gridQ);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "TPR-1";
            ((System.ComponentModel.ISupportInitialize)gridQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridQ;
        private System.Windows.Forms.DataGridView gridF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox legend;
    }
}