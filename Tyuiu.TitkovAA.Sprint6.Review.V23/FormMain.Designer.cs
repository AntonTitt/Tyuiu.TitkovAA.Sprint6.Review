
namespace Tyuiu.TitkovAA.Sprint6.Review.V23
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_TAA = new System.Windows.Forms.GroupBox();
            this.textBoxZADANIE_TAA = new System.Windows.Forms.TextBox();
            this.buttonDO_TAA = new System.Windows.Forms.Button();
            this.groupBoxOutput_TAA = new System.Windows.Forms.GroupBox();
            this.labelN_TAA = new System.Windows.Forms.Label();
            this.textBox_N_TAA = new System.Windows.Forms.TextBox();
            this.textBox_M_TAA = new System.Windows.Forms.TextBox();
            this.labelM_TAA = new System.Windows.Forms.Label();
            this.labelURODI_TAA = new System.Windows.Forms.Label();
            this.labelDIAPZNACH_TAA = new System.Windows.Forms.Label();
            this.labeln1_TAA = new System.Windows.Forms.Label();
            this.textBox_n1_TAA = new System.Windows.Forms.TextBox();
            this.labelL_TAA = new System.Windows.Forms.Label();
            this.textBox_n2_TAA = new System.Windows.Forms.TextBox();
            this.labeln2_TAA = new System.Windows.Forms.Label();
            this.labelk_TAA = new System.Windows.Forms.Label();
            this.labelc_TAA = new System.Windows.Forms.Label();
            this.textBox_l_TAA = new System.Windows.Forms.TextBox();
            this.textBox_k_TAA = new System.Windows.Forms.TextBox();
            this.textBox_c_TAA = new System.Windows.Forms.TextBox();
            this.dataGridView_YAMETE_TAA = new System.Windows.Forms.DataGridView();
            this.groupBoxMatr_TAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOUT_TAA = new System.Windows.Forms.GroupBox();
            this.textBox_re_TAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_TAA.SuspendLayout();
            this.groupBoxOutput_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_YAMETE_TAA)).BeginInit();
            this.groupBoxMatr_TAA.SuspendLayout();
            this.groupBoxOUT_TAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_TAA
            // 
            this.groupBoxTask_TAA.Controls.Add(this.textBoxZADANIE_TAA);
            this.groupBoxTask_TAA.Controls.Add(this.buttonDO_TAA);
            this.groupBoxTask_TAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_TAA.Name = "groupBoxTask_TAA";
            this.groupBoxTask_TAA.Size = new System.Drawing.Size(958, 99);
            this.groupBoxTask_TAA.TabIndex = 0;
            this.groupBoxTask_TAA.TabStop = false;
            this.groupBoxTask_TAA.Text = "Условие";
            // 
            // textBoxZADANIE_TAA
            // 
            this.textBoxZADANIE_TAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F);
            this.textBoxZADANIE_TAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxZADANIE_TAA.Multiline = true;
            this.textBoxZADANIE_TAA.Name = "textBoxZADANIE_TAA";
            this.textBoxZADANIE_TAA.ReadOnly = true;
            this.textBoxZADANIE_TAA.Size = new System.Drawing.Size(634, 72);
            this.textBoxZADANIE_TAA.TabIndex = 4;
            this.textBoxZADANIE_TAA.Text = resources.GetString("textBoxZADANIE_TAA.Text");
            // 
            // buttonDO_TAA
            // 
            this.buttonDO_TAA.BackColor = System.Drawing.Color.Red;
            this.buttonDO_TAA.Location = new System.Drawing.Point(646, 21);
            this.buttonDO_TAA.Name = "buttonDO_TAA";
            this.buttonDO_TAA.Size = new System.Drawing.Size(306, 72);
            this.buttonDO_TAA.TabIndex = 0;
            this.buttonDO_TAA.Text = "ПОСТРОИТЬ МАТРИЦУ";
            this.buttonDO_TAA.UseVisualStyleBackColor = false;
            this.buttonDO_TAA.Click += new System.EventHandler(this.buttonDO_TAA_Click);
            // 
            // groupBoxOutput_TAA
            // 
            this.groupBoxOutput_TAA.Controls.Add(this.labelN_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_N_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_M_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelM_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelURODI_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelDIAPZNACH_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labeln1_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_n1_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelL_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_n2_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labeln2_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelk_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.labelc_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_l_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_k_TAA);
            this.groupBoxOutput_TAA.Controls.Add(this.textBox_c_TAA);
            this.groupBoxOutput_TAA.Location = new System.Drawing.Point(12, 117);
            this.groupBoxOutput_TAA.Name = "groupBoxOutput_TAA";
            this.groupBoxOutput_TAA.Size = new System.Drawing.Size(216, 321);
            this.groupBoxOutput_TAA.TabIndex = 1;
            this.groupBoxOutput_TAA.TabStop = false;
            this.groupBoxOutput_TAA.Text = "Ввод";
            // 
            // labelN_TAA
            // 
            this.labelN_TAA.AutoSize = true;
            this.labelN_TAA.Location = new System.Drawing.Point(21, 148);
            this.labelN_TAA.Name = "labelN_TAA";
            this.labelN_TAA.Size = new System.Drawing.Size(18, 17);
            this.labelN_TAA.TabIndex = 14;
            this.labelN_TAA.Text = "N";
            this.labelN_TAA.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_N_TAA
            // 
            this.textBox_N_TAA.Location = new System.Drawing.Point(62, 145);
            this.textBox_N_TAA.Name = "textBox_N_TAA";
            this.textBox_N_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_N_TAA.TabIndex = 12;
            this.textBox_N_TAA.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox_M_TAA
            // 
            this.textBox_M_TAA.Location = new System.Drawing.Point(62, 173);
            this.textBox_M_TAA.Name = "textBox_M_TAA";
            this.textBox_M_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_M_TAA.TabIndex = 13;
            this.textBox_M_TAA.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // labelM_TAA
            // 
            this.labelM_TAA.AutoSize = true;
            this.labelM_TAA.Location = new System.Drawing.Point(21, 178);
            this.labelM_TAA.Name = "labelM_TAA";
            this.labelM_TAA.Size = new System.Drawing.Size(19, 17);
            this.labelM_TAA.TabIndex = 15;
            this.labelM_TAA.Text = "M";
            this.labelM_TAA.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelURODI_TAA
            // 
            this.labelURODI_TAA.AutoSize = true;
            this.labelURODI_TAA.Location = new System.Drawing.Point(21, 121);
            this.labelURODI_TAA.Name = "labelURODI_TAA";
            this.labelURODI_TAA.Size = new System.Drawing.Size(115, 17);
            this.labelURODI_TAA.TabIndex = 11;
            this.labelURODI_TAA.Text = "Размер массива";
            // 
            // labelDIAPZNACH_TAA
            // 
            this.labelDIAPZNACH_TAA.AutoSize = true;
            this.labelDIAPZNACH_TAA.Location = new System.Drawing.Point(21, 33);
            this.labelDIAPZNACH_TAA.Name = "labelDIAPZNACH_TAA";
            this.labelDIAPZNACH_TAA.Size = new System.Drawing.Size(141, 17);
            this.labelDIAPZNACH_TAA.TabIndex = 10;
            this.labelDIAPZNACH_TAA.Text = "Диапазон значений";
            // 
            // labeln1_TAA
            // 
            this.labeln1_TAA.AutoSize = true;
            this.labeln1_TAA.Location = new System.Drawing.Point(21, 58);
            this.labeln1_TAA.Name = "labeln1_TAA";
            this.labeln1_TAA.Size = new System.Drawing.Size(24, 17);
            this.labeln1_TAA.TabIndex = 5;
            this.labeln1_TAA.Text = "n1";
            // 
            // textBox_n1_TAA
            // 
            this.textBox_n1_TAA.Location = new System.Drawing.Point(62, 55);
            this.textBox_n1_TAA.Name = "textBox_n1_TAA";
            this.textBox_n1_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_n1_TAA.TabIndex = 0;
            // 
            // labelL_TAA
            // 
            this.labelL_TAA.AutoSize = true;
            this.labelL_TAA.Location = new System.Drawing.Point(21, 282);
            this.labelL_TAA.Name = "labelL_TAA";
            this.labelL_TAA.Size = new System.Drawing.Size(11, 17);
            this.labelL_TAA.TabIndex = 9;
            this.labelL_TAA.Text = "l";
            // 
            // textBox_n2_TAA
            // 
            this.textBox_n2_TAA.Location = new System.Drawing.Point(62, 83);
            this.textBox_n2_TAA.Name = "textBox_n2_TAA";
            this.textBox_n2_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_n2_TAA.TabIndex = 1;
            // 
            // labeln2_TAA
            // 
            this.labeln2_TAA.AutoSize = true;
            this.labeln2_TAA.Location = new System.Drawing.Point(21, 88);
            this.labeln2_TAA.Name = "labeln2_TAA";
            this.labeln2_TAA.Size = new System.Drawing.Size(24, 17);
            this.labeln2_TAA.TabIndex = 6;
            this.labeln2_TAA.Text = "n2";
            // 
            // labelk_TAA
            // 
            this.labelk_TAA.AutoSize = true;
            this.labelk_TAA.Location = new System.Drawing.Point(21, 254);
            this.labelk_TAA.Name = "labelk_TAA";
            this.labelk_TAA.Size = new System.Drawing.Size(15, 17);
            this.labelk_TAA.TabIndex = 8;
            this.labelk_TAA.Text = "k";
            // 
            // labelc_TAA
            // 
            this.labelc_TAA.AutoSize = true;
            this.labelc_TAA.Location = new System.Drawing.Point(21, 226);
            this.labelc_TAA.Name = "labelc_TAA";
            this.labelc_TAA.Size = new System.Drawing.Size(15, 17);
            this.labelc_TAA.TabIndex = 7;
            this.labelc_TAA.Text = "c";
            // 
            // textBox_l_TAA
            // 
            this.textBox_l_TAA.Location = new System.Drawing.Point(62, 277);
            this.textBox_l_TAA.Name = "textBox_l_TAA";
            this.textBox_l_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_l_TAA.TabIndex = 4;
            // 
            // textBox_k_TAA
            // 
            this.textBox_k_TAA.Location = new System.Drawing.Point(62, 249);
            this.textBox_k_TAA.Name = "textBox_k_TAA";
            this.textBox_k_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_k_TAA.TabIndex = 3;
            this.textBox_k_TAA.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_c_TAA
            // 
            this.textBox_c_TAA.Location = new System.Drawing.Point(62, 221);
            this.textBox_c_TAA.Name = "textBox_c_TAA";
            this.textBox_c_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_c_TAA.TabIndex = 2;
            // 
            // dataGridView_YAMETE_TAA
            // 
            this.dataGridView_YAMETE_TAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_YAMETE_TAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_YAMETE_TAA.Name = "dataGridView_YAMETE_TAA";
            this.dataGridView_YAMETE_TAA.RowHeadersWidth = 51;
            this.dataGridView_YAMETE_TAA.RowTemplate.Height = 24;
            this.dataGridView_YAMETE_TAA.Size = new System.Drawing.Size(460, 300);
            this.dataGridView_YAMETE_TAA.TabIndex = 2;
            // 
            // groupBoxMatr_TAA
            // 
            this.groupBoxMatr_TAA.Controls.Add(this.dataGridView_YAMETE_TAA);
            this.groupBoxMatr_TAA.Location = new System.Drawing.Point(498, 120);
            this.groupBoxMatr_TAA.Name = "groupBoxMatr_TAA";
            this.groupBoxMatr_TAA.Size = new System.Drawing.Size(472, 321);
            this.groupBoxMatr_TAA.TabIndex = 2;
            this.groupBoxMatr_TAA.TabStop = false;
            this.groupBoxMatr_TAA.Text = "Матрица";
            // 
            // groupBoxOUT_TAA
            // 
            this.groupBoxOUT_TAA.Controls.Add(this.textBox_re_TAA);
            this.groupBoxOUT_TAA.Location = new System.Drawing.Point(234, 117);
            this.groupBoxOUT_TAA.Name = "groupBoxOUT_TAA";
            this.groupBoxOUT_TAA.Size = new System.Drawing.Size(258, 321);
            this.groupBoxOUT_TAA.TabIndex = 2;
            this.groupBoxOUT_TAA.TabStop = false;
            this.groupBoxOUT_TAA.Text = "Вывод";
            // 
            // textBox_re_TAA
            // 
            this.textBox_re_TAA.Location = new System.Drawing.Point(6, 33);
            this.textBox_re_TAA.Name = "textBox_re_TAA";
            this.textBox_re_TAA.ReadOnly = true;
            this.textBox_re_TAA.Size = new System.Drawing.Size(100, 22);
            this.textBox_re_TAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.groupBoxOUT_TAA);
            this.Controls.Add(this.groupBoxMatr_TAA);
            this.Controls.Add(this.groupBoxOutput_TAA);
            this.Controls.Add(this.groupBoxTask_TAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Review | Вариант 23 | Титков А. А.";
            this.groupBoxTask_TAA.ResumeLayout(false);
            this.groupBoxTask_TAA.PerformLayout();
            this.groupBoxOutput_TAA.ResumeLayout(false);
            this.groupBoxOutput_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_YAMETE_TAA)).EndInit();
            this.groupBoxMatr_TAA.ResumeLayout(false);
            this.groupBoxOUT_TAA.ResumeLayout(false);
            this.groupBoxOUT_TAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_TAA;
        private System.Windows.Forms.DataGridView dataGridView_YAMETE_TAA;
        private System.Windows.Forms.GroupBox groupBoxMatr_TAA;
        private System.Windows.Forms.GroupBox groupBoxOUT_TAA;
        private System.Windows.Forms.Button buttonDO_TAA;
        private System.Windows.Forms.TextBox textBox_l_TAA;
        private System.Windows.Forms.TextBox textBox_k_TAA;
        private System.Windows.Forms.TextBox textBox_c_TAA;
        private System.Windows.Forms.TextBox textBox_n2_TAA;
        private System.Windows.Forms.TextBox textBox_n1_TAA;
        private System.Windows.Forms.Label labelN_TAA;
        private System.Windows.Forms.TextBox textBox_N_TAA;
        private System.Windows.Forms.TextBox textBox_M_TAA;
        private System.Windows.Forms.Label labelM_TAA;
        private System.Windows.Forms.Label labelURODI_TAA;
        private System.Windows.Forms.Label labelDIAPZNACH_TAA;
        private System.Windows.Forms.Label labeln1_TAA;
        private System.Windows.Forms.Label labelL_TAA;
        private System.Windows.Forms.Label labeln2_TAA;
        private System.Windows.Forms.Label labelk_TAA;
        private System.Windows.Forms.Label labelc_TAA;
        private System.Windows.Forms.TextBox textBox_re_TAA;
        private System.Windows.Forms.TextBox textBoxZADANIE_TAA;
    }
}

