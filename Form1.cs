using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    

    public partial class Projekt2 : Form
    {
        //deklaracje stałych pomocniczych
        const ushort Odstęp = 10;
        const ushort SzerokośćKolumny = 70;
        const ushort WysokośćWiersza = 25;
        const int DolnaGranicaPrzedziału = 10;
        const int GórnaGranicaPrzedziału = 100;
        const double DolnaGranicaPrzedziałuDouble = 200.0;
        const double GórnaGranicaPrzedziałuDouble = 800.0;
        //deklaracja pomocniczej tablicy opisującej stan aktywności  zakładek
        bool[] StanStronZakładki = { true, false, false };
        //deklaracje zmiennych referencyjnych kontrolek dodawanych do formularza w czasie działania programu
        DataGridView dgvMacierzA;
        DataGridView dgvMacierzB;
        DataGridView dgvMacierzC;
        const short Margines = 20;
        //deklaracje zmiennych referencyjnych do klasy macierzy
        Macierz A;
        Macierz B;
        Macierz C;
        // C = A + B
        //deklaracje zmiennych pomocniczych
        LiczbyZespolone ZespolonaA = new LiczbyZespolone(0, 0);
        LiczbyZespolone ZespolonaB = new LiczbyZespolone(0, 0);
        
        public Projekt2()
        {
            InitializeComponent();
            //ustawienie strony Kokpit jako strony otwartej (aktywnej) 
            Zakładki.SelectedTab = tabPageKokpit;
            //ustalenie rozmiarów formularza i jego lewego narożnika            
        }

        private void Zakładki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //identyfikacja wybranej zakładki
            if (e.TabPage == Zakładki.TabPages[0])
                //sprawdzenie czy jest dozwolone przejście na zakładkę kokpit
                if (StanStronZakładki[0])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageKokpit;
                }
                else
                    e.Cancel = true;
            else
                if (e.TabPage == Zakładki.TabPages[1])
                //sprawdzenie czy jest dozwolone przejście na zakładkę macierzy
                if (StanStronZakładki[1])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageMacierze;
                }
                else
                    e.Cancel = true;
            else
            if (e.TabPage == Zakładki.TabPages[2])
                if (StanStronZakładki[2])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageLiczbyZespolone;
                }
            else
                e.Cancel = true;
        }

        private void btnOblMacierz_Click(object sender, EventArgs e)
        {
            //zmiana stanu zakładki kokpit
            StanStronZakładki[0] = false;
            //zezwolenie na przejście do zakładki działanie na macierzach
            StanStronZakładki[1] = true;
            //przejście do zakładki działanie na macierzach
            Zakładki.SelectedTab = tabPageMacierze;
        }

        private void btnOblZespolonych_Click(object sender, EventArgs e)
        {
            //zmiana stanu zakładki kokpit
            StanStronZakładki[0] = false;
            //zezwolenie na przejście do zakładki działanie na liczbach zespolonych
            StanStronZakładki[2] = true;
            //przejście do zakładki działanie na liczbach zespolonych
            Zakładki.SelectedTab = tabPageLiczbyZespolone;
        }

        private void btnDoKokpituzMacierz_Click(object sender, EventArgs e)
        {
            //zmiana stanu zakładki
            StanStronZakładki[1] = false;
            //zezwolenie na przejście do zakładki kokpit
            StanStronZakładki[0] = true;
            //realizacja przejścia do zakładki kokpit
            Zakładki.SelectedTab = tabPageKokpit;
        }

        private void btnDoKokpituzZespol_Click(object sender, EventArgs e)
        {
            //zmiana stanu zakładki
            StanStronZakładki[2] = false;
            //zezwolenie na przejście do zakładki kokpit
            StanStronZakładki[0] = true;
            //realizacja przejścia do zakładki kokpit
            Zakładki.SelectedTab = tabPageKokpit;
        }

        private void btnUtwórzDataGridViewA_Click(object sender, EventArgs e)
        {//deklaracje zmiennych dla przechowania rozmiaru
            ushort LiczbaWierszy, LiczbaKolumn;
            //zgaszenie kontrolki errorprovider
            errorProvider1.Dispose();
            //pobranie liczby wierszy
            if (!ushort.TryParse(txtLiczbaWierszy.Text, out LiczbaWierszy))
            {//był błąd
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //pobranie liczby kolumn macierzy
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out LiczbaKolumn))
            {//był błąd
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby kolumn");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //utworzenie egzemolarza kontrolki DataGridView dla macierzy A
            dgvMacierzA = new DataGridView();
            //sformatowanie kontrolki dgvMacierzA
            dgvMacierzA.Location = new Point(groupBox1.Location.X + groupBox1.Width + Odstęp, btnDoKokpituzMacierz.Top);
            dgvMacierzA.Size = new Size((LiczbaKolumn + 1) * SzerokośćKolumny, (LiczbaWierszy + 1) * WysokośćWiersza);
            //wpisanie liczby kolumn do kontrolki dgvMacierzA
            dgvMacierzA.ColumnCount = LiczbaKolumn;
            //odsłonięcie wiersza nagłówkowego (HEADER) dla kolumn
            dgvMacierzA.ColumnHeadersVisible = true;
            //umożliwienie wpisywania i odczytu danych w kontrolce dgvMacierzA
            dgvMacierzA.ReadOnly = false;
            //uniemożliwienie dodawania nowych wierszy w kontrolce dgvMacierzA
            dgvMacierzA.AllowUserToAddRows = false;
            //ustawienie trybu AutoSize dla wiersza nagłówkowego kolumn
            dgvMacierzA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożiwienie multiSelekt komórkowe w kontrolce
            dgvMacierzA.MultiSelect = false;
            //ustawienie formatu dla nagłówka kolumn kontrolki dgvMacierzA
            DataGridViewCellStyle StylHeaderKolumn = new DataGridViewCellStyle();
            StylHeaderKolumn.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumn.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumn.Format = "     ";
            //przypisanie StylHeaderKolumn do kontrolki dgvMacierzA
            dgvMacierzA.ColumnHeadersDefaultCellStyle = StylHeaderKolumn;
            //ustalenie formatu dla nagłówka wierszy kontrolki dgvMacierzA
            DataGridViewCellStyle StylHeaderWierszy = new DataGridViewCellStyle();
            StylHeaderWierszy.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWierszy.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie StylHeaderWierszy do kontroli dgvMacierzA
            dgvMacierzA.RowHeadersDefaultCellStyle = StylHeaderWierszy;
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaKolumn; i++)
            {
                //wpisanie nazwy kolumny: (i)
                dgvMacierzA.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzA.Columns[i].Width = SzerokośćKolumny;
                //wycentrowanie zapisów w kolumnie
                dgvMacierzA.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie do kontrolki dgvMacierzA odpowiedniej liczby wierszy
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzA.Rows.Add();
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzA.Rows[i].HeaderCell.Value = "(" + i + ")";

            //dodanie kontrolki dgvMacierzA do strony 1 zakładki
            Zakładki.TabPages[1].Controls.Add(dgvMacierzA);
            //ustawienie automatycznego AutoResize dla kontrolki dgvMacierzA
            dgvMacierzA.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ustawienie stanu braku aktywności dla przycisku poleceń
            btnUtwórzDataGridViewA.Enabled = false;
            //uaktywnienie następnych przycisków poleceń
            btnGenerujLosowoA.Enabled = true;
            btnAkcepWartościA.Enabled = true;
            btnUtwórzDataGridViewB.Enabled = true;
            btnGenerujLosowoA.Enabled = true;
            btnAkcepWartościA.Enabled = true;
            btnUtwórzDataGridViewB.Enabled = true;
        }

        private void btnGenerujLosowoA_Click(object sender, EventArgs e)
        {//deklaracja i utworzenie egzemplarza generatora liczb losowych
            Random rnd = new Random();
            //losowanie wartości elementów macierzy A i wpisywanie ich do kontrolki dgvMacierzA do odpowiedniej pozycji
            for (ushort i = 0; i < dgvMacierzA.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzA.Columns.Count; j++)
                    dgvMacierzA.Rows[i].Cells[j].Value = rnd.Next(DolnaGranicaPrzedziału, GórnaGranicaPrzedziału);
            //ustawienie stanu braku atywności dla obsługiwanego przycisku poleceń
            btnGenerujLosowoA.Enabled = false;

        }

        private void btnAkcepWartościA_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //sprawdzenie czy zostały wpisane wszystkie wartości elementów macierzy A
            for (ushort i = 0; i < dgvMacierzA.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzA.Columns.Count; j++)
                    if(dgvMacierzA.Rows[i].Cells[j].Value is null)
                    {//komórka (i, j) - ta jest pusta
                        errorProvider1.SetError(btnAkcepWartościA, "ERROR: wszystkie komórki DataGridView dla macierzy A muszą być wypełnione wartościami jej elementów");
                        //przerwanie dalszej obsługi przycisku poleceń btnAkcepWartościA
                        return;
                    }
            //ustawić tryb ReadOnly dla kontrolki dgvMacierzA
            dgvMacierzA.ReadOnly = true;
            dgvMacierzA.Enabled = false;
            //ustawienie stanu braku aktywności
            btnAkcepWartościA.Enabled = false;
        }

        private void btnUtwórzDataGridViewB_Click(object sender, EventArgs e)
        {
            //deklaracje zmiennych dla przechowania rozmiaru
            ushort LiczbaWierszy, LiczbaKolumn;
            //zgaszenie kontrolki errorprovider
            errorProvider1.Dispose();
            //pobranie liczby wierszy
            if (!ushort.TryParse(txtLiczbaWierszy.Text, out LiczbaWierszy))
            {//był błąd
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //pobranie liczby kolumn macierzy
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out LiczbaKolumn))
            {//był błąd
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby kolumn");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //utworzenie egzemplarza kontrolki DataGridView dla macierzy B
            dgvMacierzB = new DataGridView();
            //sformatowanie kontrolki dgvMacierzB
            dgvMacierzB.Location = new Point(dgvMacierzA.Left, dgvMacierzA.Top + dgvMacierzA.Height + 2 * Odstęp);
            //dgvMacierzB.Size = new Size((LiczbaKolumn + 1) * SzerokośćKolumny, (LiczbaWierszy + 1) * WysokośćWiersza);
            dgvMacierzB.Size = new Size(dgvMacierzA.Width, dgvMacierzA.Height);
            //wpisanie liczby kolumn do kontrolki dgvMacierzB
            dgvMacierzB.ColumnCount = LiczbaKolumn;
            //odsłonięcie wiersza nagłówkowego (HEADER) dla kolumn
            dgvMacierzB.ColumnHeadersVisible = true;
            //umożliwienie wpisywania i odczytu danych w kontrolce dgvMacierzB
            dgvMacierzB.ReadOnly = false;
            //uniemożliwienie dodawania nowych wierszy w kontrolce dgvMacierzB
            dgvMacierzB.AllowUserToAddRows = false;
            //ustawienie trybu AutoSize dla wiersza nagłówkowego kolumn
            dgvMacierzB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożiwienie multiSelekt komórkowe w kontrolce
            dgvMacierzB.MultiSelect = false;
            //ustawienie formatu dla nagłówka kolumn kontrolki dgvMacierzB
            DataGridViewCellStyle StylHeaderKolumn = new DataGridViewCellStyle();
            StylHeaderKolumn.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumn.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumn.Format = "     ";
            //przypisanie StylHeaderKolumn do kontrolki dgvMacierzB
            dgvMacierzB.ColumnHeadersDefaultCellStyle = StylHeaderKolumn;
            //ustalenie formatu dla nagłówka wierszy kontrolki dgvMacierzB
            DataGridViewCellStyle StylHeaderWierszy = new DataGridViewCellStyle();
            StylHeaderWierszy.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWierszy.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie StylHeaderWierszy do kontroli dgvMacierzB
            dgvMacierzB.RowHeadersDefaultCellStyle = StylHeaderWierszy;
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaKolumn; i++)
            {
                //wpisanie nazwy kolumny: (i)
                dgvMacierzB.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzB.Columns[i].Width = SzerokośćKolumny;
                //wycentrowanie zapisów w kolumnie
                dgvMacierzB.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie do kontrolki dgvMacierzB odpowiedniej liczby wierszy
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzB.Rows.Add();
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzB.Rows[i].HeaderCell.Value = "(" + i + ")";

            //dodanie kontrolki dgvMacierzB do strony 1 zakładki
            Zakładki.TabPages[1].Controls.Add(dgvMacierzB);
            //ustawienie automatycznego AutoResize dla kontrolki dgvMacierzB
            dgvMacierzB.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ustawienie stanu braku aktywności dla przycisku poleceń
            btnUtwórzDataGridViewB.Enabled = false;
            //uaktywnienie następnych przycisków poleceń
            btnGenerujLosowoB.Enabled = true;
            btnAkcepWartościB.Enabled = true;
        }

        private void btnGenerujLosowoB_Click(object sender, EventArgs e)
        {//deklaracja i utworzenie egzemplarza generatora liczb losowych
            Random rnd = new Random();
                for (ushort i = 0; i < dgvMacierzB.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzB.Columns.Count; j++)
                    dgvMacierzB.Rows[i].Cells[j].Value = string.Format("{0:F2}", rnd.NextDouble() * (GórnaGranicaPrzedziałuDouble - DolnaGranicaPrzedziałuDouble) + DolnaGranicaPrzedziałuDouble);
            //ustawienie w stan brkau aktywności obsługiwanego przycisku poleceń
            btnGenerujLosowoB.Enabled = false;
        }

        private void btnAkcepWartościB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            //sprawdzenie czy zostały wypełnione wszystkie komórki (pola) kontrolki dgvMacierzB
            for (ushort i = 0; i < dgvMacierzB.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzB.Columns.Count; j++)
                    if (dgvMacierzB.Rows[i].Cells[j].Value is null)
                    {
                        errorProvider1.SetError(btnAkcepWartościB, "ERROR: wszystkie pola (komórki) w kontrolce DataGridView muszą być wypełnione");
                        //przerwanie dalszej obsługi przycisku poleceń btnAkcepWartościB
                        return;
                    }
            //ustawienie stanu ReadOnly dla kontrolki dgvMacierzB
            dgvMacierzB.ReadOnly = true;
            dgvMacierzB.Enabled = false;
            //ustawienie stanu braku aktywności dla obsługiwanego przyscisku poleceń
            btnAkcepWartościB.Enabled = false;
        }

        private void btnSumaMacierzyAB_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy dane w kontrolkacg DataGridView zostały zaakceowane
            if (btnAkcepWartościA.Enabled || btnAkcepWartościB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAB, "ERROR: dane wkontrolkach DataGridView muszą być zaakceowane");
                //przerwanie dalszej obsługi przycisku poleceń btnSumaMacierzyAB
                return;
            }

            //sprawdzenie czy została umieszczona na formularzu kontrolka dla macierzy wynikowej
            if (dgvMacierzC is null)
            {
                UtwórzKontrolkę_dgvMacierzC();
            }
            //utworzenie egzemplarzy dla macierzy
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);           

            C = A + B;
            C.PrzepiszElementyMacierzyDoKontrolki(dgvMacierzC);
        }

        void UtwórzKontrolkę_dgvMacierzC()
        {
            //deklaracje zmiennych dla przechowania rozmiaru
            ushort LiczbaWierszy, LiczbaKolumn;
            //zgaszenie kontrolki errorprovider
            errorProvider1.Dispose();
            //pobranie liczby wierszy
            if (!ushort.TryParse(txtLiczbaWierszy.Text, out LiczbaWierszy))
            {//był błąd
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //pobranie liczby kolumn macierzy
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out LiczbaKolumn))
            {//był błąd
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby kolumn");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            //utworzenie egzemplarza kontrolki DataGridView dla macierzy B
            dgvMacierzC = new DataGridView();
            //sformatowanie kontrolki dgvMacierzC
            dgvMacierzC.Location = new Point(dgvMacierzB.Left, dgvMacierzB.Top + dgvMacierzB.Height + 2 * Odstęp);
            //dgvMacierzC.Size = new Size((LiczbaKolumn + 1) * SzerokośćKolumny, (LiczbaWierszy + 1) * WysokośćWiersza);
            dgvMacierzC.Size = new Size(dgvMacierzB.Width, dgvMacierzB.Height);
            //wpisanie liczby kolumn do kontrolki dgvMacierzC
            dgvMacierzC.ColumnCount = LiczbaKolumn;
            //odsłonięcie wiersza nagłówkowego (HEADER) dla kolumn
            dgvMacierzC.ColumnHeadersVisible = true;
            //umożliwienie wpisywania i odczytu danych w kontrolce dgvMacierzC
            dgvMacierzC.ReadOnly = false;
            //uniemożliwienie dodawania nowych wierszy w kontrolce dgvMacierzC
            dgvMacierzC.AllowUserToAddRows = false;
            //ustawienie trybu AutoSize dla wiersza nagłówkowego kolumn
            dgvMacierzC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożiwienie multiSelekt komórkowe w kontrolce
            dgvMacierzC.MultiSelect = false;
            //ustawienie formatu dla nagłówka kolumn kontrolki dgvMacierzC
            DataGridViewCellStyle StylHeaderKolumn = new DataGridViewCellStyle();
            StylHeaderKolumn.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumn.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumn.Format = "     ";
            //przypisanie StylHeaderKolumn do kontrolki dgvMacierzC
            dgvMacierzC.ColumnHeadersDefaultCellStyle = StylHeaderKolumn;
            //ustalenie formatu dla nagłówka wierszy kontrolki dgvMacierzC
            DataGridViewCellStyle StylHeaderWierszy = new DataGridViewCellStyle();
            StylHeaderWierszy.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWierszy.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie StylHeaderWierszy do kontroli dgvMacierzC
            dgvMacierzC.RowHeadersDefaultCellStyle = StylHeaderWierszy;
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaKolumn; i++)
            {
                //wpisanie nazwy kolumny: (i)
                dgvMacierzC.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzC.Columns[i].Width = SzerokośćKolumny;
                //wycentrowanie zapisów w kolumnie
                dgvMacierzC.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie do kontrolki dgvMacierzC odpowiedniej liczby wierszy
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzC.Rows.Add();
            //wpisanie nazw (numerów) kolumn
            for (ushort i = 0; i < LiczbaWierszy; i++)
                dgvMacierzC.Rows[i].HeaderCell.Value = "(" + i + ")";

            //dodanie kontrolki dgvMacierzC do strony 1 zakładki
            Zakładki.TabPages[1].Controls.Add(dgvMacierzC);
            //ustawienie automatycznego AutoResize dla kontrolki dgvMacierzC
            dgvMacierzC.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnIloczynMacierzyAB_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy dane w kontrolkacg DataGridView zostały zaakceowane
            if (btnAkcepWartościA.Enabled || btnAkcepWartościB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAB, "ERROR: dane wkontrolkach DataGridView muszą być zaakceowane");
                //przerwanie dalszej obsługi przycisku poleceń btnSumaMacierzyAB
                return;
            }

            //sprawdzenie czy została umieszczona na formularzu kontrolka dla macierzy wynikowej
            if (dgvMacierzC is null)
            {
                UtwórzKontrolkę_dgvMacierzC();
            }
            //utworzenie egzemplarzy dla macierzy
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);

            C = A * B;
            C.PrzepiszElementyMacierzyDoKontrolki(dgvMacierzC);
        }

        private void btnSumaABzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
             {//był błąd
                 errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                 //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                 return;
             }
             if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
             {//był błąd
                 errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                 //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                 return;
             }
             if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
             {//był błąd
                 errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                 //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                 return;
             }
             if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
             {//był błąd
                 errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                 //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                 return;
             }
             ZespolonaA.Re = h;
             ZespolonaB.Re = j;
             ZespolonaA.Im = k;
             ZespolonaB.Im = l;

             txtwynik.Text = (ZespolonaA + ZespolonaB).ToString(); 
        }

        private void btnOdejmowanieABzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            ZespolonaA.Re = h;
            ZespolonaB.Re = j;
            ZespolonaA.Im = k;
            ZespolonaB.Im = l;

            txtwynik.Text = (ZespolonaA - ZespolonaB).ToString();
        }

        private void btnOdejmowanieBAzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            ZespolonaA.Re = h;
            ZespolonaB.Re = j;
            ZespolonaA.Im = k;
            ZespolonaB.Im = l;

            txtwynik.Text = (ZespolonaB - ZespolonaA).ToString();
        }

        private void btnMnozenieABzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            ZespolonaA.Re = h;
            ZespolonaB.Re = j;
            ZespolonaA.Im = k;
            ZespolonaB.Im = l;

            txtwynik.Text = (ZespolonaA * ZespolonaB).ToString();
        }

        private void btnDzielenieABzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (l == 0 || j == 0)
            {
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: liczba w mianowniku musi być różna od 0");
                return;
            }
            ZespolonaA.Re = h;
            ZespolonaB.Re = j;
            ZespolonaA.Im = k;
            ZespolonaB.Im = l;

            txtwynik.Text = (ZespolonaA / ZespolonaB).ToString();
        }

        private void btnDzielenieBAzespol_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbarzeczywistaB.Text, out double j))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaB.Text, out double l))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (h == 0 || k == 0)
            {
                errorProvider1.SetError(txtliczbaurojonaB, "ERROR: liczba w mianowniku musi być różna od 0");
                return;
            }
            ZespolonaA.Re = h;
            ZespolonaB.Re = j;
            ZespolonaA.Im = k;
            ZespolonaB.Im = l;

            txtwynik.Text = (ZespolonaB / ZespolonaA).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnModulA_Click(object sender, EventArgs e)
        {            
            if (!double.TryParse(txtliczbarzeczywistaA.Text, out double h))
            {//był błąd
                errorProvider1.SetError(txtliczbarzeczywistaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }
            if (!double.TryParse(txtliczbaurojonaA.Text, out double k))
            {//był błąd
                errorProvider1.SetError(txtliczbaurojonaA, "ERROR: wystąpił niedozwolony znak w zapisie liczby urojonej");
                //przerwanie dalszej obsługi zdarzenia Click od przycisku 
                return;
            }

            txtwynik.Text = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(k, 2)).ToString();     
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            LiczbyZespolone Z1 = new LiczbyZespolone(10, 12);
            LiczbyZespolone Z2 = new LiczbyZespolone(100, 0);
            LiczbyZespolone Z3 = new LiczbyZespolone();

            Z2 = Z2 + -2;
            double x = 20;
            Z3 = x + 30;
            LiczbyZespolone Z4 = Z3 + new LiczbyZespolone(3, 4);            

            txtwynik.Text = Z4.ToString();
        }
    }

    //deklaracja klasy pomocniczej rozszerzenia właściwości klasy Macierzy
    static class RozszerzenieWłaściwościKlasyMacierz
    {
        public static void PrzepiszElementyDataGridViewDoMacierzy(this Macierz X, DataGridView dgvMacierzX)
        {
            //sprawdzenie czy liczba wierszy i kolumn macierzy X odpowiada liczb wierszy i kolumn kontrolki DataGridView
            if ((X.LiczbaWierszy != dgvMacierzX.Rows.Count) || (X.LiczbaKolumn != dgvMacierzX.Columns.Count))
                //jest błąd który sygnalizujemy wyrzuceniem odpowiedniego wyjątku
                throw new IndexOutOfRangeException("ERROR: występuje niezgodność rozmiarów macierzy i kontrolki DataGridView, " +
                    "co ozna że dane nie mogą być pobrane kontrolki DataGridView i wpisane do macierzy");
            //pobranie wartości elementów kontrolki DataGridView w wpisanie ich do macierzy X
            for (ushort i = 0; i < X.LiczbaWierszy; i++)
                for (ushort j = 0; j < X.LiczbaKolumn; j++)
                    X[i, j] = float.Parse((dgvMacierzX.Rows[i].Cells[j].Value).ToString());
        }

        public static void PrzepiszElementyMacierzyDoKontrolki(this Macierz X, DataGridView dgvMacierzX)
        {
            //wpisanie do konrolki DataGridView elmentów macierzy X
            for (ushort i = 0; i < dgvMacierzX.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzX.Columns.Count; j++)
                    dgvMacierzX.Rows[i].Cells[j].Value = string.Format("{0:F2}", X[i, j]);
        }
    }
}
