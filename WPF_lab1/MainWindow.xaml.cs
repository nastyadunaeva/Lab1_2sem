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
using System.Numerics;
using Lab3;

namespace WPF_lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_New_Click(object sender, RoutedEventArgs e)
        {
            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if ((coll != null) && (coll.Is_changed == true))
            {
                MessageBoxResult result = MessageBox.Show("Изменения будут потеряны. Сохранить изменения?", "", MessageBoxButton.YesNo); 
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                        dlg.Filter = "Text documents (.txt)|*.txt";
                        dlg.CreatePrompt = true;
                        dlg.OverwritePrompt = true;
                        if (dlg.ShowDialog() == true)
                        {
                            string filename = dlg.FileName;
                            if (coll != null)
                            {
                                coll.Save(filename);
                            }
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
           
            if (coll != null)
            {
                coll.RemoveAll();
            }
        }

        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {
            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if ((coll != null) && (coll.Is_changed == true))
            {
                MessageBoxResult result = MessageBox.Show("Изменения будут потеряны. Сохранить изменения?", "", MessageBoxButton.YesNo); 
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                        dlg.Filter = "Text documents (.txt)|*.txt";
                        dlg.CreatePrompt = true;
                        dlg.OverwritePrompt = true;
                        if (dlg.ShowDialog() == true)
                        {
                            string filename = dlg.FileName;
                            if (coll != null)
                            {
                                coll.Save(filename);
                            }
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }

            Microsoft.Win32.OpenFileDialog dlg1 = new Microsoft.Win32.OpenFileDialog();
            dlg1.Filter = "Text documents (.txt)|*.txt";
            if (dlg1.ShowDialog() == true)
            {
                string filename = dlg1.FileName;
                if (coll != null)
                {
                    coll.Load(filename);
                }

            }
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "Text documents (.txt)|*.txt";
            dlg.CreatePrompt = true;
            dlg.OverwritePrompt = true;
            if (dlg.ShowDialog() == true)
            {
                string filename = dlg.FileName;
                V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
                if (coll != null)
                {
                    coll.Save(filename);
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if ((coll != null) && (coll.Is_changed == true))
            {
                MessageBoxResult result = MessageBox.Show("Изменения будут потеряны. Сохранить изменения?", "", MessageBoxButton.YesNo); 
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                        dlg.Filter = "Text documents (.txt)|*.txt";
                        dlg.CreatePrompt = true;
                        dlg.OverwritePrompt = true;
                        if (dlg.ShowDialog() == true)
                        {
                            string filename = dlg.FileName;
                            if (coll != null)
                            {
                                coll.Save(filename);
                            }
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
        }

        private void Button_AddDefaults_Click(object sender, RoutedEventArgs e)
        {
            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if (coll != null)
            {
                coll.AddDefaults();
            }
        }

        private void Button_AddDefaultCollection_Click(object sender, RoutedEventArgs e)
        {
            V3DataCollection datacollection = new V3DataCollection();
            datacollection.InitRandom(3, (float)0.5, (float)0.5, 0.1, 1.0);

            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if (coll != null)
            {
                coll.Add(datacollection);
            }
        }

        private void Button_AddDefaultGrid_Click(object sender, RoutedEventArgs e)
        {
            Grid1D x = new Grid1D((float)0.3, 3);
            Grid1D y = new Grid1D((float)0.3, 3);
            V3DataOnGrid dataongrid = new V3DataOnGrid("", DateTime.Now, x, y);
            dataongrid.InitRandom(0.1, 1.0);

            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if (coll != null)
            {
                coll.Add(dataongrid);
            }
        }

        private void Button_AddFromFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Text documents (.txt)|*.txt";
            try
            {
                if (dlg.ShowDialog() == true)
                {
                    string filename = dlg.FileName;
                    V3DataOnGrid dataongrid = new V3DataOnGrid(filename);

                    V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
                    if (coll != null)
                    {
                        coll.Add(dataongrid);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {
            V3MainCollection coll = TryFindResource("key_main_collection") as V3MainCollection;
            if (coll != null)
            {
                coll.RemoveAt(lisBox_Main.SelectedIndex);
            }
        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            V3Data data = e.Item as V3Data;
            if (data != null)
            {
                if (data.GetType().ToString() == "Lab3.V3DataCollection") e.Accepted = true;
                else e.Accepted = false;
            }
        }

        private void CollectionViewSource_Filter_1(object sender, FilterEventArgs e)
        {
            V3Data data = e.Item as V3Data;
            if (data != null)
            {
                if (data.GetType().ToString() == "Lab3.V3DataOnGrid") e.Accepted = true;
                else e.Accepted = false;
            }
        }
    }

    [ValueConversion(typeof(Grid1D[]), typeof(string))]
     public class DataOnGridConverter: IValueConverter
     {
         public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
         {
             Grid1D[] data = (Grid1D[])value;
             return "x axis: " + data[0].node + ", y axis: " + data[1].node;
         }
         public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
         {
             return value;
         }
     }
    [ValueConversion(typeof(DataItem), typeof(string))]
    public class DataCollConverter_1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DataItem data = (DataItem)value;
            return data.Vec.ToString() + " ";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
    [ValueConversion(typeof(DataItem), typeof(string))]
    public class DataCollConverter_2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DataItem data = (DataItem)value;
            return data.field.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
