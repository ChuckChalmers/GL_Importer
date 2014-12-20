﻿using System;
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
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace GL_Importer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Logic for picking file and checking if it is proper extension
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            var open = new System.Windows.Forms.OpenFileDialog();
            var fileInteract = open.ShowDialog();
            switch(fileInteract)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = open.FileName;
                    txtFile.Text = file;
                    txtFile.ToolTip = file;
                    string test2 = open.ToString();
                    if(System.IO.Path.GetExtension(test2).ToUpper() != ".XML")
                    {
                        MessageBox.Show("Please select a valid .XML file", "Error");
                        txtFile.Clear();
                    }
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    txtFile.Text = null;
                    txtFile.ToolTip = null;
                    break;
            }

        }

        private void btnTestData_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "";
            string worksheet = "";
            filePath = txtFile.Text;
            worksheet = "Sheet1";

        }
    }
}
