﻿
namespace Project3_MykhailoKravchenko58603
{
    partial class Project3
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
            this.components = new System.ComponentModel.Container();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.nudNrOfFigureSlide = new System.Windows.Forms.NumericUpDown();
            this.btnSlideOFF = new System.Windows.Forms.Button();
            this.btnSlideON = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.cbFigureType = new System.Windows.Forms.ComboBox();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeleteChosenFigure = new System.Windows.Forms.Button();
            this.nudNrOfFigureDelete = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPromien = new System.Windows.Forms.RadioButton();
            this.rbObetosc = new System.Windows.Forms.RadioButton();
            this.rbPole = new System.Windows.Forms.RadioButton();
            this.rbWysokosc = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRandomLocation = new System.Windows.Forms.Button();
            this.btnRandomAtributes = new System.Windows.Forms.Button();
            this.btnTurnRight = new System.Windows.Forms.Button();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnAddNewFigure = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudSlopeAngle = new System.Windows.Forms.NumericUpDown();
            this.nudPolygonDegree = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFigureRadius = new System.Windows.Forms.TrackBar();
            this.tbFigureHeight = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureSlide)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureDelete)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlopeAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPowrot
            // 
            this.btnPowrot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowrot.Location = new System.Drawing.Point(999, 458);
            this.btnPowrot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(92, 25);
            this.btnPowrot.TabIndex = 0;
            this.btnPowrot.Text = "powrót";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRysownica.Location = new System.Drawing.Point(172, 39);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(780, 444);
            this.pbRysownica.TabIndex = 1;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.nudNrOfFigureSlide);
            this.groupBox1.Controls.Add(this.btnSlideOFF);
            this.groupBox1.Controls.Add(this.btnSlideON);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(962, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(160, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slajder";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(132, 140);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 21);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(6, 140);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(20, 22);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // nudNrOfFigureSlide
            // 
            this.nudNrOfFigureSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNrOfFigureSlide.Location = new System.Drawing.Point(26, 141);
            this.nudNrOfFigureSlide.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.nudNrOfFigureSlide.Name = "nudNrOfFigureSlide";
            this.nudNrOfFigureSlide.ReadOnly = true;
            this.nudNrOfFigureSlide.Size = new System.Drawing.Size(106, 23);
            this.nudNrOfFigureSlide.TabIndex = 3;
            this.nudNrOfFigureSlide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNrOfFigureSlide.ValueChanged += new System.EventHandler(this.nudNrOfFigureSlide_ValueChanged);
            // 
            // btnSlideOFF
            // 
            this.btnSlideOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSlideOFF.Location = new System.Drawing.Point(6, 166);
            this.btnSlideOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlideOFF.Name = "btnSlideOFF";
            this.btnSlideOFF.Size = new System.Drawing.Size(145, 27);
            this.btnSlideOFF.TabIndex = 2;
            this.btnSlideOFF.Text = "Wylącz";
            this.btnSlideOFF.UseVisualStyleBackColor = true;
            this.btnSlideOFF.Click += new System.EventHandler(this.btnSlideOFF_Click);
            // 
            // btnSlideON
            // 
            this.btnSlideON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSlideON.Location = new System.Drawing.Point(6, 106);
            this.btnSlideON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlideON.Name = "btnSlideON";
            this.btnSlideON.Size = new System.Drawing.Size(145, 28);
            this.btnSlideON.TabIndex = 1;
            this.btnSlideON.Text = "Wlącz";
            this.btnSlideON.UseVisualStyleBackColor = true;
            this.btnSlideON.Click += new System.EventHandler(this.btnSlideON_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.rbAuto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(145, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tryb pokazu";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(6, 46);
            this.rbManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(90, 21);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manualny";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(6, 21);
            this.rbAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(117, 21);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automatyczny";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // cbFigureType
            // 
            this.cbFigureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFigureType.FormattingEnabled = true;
            this.cbFigureType.Items.AddRange(new object[] {
            "Walec",
            "Stożek",
            "Stożek pochiliony",
            "Kula",
            "Graniastoslup",
            "Ostoslup",
            "Dwa ostroslupy o wspolnej podstawie",
            "Walec Pochiliony",
            "Ostroslup sciety"});
            this.cbFigureType.Location = new System.Drawing.Point(5, 37);
            this.cbFigureType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFigureType.Name = "cbFigureType";
            this.cbFigureType.Size = new System.Drawing.Size(151, 24);
            this.cbFigureType.TabIndex = 3;
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteFirst.Location = new System.Drawing.Point(-1, 121);
            this.btnDeleteFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(145, 25);
            this.btnDeleteFirst.TabIndex = 4;
            this.btnDeleteFirst.Text = "Usun pierwszą brylę";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(0, 150);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "Usun ostatnią brylę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDeleteChosenFigure
            // 
            this.btnDeleteChosenFigure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteChosenFigure.Location = new System.Drawing.Point(-1, 179);
            this.btnDeleteChosenFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteChosenFigure.Name = "btnDeleteChosenFigure";
            this.btnDeleteChosenFigure.Size = new System.Drawing.Size(102, 25);
            this.btnDeleteChosenFigure.TabIndex = 6;
            this.btnDeleteChosenFigure.Text = "Usun wybraną brylę";
            this.btnDeleteChosenFigure.UseVisualStyleBackColor = true;
            this.btnDeleteChosenFigure.Click += new System.EventHandler(this.btnDeleteChosenFigure_Click);
            // 
            // nudNrOfFigureDelete
            // 
            this.nudNrOfFigureDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudNrOfFigureDelete.Location = new System.Drawing.Point(107, 183);
            this.nudNrOfFigureDelete.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.nudNrOfFigureDelete.Name = "nudNrOfFigureDelete";
            this.nudNrOfFigureDelete.ReadOnly = true;
            this.nudNrOfFigureDelete.Size = new System.Drawing.Size(45, 21);
            this.nudNrOfFigureDelete.TabIndex = 6;
            this.nudNrOfFigureDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNrOfFigureDelete.ValueChanged += new System.EventHandler(this.nudNrOfFigureDelete_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rbPromien);
            this.groupBox3.Controls.Add(this.rbObetosc);
            this.groupBox3.Controls.Add(this.nudNrOfFigureDelete);
            this.groupBox3.Controls.Add(this.rbPole);
            this.groupBox3.Controls.Add(this.btnDeleteChosenFigure);
            this.groupBox3.Controls.Add(this.rbWysokosc);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btnDeleteFirst);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(962, 236);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(160, 216);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kriteria pokazu bryl";
            // 
            // rbPromien
            // 
            this.rbPromien.AutoSize = true;
            this.rbPromien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPromien.Location = new System.Drawing.Point(6, 45);
            this.rbPromien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPromien.Name = "rbPromien";
            this.rbPromien.Size = new System.Drawing.Size(81, 21);
            this.rbPromien.TabIndex = 3;
            this.rbPromien.TabStop = true;
            this.rbPromien.Text = "Promień";
            this.rbPromien.UseVisualStyleBackColor = true;
            this.rbPromien.CheckedChanged += new System.EventHandler(this.rbPromien_CheckedChanged);
            // 
            // rbObetosc
            // 
            this.rbObetosc.AutoSize = true;
            this.rbObetosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbObetosc.Location = new System.Drawing.Point(6, 69);
            this.rbObetosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbObetosc.Name = "rbObetosc";
            this.rbObetosc.Size = new System.Drawing.Size(82, 21);
            this.rbObetosc.TabIndex = 2;
            this.rbObetosc.TabStop = true;
            this.rbObetosc.Text = "Obętość";
            this.rbObetosc.UseVisualStyleBackColor = true;
            this.rbObetosc.CheckedChanged += new System.EventHandler(this.rbObetosc_CheckedChanged);
            // 
            // rbPole
            // 
            this.rbPole.AutoSize = true;
            this.rbPole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPole.Location = new System.Drawing.Point(6, 93);
            this.rbPole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPole.Name = "rbPole";
            this.rbPole.Size = new System.Drawing.Size(135, 21);
            this.rbPole.TabIndex = 1;
            this.rbPole.TabStop = true;
            this.rbPole.Text = "Pole powierzchni";
            this.rbPole.UseVisualStyleBackColor = true;
            this.rbPole.CheckedChanged += new System.EventHandler(this.rbPole_CheckedChanged);
            // 
            // rbWysokosc
            // 
            this.rbWysokosc.AutoSize = true;
            this.rbWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbWysokosc.Location = new System.Drawing.Point(6, 21);
            this.rbWysokosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbWysokosc.Name = "rbWysokosc";
            this.rbWysokosc.Size = new System.Drawing.Size(93, 21);
            this.rbWysokosc.TabIndex = 0;
            this.rbWysokosc.TabStop = true;
            this.rbWysokosc.Text = "Wysokość\r\n";
            this.rbWysokosc.UseVisualStyleBackColor = true;
            this.rbWysokosc.CheckedChanged += new System.EventHandler(this.rbWysokosc_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRandomLocation);
            this.groupBox4.Controls.Add(this.btnRandomAtributes);
            this.groupBox4.Controls.Add(this.btnTurnRight);
            this.groupBox4.Controls.Add(this.btnTurnLeft);
            this.groupBox4.Controls.Add(this.btnAddNewFigure);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbFigureType);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(4, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(162, 443);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wykreslenie nowej bryly";
            // 
            // btnRandomLocation
            // 
            this.btnRandomLocation.Location = new System.Drawing.Point(0, 403);
            this.btnRandomLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandomLocation.Name = "btnRandomLocation";
            this.btnRandomLocation.Size = new System.Drawing.Size(162, 34);
            this.btnRandomLocation.TabIndex = 10;
            this.btnRandomLocation.Text = "Losuj położenie";
            this.btnRandomLocation.UseVisualStyleBackColor = true;
            this.btnRandomLocation.Click += new System.EventHandler(this.btnRandomLocation_Click);
            // 
            // btnRandomAtributes
            // 
            this.btnRandomAtributes.Location = new System.Drawing.Point(0, 365);
            this.btnRandomAtributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandomAtributes.Name = "btnRandomAtributes";
            this.btnRandomAtributes.Size = new System.Drawing.Size(162, 34);
            this.btnRandomAtributes.TabIndex = 9;
            this.btnRandomAtributes.Text = "Losuj atrybuty graficzne\r\n";
            this.btnRandomAtributes.UseVisualStyleBackColor = true;
            this.btnRandomAtributes.Click += new System.EventHandler(this.btnRandomAtributes_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.Location = new System.Drawing.Point(82, 321);
            this.btnTurnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(80, 39);
            this.btnTurnRight.TabIndex = 8;
            this.btnTurnRight.Text = "Obrót w prawo";
            this.btnTurnRight.UseVisualStyleBackColor = true;
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Location = new System.Drawing.Point(0, 321);
            this.btnTurnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(80, 39);
            this.btnTurnLeft.TabIndex = 7;
            this.btnTurnLeft.Text = "Obrót w lewo";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFigure
            // 
            this.btnAddNewFigure.Location = new System.Drawing.Point(0, 282);
            this.btnAddNewFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewFigure.Name = "btnAddNewFigure";
            this.btnAddNewFigure.Size = new System.Drawing.Size(162, 34);
            this.btnAddNewFigure.TabIndex = 6;
            this.btnAddNewFigure.Text = "Dodaj nową brylę";
            this.btnAddNewFigure.UseVisualStyleBackColor = true;
            this.btnAddNewFigure.Click += new System.EventHandler(this.btnAddNewFigure_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox5.Controls.Add(this.nudSlopeAngle);
            this.groupBox5.Controls.Add(this.nudPolygonDegree);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbFigureRadius);
            this.groupBox5.Controls.Add(this.tbFigureHeight);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(0, 82);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(162, 189);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cechy nowej bryly";
            // 
            // nudSlopeAngle
            // 
            this.nudSlopeAngle.Location = new System.Drawing.Point(9, 154);
            this.nudSlopeAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSlopeAngle.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.nudSlopeAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSlopeAngle.Name = "nudSlopeAngle";
            this.nudSlopeAngle.Size = new System.Drawing.Size(138, 21);
            this.nudSlopeAngle.TabIndex = 7;
            this.nudSlopeAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSlopeAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nudPolygonDegree
            // 
            this.nudPolygonDegree.Location = new System.Drawing.Point(9, 118);
            this.nudPolygonDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPolygonDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPolygonDegree.Name = "nudPolygonDegree";
            this.nudPolygonDegree.Size = new System.Drawing.Size(138, 21);
            this.nudPolygonDegree.TabIndex = 6;
            this.nudPolygonDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPolygonDegree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kąt nachilenia:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stopień wielokąta:";
            // 
            // tbFigureRadius
            // 
            this.tbFigureRadius.AutoSize = false;
            this.tbFigureRadius.Location = new System.Drawing.Point(5, 71);
            this.tbFigureRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFigureRadius.Maximum = 300;
            this.tbFigureRadius.Minimum = 50;
            this.tbFigureRadius.Name = "tbFigureRadius";
            this.tbFigureRadius.Size = new System.Drawing.Size(150, 18);
            this.tbFigureRadius.TabIndex = 3;
            this.tbFigureRadius.Value = 50;
            // 
            // tbFigureHeight
            // 
            this.tbFigureHeight.AutoSize = false;
            this.tbFigureHeight.Location = new System.Drawing.Point(5, 34);
            this.tbFigureHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFigureHeight.Maximum = 300;
            this.tbFigureHeight.Minimum = 50;
            this.tbFigureHeight.Name = "tbFigureHeight";
            this.tbFigureHeight.Size = new System.Drawing.Size(150, 18);
            this.tbFigureHeight.TabIndex = 2;
            this.tbFigureHeight.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Promień bryły:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wysokość bryły:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz typ bryły:";
            // 
            // turnTimer
            // 
            this.turnTimer.Enabled = true;
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 2000;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // Project3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 494);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnPowrot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Project3";
            this.Text = "Wybrane bryly zlozone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Project3_FormClosed);
            this.Resize += new System.EventHandler(this.Project3_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureSlide)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureDelete)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlopeAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSlideOFF;
        private System.Windows.Forms.Button btnSlideON;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.ComboBox cbFigureType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.NumericUpDown nudNrOfFigureSlide;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteChosenFigure;
        private System.Windows.Forms.NumericUpDown nudNrOfFigureDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPromien;
        private System.Windows.Forms.RadioButton rbObetosc;
        private System.Windows.Forms.RadioButton rbPole;
        private System.Windows.Forms.RadioButton rbWysokosc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRandomLocation;
        private System.Windows.Forms.Button btnRandomAtributes;
        private System.Windows.Forms.Button btnTurnRight;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnAddNewFigure;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudSlopeAngle;
        private System.Windows.Forms.NumericUpDown nudPolygonDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbFigureRadius;
        private System.Windows.Forms.TrackBar tbFigureHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Timer slideTimer;
    }
}