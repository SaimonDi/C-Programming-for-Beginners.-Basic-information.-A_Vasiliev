namespace Swap_Elephant {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.btnFirstElephant = new System.Windows.Forms.Button();
            this.btnSecondElephant = new System.Windows.Forms.Button();
            this.btnSwapElephant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstElephant
            // 
            this.btnFirstElephant.Location = new System.Drawing.Point(29, 12);
            this.btnFirstElephant.Name = "btnFirstElephant";
            this.btnFirstElephant.Size = new System.Drawing.Size(75, 23);
            this.btnFirstElephant.TabIndex = 0;
            this.btnFirstElephant.Text = "Lloyd";
            this.btnFirstElephant.UseVisualStyleBackColor = true;
            this.btnFirstElephant.Click += new System.EventHandler(this.btnFirstElephant_Click);
            // 
            // btnSecondElephant
            // 
            this.btnSecondElephant.Location = new System.Drawing.Point(29, 41);
            this.btnSecondElephant.Name = "btnSecondElephant";
            this.btnSecondElephant.Size = new System.Drawing.Size(75, 23);
            this.btnSecondElephant.TabIndex = 1;
            this.btnSecondElephant.Text = "Lucinda";
            this.btnSecondElephant.UseVisualStyleBackColor = true;
            this.btnSecondElephant.Click += new System.EventHandler(this.btnSecondElephant_Click);
            // 
            // btnSwapElephant
            // 
            this.btnSwapElephant.Location = new System.Drawing.Point(29, 70);
            this.btnSwapElephant.Name = "btnSwapElephant";
            this.btnSwapElephant.Size = new System.Drawing.Size(75, 23);
            this.btnSwapElephant.TabIndex = 2;
            this.btnSwapElephant.Text = "Swap!";
            this.btnSwapElephant.UseVisualStyleBackColor = true;
            this.btnSwapElephant.Click += new System.EventHandler(this.btnSwapElephant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(134, 111);
            this.Controls.Add(this.btnFirstElephant);
            this.Controls.Add(this.btnSecondElephant);
            this.Controls.Add(this.btnSwapElephant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swap";
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button btnFirstElephant;
        private System.Windows.Forms.Button btnSecondElephant;
        private System.Windows.Forms.Button btnSwapElephant;
        }
    }

