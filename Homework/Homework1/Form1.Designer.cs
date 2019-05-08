namespace Homework1
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.listSystem = new System.Windows.Forms.ListBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNumber.Location = new System.Drawing.Point(12, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 24);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Число";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNumber.Location = new System.Drawing.Point(228, 25);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 29);
            this.txtNumber.TabIndex = 1;
            // 
            // listSystem
            // 
            this.listSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listSystem.FormattingEnabled = true;
            this.listSystem.ItemHeight = 24;
            this.listSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "16"});
            this.listSystem.Location = new System.Drawing.Point(228, 71);
            this.listSystem.Name = "listSystem";
            this.listSystem.Size = new System.Drawing.Size(120, 28);
            this.listSystem.TabIndex = 2;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSystem.Location = new System.Drawing.Point(12, 71);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(187, 24);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "Система счисления";
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultText.Location = new System.Drawing.Point(12, 122);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(198, 24);
            this.lblResultText.TabIndex = 4;
            this.lblResultText.Text = "Получившиеся число";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResult.Location = new System.Drawing.Point(224, 122);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 5;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnResult.Location = new System.Drawing.Point(112, 197);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(161, 76);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Старт";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 320);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.listSystem);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ListBox listSystem;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnResult;
    }
}

