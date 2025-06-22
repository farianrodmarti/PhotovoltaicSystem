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
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            InitializeComponent();
        }


        private void sistema_fotovoltaico(object sender, RoutedEventArgs e)
        {



            stack.Children.Clear();
            TextBlock tx = new TextBlock();
            tx.Text = "Bienvenido a nuestra empresa";
            tx.Margin = new Thickness(110, 20, 0, 0);
            tx.FontSize = 26;
            tx.Foreground = Brushes.DarkSlateBlue;
            Button create_button = new Button();
            create_button.Margin = new Thickness(10);
            create_button.Content = "Crear nuevo sistema fotovoltaico";
            create_button.Click += Create_Photovoltaic_System_Click;
            create_button.FontSize = 18;
            create_button.Background = Brushes.AliceBlue;
            Button aquire_button = new Button();
            aquire_button.Margin = new Thickness(10);
            aquire_button.Content = "Adquirir un sistema fotovoltaico";
            aquire_button.Click += Aquire_Photovoltaic_System_Click;
            aquire_button.FontSize = 18;
            aquire_button.Background = Brushes.AliceBlue;
            Button update_button = new Button();
            update_button.Margin = new Thickness(10);
            update_button.Content = "Actualizar un sistema fotovoltaco";
            update_button.Click += Update_Photovoltaic_System_Click;
            update_button.FontSize = 18;
            update_button.Background = Brushes.AliceBlue;
            Button delete_button = new Button();
            delete_button.Margin = new Thickness(10);
            delete_button.Content = "Eliminar un sistema fotovoltaico";
            delete_button.Click += Delete_Photovoltaic_System_Click;
            delete_button.FontSize = 18;
            delete_button.Background = Brushes.AliceBlue;
            stack.Children.Add(tx); 
            stack.Children.Add(create_button);
            stack.Children.Add(aquire_button);          
            stack.Children.Add(update_button);
            stack.Children.Add(delete_button);




        }

        private void Delete_Photovoltaic_System_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Update_Photovoltaic_System_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Aquire_Photovoltaic_System_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Create_Photovoltaic_System_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }





        private void Panel(object sender, RoutedEventArgs e)
        {
            stack.Children.Clear();
            TextBlock tx = new TextBlock();
            tx.Text = "Bienvenido a nuestra empresa";
            tx.Margin = new Thickness(110, 20, 0, 0);
            tx.FontSize = 26;
            tx.Foreground = Brushes.DarkSlateBlue;
            Button create_button = new Button();
            create_button.Margin = new Thickness(10);
            create_button.Content = "Crear nuevo Panel Solar";
            create_button.Click += Create_Panel_Click;
            create_button.FontSize = 18;
            create_button.Background = Brushes.AliceBlue;
            Button aquire_button = new Button();
            aquire_button.Margin = new Thickness(10);
            aquire_button.Content = "Adquirir un Panel Solar";
            aquire_button.Click += Aquire_Panel_Click;
            aquire_button.FontSize = 18;
            aquire_button.Background = Brushes.AliceBlue;
            Button update_button = new Button();
            update_button.Margin = new Thickness(10);
            update_button.Content = "Actualizar un Panel Solar";
            update_button.Click += Update_panel_Click;
            update_button.FontSize = 18;
            update_button.Background = Brushes.AliceBlue;
            Button delete_button = new Button();
            delete_button.Margin = new Thickness(10);
            delete_button.Content = "Eliminar un Panel Solar";
            delete_button.Click += Delete_Panel_Click;
            delete_button.FontSize = 18;
            delete_button.Background = Brushes.AliceBlue;
            stack.Children.Add(tx);
            stack.Children.Add(create_button);
            stack.Children.Add(aquire_button);
            stack.Children.Add(update_button);
            stack.Children.Add(delete_button);

        }

        private void Aquire_Panel_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Create_Panel_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Update_panel_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Delete_Panel_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        

      

        private void inversor(object sender, RoutedEventArgs e)
        {
            TextBlock tx = new TextBlock();
            tx.Text = "Bienvenido a nuestra empresa";
            tx.Margin = new Thickness(110, 20, 0, 0);
            tx.FontSize = 26;
            tx.Foreground = Brushes.DarkSlateBlue;
            stack.Children.Clear(); 
            Button B2 = new Button();
            B2.Margin = new Thickness(10);
            B2.Content = "Adquirir inversores";
            B2.Click += Aquire_Inverter_Click;
            B2.FontSize = 18;
            B2.Background = Brushes.AliceBlue;
            Button B1 = new Button();
            B1.Margin = new Thickness(10);
            B1.Content = "Crear nuevo inversor";
            B1.Click += Create_Inverter_Click;
            B1.FontSize = 18;
            B1.Background = Brushes.AliceBlue;
           
            Button B3 = new Button();
            B3.Margin = new Thickness(10);
            B3.Content = "Actualizar un inversor";
            B3.Click += Update_inverter_Click;
            B3.FontSize = 18;
            B3.Background = Brushes.AliceBlue;
            Button B4 = new Button();
            B4.Margin = new Thickness(10);
            B4.Content = "Eliminar un inversor";
            B4.Click += Delete_Inverter_Click;
            B4.FontSize = 18;
            B4.Background = Brushes.AliceBlue;
            stack.Children.Add(tx);
            stack.Children.Add(B1);
            stack.Children.Add(B2);
            stack.Children.Add(B3);
            stack.Children.Add(B4);



        }

        private void Create_Inverter_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Aquire_Inverter_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Update_inverter_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Delete_Inverter_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

      

       

        private void Salir(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

       

       

       

       


    }
}
    
