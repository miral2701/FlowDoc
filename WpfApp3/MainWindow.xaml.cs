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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List myList = new List();

        public MainWindow()
        {
            InitializeComponent();
           
            Paragraph myParagraph = new Paragraph();

            myParagraph.Inlines.Add(new Bold(new Run("Notes->")));

        


         

            FlowDocument myFlowDocument = new FlowDocument();
            myFlowDocument.Blocks.Add(myParagraph);
            myFlowDocument.Blocks.Add(myList);


           
            FlowDocumentReader myFlowDocumentReader = new FlowDocumentReader();
            myFlowDocumentReader.Document = myFlowDocument;
            grid.Children.Add(myFlowDocumentReader) ;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Paragraph paragraphListItem1 = new Paragraph(new Run(textBox.Text));

            myList.ListItems.Add(new ListItem(paragraphListItem1));
            textBox.Text = "";
        }
    }
}
    
