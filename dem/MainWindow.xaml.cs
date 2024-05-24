using dem.View;

using Microsoft.EntityFrameworkCore;

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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context context = new Context();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)) 
            {
                var user = context.Employees.FirstOrDefault(u => u.Name == login && u.Password == password);
                
                if(user != null)
                {
                    TicketsPage ticketsPage= new TicketsPage();
                    ticketsPage.Show();
                    this.Close();

                }
            }


        }
    }
}