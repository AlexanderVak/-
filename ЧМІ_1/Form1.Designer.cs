namespace ЧМІ_1
{
    partial class Form1
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
            this.expression_tbx = new System.Windows.Forms.TextBox();
            this.step_tbx = new System.Windows.Forms.TextBox();
            this.getResult_btn = new System.Windows.Forms.Button();
            this.btmBorder_tbx = new System.Windows.Forms.TextBox();
            this.highBorder_tbx = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.results_lview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // expression_tbx
            // 
            this.expression_tbx.Location = new System.Drawing.Point(15, 39);
            this.expression_tbx.Name = "expression_tbx";
            this.expression_tbx.Size = new System.Drawing.Size(100, 20);
            this.expression_tbx.TabIndex = 1;
            // 
            // step_tbx
            // 
            this.step_tbx.Location = new System.Drawing.Point(121, 39);
            this.step_tbx.Name = "step_tbx";
            this.step_tbx.Size = new System.Drawing.Size(100, 20);
            this.step_tbx.TabIndex = 2;
            // 
            // getResult_btn
            // 
            this.getResult_btn.Location = new System.Drawing.Point(144, 91);
            this.getResult_btn.Name = "getResult_btn";
            this.getResult_btn.Size = new System.Drawing.Size(152, 49);
            this.getResult_btn.TabIndex = 5;
            this.getResult_btn.Text = "Отримати результат";
            this.getResult_btn.UseVisualStyleBackColor = true;
            this.getResult_btn.Click += new System.EventHandler(this.getResult_btn_Click);
            // 
            // btmBorder_tbx
            // 
            this.btmBorder_tbx.Location = new System.Drawing.Point(227, 39);
            this.btmBorder_tbx.Name = "btmBorder_tbx";
            this.btmBorder_tbx.Size = new System.Drawing.Size(100, 20);
            this.btmBorder_tbx.TabIndex = 6;
            // 
            // highBorder_tbx
            // 
            this.highBorder_tbx.Location = new System.Drawing.Point(333, 39);
            this.highBorder_tbx.Name = "highBorder_tbx";
            this.highBorder_tbx.Size = new System.Drawing.Size(100, 20);
            this.highBorder_tbx.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.results_lview});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(144, 339);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(152, 71);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // results_lview
            // 
            this.results_lview.Text = "Корені";
            this.results_lview.Width = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Рівняння";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Крок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(224, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Верхня межа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(329, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Нижня межа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.highBorder_tbx);
            this.Controls.Add(this.btmBorder_tbx);
            this.Controls.Add(this.getResult_btn);
            this.Controls.Add(this.step_tbx);
            this.Controls.Add(this.expression_tbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Відокремлення Коренів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox expression_tbx;
        private System.Windows.Forms.TextBox step_tbx;
        private System.Windows.Forms.Button getResult_btn;
        private System.Windows.Forms.TextBox btmBorder_tbx;
        private System.Windows.Forms.TextBox highBorder_tbx;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader results_lview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

