namespace BudgetApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            add = new Button();
            spendings = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            type = new TextBox();
            splitter1 = new Splitter();
            amount = new TextBox();
            category = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            splitter2 = new Splitter();
            comboBox1 = new ComboBox();
            button1 = new Button();
            search = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            total = new Label();
            label5 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)spendings).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add.BackColor = SystemColors.Window;
            add.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            add.FlatAppearance.BorderSize = 0;
            add.FlatAppearance.MouseDownBackColor = Color.FromArgb(249, 99, 217);
            add.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            add.ForeColor = Color.FromArgb(236, 9, 188);
            add.Location = new Point(762, 3);
            add.Name = "add";
            add.Size = new Size(87, 38);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // spendings
            // 
            spendings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(50, 50, 50);
            spendings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            spendings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            spendings.BackgroundColor = SystemColors.Window;
            spendings.BorderStyle = BorderStyle.None;
            spendings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 99, 217);
            dataGridViewCellStyle2.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 9, 188);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            spendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            spendings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            spendings.DefaultCellStyle = dataGridViewCellStyle3;
            spendings.EnableHeadersVisualStyles = false;
            spendings.GridColor = Color.FromArgb(249, 99, 217);
            spendings.Location = new Point(12, 45);
            spendings.Name = "spendings";
            spendings.ReadOnly = true;
            spendings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(249, 99, 217);
            dataGridViewCellStyle4.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(236, 9, 188);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            spendings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            spendings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = Color.White;
            spendings.RowsDefaultCellStyle = dataGridViewCellStyle5;
            spendings.Size = new Size(519, 268);
            spendings.TabIndex = 1;
            spendings.RowHeaderMouseClick += spendings_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(type);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(amount);
            panel1.Controls.Add(category);
            panel1.Controls.Add(add);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 455);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 47);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(236, 9, 188);
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(345, 7);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 7;
            label3.Text = "amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(236, 9, 188);
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(28, 16);
            label2.TabIndex = 6;
            label2.Text = "type";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(249, 99, 217);
            panel2.Location = new Point(0, -26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1675, 30);
            panel2.TabIndex = 4;
            // 
            // type
            // 
            type.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            type.BackColor = Color.FromArgb(255, 192, 255);
            type.BorderStyle = BorderStyle.None;
            type.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            type.ForeColor = Color.FromArgb(236, 9, 188);
            type.Location = new Point(12, 9);
            type.MaximumSize = new Size(600, 25);
            type.MinimumSize = new Size(200, 25);
            type.Name = "type";
            type.Size = new Size(283, 25);
            type.TabIndex = 3;
            type.TextAlign = HorizontalAlignment.Center;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 47);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            amount.BackColor = Color.FromArgb(255, 192, 255);
            amount.BorderStyle = BorderStyle.None;
            amount.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            amount.ForeColor = Color.FromArgb(236, 9, 188);
            amount.Location = new Point(356, 10);
            amount.Name = "amount";
            amount.Size = new Size(153, 25);
            amount.TabIndex = 1;
            amount.TextAlign = HorizontalAlignment.Center;
            // 
            // category
            // 
            category.BackColor = SystemColors.Window;
            category.DropDownStyle = ComboBoxStyle.DropDownList;
            category.FlatStyle = FlatStyle.System;
            category.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            category.ForeColor = Color.DimGray;
            category.FormattingEnabled = true;
            category.Location = new Point(552, 9);
            category.Name = "category";
            category.Size = new Size(190, 26);
            category.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 9, 188);
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 5;
            label1.Text = "Spendings";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(splitter2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 64);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(249, 99, 217);
            panel4.Location = new Point(0, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(1798, 17);
            panel4.TabIndex = 4;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 64);
            splitter2.TabIndex = 2;
            splitter2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.ForeColor = Color.FromArgb(236, 9, 188);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(2125, -31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 26);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.Window;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(249, 99, 217);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(236, 9, 188);
            button1.Location = new Point(2249, -37);
            button1.Name = "button1";
            button1.Size = new Size(87, 38);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(255, 192, 255);
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            search.ForeColor = Color.FromArgb(236, 9, 188);
            search.Location = new Point(18, 14);
            search.Name = "search";
            search.Size = new Size(275, 25);
            search.TabIndex = 8;
            search.TextAlign = HorizontalAlignment.Center;
            search.KeyDown += search_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(236, 9, 188);
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 8;
            label4.Text = "search";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Window;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox2.ForeColor = Color.DimGray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(309, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 26);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Window;
            button2.FlatAppearance.BorderColor = Color.FromArgb(236, 9, 188);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(249, 99, 217);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.FromArgb(236, 9, 188);
            button2.Location = new Point(443, 319);
            button2.Name = "button2";
            button2.Size = new Size(83, 28);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(total);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox1.ForeColor = Color.FromArgb(236, 9, 188);
            groupBox1.Location = new Point(537, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 391);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Verdana", 8F);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 65F;
            legend1.Name = "Legend1";
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 91);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart1.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(246, 25, 199),
    Color.FromArgb(248, 74, 211),
    Color.FromArgb(250, 123, 223),
    Color.FromArgb(253, 173, 235),
    Color.FromArgb(254, 222, 247)
    };
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 294);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            title1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            title1.ForeColor = Color.FromArgb(236, 9, 188);
            title1.Name = "Title1";
            title1.Text = "Expenses by category";
            chart1.Titles.Add(title1);
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = SystemColors.Window;
            total.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            total.ForeColor = Color.FromArgb(50, 50, 50);
            total.Location = new Point(103, 56);
            total.Name = "total";
            total.Size = new Size(40, 32);
            total.TabIndex = 1;
            total.Text = "zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Impact", 14.25F);
            label5.ForeColor = Color.FromArgb(236, 9, 188);
            label5.Location = new Point(103, 33);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 0;
            label5.Text = "Total spend";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(search);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(spendings);
            panel5.Controls.Add(comboBox2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(537, 391);
            panel5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(849, 502);
            Controls.Add(panel5);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Budget App";
            ((System.ComponentModel.ISupportInitialize)spendings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private DataGridView spendings;
        private Panel panel1;
        private ComboBox category;
        private TextBox amount;
        private Splitter splitter1;
        private TextBox type;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter2;
        private ComboBox comboBox1;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox search;
        private Label label4;
        private ComboBox comboBox2;
        private Button button2;
        private GroupBox groupBox1;
        private Label total;
        private Label label5;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
