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

namespace Macket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Model.textCombo = TextBlockOperator;
            Model.OneNumber = TextBoxNumberOne;
            Model.TwoNumber = TextBoxNumberTwo;
            Model.textResult = TextBlockResult;
            ComboBoxOperation.ItemsSource = Model.datalist;
            ComboBoxOperation.SelectedIndex = 0;
        }

        private void ComboBoxOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Comdo = ComboBoxOperation.SelectedIndex;
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            Model.Result = ComboBoxOperation.SelectedIndex;
        }
    }
}
