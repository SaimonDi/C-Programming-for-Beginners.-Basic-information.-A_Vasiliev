namespace ProjectGuy {
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeRecieveButton = new System.Windows.Forms.Button();
            this.bobGiveButton = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Location = new System.Drawing.Point(13, 12);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(0, 13);
            this.joeCashLabel.TabIndex = 0;
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Location = new System.Drawing.Point(13, 37);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(0, 13);
            this.bobCashLabel.TabIndex = 1;
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(13, 64);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(0, 13);
            this.bankCashLabel.TabIndex = 2;
            // 
            // joeRecieveButton
            // 
            this.joeRecieveButton.Location = new System.Drawing.Point(16, 94);
            this.joeRecieveButton.Name = "joeRecieveButton";
            this.joeRecieveButton.Size = new System.Drawing.Size(75, 35);
            this.joeRecieveButton.TabIndex = 3;
            this.joeRecieveButton.Text = "Give 10$ to Joe";
            this.joeRecieveButton.UseVisualStyleBackColor = true;
            this.joeRecieveButton.Click += new System.EventHandler(this.joeRecieveButton_Click);
            // 
            // bobGiveButton
            // 
            this.bobGiveButton.Location = new System.Drawing.Point(97, 94);
            this.bobGiveButton.Name = "bobGiveButton";
            this.bobGiveButton.Size = new System.Drawing.Size(75, 35);
            this.bobGiveButton.TabIndex = 4;
            this.bobGiveButton.Text = "Recieve 5$ from Bob";
            this.bobGiveButton.UseVisualStyleBackColor = true;
            this.bobGiveButton.Click += new System.EventHandler(this.bobGiveButton_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(16, 139);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(75, 35);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives 10$ to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(97, 139);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(75, 35);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives 5$ to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 186);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeRecieveButton);
            this.Controls.Add(this.bobGiveButton);
            this.Controls.Add(this.joeCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.bankCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun whith Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeRecieveButton;
        private System.Windows.Forms.Button bobGiveButton;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
        }
    }

