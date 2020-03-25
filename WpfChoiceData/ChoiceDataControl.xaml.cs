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

namespace WpfChoiceData
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ChoiceDataControl : UserControl
    {     

        public event RoutedEventHandler Add;
        public event RoutedEventHandler Edit;
        public event RoutedEventHandler Remove;

        public ChoiceDataControl() => InitializeComponent();

        private void AddSenderButton_Click(object sender, RoutedEventArgs e) => Add?.Invoke(this, new RoutedEventArgs());
        private void EditSenderButton_Click(object sender, RoutedEventArgs e) => Edit?.Invoke(this, new RoutedEventArgs());
        private void RemoveSenderButton_Click(object sender, RoutedEventArgs e) => Remove?.Invoke(this, new RoutedEventArgs());
    }
}
