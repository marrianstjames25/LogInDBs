using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LogInDBs
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : Window
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
                string dbsCon = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SignUpDB; Integrated Security=True";
                SqlConnection sqlCon_ = new SqlConnection(dbsCon);

                try
                {
                    sqlCon_.Open();
                    string query = "Select Email,FirstName from SignupTable_";
                    SqlCommand cmd = new SqlCommand(query, sqlCon_);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGrid_.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);

                    MessageBox.Show("Successful loading");
                    sqlCon_.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LogInDBs.DataSet__ dataSet__ = ((LogInDBs.DataSet__)(this.FindResource("dataSet__")));
            // Load data into the table BookDetails. You can modify this code as needed.
            LogInDBs.DataSet__TableAdapters.BookDetailsTableAdapter dataSet__BookDetailsTableAdapter = new LogInDBs.DataSet__TableAdapters.BookDetailsTableAdapter();
            dataSet__BookDetailsTableAdapter.Fill(dataSet__.BookDetails);
            System.Windows.Data.CollectionViewSource bookDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookDetailsViewSource")));
            bookDetailsViewSource.View.MoveCurrentToFirst();
            // Load data into the table section125. You can modify this code as needed.
            LogInDBs.DataSet__TableAdapters.section125TableAdapter dataSet__section125TableAdapter = new LogInDBs.DataSet__TableAdapters.section125TableAdapter();
            dataSet__section125TableAdapter.Fill(dataSet__.section125);
            System.Windows.Data.CollectionViewSource section125ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("section125ViewSource")));
            section125ViewSource.View.MoveCurrentToFirst();
        }
    }
    }

