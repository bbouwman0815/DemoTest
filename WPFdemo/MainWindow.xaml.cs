using SharedLibraryDemo.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CapstoneDemoDatabaseEntities db = new CapstoneDemoDatabaseEntities();

        public MainWindow()
        {
            InitializeComponent();
            FillBS();
        }

        private void FillBS()
        {
            Student student2 = db.Students.Where(s => s.LastName == "Bouwman").Where(s => s.FirstName == "Brian").FirstOrDefault<Student>();
            this.textBlock.Text = student2.FirstName;
        }
    }
}
