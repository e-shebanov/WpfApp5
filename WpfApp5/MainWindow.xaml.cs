using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DataContext _context = new DataContext();
        
        private CollectionViewSource pipesViewSource;

        public ObservableCollection<string> ListCombobox { get; }

        public MainWindow()
        {

            InitializeComponent();
            pipesViewSource = (CollectionViewSource)FindResource(nameof(pipesViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.EnsureCreated();
            _context.Pipes.Load();

            pipesViewSource.Source = _context.Pipes.Local.ToObservableCollection();

        }

        private void pipesDataGrid_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();

            // this forces the grid to refresh to latest values
            pipesDataGrid.Items.Refresh();
            //packageDataGrid.Items.Refresh();
        }
    }
}
