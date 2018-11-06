using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFTest.UI.Menu
{
    /// <summary>
    /// TopMenuPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenuPage : ChildPage
    {
        Label labelLighten;
        Brush brush_light = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        Brush brush_normal = new SolidColorBrush(Color.FromRgb(239, 248, 251));


        public MainMenuPage()
        {
            InitializeComponent();

            label2.Background = brush_light;
            labelLighten = label2;
        }

        private void label1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter0");
        }

        private void label2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter1");
            labelLighten.Background = brush_normal;
            label2.Background = brush_light;
            labelLighten = label2;
        }

        private void label3_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter2");

            labelLighten.Background = brush_normal;
            label3.Background = brush_light;
            labelLighten = label3;
        }

        private void label4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter3");

            labelLighten.Background = brush_normal;
            label4.Background = brush_light;
            labelLighten = label4;
        }

        private void label5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter4");

            labelLighten.Background = brush_normal;
            label5.Background = brush_light;
            labelLighten = label5;
        }

        private void label6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter5");

            labelLighten.Background = brush_normal;
            label6.Background = brush_light;
            labelLighten = label6;
        }

        private void label7_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter6");
            labelLighten.Background = brush_normal;
            label7.Background = brush_light;
            labelLighten = label7;
        }

        private void label8_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter7");
            labelLighten.Background = brush_normal;
            label8.Background = brush_light;
            labelLighten = label8;
        }

        private void label9_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter8");
        }

        private void ChildPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter1");
        }
    }
}
