using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDay03
{
    /// <summary>
    /// Interaction logic for Document.xaml
    /// </summary>
    public partial class Document : Window
    {
        public Document()
        {
            InitializeComponent();
            Paragraph p = new Paragraph();
            p.Inlines.Add(File.ReadAllText(@"C:\Users\dell\Desktop\DummyText.txt"));
            FlowDocument flow = new FlowDocument(p);
            flwdoc.Document = flow;


        }
    }
}
