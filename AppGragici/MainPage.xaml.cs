using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Telerik.Charting;
using Telerik.UI.Xaml.Controls.Chart;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace AppGragici
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();

            // radChart.VerticalAxis.LabelStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.Green) });
            List<Data> data = new List<Data>();
            data.Add(new Data() { Category = 1, Value = 5 });
            data.Add(new Data() { Category = 2, Value = 9 });
            data.Add(new Data() { Category = 3, Value = 8 });

            LinearAxis cartesianAxis = new LinearAxis();
            radChart.HorizontalAxis = cartesianAxis;

            this.radChart.Series.Add(new ScatterLineSeries { ItemsSource = data, YValueBinding = new PropertyNameDataPointBinding("Value"),  CompositeMode =ElementCompositeMode.SourceOver,  Foreground = new SolidColorBrush(Colors.Green), Background = new SolidColorBrush(Colors.Green), DisplayName = "fhf", XValueBinding = new PropertyNameDataPointBinding("Category"), LegendTitle="D1", Stroke= new SolidColorBrush(Colors.Green) });


            data = new List<Data>();
            data.Add(new Data() { Category = 1, Value = 10 });
            data.Add(new Data() { Category = 2, Value = 12 });
            data.Add(new Data() { Category = 3, Value = 11 });
        
            this.radChart.Series.Add(new ScatterLineSeries { ItemsSource = data, BorderBrush=new SolidColorBrush(Colors.Green),  YValueBinding = new PropertyNameDataPointBinding("Value"), CompositeMode = ElementCompositeMode.SourceOver, Foreground = new SolidColorBrush(Colors.Green), Background = new SolidColorBrush(Colors.Green), DisplayName = "fhf", XValueBinding = new PropertyNameDataPointBinding("Category"), LegendTitle = "D2", Stroke = new SolidColorBrush(Colors.Red) });
            //radChart.PaletteName = PredefinedPaletteName.DefaultLight;
            
           // this.radChart.Series.Add(new ScatterPointSeries { ItemsSource = data,  YValueBinding = new PropertyNameDataPointBinding("Value"), Foreground = new SolidColorBrush(Colors.Green), Background = new SolidColorBrush(Colors.Green), DisplayName = "fhf", XValueBinding = new PropertyNameDataPointBinding("Category") });


        }
        public class Data
        {
            public double Category { get; set; }

            public double Value { get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           
            this.radChart.DataContext = new double[] { 10, 30, 10, 10, 100, 40, 20, 80 };

        }
    }
}
