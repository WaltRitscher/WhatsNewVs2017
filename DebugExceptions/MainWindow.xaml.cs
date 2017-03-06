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

namespace DebugExceptions {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void IndexExceptionButton_Click(object sender, RoutedEventArgs e) {
      var books = new List<string>();
      books.Add("HLSL and Pixel Shaders for XAML Developers");

      string bookName = books[5]; // try to access an non-existent  item
                                  // comment:  a long comment that could get obscured by the exception helper.  a long comment that could get obscured by the exception helper. 
                                  //  a long comment that could get obscured by the exception helper. a long comment that could get obscured by the exception helper. 
    }

    private void handlerButton_Click(object sender, RoutedEventArgs e) {

      resultTextBlock.Text = Models.ArtDataSource.GetArtPrice("Portaments");

    }

    private void DivideButton_Click(object sender, RoutedEventArgs e) {
      resultTextBlock.Text = GetAverageCustomerSales(sales: 1500, customerCount: 0).ToString();
    }
    private double GetAverageCustomerSales(int sales, int customerCount) {
      try
      {

        var result = sales / customerCount;
        return result;
      }
      catch (DivideByZeroException ex)
      {

        throw new ArgumentOutOfRangeException("Customer Count cannot be zero", ex);
      }
    }
  }
}
