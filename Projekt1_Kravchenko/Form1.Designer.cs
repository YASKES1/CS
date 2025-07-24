namespace Projekt1_Kravchenko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Zakładki = new System.Windows.Forms.TabControl();
            this.Pulpit = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DziałanieNaMacierach = new System.Windows.Forms.TabPage();
            this.AB = new System.Windows.Forms.DataGridView();
            this.B_minus_A = new System.Windows.Forms.DataGridView();
            this.A_minus_B = new System.Windows.Forms.DataGridView();
            this.A_plus_B = new System.Windows.Forms.DataGridView();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dgvMacierzB = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvMacierzA = new System.Windows.Forms.DataGridView();
            this.txtLiczbaKolumn = new System.Windows.Forms.TextBox();
            this.txtLiczbaWierszy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DziałanieNaLliczbachZespołonych = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Zakładki.SuspendLayout();
            this.Pulpit.SuspendLayout();
            this.DziałanieNaMacierach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_minus_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_minus_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_plus_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacierzB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacierzA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Zakładki
            // 
            this.Zakładki.Controls.Add(this.Pulpit);
            this.Zakładki.Controls.Add(this.DziałanieNaMacierach);
            this.Zakładki.Controls.Add(this.DziałanieNaLliczbachZespołonych);
            this.Zakładki.Location = new System.Drawing.Point(0, 0);
            this.Zakładki.Name = "Zakładki";
            this.Zakładki.SelectedIndex = 0;
            this.Zakładki.Size = new System.Drawing.Size(847, 543);
            this.Zakładki.TabIndex = 0;
            // 
            // Pulpit
            // 
            this.Pulpit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Pulpit.Controls.Add(this.button2);
            this.Pulpit.Controls.Add(this.button1);
            this.Pulpit.Controls.Add(this.label1);
            this.Pulpit.Location = new System.Drawing.Point(4, 29);
            this.Pulpit.Name = "Pulpit";
            this.Pulpit.Padding = new System.Windows.Forms.Padding(3);
            this.Pulpit.Size = new System.Drawing.Size(839, 510);
            this.Pulpit.TabIndex = 0;
            this.Pulpit.Text = "Pulpit";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(443, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kalkulator obliczeń na liczbach \r\nzespolonych";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(168, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kalkulator obliczeń na\r\nmacierzach\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przeciązanie metod i operatorów\r\n                   w języku C#";
            // 
            // DziałanieNaMacierach
            // 
            this.DziałanieNaMacierach.BackColor = System.Drawing.Color.IndianRed;
            this.DziałanieNaMacierach.Controls.Add(this.AB);
            this.DziałanieNaMacierach.Controls.Add(this.B_minus_A);
            this.DziałanieNaMacierach.Controls.Add(this.A_minus_B);
            this.DziałanieNaMacierach.Controls.Add(this.A_plus_B);
            this.DziałanieNaMacierach.Controls.Add(this.button15);
            this.DziałanieNaMacierach.Controls.Add(this.button14);
            this.DziałanieNaMacierach.Controls.Add(this.button13);
            this.DziałanieNaMacierach.Controls.Add(this.button12);
            this.DziałanieNaMacierach.Controls.Add(this.button11);
            this.DziałanieNaMacierach.Controls.Add(this.button10);
            this.DziałanieNaMacierach.Controls.Add(this.dgvMacierzB);
            this.DziałanieNaMacierach.Controls.Add(this.button7);
            this.DziałanieNaMacierach.Controls.Add(this.button8);
            this.DziałanieNaMacierach.Controls.Add(this.button9);
            this.DziałanieNaMacierach.Controls.Add(this.button6);
            this.DziałanieNaMacierach.Controls.Add(this.button5);
            this.DziałanieNaMacierach.Controls.Add(this.dgvMacierzA);
            this.DziałanieNaMacierach.Controls.Add(this.txtLiczbaKolumn);
            this.DziałanieNaMacierach.Controls.Add(this.txtLiczbaWierszy);
            this.DziałanieNaMacierach.Controls.Add(this.label3);
            this.DziałanieNaMacierach.Controls.Add(this.label2);
            this.DziałanieNaMacierach.Controls.Add(this.button4);
            this.DziałanieNaMacierach.Controls.Add(this.button3);
            this.DziałanieNaMacierach.Location = new System.Drawing.Point(4, 29);
            this.DziałanieNaMacierach.Name = "DziałanieNaMacierach";
            this.DziałanieNaMacierach.Padding = new System.Windows.Forms.Padding(3);
            this.DziałanieNaMacierach.Size = new System.Drawing.Size(839, 510);
            this.DziałanieNaMacierach.TabIndex = 1;
            this.DziałanieNaMacierach.Text = "Działanie na macierach";
            // 
            // AB
            // 
            this.AB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AB.Location = new System.Drawing.Point(523, 6);
            this.AB.Name = "AB";
            this.AB.RowHeadersWidth = 51;
            this.AB.RowTemplate.Height = 29;
            this.AB.Size = new System.Drawing.Size(300, 188);
            this.AB.TabIndex = 22;
            this.AB.Visible = false;
            // 
            // B_minus_A
            // 
            this.B_minus_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_minus_A.Location = new System.Drawing.Point(523, 208);
            this.B_minus_A.Name = "B_minus_A";
            this.B_minus_A.RowHeadersWidth = 51;
            this.B_minus_A.RowTemplate.Height = 29;
            this.B_minus_A.Size = new System.Drawing.Size(300, 188);
            this.B_minus_A.TabIndex = 21;
            this.B_minus_A.Visible = false;
            // 
            // A_minus_B
            // 
            this.A_minus_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_minus_B.Location = new System.Drawing.Point(206, 208);
            this.A_minus_B.Name = "A_minus_B";
            this.A_minus_B.RowHeadersWidth = 51;
            this.A_minus_B.RowTemplate.Height = 29;
            this.A_minus_B.Size = new System.Drawing.Size(300, 188);
            this.A_minus_B.TabIndex = 20;
            this.A_minus_B.Visible = false;
            // 
            // A_plus_B
            // 
            this.A_plus_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_plus_B.Location = new System.Drawing.Point(206, 6);
            this.A_plus_B.Name = "A_plus_B";
            this.A_plus_B.RowHeadersWidth = 51;
            this.A_plus_B.RowTemplate.Height = 29;
            this.A_plus_B.Size = new System.Drawing.Size(300, 188);
            this.A_plus_B.TabIndex = 19;
            this.A_plus_B.Visible = false;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(15, 402);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(113, 29);
            this.button15.TabIndex = 18;
            this.button15.Text = "B = 0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(15, 367);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(113, 29);
            this.button14.TabIndex = 17;
            this.button14.Text = "A = 0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(15, 330);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 29);
            this.button13.TabIndex = 16;
            this.button13.Text = "C = A * B";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(15, 295);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(113, 29);
            this.button12.TabIndex = 15;
            this.button12.Text = "C = B - A";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(15, 260);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 29);
            this.button11.TabIndex = 14;
            this.button11.Text = "C = A - B";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(15, 225);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 29);
            this.button10.TabIndex = 13;
            this.button10.Text = "C = A + B";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvMacierzB
            // 
            this.dgvMacierzB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacierzB.Location = new System.Drawing.Point(211, 255);
            this.dgvMacierzB.Name = "dgvMacierzB";
            this.dgvMacierzB.RowHeadersWidth = 51;
            this.dgvMacierzB.RowTemplate.Height = 29;
            this.dgvMacierzB.Size = new System.Drawing.Size(362, 243);
            this.dgvMacierzB.TabIndex = 12;
            this.dgvMacierzB.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(579, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 52);
            this.button7.TabIndex = 11;
            this.button7.Text = "Akceptacja wartości elementów\r\nmacierzy B";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(579, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(244, 67);
            this.button8.TabIndex = 10;
            this.button8.Text = "Wygeneruj wartości (losowo)\r\nelementów macierzy B\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(579, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(244, 52);
            this.button9.TabIndex = 9;
            this.button9.Text = "Utworz kontrolkę \r\nDataGridView dla macierzy B";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(579, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(244, 52);
            this.button6.TabIndex = 8;
            this.button6.Text = "Akceptacja wartości elementów\r\nmacierzy A";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(579, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 67);
            this.button5.TabIndex = 7;
            this.button5.Text = "Wygeneruj wartości (losowo)\r\nelementów macierzy A\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvMacierzA
            // 
            this.dgvMacierzA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacierzA.Location = new System.Drawing.Point(211, 6);
            this.dgvMacierzA.Name = "dgvMacierzA";
            this.dgvMacierzA.RowHeadersWidth = 51;
            this.dgvMacierzA.RowTemplate.Height = 29;
            this.dgvMacierzA.Size = new System.Drawing.Size(362, 243);
            this.dgvMacierzA.TabIndex = 6;
            this.dgvMacierzA.Visible = false;
            // 
            // txtLiczbaKolumn
            // 
            this.txtLiczbaKolumn.Location = new System.Drawing.Point(3, 180);
            this.txtLiczbaKolumn.Name = "txtLiczbaKolumn";
            this.txtLiczbaKolumn.Size = new System.Drawing.Size(125, 27);
            this.txtLiczbaKolumn.TabIndex = 5;
            // 
            // txtLiczbaWierszy
            // 
            this.txtLiczbaWierszy.Location = new System.Drawing.Point(3, 104);
            this.txtLiczbaWierszy.Name = "txtLiczbaWierszy";
            this.txtLiczbaWierszy.Size = new System.Drawing.Size(125, 27);
            this.txtLiczbaWierszy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liczba kolumn macierzy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba wierszy macierzy";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(579, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 52);
            this.button4.TabIndex = 1;
            this.button4.Text = "Utworz kontrolkę \r\nDataGridView dla macierzy A";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "powrót";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DziałanieNaLliczbachZespołonych
            // 
            this.DziałanieNaLliczbachZespołonych.BackColor = System.Drawing.Color.Silver;
            this.DziałanieNaLliczbachZespołonych.Location = new System.Drawing.Point(4, 29);
            this.DziałanieNaLliczbachZespołonych.Name = "DziałanieNaLliczbachZespołonych";
            this.DziałanieNaLliczbachZespołonych.Size = new System.Drawing.Size(839, 510);
            this.DziałanieNaLliczbachZespołonych.TabIndex = 2;
            this.DziałanieNaLliczbachZespołonych.Text = "Działanie na liczbach zespołonych";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 534);
            this.Controls.Add(this.Zakładki);
            this.Name = "Form1";
            this.Text = "Projekt1_Kravchenko58603";
            this.Zakładki.ResumeLayout(false);
            this.Pulpit.ResumeLayout(false);
            this.Pulpit.PerformLayout();
            this.DziałanieNaMacierach.ResumeLayout(false);
            this.DziałanieNaMacierach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_minus_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_minus_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_plus_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacierzB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacierzA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Zakładki;
        private TabPage Pulpit;
        private TabPage DziałanieNaMacierach;
        private TabPage DziałanieNaLliczbachZespołonych;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button4;
        private ErrorProvider errorProvider1;
        private TextBox txtLiczbaKolumn;
        private TextBox txtLiczbaWierszy;
        private Label label3;
        private Label label2;
        private DataGridView dgvMacierzA;
        private Button button5;
        private Button button6;
        private DataGridView dgvMacierzB;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private DataGridView B_minus_A;
        private DataGridView A_minus_B;
        private DataGridView A_plus_B;
        private DataGridView AB;
    }
}