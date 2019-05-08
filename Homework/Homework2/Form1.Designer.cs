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
            this.btnWithoutRec = new System.Windows.Forms.Button();
            this.bntRec = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithoutRec
            // 
            this.btnWithoutRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnWithoutRec.Location = new System.Drawing.Point(16, 171);
            this.btnWithoutRec.Name = "btnWithoutRec";
            this.btnWithoutRec.Size = new System.Drawing.Size(122, 72);
            this.btnWithoutRec.TabIndex = 0;
            this.btnWithoutRec.Text = "Без рекурсии";
            this.btnWithoutRec.UseVisualStyleBackColor = true;
            this.btnWithoutRec.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntRec
            // 
            this.bntRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bntRec.Location = new System.Drawing.Point(180, 171);
            this.bntRec.Name = "bntRec";
            this.bntRec.Size = new System.Drawing.Size(122, 72);
            this.bntRec.TabIndex = 1;
            this.bntRec.Text = "С рекурсией";
            this.bntRec.UseVisualStyleBackColor = true;
            this.bntRec.Click += new System.EventHandler(this.bntRec_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNumber.Location = new System.Drawing.Point(180, 36);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(122, 29);
            this.txtNumber.TabIndex = 2;
            // 
            // txtDegree
            // 
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDegree.Location = new System.Drawing.Point(180, 79);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(122, 29);
            this.txtDegree.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtResult.Location = new System.Drawing.Point(180, 121);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(122, 29);
            this.txtResult.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNumber.Location = new System.Drawing.Point(12, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 24);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Число";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResult.Location = new System.Drawing.Point(12, 124);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(103, 24);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Результат";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDegree.Location = new System.Drawing.Point(12, 79);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(88, 24);
            this.lblDegree.TabIndex = 8;
            this.lblDegree.Text = "Cтепень";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 267);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.bntRec);
            this.Controls.Add(this.btnWithoutRec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithoutRec;
        private System.Windows.Forms.Button bntRec;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDegree;
    }
}

