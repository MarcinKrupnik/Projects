using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinKrupnikLab2Zadanie
{
    public partial class FormCards : Form
    {
        /// <summary>
        /// Configuration Manager potrzebuje, aby dodać do referencji bliblioteki System.Configuration.'
        /// Dokładny opis w klasie SignIn
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionCards = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Cards"].ConnectionString);
        /// <summary>
        /// Konstruktor inizjalizujący. Wywołuje komponenty formsa
        /// oraz przez nas wpisanych w konstruktor metody łączącej baze danyh z datagridview.
        /// </summary>
        public FormCards()
        {
            InitializeComponent();
            GetDataFromTable();
        }

        /// <summary>
        /// Metoda połączy dane z datagridview
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionCards())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CardTable ", connection))
                {
                    ///Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    /// Do datagridview dodano powyższą tabelę
                    dataGridViewCards.DataSource = table;
                }
            }
        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCards())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CardTable WHERE CardName = 'Adam' ", connection))
                {
                    ///Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    /// Do datagridview dodano powyższą tabelę
                    dataGridViewCards.DataSource = table;
                }
            }
        }
    }
}