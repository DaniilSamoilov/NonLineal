namespace NonLineal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NutonBtn = new System.Windows.Forms.Button();
            this.BisectionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.TextBox();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionSelector = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GenerateTable = new System.Windows.Forms.Button();
            this.ArgumentsTable = new System.Windows.Forms.DataGridView();
            this.TopBorder = new System.Windows.Forms.TextBox();
            this.Guess = new System.Windows.Forms.TextBox();
            this.Presic = new System.Windows.Forms.TextBox();
            this.BottomBorder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 454);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BottomBorder);
            this.tabPage1.Controls.Add(this.Presic);
            this.tabPage1.Controls.Add(this.Guess);
            this.tabPage1.Controls.Add(this.TopBorder);
            this.tabPage1.Controls.Add(this.NutonBtn);
            this.tabPage1.Controls.Add(this.BisectionBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Solution);
            this.tabPage1.Controls.Add(this.Graph);
            this.tabPage1.Controls.Add(this.FunctionSelector);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отдельные уравнения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NutonBtn
            // 
            this.NutonBtn.Location = new System.Drawing.Point(508, 366);
            this.NutonBtn.Name = "NutonBtn";
            this.NutonBtn.Size = new System.Drawing.Size(112, 50);
            this.NutonBtn.TabIndex = 5;
            this.NutonBtn.Text = "Решить методом Ньютона ";
            this.NutonBtn.UseVisualStyleBackColor = true;
            this.NutonBtn.Click += new System.EventHandler(this.NutonBtn_Click);
            // 
            // BisectionBtn
            // 
            this.BisectionBtn.Location = new System.Drawing.Point(350, 366);
            this.BisectionBtn.Name = "BisectionBtn";
            this.BisectionBtn.Size = new System.Drawing.Size(103, 50);
            this.BisectionBtn.TabIndex = 4;
            this.BisectionBtn.Text = "Решить Методом дихотомии";
            this.BisectionBtn.UseVisualStyleBackColor = true;
            this.BisectionBtn.Click += new System.EventHandler(this.BisectionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Решение";
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(684, 374);
            this.Solution.Name = "Solution";
            this.Solution.ReadOnly = true;
            this.Solution.Size = new System.Drawing.Size(100, 20);
            this.Solution.TabIndex = 2;
            // 
            // Graph
            // 
            chartArea4.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea4);
            this.Graph.Location = new System.Drawing.Point(0, 0);
            this.Graph.Name = "Graph";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Name = "Function";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.MarkerSize = 10;
            series8.Name = "Root";
            this.Graph.Series.Add(series7);
            this.Graph.Series.Add(series8);
            this.Graph.Size = new System.Drawing.Size(792, 372);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "chart1";
            // 
            // FunctionSelector
            // 
            this.FunctionSelector.FormattingEnabled = true;
            this.FunctionSelector.Location = new System.Drawing.Point(84, 366);
            this.FunctionSelector.Name = "FunctionSelector";
            this.FunctionSelector.Size = new System.Drawing.Size(105, 21);
            this.FunctionSelector.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GenerateTable);
            this.tabPage2.Controls.Add(this.ArgumentsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Система уравнений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GenerateTable
            // 
            this.GenerateTable.Location = new System.Drawing.Point(8, 374);
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.Size = new System.Drawing.Size(84, 42);
            this.GenerateTable.TabIndex = 4;
            this.GenerateTable.Text = "Создать матрицу";
            this.GenerateTable.UseVisualStyleBackColor = true;
            // 
            // ArgumentsTable
            // 
            this.ArgumentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArgumentsTable.Location = new System.Drawing.Point(3, 6);
            this.ArgumentsTable.Name = "ArgumentsTable";
            this.ArgumentsTable.Size = new System.Drawing.Size(775, 362);
            this.ArgumentsTable.TabIndex = 1;
            // 
            // TopBorder
            // 
            this.TopBorder.Location = new System.Drawing.Point(294, 369);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(50, 20);
            this.TopBorder.TabIndex = 6;
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(459, 396);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(43, 20);
            this.Guess.TabIndex = 7;
            // 
            // Presic
            // 
            this.Presic.Location = new System.Drawing.Point(84, 396);
            this.Presic.Name = "Presic";
            this.Presic.Size = new System.Drawing.Size(105, 20);
            this.Presic.TabIndex = 8;
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(294, 393);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(50, 20);
            this.BottomBorder.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Верхняя граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Нижняя граница";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Функция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Точность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Первая\r\nточка\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button GenerateTable;
        private System.Windows.Forms.DataGridView ArgumentsTable;
        private System.Windows.Forms.ComboBox FunctionSelector;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Solution;
        private System.Windows.Forms.Button BisectionBtn;
        private System.Windows.Forms.Button NutonBtn;
        private System.Windows.Forms.TextBox BottomBorder;
        private System.Windows.Forms.TextBox Presic;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.TextBox TopBorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

