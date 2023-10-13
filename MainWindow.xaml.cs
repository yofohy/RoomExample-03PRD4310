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
using RoomLibrary03ПРд4310;


namespace RoomExample_03ПРд4310
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;//разрешаем открыть вторую комнату
            /// инициализация полей класса и генерация числа человек
            room1.RoomLenght = rnd.Next(2, 11);
            room1.RoomWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            ///вывод сгенерированные данные в метки
            LabelLenght1.Content = room1.RoomLenght;
            LabelWidth1.Content = room1.RoomWidth;
            LabelNumPerson1.Content = numP;

            ///вычисление периметра, площади, метража и вывод в метки
            LabelPerimetr1.Content = room1.RoomPerimetr();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonArea1.Content = Math.Round(room1.PersonArea(numP),0);

            

              

        }

        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            ButtonAll.IsEnabled = true;//разрещать суммировать площади комнат
           ///ввод данных инициализация полей класса и генерация числа человек
            room2.RoomLenght = Convert.ToDouble(TBLenght2.Text);
            room2.RoomWidth = Convert.ToDouble(TBWidth2.Text);
            int numP = Convert.ToInt32(TBNumPerson2.Text);

            ///вычисление периметра, площади, метража и вывод в метки
            LabelPerimetr2.Content = room2.RoomPerimetr();
            LabelArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room1.PersonArea(numP), 0);
        }

        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            LabelAllArea.Content = room1.RoomArea() + room2.RoomArea();
        }
    }
}
