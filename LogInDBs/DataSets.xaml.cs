using System;
using System.Collections.Generic;
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
    /// Interaction logic for DataSets.xaml
    /// </summary>
    public partial class DataSets : Window
    {
        public DataSets()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, object e)
        {

            LogInDBs.SignUpDBDataSet signUpDBDataSet = ((LogInDBs.SignUpDBDataSet)(this.FindResource("signUpDBDataSet")));
            // Load data into the table SignupTable_. You can modify this code as needed.
            LogInDBs.SignUpDBDataSetTableAdapters.SignupTable_TableAdapter signUpDBDataSetSignupTable_TableAdapter = new LogInDBs.SignUpDBDataSetTableAdapters.SignupTable_TableAdapter();
            signUpDBDataSetSignupTable_TableAdapter.Fill(signUpDBDataSet.SignupTable_);
            System.Windows.Data.CollectionViewSource signupTable_ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("signupTable_ViewSource")));
            signupTable_ViewSource.View.MoveCurrentToFirst();
        }
    }
}
