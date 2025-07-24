
namespace Project3_MykhailoKravchenko58603
{
    partial class mainForm
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
            this.btnRegularFigures = new System.Windows.Forms.Button();
            this.btnComplexFigures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegularFigures
            // 
            this.btnRegularFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegularFigures.Location = new System.Drawing.Point(23, 54);
            this.btnRegularFigures.Name = "btnRegularFigures";
            this.btnRegularFigures.Size = new System.Drawing.Size(284, 138);
            this.btnRegularFigures.TabIndex = 0;
            this.btnRegularFigures.Text = "LABORATORIUM\r\nWybrane bryly regularne\r\n";
            this.btnRegularFigures.UseVisualStyleBackColor = true;
            this.btnRegularFigures.Click += new System.EventHandler(this.btnRegularFigures_Click);
            // 
            // btnComplexFigures
            // 
            this.btnComplexFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplexFigures.Location = new System.Drawing.Point(346, 54);
            this.btnComplexFigures.Name = "btnComplexFigures";
            this.btnComplexFigures.Size = new System.Drawing.Size(284, 138);
            this.btnComplexFigures.TabIndex = 1;
            this.btnComplexFigures.Text = "PROJEKT #3\r\nWybrane bryly złożone ";
            this.btnComplexFigures.UseVisualStyleBackColor = true;
            this.btnComplexFigures.Click += new System.EventHandler(this.btnComplexFigures_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 249);
            this.Controls.Add(this.btnComplexFigures);
            this.Controls.Add(this.btnRegularFigures);
            this.MaximumSize = new System.Drawing.Size(679, 305);
            this.MinimumSize = new System.Drawing.Size(679, 305);
            this.Name = "mainForm";
            this.Text = "Wizualizacja bryl geometrycznych";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegularFigures;
        private System.Windows.Forms.Button btnComplexFigures;
    }
}

