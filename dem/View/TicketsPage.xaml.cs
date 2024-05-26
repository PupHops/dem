using dem.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace dem.View
{
    /// <summary>
    /// Логика взаимодействия для TicketsPage.xaml
    /// </summary>
    public partial class TicketsPage : Window
    {

        public TicketsPage()
        {
            InitializeComponent();
            Context context = new Context();
            TicketList.ItemsSource = context.Tickets.ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is int id)
            {
                // Открытие окна редактирования с передачей Id
                EditTicket editWindow = new EditTicket(id);
                editWindow.ShowDialog();
            }
        }
    }
}
