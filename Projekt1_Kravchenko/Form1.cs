namespace Projekt1_Kravchenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const ushort mkOdstęp = 10;
        const ushort mkSzerokośćKolumny = 70;
        const ushort mkWysokośćWierza = 25;
        const int mkDolnaGranicaPrzedziału = 10;
        const int mkGórnaGranicaPrzeziału = 100;
        const double mkDolnaGranicaPrzedziałuDouble = 200.0;
        const double mkGórnaGranicaPrzedziałuDouble = 800.0;

        bool[] mkStanStronZakładki = { true, false, false };

        Macierz mkA;
        Macierz mkB;
        Macierz mkC;

        

        

        private void Zakładki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Zakładki.TabPages[0])
            {
                if (mkStanStronZakładki[0])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = Pulpit;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.TabPage == Zakładki.TabPages[1])
            {
                if (mkStanStronZakładki[1])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = DziałanieNaMacierach;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.TabPage == Zakładki.TabPages[2])
            {
                if (mkStanStronZakładki[2])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = DziałanieNaLliczbachZespołonych;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mkStanStronZakładki[0] = false;
            mkStanStronZakładki[1] = true;
            Zakładki.SelectedTab = DziałanieNaMacierach;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkStanStronZakładki[0] = false;
            mkStanStronZakładki[2] = true;
            Zakładki.SelectedTab = DziałanieNaLliczbachZespołonych;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mkStanStronZakładki[1] = false;
            mkStanStronZakładki[0] = true;
            Zakładki.SelectedTab = Pulpit;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ushort mkLiczbaWierszyMacierzy;
            ushort mkLiczbaKolumnMacierzy;

            errorProvider1.Dispose();

            if (!ushort.TryParse(txtLiczbaWierszy.Text, out mkLiczbaWierszyMacierzy))
            {
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }

            if (!ushort.TryParse(txtLiczbaKolumn.Text, out mkLiczbaKolumnMacierzy))
            {
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby kolumn macierzy");
                return;
            }


            dgvMacierzA.Visible = true;

            dgvMacierzA.ColumnCount = mkLiczbaKolumnMacierzy;
            dgvMacierzA.ColumnHeadersVisible = true;
            dgvMacierzA.ReadOnly = false;
            dgvMacierzA.AllowUserToAddRows = false;
            dgvMacierzA.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMacierzA.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            dgvMacierzA.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dgvMacierzA.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort i = 0; i < mkLiczbaKolumnMacierzy; i++)
            {
                dgvMacierzA.Columns[i].HeaderText =  "(" + i + ")";
                dgvMacierzA.Columns[i].Width = mkSzerokośćKolumny;

                dgvMacierzA.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  

            }

            for (ushort i = 0; i < mkLiczbaWierszyMacierzy; i++)
            {
                dgvMacierzA.Rows.Add();
            }

            for (ushort i = 0; i < mkLiczbaWierszyMacierzy; i++)
            {
                dgvMacierzA.Rows[i].HeaderCell.Value = "(" + i + ")";
            }

            dgvMacierzA.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            button4.Enabled = false;

            mkA = new Macierz(mkLiczbaWierszyMacierzy, mkLiczbaKolumnMacierzy);
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random mkrnd = new Random();
            for (ushort mki = 0; mki < dgvMacierzA.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < dgvMacierzA.Columns.Count; mkj++)
                {
                    int mkx = mkrnd.Next(mkDolnaGranicaPrzedziału, mkGórnaGranicaPrzeziału);
                    dgvMacierzA.Rows[mki].Cells[mkj].Value = mkx;
                    mkA[mki, mkj] = mkx;
                }
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            for (ushort mki = 0; mki < dgvMacierzA.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < dgvMacierzA.Columns.Count; mkj++)
                {
                    if (dgvMacierzA.Rows[mki].Cells[mkj].Value is null)
                    {
                        MessageBox.Show("dgvMacierzA.Rows[i].Cells[j].Value is null");
                        errorProvider1.SetError(button6, "ERROR: wszystkie komórki DataGridView dla macierzy A muszą być wypełnione wartości jej elementów");
                        return;

                    }
                    
                }
            }
            dgvMacierzA.ReadOnly = true;
            dgvMacierzA.Enabled = false;
            button6.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ushort mkLiczbaWierszyMacierzy;
            ushort mkLiczbaKolumnMacierzy;

            errorProvider1.Dispose();

            if (!ushort.TryParse(txtLiczbaWierszy.Text, out mkLiczbaWierszyMacierzy))
            {
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }

            if (!ushort.TryParse(txtLiczbaKolumn.Text, out mkLiczbaKolumnMacierzy))
            {
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby kolumn macierzy");
                return;
            }

            dgvMacierzB.Visible = true;
            
            dgvMacierzB.ColumnCount = mkLiczbaKolumnMacierzy;
            dgvMacierzB.ColumnHeadersVisible = true;
            dgvMacierzB.ReadOnly = false;
            dgvMacierzB.AllowUserToAddRows = false;
            dgvMacierzB.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMacierzB.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            dgvMacierzB.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dgvMacierzB.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort mki = 0; mki < mkLiczbaKolumnMacierzy; mki++)
            {
                dgvMacierzB.Columns[mki].HeaderText = "(" + mki + ")";
                dgvMacierzB.Columns[mki].Width = mkSzerokośćKolumny;

                dgvMacierzB.Columns[mki].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            for (ushort mki = 0; mki < mkLiczbaWierszyMacierzy; mki++)
            {
                dgvMacierzB.Rows.Add();
            }

            for (ushort mki = 0; mki < mkLiczbaWierszyMacierzy; mki++)
            {
                dgvMacierzB.Rows[mki].HeaderCell.Value = "(" + mki + ")";
            }

            dgvMacierzB.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            button9.Enabled = false;

            mkB = new Macierz(mkLiczbaWierszyMacierzy, mkLiczbaKolumnMacierzy);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random mkrnd = new Random();
            for (ushort mki = 0; mki < dgvMacierzB.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < dgvMacierzB.Columns.Count; mkj++)
                {
                    int mkx = mkrnd.Next(mkDolnaGranicaPrzedziału, mkGórnaGranicaPrzeziału);
                    dgvMacierzB.Rows[mki].Cells[mkj].Value = mkx;
                    mkB[mki, mkj] = mkx;
                }
            }
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            for (ushort mki = 0; mki < dgvMacierzB.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < dgvMacierzB.Columns.Count; mkj++)
                {
                    if (dgvMacierzB.Rows[mki].Cells[mkj].Value is null)
                    {
                        MessageBox.Show("dgvMacierzA.Rows[i].Cells[j].Value is null");
                        errorProvider1.SetError(button7, "ERROR: wszystkie komórki DataGridView dla macierzy A muszą być wypełnione wartości jej elementów");
                        return;

                    }
                }
            }
            dgvMacierzB.ReadOnly = true;
            dgvMacierzB.Enabled = false;
            button7.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mkC = mkA + mkB;
            
            A_plus_B.Visible = true;
            A_plus_B.ColumnCount = mkC.LiczbaKolumn;

            A_plus_B.ColumnHeadersVisible = true;
            A_plus_B.ReadOnly = false;
            A_plus_B.AllowUserToAddRows = false;
            A_plus_B.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            A_plus_B.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            A_plus_B.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            A_plus_B.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort mki = 0; mki < mkC.LiczbaKolumn; mki++)
            {
                A_plus_B.Columns[mki].HeaderText = "(" + mki + ")";
                A_plus_B.Columns[mki].Width = mkSzerokośćKolumny;

                A_plus_B.Columns[mki].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                A_plus_B.Rows.Add();
            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                A_plus_B.Rows[mki].HeaderCell.Value = "(" + mki + ")";
            }

            A_plus_B.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            A_plus_B.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (ushort mki = 0; mki < A_plus_B.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < A_plus_B.Columns.Count; mkj++)
                {

                    A_plus_B.Rows[mki].Cells[mkj].Value = mkC[mki, mkj];
                    
                }
            }
            button10.Enabled = false;
            dgvMacierzA.Visible = false;
            dgvMacierzB.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mkC = mkA - mkB;

            A_minus_B.Visible = true;
            A_minus_B.ColumnCount = mkC.LiczbaKolumn;

            A_minus_B.ColumnHeadersVisible = true;
            A_minus_B.ReadOnly = false;
            A_minus_B.AllowUserToAddRows = false;
            A_minus_B.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            A_minus_B.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            A_minus_B.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            A_minus_B.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort mki = 0; mki < mkC.LiczbaKolumn; mki++)
            {
                A_minus_B.Columns[mki].HeaderText = "(" + mki + ")";
                A_minus_B.Columns[mki].Width = mkSzerokośćKolumny;

                A_minus_B.Columns[mki].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                A_minus_B.Rows.Add();
            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                A_minus_B.Rows[mki].HeaderCell.Value = "(" + mki + ")";
            }

            A_minus_B.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            A_minus_B.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (ushort mki = 0; mki < A_minus_B.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < A_minus_B.Columns.Count; mkj++)
                {

                    A_minus_B.Rows[mki].Cells[mkj].Value = mkC[mki, mkj];

                }
            }
            button11.Enabled = false;
            dgvMacierzA.Visible = false;
            dgvMacierzB.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mkC = mkB - mkA;

            B_minus_A.Visible = true;
            B_minus_A.ColumnCount = mkC.LiczbaKolumn;

            B_minus_A.ColumnHeadersVisible = true;
            B_minus_A.ReadOnly = false;
            B_minus_A.AllowUserToAddRows = false;
            B_minus_A.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            B_minus_A.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            B_minus_A.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            B_minus_A.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort mki = 0; mki < mkC.LiczbaKolumn; mki++)
            {
                B_minus_A.Columns[mki].HeaderText = "(" + mki + ")";
                B_minus_A.Columns[mki].Width = mkSzerokośćKolumny;

                B_minus_A.Columns[mki].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                B_minus_A.Rows.Add();
            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                B_minus_A.Rows[mki].HeaderCell.Value = "(" + mki + ")";
            }

            B_minus_A.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            B_minus_A.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (ushort mki = 0; mki < B_minus_A.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < B_minus_A.Columns.Count; mkj++)
                {

                    B_minus_A.Rows[mki].Cells[mkj].Value = mkC[mki, mkj];

                }
            }
            button12.Enabled = false;
            dgvMacierzA.Visible = false;
            dgvMacierzB.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mkC = mkA * mkB;

            AB.Visible = true;
            AB.ColumnCount = mkC.LiczbaKolumn;

            AB.ColumnHeadersVisible = true;
            AB.ReadOnly = false;
            AB.AllowUserToAddRows = false;
            AB.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AB.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "   "
            };

            AB.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;
            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            AB.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort mki = 0; mki < mkC.LiczbaKolumn; mki++)
            {
                AB.Columns[mki].HeaderText = "(" + mki + ")";
                AB.Columns[mki].Width = mkSzerokośćKolumny;

                AB.Columns[mki].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                AB.Rows.Add();
            }

            for (ushort mki = 0; mki < mkC.LiczbaWierszy; mki++)
            {
                AB.Rows[mki].HeaderCell.Value = "(" + mki + ")";
            }

            AB.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            AB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (ushort mki = 0; mki < AB.Rows.Count; mki++)
            {
                for (ushort mkj = 0; mkj < AB.Columns.Count; mkj++)
                {

                    AB.Rows[mki].Cells[mkj].Value = mkC[mki, mkj];

                }
            }
            button13.Enabled = false;
            dgvMacierzA.Visible = false;
            dgvMacierzB.Visible = false;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mkA = new Macierz(0, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mkB = new Macierz(0, 0);
        }
    }
}