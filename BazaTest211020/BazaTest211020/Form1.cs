using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace BazaTest211020
{
    public partial class Form1 : Form
    {
        private SQLiteConnection db;

        private void TworzBaze()
        {
            //tworzę bazę
            SQLiteConnection.CreateFile("bazaTest");

            //otwieram bazę
            db = new SQLiteConnection("Data Source=bazaTest;");
            db.Open();

            //tworzę tabelę
            string s1 = "CREATE TABLE 'tab1' ( " +
                "'id' INTEGER PRIMARY KEY AUTOINCREMENT," +
                "'stan' INTEGER," +
                "'ip' VARCHAR(50)," +
                "'opis' VARCHAR(100) );";

            //wpisuje jako komendę
            SQLiteCommand com = new SQLiteCommand(s1, db);
            //potwierdzam bez otrzymania wyniku
            com.ExecuteNonQuery();
            db.Close();
        }

        private string IleRekordow()
        {
            string s1;
            s1 = "SELECT COUNT(*) FROM tab1;";
            SQLiteCommand com = new SQLiteCommand(s1, db);
            //com.ExecuteScalar() zwraca pojedyńczą wartość
            return "Ilość rekordów: " + com.ExecuteScalar();
        }

        public Form1()
        {
            InitializeComponent();
            //TworzBaze();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SQLiteConnection("Data Source=bazaTest;");
            db.Open();
            label_ileRekordow.Text = IleRekordow();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void button_dopisz_Click(object sender, EventArgs e)
        {
            if (textBox_ip.Text != "" && textBox_opis.Text != "")
            {
                try
                {
                    string s1;
                    s1 = "INSERT INTO tab1(stan, ip, opis) VALUES(";
                    if (checkBox_stan.Checked) s1 += 1; else s1 += 0;
                    s1 += ", '" + textBox_ip.Text + "', '" + textBox_opis.Text + "');";
                    SQLiteCommand com = new SQLiteCommand(s1, db);
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.HResult + "\n" + ex.Message, "Błąd programu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                label_ileRekordow.Text = IleRekordow();
            }
        }

        private void button_znajdz_Click(object sender, EventArgs e)
        {
            //richTextBox.Clear() czyści zawartość richTextBoxa
            richTextBox_wyniki.Clear();
            string s1;
            s1 = "SELECT * FROM tab1 WHERE ip LIKE '%" + textBox_ip.Text +
                "%' AND opis LIKE '%" + textBox_opis.Text + "%';";
            SQLiteCommand com = new SQLiteCommand(s1, db);
            
            //com.ExecuteReader zwraca dane z wypełnionej komendy czyli select
            SQLiteDataReader dr = com.ExecuteReader();

            //dr.HasRows jak są jakieś wyniki
            if (dr.HasRows)
            {
                //czytamy w jedną stronę od pocżatku aż do końca 
                while (dr.Read())
                {
                    //dr['stan'] wartość z pola stan pobrana z tablicy
                    richTextBox_wyniki.Text += "stan: " + dr["stan"] +                                          
                                                " ip: " + dr["ip"] +
                                                " opis: " + dr["opis"] + "\r\n";
                }
            }
            else richTextBox_wyniki.Text = "Brak rekordów spełniających warunki";  
        }
    }




}
