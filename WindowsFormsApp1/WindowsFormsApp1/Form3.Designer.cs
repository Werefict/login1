namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_coe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rt4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rt6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rt7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_coe,
            this.Rt,
            this.rt2,
            this.rt3,
            this.rt4,
            this.rt6,
            this.rt7});
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_coe
            // 
            this.id_coe.HeaderText = "id_coe";
            this.id_coe.Name = "id_coe";
            // 
            // Rt
            // 
            this.Rt.HeaderText = "Коэффициент для анализ и проектирование";
            this.Rt.Name = "Rt";
            // 
            // rt2
            // 
            this.rt2.HeaderText = "Коэффициент для остановка оборудования";
            this.rt2.Name = "rt2";
            // 
            // rt3
            // 
            this.rt3.HeaderText = "Коэффициент для ехническое обслуживание и сопровождение";
            this.rt3.Name = "rt3";
            // 
            // rt4
            // 
            this.rt4.HeaderText = "Коэффициент времени";
            this.rt4.Name = "rt4";
            // 
            // rt6
            // 
            this.rt6.HeaderText = "Коэффициент сложности";
            this.rt6.Name = "rt6";
            // 
            // rt7
            // 
            this.rt7.HeaderText = "Коэффициент для перевода в денежный эквивалент";
            this.rt7.Name = "rt7";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_coe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rt;
        private System.Windows.Forms.DataGridViewTextBoxColumn rt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rt6;
        private System.Windows.Forms.DataGridViewTextBoxColumn rt7;
    }
}