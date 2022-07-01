
namespace Projekt2
{
    partial class Projekt2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Zakładki = new System.Windows.Forms.TabControl();
            this.tabPageKokpit = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOblZespolonych = new System.Windows.Forms.Button();
            this.btnOblMacierz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMacierze = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAkcepWartościB = new System.Windows.Forms.Button();
            this.btnGenerujLosowoB = new System.Windows.Forms.Button();
            this.btnUtwórzDataGridViewB = new System.Windows.Forms.Button();
            this.btnAkcepWartościA = new System.Windows.Forms.Button();
            this.btnGenerujLosowoA = new System.Windows.Forms.Button();
            this.btnUtwórzDataGridViewA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIloczynMacierzyAB = new System.Windows.Forms.Button();
            this.btnSumaMacierzyAB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLiczbaKolumn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLiczbaWierszy = new System.Windows.Forms.TextBox();
            this.btnDoKokpituzMacierz = new System.Windows.Forms.Button();
            this.tabPageLiczbyZespolone = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtliczbaurojonaB = new System.Windows.Forms.TextBox();
            this.txtliczbarzeczywistaB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwynik = new System.Windows.Forms.TextBox();
            this.txtliczbaurojonaA = new System.Windows.Forms.TextBox();
            this.txtliczbarzeczywistaA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnModulA = new System.Windows.Forms.Button();
            this.btnSumaABzespol = new System.Windows.Forms.Button();
            this.btnDzielenieBAzespol = new System.Windows.Forms.Button();
            this.btnOdejmowanieABzespol = new System.Windows.Forms.Button();
            this.btnDzielenieABzespol = new System.Windows.Forms.Button();
            this.btnOdejmowanieBAzespol = new System.Windows.Forms.Button();
            this.btnMnozenieABzespol = new System.Windows.Forms.Button();
            this.btnDoKokpituzZespol = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Zakładki.SuspendLayout();
            this.tabPageKokpit.SuspendLayout();
            this.tabPageMacierze.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageLiczbyZespolone.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Zakładki
            // 
            this.Zakładki.Controls.Add(this.tabPageKokpit);
            this.Zakładki.Controls.Add(this.tabPageMacierze);
            this.Zakładki.Controls.Add(this.tabPageLiczbyZespolone);
            this.Zakładki.Location = new System.Drawing.Point(13, 12);
            this.Zakładki.Name = "Zakładki";
            this.Zakładki.SelectedIndex = 0;
            this.Zakładki.Size = new System.Drawing.Size(1082, 649);
            this.Zakładki.TabIndex = 0;
            this.Zakładki.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Zakładki_Selecting);
            // 
            // tabPageKokpit
            // 
            this.tabPageKokpit.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageKokpit.Controls.Add(this.btnReset);
            this.tabPageKokpit.Controls.Add(this.btnOblZespolonych);
            this.tabPageKokpit.Controls.Add(this.btnOblMacierz);
            this.tabPageKokpit.Controls.Add(this.label1);
            this.tabPageKokpit.Location = new System.Drawing.Point(4, 22);
            this.tabPageKokpit.Name = "tabPageKokpit";
            this.tabPageKokpit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKokpit.Size = new System.Drawing.Size(1074, 623);
            this.tabPageKokpit.TabIndex = 0;
            this.tabPageKokpit.Text = "Kokpit";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(446, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOblZespolonych
            // 
            this.btnOblZespolonych.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblZespolonych.Location = new System.Drawing.Point(606, 203);
            this.btnOblZespolonych.Name = "btnOblZespolonych";
            this.btnOblZespolonych.Size = new System.Drawing.Size(209, 71);
            this.btnOblZespolonych.TabIndex = 2;
            this.btnOblZespolonych.Text = "Kalkulator obliczeń na liczbach zespolonych";
            this.btnOblZespolonych.UseVisualStyleBackColor = true;
            this.btnOblZespolonych.Click += new System.EventHandler(this.btnOblZespolonych_Click);
            // 
            // btnOblMacierz
            // 
            this.btnOblMacierz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblMacierz.Location = new System.Drawing.Point(264, 203);
            this.btnOblMacierz.Name = "btnOblMacierz";
            this.btnOblMacierz.Size = new System.Drawing.Size(194, 71);
            this.btnOblMacierz.TabIndex = 1;
            this.btnOblMacierz.Text = "Kalkulator obliczeń na macierzach";
            this.btnOblMacierz.UseVisualStyleBackColor = true;
            this.btnOblMacierz.Click += new System.EventHandler(this.btnOblMacierz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(336, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przeciążanie metod i operatorów w języku C#\r\n";
            // 
            // tabPageMacierze
            // 
            this.tabPageMacierze.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageMacierze.Controls.Add(this.groupBox3);
            this.tabPageMacierze.Controls.Add(this.groupBox2);
            this.tabPageMacierze.Controls.Add(this.groupBox1);
            this.tabPageMacierze.Controls.Add(this.btnDoKokpituzMacierz);
            this.tabPageMacierze.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacierze.Name = "tabPageMacierze";
            this.tabPageMacierze.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacierze.Size = new System.Drawing.Size(1074, 623);
            this.tabPageMacierze.TabIndex = 1;
            this.tabPageMacierze.Text = "Działania na macierzach";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAkcepWartościB);
            this.groupBox3.Controls.Add(this.btnGenerujLosowoB);
            this.groupBox3.Controls.Add(this.btnUtwórzDataGridViewB);
            this.groupBox3.Controls.Add(this.btnAkcepWartościA);
            this.groupBox3.Controls.Add(this.btnGenerujLosowoA);
            this.groupBox3.Controls.Add(this.btnUtwórzDataGridViewA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(863, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 408);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przyciski operacyjne";
            // 
            // btnAkcepWartościB
            // 
            this.btnAkcepWartościB.Enabled = false;
            this.btnAkcepWartościB.Location = new System.Drawing.Point(16, 333);
            this.btnAkcepWartościB.Name = "btnAkcepWartościB";
            this.btnAkcepWartościB.Size = new System.Drawing.Size(166, 59);
            this.btnAkcepWartościB.TabIndex = 4;
            this.btnAkcepWartościB.Text = "Akceptacja wartości elementów macierzy B";
            this.btnAkcepWartościB.UseVisualStyleBackColor = true;
            this.btnAkcepWartościB.Click += new System.EventHandler(this.btnAkcepWartościB_Click);
            // 
            // btnGenerujLosowoB
            // 
            this.btnGenerujLosowoB.Enabled = false;
            this.btnGenerujLosowoB.Location = new System.Drawing.Point(16, 268);
            this.btnGenerujLosowoB.Name = "btnGenerujLosowoB";
            this.btnGenerujLosowoB.Size = new System.Drawing.Size(166, 59);
            this.btnGenerujLosowoB.TabIndex = 4;
            this.btnGenerujLosowoB.Text = "Wygeneruj losowo wartości elementów macierzy B";
            this.btnGenerujLosowoB.UseVisualStyleBackColor = true;
            this.btnGenerujLosowoB.Click += new System.EventHandler(this.btnGenerujLosowoB_Click);
            // 
            // btnUtwórzDataGridViewB
            // 
            this.btnUtwórzDataGridViewB.Enabled = false;
            this.btnUtwórzDataGridViewB.Location = new System.Drawing.Point(16, 209);
            this.btnUtwórzDataGridViewB.Name = "btnUtwórzDataGridViewB";
            this.btnUtwórzDataGridViewB.Size = new System.Drawing.Size(166, 53);
            this.btnUtwórzDataGridViewB.TabIndex = 4;
            this.btnUtwórzDataGridViewB.Text = "Utwórz Graf\r\n macierzy B";
            this.btnUtwórzDataGridViewB.UseVisualStyleBackColor = true;
            this.btnUtwórzDataGridViewB.Click += new System.EventHandler(this.btnUtwórzDataGridViewB_Click);
            // 
            // btnAkcepWartościA
            // 
            this.btnAkcepWartościA.Enabled = false;
            this.btnAkcepWartościA.Location = new System.Drawing.Point(16, 145);
            this.btnAkcepWartościA.Name = "btnAkcepWartościA";
            this.btnAkcepWartościA.Size = new System.Drawing.Size(166, 58);
            this.btnAkcepWartościA.TabIndex = 2;
            this.btnAkcepWartościA.Text = "Akceptacja wartości elementów macierzy A";
            this.btnAkcepWartościA.UseVisualStyleBackColor = true;
            this.btnAkcepWartościA.Click += new System.EventHandler(this.btnAkcepWartościA_Click);
            // 
            // btnGenerujLosowoA
            // 
            this.btnGenerujLosowoA.Enabled = false;
            this.btnGenerujLosowoA.Location = new System.Drawing.Point(16, 80);
            this.btnGenerujLosowoA.Name = "btnGenerujLosowoA";
            this.btnGenerujLosowoA.Size = new System.Drawing.Size(166, 59);
            this.btnGenerujLosowoA.TabIndex = 1;
            this.btnGenerujLosowoA.Text = "Wygeneruj losowo wartości elementów macierzy A";
            this.btnGenerujLosowoA.UseVisualStyleBackColor = true;
            this.btnGenerujLosowoA.Click += new System.EventHandler(this.btnGenerujLosowoA_Click);
            // 
            // btnUtwórzDataGridViewA
            // 
            this.btnUtwórzDataGridViewA.Location = new System.Drawing.Point(16, 21);
            this.btnUtwórzDataGridViewA.Name = "btnUtwórzDataGridViewA";
            this.btnUtwórzDataGridViewA.Size = new System.Drawing.Size(166, 53);
            this.btnUtwórzDataGridViewA.TabIndex = 0;
            this.btnUtwórzDataGridViewA.Text = "Utwórz Graf\r\n macierzy A";
            this.btnUtwórzDataGridViewA.UseVisualStyleBackColor = true;
            this.btnUtwórzDataGridViewA.Click += new System.EventHandler(this.btnUtwórzDataGridViewA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIloczynMacierzyAB);
            this.groupBox2.Controls.Add(this.btnSumaMacierzyAB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(26, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kalkulator działań na macierzach";
            // 
            // btnIloczynMacierzyAB
            // 
            this.btnIloczynMacierzyAB.Location = new System.Drawing.Point(50, 90);
            this.btnIloczynMacierzyAB.Name = "btnIloczynMacierzyAB";
            this.btnIloczynMacierzyAB.Size = new System.Drawing.Size(90, 41);
            this.btnIloczynMacierzyAB.TabIndex = 1;
            this.btnIloczynMacierzyAB.Text = "C = A * B";
            this.btnIloczynMacierzyAB.UseVisualStyleBackColor = true;
            this.btnIloczynMacierzyAB.Click += new System.EventHandler(this.btnIloczynMacierzyAB_Click);
            // 
            // btnSumaMacierzyAB
            // 
            this.btnSumaMacierzyAB.Location = new System.Drawing.Point(50, 41);
            this.btnSumaMacierzyAB.Name = "btnSumaMacierzyAB";
            this.btnSumaMacierzyAB.Size = new System.Drawing.Size(90, 43);
            this.btnSumaMacierzyAB.TabIndex = 0;
            this.btnSumaMacierzyAB.Text = "C = A + B";
            this.btnSumaMacierzyAB.UseVisualStyleBackColor = true;
            this.btnSumaMacierzyAB.Click += new System.EventHandler(this.btnSumaMacierzyAB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLiczbaKolumn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLiczbaWierszy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(26, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opis rozmiaru macierzy";
            // 
            // txtLiczbaKolumn
            // 
            this.txtLiczbaKolumn.Location = new System.Drawing.Point(40, 85);
            this.txtLiczbaKolumn.Name = "txtLiczbaKolumn";
            this.txtLiczbaKolumn.Size = new System.Drawing.Size(100, 22);
            this.txtLiczbaKolumn.TabIndex = 3;
            this.txtLiczbaKolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba kolumn macierzy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba wierszy macierzy";
            // 
            // txtLiczbaWierszy
            // 
            this.txtLiczbaWierszy.Location = new System.Drawing.Point(40, 41);
            this.txtLiczbaWierszy.Name = "txtLiczbaWierszy";
            this.txtLiczbaWierszy.Size = new System.Drawing.Size(100, 22);
            this.txtLiczbaWierszy.TabIndex = 0;
            this.txtLiczbaWierszy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDoKokpituzMacierz
            // 
            this.btnDoKokpituzMacierz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDoKokpituzMacierz.Location = new System.Drawing.Point(26, 25);
            this.btnDoKokpituzMacierz.Name = "btnDoKokpituzMacierz";
            this.btnDoKokpituzMacierz.Size = new System.Drawing.Size(183, 64);
            this.btnDoKokpituzMacierz.TabIndex = 0;
            this.btnDoKokpituzMacierz.Text = "Powrót do Kokpitu";
            this.btnDoKokpituzMacierz.UseVisualStyleBackColor = true;
            this.btnDoKokpituzMacierz.Click += new System.EventHandler(this.btnDoKokpituzMacierz_Click);
            // 
            // tabPageLiczbyZespolone
            // 
            this.tabPageLiczbyZespolone.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageLiczbyZespolone.Controls.Add(this.label10);
            this.tabPageLiczbyZespolone.Controls.Add(this.label9);
            this.tabPageLiczbyZespolone.Controls.Add(this.label8);
            this.tabPageLiczbyZespolone.Controls.Add(this.label7);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtliczbaurojonaB);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtliczbarzeczywistaB);
            this.tabPageLiczbyZespolone.Controls.Add(this.label6);
            this.tabPageLiczbyZespolone.Controls.Add(this.label5);
            this.tabPageLiczbyZespolone.Controls.Add(this.label4);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtwynik);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtliczbaurojonaA);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtliczbarzeczywistaA);
            this.tabPageLiczbyZespolone.Controls.Add(this.groupBox4);
            this.tabPageLiczbyZespolone.Controls.Add(this.btnDoKokpituzZespol);
            this.tabPageLiczbyZespolone.Location = new System.Drawing.Point(4, 22);
            this.tabPageLiczbyZespolone.Name = "tabPageLiczbyZespolone";
            this.tabPageLiczbyZespolone.Size = new System.Drawing.Size(1074, 623);
            this.tabPageLiczbyZespolone.TabIndex = 2;
            this.tabPageLiczbyZespolone.Text = "Działania na liczbach zespolonych";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(760, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "i";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(507, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(641, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(388, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "+";
            // 
            // txtliczbaurojonaB
            // 
            this.txtliczbaurojonaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtliczbaurojonaB.Location = new System.Drawing.Point(668, 266);
            this.txtliczbaurojonaB.Name = "txtliczbaurojonaB";
            this.txtliczbaurojonaB.Size = new System.Drawing.Size(86, 31);
            this.txtliczbaurojonaB.TabIndex = 16;
            this.txtliczbaurojonaB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtliczbarzeczywistaB
            // 
            this.txtliczbarzeczywistaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtliczbarzeczywistaB.Location = new System.Drawing.Point(549, 266);
            this.txtliczbarzeczywistaB.Name = "txtliczbarzeczywistaB";
            this.txtliczbarzeczywistaB.Size = new System.Drawing.Size(86, 31);
            this.txtliczbarzeczywistaB.TabIndex = 15;
            this.txtliczbarzeczywistaB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(869, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Wynik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(556, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Liczba zespolona B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(303, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Liczba zespolona A";
            // 
            // txtwynik
            // 
            this.txtwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtwynik.Location = new System.Drawing.Point(838, 266);
            this.txtwynik.Name = "txtwynik";
            this.txtwynik.Size = new System.Drawing.Size(129, 31);
            this.txtwynik.TabIndex = 11;
            this.txtwynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtliczbaurojonaA
            // 
            this.txtliczbaurojonaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtliczbaurojonaA.Location = new System.Drawing.Point(415, 266);
            this.txtliczbaurojonaA.Name = "txtliczbaurojonaA";
            this.txtliczbaurojonaA.Size = new System.Drawing.Size(86, 31);
            this.txtliczbaurojonaA.TabIndex = 10;
            this.txtliczbaurojonaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtliczbarzeczywistaA
            // 
            this.txtliczbarzeczywistaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtliczbarzeczywistaA.Location = new System.Drawing.Point(296, 266);
            this.txtliczbarzeczywistaA.Name = "txtliczbarzeczywistaA";
            this.txtliczbarzeczywistaA.Size = new System.Drawing.Size(86, 31);
            this.txtliczbarzeczywistaA.TabIndex = 9;
            this.txtliczbarzeczywistaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnZ);
            this.groupBox4.Controls.Add(this.btnModulA);
            this.groupBox4.Controls.Add(this.btnSumaABzespol);
            this.groupBox4.Controls.Add(this.btnDzielenieBAzespol);
            this.groupBox4.Controls.Add(this.btnOdejmowanieABzespol);
            this.groupBox4.Controls.Add(this.btnDzielenieABzespol);
            this.groupBox4.Controls.Add(this.btnOdejmowanieBAzespol);
            this.groupBox4.Controls.Add(this.btnMnozenieABzespol);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(32, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 466);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Przyciski operacyjne";
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZ.Location = new System.Drawing.Point(50, 382);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(94, 45);
            this.btnZ.TabIndex = 22;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnModulA
            // 
            this.btnModulA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModulA.Location = new System.Drawing.Point(50, 331);
            this.btnModulA.Name = "btnModulA";
            this.btnModulA.Size = new System.Drawing.Size(94, 45);
            this.btnModulA.TabIndex = 21;
            this.btnModulA.Text = "|A|";
            this.btnModulA.UseVisualStyleBackColor = true;
            this.btnModulA.Click += new System.EventHandler(this.btnModulA_Click);
            // 
            // btnSumaABzespol
            // 
            this.btnSumaABzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSumaABzespol.Location = new System.Drawing.Point(50, 25);
            this.btnSumaABzespol.Name = "btnSumaABzespol";
            this.btnSumaABzespol.Size = new System.Drawing.Size(94, 45);
            this.btnSumaABzespol.TabIndex = 2;
            this.btnSumaABzespol.Text = "A + B";
            this.btnSumaABzespol.UseVisualStyleBackColor = true;
            this.btnSumaABzespol.Click += new System.EventHandler(this.btnSumaABzespol_Click);
            // 
            // btnDzielenieBAzespol
            // 
            this.btnDzielenieBAzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzielenieBAzespol.Location = new System.Drawing.Point(50, 280);
            this.btnDzielenieBAzespol.Name = "btnDzielenieBAzespol";
            this.btnDzielenieBAzespol.Size = new System.Drawing.Size(94, 45);
            this.btnDzielenieBAzespol.TabIndex = 7;
            this.btnDzielenieBAzespol.Text = "B / A";
            this.btnDzielenieBAzespol.UseVisualStyleBackColor = true;
            this.btnDzielenieBAzespol.Click += new System.EventHandler(this.btnDzielenieBAzespol_Click);
            // 
            // btnOdejmowanieABzespol
            // 
            this.btnOdejmowanieABzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdejmowanieABzespol.Location = new System.Drawing.Point(50, 76);
            this.btnOdejmowanieABzespol.Name = "btnOdejmowanieABzespol";
            this.btnOdejmowanieABzespol.Size = new System.Drawing.Size(94, 45);
            this.btnOdejmowanieABzespol.TabIndex = 3;
            this.btnOdejmowanieABzespol.Text = "A - B";
            this.btnOdejmowanieABzespol.UseVisualStyleBackColor = true;
            this.btnOdejmowanieABzespol.Click += new System.EventHandler(this.btnOdejmowanieABzespol_Click);
            // 
            // btnDzielenieABzespol
            // 
            this.btnDzielenieABzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzielenieABzespol.Location = new System.Drawing.Point(50, 229);
            this.btnDzielenieABzespol.Name = "btnDzielenieABzespol";
            this.btnDzielenieABzespol.Size = new System.Drawing.Size(94, 45);
            this.btnDzielenieABzespol.TabIndex = 6;
            this.btnDzielenieABzespol.Text = "A / B";
            this.btnDzielenieABzespol.UseVisualStyleBackColor = true;
            this.btnDzielenieABzespol.Click += new System.EventHandler(this.btnDzielenieABzespol_Click);
            // 
            // btnOdejmowanieBAzespol
            // 
            this.btnOdejmowanieBAzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdejmowanieBAzespol.Location = new System.Drawing.Point(50, 127);
            this.btnOdejmowanieBAzespol.Name = "btnOdejmowanieBAzespol";
            this.btnOdejmowanieBAzespol.Size = new System.Drawing.Size(94, 45);
            this.btnOdejmowanieBAzespol.TabIndex = 4;
            this.btnOdejmowanieBAzespol.Text = "B - A";
            this.btnOdejmowanieBAzespol.UseVisualStyleBackColor = true;
            this.btnOdejmowanieBAzespol.Click += new System.EventHandler(this.btnOdejmowanieBAzespol_Click);
            // 
            // btnMnozenieABzespol
            // 
            this.btnMnozenieABzespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMnozenieABzespol.Location = new System.Drawing.Point(50, 178);
            this.btnMnozenieABzespol.Name = "btnMnozenieABzespol";
            this.btnMnozenieABzespol.Size = new System.Drawing.Size(94, 45);
            this.btnMnozenieABzespol.TabIndex = 5;
            this.btnMnozenieABzespol.Text = "A * B";
            this.btnMnozenieABzespol.UseVisualStyleBackColor = true;
            this.btnMnozenieABzespol.Click += new System.EventHandler(this.btnMnozenieABzespol_Click);
            // 
            // btnDoKokpituzZespol
            // 
            this.btnDoKokpituzZespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDoKokpituzZespol.Location = new System.Drawing.Point(32, 25);
            this.btnDoKokpituzZespol.Name = "btnDoKokpituzZespol";
            this.btnDoKokpituzZespol.Size = new System.Drawing.Size(184, 68);
            this.btnDoKokpituzZespol.TabIndex = 1;
            this.btnDoKokpituzZespol.Text = "Powrót do Kokpitu";
            this.btnDoKokpituzZespol.UseVisualStyleBackColor = true;
            this.btnDoKokpituzZespol.Click += new System.EventHandler(this.btnDoKokpituzZespol_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProjektNr1_Tatarkiewicz57254
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.Zakładki);
            this.Name = "ProjektNr1_Tatarkiewicz57254";
            this.Text = "Przeciążanie operatorów w języku C#";
            this.Zakładki.ResumeLayout(false);
            this.tabPageKokpit.ResumeLayout(false);
            this.tabPageKokpit.PerformLayout();
            this.tabPageMacierze.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageLiczbyZespolone.ResumeLayout(false);
            this.tabPageLiczbyZespolone.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Zakładki;
        private System.Windows.Forms.TabPage tabPageKokpit;
        private System.Windows.Forms.TabPage tabPageMacierze;
        private System.Windows.Forms.TabPage tabPageLiczbyZespolone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOblZespolonych;
        private System.Windows.Forms.Button btnOblMacierz;
        private System.Windows.Forms.Button btnDoKokpituzMacierz;
        private System.Windows.Forms.Button btnDoKokpituzZespol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUtwórzDataGridViewA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIloczynMacierzyAB;
        private System.Windows.Forms.Button btnSumaMacierzyAB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLiczbaKolumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLiczbaWierszy;
        private System.Windows.Forms.Button btnAkcepWartościA;
        private System.Windows.Forms.Button btnGenerujLosowoA;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUtwórzDataGridViewB;
        private System.Windows.Forms.Button btnAkcepWartościB;
        private System.Windows.Forms.Button btnGenerujLosowoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtwynik;
        private System.Windows.Forms.TextBox txtliczbaurojonaA;
        private System.Windows.Forms.TextBox txtliczbarzeczywistaA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSumaABzespol;
        private System.Windows.Forms.Button btnDzielenieBAzespol;
        private System.Windows.Forms.Button btnOdejmowanieABzespol;
        private System.Windows.Forms.Button btnDzielenieABzespol;
        private System.Windows.Forms.Button btnOdejmowanieBAzespol;
        private System.Windows.Forms.Button btnMnozenieABzespol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtliczbaurojonaB;
        private System.Windows.Forms.TextBox txtliczbarzeczywistaB;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnModulA;
        private System.Windows.Forms.Button btnZ;
    }
}

