using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
    public class Calc : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btn_sbros;
        private System.Windows.Forms.Button btnChangesign;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn_ravno;
        private System.Windows.Forms.Button btn_delenie;
        private System.Windows.Forms.Button btn_umnojenie;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private IContainer components;

 
        private const string odin = "1";
        private const string dva = "2";
        private const string tri = "3";
        private const string chetire = "4";
        private const string pyat = "5";
        private const string shest = "6";
        private const string sem = "7";
        private const string vosem = "8";
        private const string devyat = "9";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ChangeView;
        private ToolStripMenuItem Exit;
        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public ToolTip toolTip1;
        private const string nul = "0";

        public Calc()
        {
            InitializeComponent();
            txtOutput.Text = "0";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false; 
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeView = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(18, 83);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(250, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Location = new System.Drawing.Point(208, 147);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(40, 80);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Location = new System.Drawing.Point(72, 267);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(40, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Location = new System.Drawing.Point(112, 267);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(40, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Location = new System.Drawing.Point(208, 227);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(40, 80);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Location = new System.Drawing.Point(168, 147);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(40, 40);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Location = new System.Drawing.Point(168, 187);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(40, 40);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Location = new System.Drawing.Point(168, 267);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Location = new System.Drawing.Point(168, 227);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Location = new System.Drawing.Point(32, 267);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Location = new System.Drawing.Point(112, 147);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Location = new System.Drawing.Point(72, 147);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Location = new System.Drawing.Point(32, 147);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Location = new System.Drawing.Point(112, 187);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Location = new System.Drawing.Point(72, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Location = new System.Drawing.Point(32, 187);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Location = new System.Drawing.Point(112, 227);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Location = new System.Drawing.Point(72, 227);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Location = new System.Drawing.Point(32, 227);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeView,
            this.Exit});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // ChangeView
            // 
            this.ChangeView.Name = "ChangeView";
            this.ChangeView.Size = new System.Drawing.Size(180, 22);
            this.ChangeView.Text = "&Extended Calc";
            this.ChangeView.Click += new System.EventHandler(this.ChangeView_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(32, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "^";
            this.toolTip1.SetToolTip(this.button1, "���������� � �������");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(77, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 63;
            this.button2.Text = "Sqrt";
            this.toolTip1.SetToolTip(this.button2, "���������� �����");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(168, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 64;
            this.button3.Text = "1/x";
            this.toolTip1.SetToolTip(this.button3, "�������� �����");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(213, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 65;
            this.button4.Text = "Sqr";
            this.toolTip1.SetToolTip(this.button4, "������� �����");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(280, 399);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "����������� 1.0";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calc_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.Run(new Calc());
           
        }
 
        private void btn1_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(odin);
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(dva);
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(tri);
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(chetire);
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(pyat);
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(shest);
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(sem);
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(vosem);
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(devyat);
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(nul);
        }

        private void btnChangesign_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
        }

        private void btnpoint_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
        }
 
        private void btn_delenie_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Delenie);
        }

        private void btn_umnojenie_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Umnojenie);
        }

        private void btn_minus_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Vichitanie);
        }

        private void btn_plus_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Slojenie);
        }

        private void btn_ravno_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
            
        }

        private void btn_sbros_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.Sbros();
            txtOutput.Text = "0";
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Exponentiation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Sqrt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Reciprocal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Square();
        }

        private void ChangeView_Click(object sender, EventArgs e)
        {
            Form2 newChild = new Form2();
            newChild.FormClosed += newChild_FormClosed;
            newChild.ShowButton1 = true;
            newChild.ShowButton2 = true;
            newChild.ShowButton3 = true;
            newChild.ShowButton4 = true;
            this.Hide();
            newChild.ShowDialog();
            this.Show();
        }
        private void newChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        class mehanizmcalkulyatora
        {
            public enum Deystvie : int
            {
                NeopredelDeystvie = 0,
                Slojenie = 1,
                Vichitanie = 2,
                Umnojenie = 3,
                Delenie = 4,
                Exponentiation = 5,
            }
  
            private static double peremennayaMinus = -1;
            private static double resultatVichisleniy;
            private static string resultatOutput;
            private static Deystvie tekusheeDeystvieCalculatora;
            private static double pervoeChislo;
            private static double vtoroeChislo;
            private static bool dobavlenierazryada;
            private static bool ChislosTochkoy;
            
            public mehanizmcalkulyatora()
            {
                ChislosTochkoy = false;
                dobavlenierazryada = false;
            }

            public static string chislonaEkrane(string najatayaKlavisha)
            {
                resultatOutput = resultatOutput + najatayaKlavisha;
                return (resultatOutput);
            }

            public static void DeystvieCalculatora(Deystvie peremenDeystviya)
            {
                try
                {
                    if (resultatOutput != "" && !dobavlenierazryada)
                    {
                        pervoeChislo = System.Convert.ToDouble(resultatOutput);
                        tekusheeDeystvieCalculatora = peremenDeystviya;
                        resultatOutput = "";
                        ChislosTochkoy = false;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                }
            }

            public static string ZnakChisla()
            {
                double tekusheeChislo;

                if (resultatOutput != "")
                {
                    tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
                }

                return (resultatOutput);
            }

            public static string ZnakTochki()
            {
                if (!ChislosTochkoy && !dobavlenierazryada)
                {
                    if (resultatOutput != "")
                        resultatOutput = resultatOutput + ",";
                    else
                        resultatOutput = "0,";

                    ChislosTochkoy = true;
                }

                return (resultatOutput);
            }

            public static string Square()
            {
                double tekusheeChislo;

                if (resultatOutput != "")
                {
                    tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(Math.Pow(tekusheeChislo, 2));
                }

                return (resultatOutput);
            }

            public static string Reciprocal()
            {
                double tekusheeChislo;

                if (resultatOutput != "")
                {
                    tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(1 / tekusheeChislo);
                }

                return (resultatOutput);
            }

            public static string Sqrt()
            {
                double tekusheeChislo;

                if (resultatOutput != "")
                {
                    tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(Math.Sqrt(tekusheeChislo));
                }

                return (resultatOutput);
            }

            public static string ZnakRavno()
            {
                bool proverkaOshibok = false;

                if (resultatOutput != "")
                {
                    vtoroeChislo = System.Convert.ToDouble(resultatOutput);
                    dobavlenierazryada = true;


                    switch (tekusheeDeystvieCalculatora)
                    {
                        case Deystvie.NeopredelDeystvie:
                            proverkaOshibok = false;
                            break;

                        case Deystvie.Slojenie:
                            resultatVichisleniy = pervoeChislo + vtoroeChislo;
                            proverkaOshibok = true;
                            break;

                        case Deystvie.Vichitanie:
                            resultatVichisleniy = pervoeChislo - vtoroeChislo;
                            proverkaOshibok = true;
                            break;

                        case Deystvie.Umnojenie:
                            resultatVichisleniy = pervoeChislo * vtoroeChislo;
                            proverkaOshibok = true;
                            break;

                        case Deystvie.Delenie:
                            resultatVichisleniy = pervoeChislo / vtoroeChislo;
                            proverkaOshibok = true;
                            break;

                        case Deystvie.Exponentiation:
                            resultatVichisleniy = (float)Math.Pow(pervoeChislo, vtoroeChislo);

                            proverkaOshibok = true;
                            break;

                        default:
                            proverkaOshibok = false;
                            break;
                    }

                    if (proverkaOshibok)
                        resultatOutput = System.Convert.ToString(resultatVichisleniy);
                }

                return (resultatOutput);
            }

            public static void Sbros()
            {
                resultatVichisleniy = 0;
                pervoeChislo = 0;
                vtoroeChislo = 0;
                resultatOutput = "";
                tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
                ChislosTochkoy = false;
                dobavlenierazryada = false;
            }
        }
    }
}
