
namespace TPR_LR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grid = new System.Windows.Forms.DataGridView();
            numericUpDownN = new System.Windows.Forms.NumericUpDown();
            labelLegenda = new System.Windows.Forms.Label();
            labelN = new System.Windows.Forms.Label();
            labelS = new System.Windows.Forms.Label();
            numericUpDownS = new System.Windows.Forms.NumericUpDown();
            labelStages = new System.Windows.Forms.Label();
            numericUpDownStages = new System.Windows.Forms.NumericUpDown();
            buttonRecreateTable = new System.Windows.Forms.Button();
            buttonSaveData = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ofd = new System.Windows.Forms.OpenFileDialog();
            sfd = new System.Windows.Forms.SaveFileDialog();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStages).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new System.Drawing.Point(12, 212);
            grid.Name = "grid";
            grid.RowHeadersWidth = 50;
            grid.RowTemplate.Height = 29;
            grid.Size = new System.Drawing.Size(1185, 458);
            grid.TabIndex = 0;
            // 
            // numericUpDownN
            // 
            numericUpDownN.BackColor = System.Drawing.Color.White;
            numericUpDownN.Location = new System.Drawing.Point(472, 21);
            numericUpDownN.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownN.Name = "numericUpDownN";
            numericUpDownN.Size = new System.Drawing.Size(45, 25);
            numericUpDownN.TabIndex = 1;
            numericUpDownN.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // labelLegenda
            // 
            labelLegenda.AutoSize = true;
            labelLegenda.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelLegenda.Location = new System.Drawing.Point(12, 23);
            labelLegenda.Name = "labelLegenda";
            labelLegenda.Size = new System.Drawing.Size(369, 95);
            labelLegenda.TabIndex = 3;
            labelLegenda.Text = "N - число состояний системы.\r\n\r\nS - число стратегий.\r\n\r\nn - количество этапов моделирования.";
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelN.Location = new System.Drawing.Point(427, 23);
            labelN.Name = "labelN";
            labelN.Size = new System.Drawing.Size(39, 19);
            labelN.TabIndex = 4;
            labelN.Text = "N =";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelS.Location = new System.Drawing.Point(427, 61);
            labelS.Name = "labelS";
            labelS.Size = new System.Drawing.Size(39, 19);
            labelS.TabIndex = 6;
            labelS.Text = "S =";
            // 
            // numericUpDownS
            // 
            numericUpDownS.Location = new System.Drawing.Point(472, 55);
            numericUpDownS.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownS.Name = "numericUpDownS";
            numericUpDownS.Size = new System.Drawing.Size(45, 25);
            numericUpDownS.TabIndex = 5;
            numericUpDownS.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // labelStages
            // 
            labelStages.AutoSize = true;
            labelStages.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelStages.Location = new System.Drawing.Point(427, 94);
            labelStages.Name = "labelStages";
            labelStages.Size = new System.Drawing.Size(39, 19);
            labelStages.TabIndex = 8;
            labelStages.Text = "n =";
            // 
            // numericUpDownStages
            // 
            numericUpDownStages.Location = new System.Drawing.Point(472, 92);
            numericUpDownStages.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownStages.Name = "numericUpDownStages";
            numericUpDownStages.Size = new System.Drawing.Size(45, 25);
            numericUpDownStages.TabIndex = 7;
            numericUpDownStages.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // buttonRecreateTable
            // 
            buttonRecreateTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonRecreateTable.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            buttonRecreateTable.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonRecreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonRecreateTable.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRecreateTable.Location = new System.Drawing.Point(127, 152);
            buttonRecreateTable.Name = "buttonRecreateTable";
            buttonRecreateTable.Size = new System.Drawing.Size(199, 25);
            buttonRecreateTable.TabIndex = 9;
            buttonRecreateTable.Text = "Создать таблицу";
            buttonRecreateTable.UseVisualStyleBackColor = false;
            buttonRecreateTable.Click += buttonRecreateTable_Click;
            // 
            // buttonSaveData
            // 
            buttonSaveData.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSaveData.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            buttonSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSaveData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSaveData.Location = new System.Drawing.Point(459, 698);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new System.Drawing.Size(311, 27);
            buttonSaveData.TabIndex = 10;
            buttonSaveData.Text = "Вычислить";
            buttonSaveData.UseVisualStyleBackColor = false;
            buttonSaveData.Click += buttonSaveData_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(496, 152);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(199, 25);
            button1.TabIndex = 11;
            button1.Text = "Загрузить таблицу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(844, 152);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(199, 25);
            button2.TabIndex = 12;
            button2.Text = "Сохранить таблицу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ofd
            // 
            ofd.Filter = "Входные данные |*.txt";
            // 
            // sfd
            // 
            sfd.FileName = "saved";
            sfd.Filter = "Входные данные |*.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(638, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(559, 57);
            label1.TabIndex = 13;
            label1.Text = "P - вероятность перехода от одного состояния к другому.\r\n\r\nR - доходность.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(232, 247, 255);
            ClientSize = new System.Drawing.Size(1209, 748);
            Controls.Add(label1);
            Controls.Add(numericUpDownN);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonSaveData);
            Controls.Add(buttonRecreateTable);
            Controls.Add(labelStages);
            Controls.Add(numericUpDownStages);
            Controls.Add(labelS);
            Controls.Add(numericUpDownS);
            Controls.Add(labelN);
            Controls.Add(labelLegenda);
            Controls.Add(grid);
            MinimumSize = new System.Drawing.Size(18, 635);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Дискретные марковские процессы";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownS).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label labelLegenda;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelStages;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button buttonRecreateTable;
        private System.Windows.Forms.Button buttonSaveData;
        public System.Windows.Forms.NumericUpDown numericUpDownN;
        public System.Windows.Forms.NumericUpDown numericUpDownS;
        public System.Windows.Forms.NumericUpDown numericUpDownStages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label1;
    }
}

