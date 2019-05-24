namespace Homework2
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
            this.txtStr1 = new System.Windows.Forms.TextBox();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtStr3 = new System.Windows.Forms.TextBox();
            this.lblStr1 = new System.Windows.Forms.Label();
            this.lblStr2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblStr3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStr1
            // 
            this.txtStr1.Location = new System.Drawing.Point(153, 20);
            this.txtStr1.Name = "txtStr1";
            this.txtStr1.Size = new System.Drawing.Size(100, 20);
            this.txtStr1.TabIndex = 0;
            // 
            // txtStr2
            // 
            this.txtStr2.Location = new System.Drawing.Point(153, 58);
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.Size = new System.Drawing.Size(100, 20);
            this.txtStr2.TabIndex = 1;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(153, 95);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 2;
            // 
            // txtStr3
            // 
            this.txtStr3.Location = new System.Drawing.Point(153, 130);
            this.txtStr3.Name = "txtStr3";
            this.txtStr3.Size = new System.Drawing.Size(100, 20);
            this.txtStr3.TabIndex = 3;
            // 
            // lblStr1
            // 
            this.lblStr1.AutoSize = true;
            this.lblStr1.Location = new System.Drawing.Point(13, 26);
            this.lblStr1.Name = "lblStr1";
            this.lblStr1.Size = new System.Drawing.Size(83, 13);
            this.lblStr1.TabIndex = 4;
            this.lblStr1.Text = "Первая строка";
            // 
            // lblStr2
            // 
            this.lblStr2.AutoSize = true;
            this.lblStr2.Location = new System.Drawing.Point(13, 65);
            this.lblStr2.Name = "lblStr2";
            this.lblStr2.Size = new System.Drawing.Size(81, 13);
            this.lblStr2.TabIndex = 5;
            this.lblStr2.Text = "Вторая строка";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(13, 102);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(127, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Количество элементов ";
            // 
            // lblStr3
            // 
            this.lblStr3.AutoSize = true;
            this.lblStr3.Location = new System.Drawing.Point(12, 137);
            this.lblStr3.Name = "lblStr3";
            this.lblStr3.Size = new System.Drawing.Size(133, 13);
            this.lblStr3.TabIndex = 7;
            this.lblStr3.Text = "Подпоследовательность";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(99, 176);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 211);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblStr3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblStr2);
            this.Controls.Add(this.lblStr1);
            this.Controls.Add(this.txtStr3);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtStr2);
            this.Controls.Add(this.txtStr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStr1;
        private System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtStr3;
        private System.Windows.Forms.Label lblStr1;
        private System.Windows.Forms.Label lblStr2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblStr3;
        private System.Windows.Forms.Button btnFind;
    }
}

