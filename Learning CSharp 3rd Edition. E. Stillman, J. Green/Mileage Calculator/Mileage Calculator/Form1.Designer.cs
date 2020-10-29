namespace Mileage_Calculator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numStartMileage = new System.Windows.Forms.NumericUpDown();
            this.numEndMileage = new System.Windows.Forms.NumericUpDown();
            this.lblResultAmountOwed = new System.Windows.Forms.Label();
            this.btnDisplayMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стартовые мили";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечные мили";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Причитающаяся сумма";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 89);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Расчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numStartMileage
            // 
            this.numStartMileage.Location = new System.Drawing.Point(148, 12);
            this.numStartMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStartMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartMileage.Name = "numStartMileage";
            this.numStartMileage.Size = new System.Drawing.Size(120, 20);
            this.numStartMileage.TabIndex = 4;
            this.numStartMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numEndMileage
            // 
            this.numEndMileage.Location = new System.Drawing.Point(148, 38);
            this.numEndMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEndMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndMileage.Name = "numEndMileage";
            this.numEndMileage.Size = new System.Drawing.Size(120, 20);
            this.numEndMileage.TabIndex = 5;
            this.numEndMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblResultAmountOwed
            // 
            this.lblResultAmountOwed.AutoSize = true;
            this.lblResultAmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultAmountOwed.Location = new System.Drawing.Point(144, 66);
            this.lblResultAmountOwed.Name = "lblResultAmountOwed";
            this.lblResultAmountOwed.Size = new System.Drawing.Size(0, 20);
            this.lblResultAmountOwed.TabIndex = 6;
            // 
            // btnDisplayMiles
            // 
            this.btnDisplayMiles.Location = new System.Drawing.Point(148, 89);
            this.btnDisplayMiles.Name = "btnDisplayMiles";
            this.btnDisplayMiles.Size = new System.Drawing.Size(120, 23);
            this.btnDisplayMiles.TabIndex = 7;
            this.btnDisplayMiles.Text = "Показать мили";
            this.btnDisplayMiles.UseVisualStyleBackColor = true;
            this.btnDisplayMiles.Click += new System.EventHandler(this.btnDisplayMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(294, 141);
            this.Controls.Add(this.btnDisplayMiles);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numStartMileage);
            this.Controls.Add(this.numEndMileage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultAmountOwed);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numStartMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numStartMileage;
        private System.Windows.Forms.NumericUpDown numEndMileage;
        private System.Windows.Forms.Label lblResultAmountOwed;
        private System.Windows.Forms.Button btnDisplayMiles;
        }
    }

