using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Data;

namespace formatingtext
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding();
            binding.Source = sliderFontSize;
            binding.Source = sliderBorderThickness;
            binding.Source = sliderCornerRadius;
            binding.Source = sliderIndentation;

            var installedFontCollection = new InstalledFontCollection();
            foreach (var fontFamily in installedFontCollection.Families)
            {
                cbFontFamilies.Items.Add(fontFamily.Name);
            }

            var properties = typeof(Brushes).GetProperties();
            foreach (var brushProp in properties)
            {
                cbFontColor.Items.Add(brushProp.Name);
                cbFillColor.Items.Add(brushProp.Name);
                cbBorderColor.Items.Add(brushProp.Name);
            }

            var aligment = typeof(TextAlignment).GetEnumNames();
            foreach (var aligmentX in aligment) {
                cbAligment.Items.Add(aligmentX);
            }  
        }

        private void Typeface_Checked(object sender, RoutedEventArgs e)
        {
            if (NormalTypeface.IsChecked == true)
            {
                tbText.FontStyle = FontStyles.Normal;
            }
            if (ItalicTypeface.IsChecked == true)
            {
                tbText.FontStyle = FontStyles.Italic;
            }

        }
        private void Weight_Checked(object sender, RoutedEventArgs e)
        {
            if (ThinWeight.IsChecked == true)
            {
                tbText.FontWeight = FontWeights.Thin;
            }
            if (NormalWeight.IsChecked == true)
            {
                tbText.FontWeight = FontWeights.Normal;
            }
            if (BoldWeight.IsChecked == true)
            {
                tbText.FontWeight= FontWeights.Bold;
            }
        }
    }
}
