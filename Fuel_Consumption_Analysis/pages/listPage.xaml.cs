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
using Fuel_Consumption_Analysis.Model;

namespace Fuel_Consumption_Analysis.pages
{
    /// <summary>
    /// Логика взаимодействия для listPage.xaml
    /// </summary>
    public partial class listPage : Page
    {
        public listPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string[] SortingList { get; set; } =
        {
            "Без сортировки",
            "Стоимость по возрастанию",
            "Стоимость по убыванию"
        };

        public string[] FilterList { get; set; } =
        {
            "Все диапозоны",
            "0%-9,99%",
            "10%-14,99%",
            "15% и более"
        };

        private void cmbSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void cmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var result = Fuel_Consumption_AnalysisEntities.GetContext().Records.ToList();

            //switch (cmbSorting.SelectedIndex)
            //{
            //    case 1:
            //        result = result.OrderBy(p => p.ProductCost).ToList();
            //        break;
            //    case 2:
            //        result = result.OrderByDescending(p => p.ProductCost).ToList();
            //        break;
            //}

            //switch (cmbFilter.SelectedIndex)
            //{
            //    case 1:
            //        result = result.Where(p => p.ProductDiscountAmount >= 0 && p.ProductDiscountAmount < 10).ToList();
            //        break;
            //    case 2:
            //        result = result.Where(p => p.ProductDiscountAmount >= 10 && p.ProductDiscountAmount < 15).ToList();
            //        break;
            //    case 3:
            //        result = result.Where(p => p.ProductDiscountAmount >= 15).ToList();
            //        break;
            //}
            //result = result.Where(p => p.ProductName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            LViewRecords.ItemsSource = result;

            //txtResultAmount.Text = result.Count.ToString();
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddRedoRecord addRedoRecord = new AddRedoRecord();
            NavigationService.Navigate(addRedoRecord);
        }

        private void RedoRecord_Click(object sender, RoutedEventArgs e)
        {
            AddRedoRecord addRedoRecord = new AddRedoRecord();
            NavigationService.Navigate(addRedoRecord);
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LViewRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
