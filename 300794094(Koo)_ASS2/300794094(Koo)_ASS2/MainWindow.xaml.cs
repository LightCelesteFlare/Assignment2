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

namespace _300794094_Koo__ASS2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double subtotal = 0;
        public double tax = .15;
        public double total;

        string a;
        string b;
        string c;
        string d;
        double a1;
        double b1;
        double c1;
        double d1;
        public MainWindow()
        {
            InitializeComponent();
            Beverage.Items.Add(new ComboBoxItem("Soda $1.95"));
            Beverage.Items.Add(new ComboBoxItem("Tea $1.50"));
            Beverage.Items.Add(new ComboBoxItem("Coffee $1.25"));
            Beverage.Items.Add(new ComboBoxItem("Mineral Water $2.95"));
            Beverage.Items.Add(new ComboBoxItem("Juice $2.50"));
            Beverage.Items.Add(new ComboBoxItem("Milk $1.50"));

            Appetizer.Items.Add(new ComboBoxItem("Buffalo Wings     $5.95"));
            Appetizer.Items.Add(new ComboBoxItem("Buffalo Fingers   $6.95"));
            Appetizer.Items.Add(new ComboBoxItem("Potato Skins      $8.95"));
            Appetizer.Items.Add(new ComboBoxItem("Nachos            $8.95"));
            Appetizer.Items.Add(new ComboBoxItem("Mushroom Caps     $10.95"));
            Appetizer.Items.Add(new ComboBoxItem("Shrimp Cocktail   $12.95"));
            Appetizer.Items.Add(new ComboBoxItem("Chips and Salsa   $6.95"));

            Main_Course.Items.Add(new ComboBoxItem("Seafood Alfredo  $15.95"));
            Main_Course.Items.Add(new ComboBoxItem("Chicken Alfredo  $13.95"));
            Main_Course.Items.Add(new ComboBoxItem("Turkey Club      $11.95"));
            Main_Course.Items.Add(new ComboBoxItem("Lobster Pie      $19.95"));
            Main_Course.Items.Add(new ComboBoxItem("Prime Rib        $20.95"));
            Main_Course.Items.Add(new ComboBoxItem("Shrimp Scampi    $18.95"));
            Main_Course.Items.Add(new ComboBoxItem("Turkey Dinner    $13.95"));
            Main_Course.Items.Add(new ComboBoxItem("Stuffed Chicken  $14.95"));

            Dessert.Items.Add(new ComboBoxItem("Apple Pie       $5.95"));
            Dessert.Items.Add(new ComboBoxItem("Sundae          $3.95"));
            Dessert.Items.Add(new ComboBoxItem("Carrot Cake     $5.95"));
            Dessert.Items.Add(new ComboBoxItem("Mud Pie         $4.95"));
            Dessert.Items.Add(new ComboBoxItem("Apple Crisp     $5.95"));

            //Beverage.Items.Add(new ComboBoxItem(0, "Soda"));
            //Beverage.Items.Add(new ComboBoxItem(1, "Tea"));
            //Beverage.Items.Add(new ComboBoxItem(2, "Coffee"));
            //Beverage.Items.Add(new ComboBoxItem(3, "Mineral Water"));
            //Beverage.Items.Add(new ComboBoxItem(4, "Juice"));
            //Beverage.Items.Add(new ComboBoxItem(5, "Milk"));
            //Appetizer.Items.Add(new ComboBoxItem(0, "Buffalo Wings"));
            //Appetizer.Items.Add(new ComboBoxItem(1, "Buffalo Fingers"));
            //Appetizer.Items.Add(new ComboBoxItem(2, "Potato Skins"));
            //Appetizer.Items.Add(new ComboBoxItem(3, "Nachos"));
            //Appetizer.Items.Add(new ComboBoxItem(4, "Mushroom Caps"));
            //Appetizer.Items.Add(new ComboBoxItem(5, "Shrimp Cocktail"));
            //Appetizer.Items.Add(new ComboBoxItem(6, "Chips and Salsa"));
            //Main_Course.Items.Add(new ComboBoxItem("0", "Seafood Alfredo"));
            //Main_Course.Items.Add(new ComboBoxItem("1", "Chicken Alfredo"));
            //Main_Course.Items.Add(new ComboBoxItem("2", "Turkey Club"));
            //Main_Course.Items.Add(new ComboBoxItem("3", "Lobster Pie"));
            //Main_Course.Items.Add(new ComboBoxItem("4", "Prime Rib"));
            //Main_Course.Items.Add(new ComboBoxItem("5", "Shrimp Scampi"));
            //Main_Course.Items.Add(new ComboBoxItem("6", "Turkey Dinner"));
            //Main_Course.Items.Add(new ComboBoxItem("7", "Stuffed Chicken"));
            //Dessert.Items.Add(new ComboBoxItem("0", "Apple Pie"));
            //Dessert.Items.Add(new ComboBoxItem("1", "Sundae"));
            //Dessert.Items.Add(new ComboBoxItem("2", "Carrot Cake"));
            //Dessert.Items.Add(new ComboBoxItem("3", "Mud Pie"));
            //Dessert.Items.Add(new ComboBoxItem("4", "Apple Crisp"));

        }

        private void Beverage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            a = ((ComboBoxItem)Beverage.SelectedItem).ToString();
            a1 = (Convert.ToDouble(a.Split('$')[1]));
            subtotal = d1 + a1 + b1 + c1;
            tax = subtotal * .15;
            total = subtotal + tax;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(tax);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void Appetizer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            b = ((ComboBoxItem)Appetizer.SelectedItem).ToString();
            b1 = (Convert.ToDouble(b));
            subtotal = d1 + a1 + b1 + c1;
            tax = subtotal * .15;
            total = subtotal + tax;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(tax);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void Main_Course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            c = ((ComboBoxItem)Main_Course.SelectedItem).ToString();
            c1 = (Convert.ToDouble(c));
            subtotal = d1 + a1 + b1 + c1;
            tax = subtotal * .15;
            total = subtotal + tax;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(tax);
            txtTotal.Text = Convert.ToString(Total);

        }

        private void Dessert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            d = ((ComboBoxItem)Dessert.SelectedItem).ToString();
            d1 = (Convert.ToDouble(d));
            subtotal = d1 + a1 + b1 + c1;
            tax = subtotal * .15;
            total = subtotal + tax;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(tax);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Beverage.Items.Clear();
            Main_Course.Items.Clear();
            Appetizer.Items.Clear();
            Dessert.Items.Clear();
            
            subtotal = 0;
            tax = 0;
            total = 0;

            txtSubtotal.Text = "$0.00";
            txtTax.Text = "$0.00";
            txtTotal.Text = "$0.00";
        }

    }
   
    public class ComboBoxItem

    {

        public double Value;

        public string Text;

        public ComboBoxItem(/*double val,*/ string text)

        {

            //Value = val;

            Text = text.Split('$')[0];
            Value = Convert.ToDouble(text.Split('$')[1]);

        }



        public override string ToString()

        {

            return Text;

        }

    }
}
