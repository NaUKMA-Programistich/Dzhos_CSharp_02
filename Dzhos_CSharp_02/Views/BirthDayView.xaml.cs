using Dzhos_CSharp_01.ViewModels;
using System;
using System.Windows.Controls;
namespace Dzhos_CSharp_02.Views
{
    /// <summary>
    /// Interaction logic for BirthDayView.xaml
    /// </summary>
    public partial class BirthDayView : UserControl
    {
        private readonly BirthDayViewModel _viewModel;

        public BirthDayView()
        {
            InitializeComponent();
            DataContext = _viewModel = new BirthDayViewModel();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = datePicker.SelectedDate;
            if (selectedDate != null)
            {
                _viewModel.Date = selectedDate.Value;
            }
        }
    }
}
