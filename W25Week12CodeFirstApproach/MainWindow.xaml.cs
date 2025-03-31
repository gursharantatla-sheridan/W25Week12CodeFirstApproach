using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W25Week12CodeFirstApproach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // instantiate the context class
        SchoolContext db = new SchoolContext();

        public MainWindow()
        {
            InitializeComponent();

            LoadStudentsInDataGrid();
            LoadStandardsInCombobox();
        }

        private void LoadStudentsInDataGrid()
        {
            var students = (from s in db.Students
                           select new { s.StudentId, s.Name, s.Standard.StandardName }).ToList();

            grdStudents.ItemsSource = students;
        }

        private void LoadStandardsInCombobox()
        {
            var standards = db.Standards.ToList();

            cmbStandard.ItemsSource = standards;
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void btnLoadStudents_Click(object sender, RoutedEventArgs e)
        {
            LoadStudentsInDataGrid();
        }
    }
}