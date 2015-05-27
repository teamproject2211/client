using System;
using System.Collections.Generic;
using System.IO;
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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientCallback MyClientCallback = null;
        //размеры ячеек
        int width = 50;
        int height = 50;

        //кол-во столбцов и строк
        int row = 15;
        int col = 20;
        string path = "";

        public MainWindow()
        {
            InitializeComponent();
            //this.path = Directory.GetCurrentDirectory();
            //FillingGrid();
            //DrawMap(InsertField());
            this.MyClientCallback = new ClientCallback();
            LoginWindow login = new LoginWindow(MyClientCallback);
            login.Show();
        }

        private void FillingGrid()
        {
            try
            {
                Image img = null;
                String url = @"../../Image/empty.jpg";
                RowDefinition r = null;
                ColumnDefinition c = null;
                int row = 15;
                int col = 21;

                //Создаем колонки 
                for (int i = 0; i < col; i++)
                {
                    c = new ColumnDefinition();
                    c.Width = new GridLength(width);
                    MapGrid.ColumnDefinitions.Add(c);
                }

                //создаем строки
                for (int j = 0; j < row; j++)
                {
                    r = new RowDefinition();
                    r.Height = new GridLength(height);
                    MapGrid.RowDefinitions.Add(r);

                    //Добавляем ячейки в строку (изображение)
                    for (int k = 0; k < col; k++)
                    {
                        img = new Image();
                        img.Tag = "0";
                        img.Source = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                        img.Stretch = Stretch.Fill;
                        img.Width = width;
                        img.Height = height;

                        //подписываемся на клик для смены изображения
                        //  img.MouseLeftButtonDown += img_MouseLeftButtonDown;

                        Grid.SetRow(img, j);
                        Grid.SetColumn(img, k);
                        Grid.SetColumnSpan(img, 1);

                        MapGrid.Children.Add(img);
                    }

                }

                this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            
        }


        private byte[][] InsertField()
        {
            try
            {
                StreamReader reader = new StreamReader("Map.txt");
                List<string> list = new List<string>();
                for (; !reader.EndOfStream; )
                {
                    list.Add(reader.ReadLine());
                }
                byte[][] arr = new byte[list.Count][];
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] strarr = list[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    arr[i] = new byte[strarr.Length];
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = byte.Parse(strarr[j]);
                    }
                }
                return arr;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return null; }
        }

        private void DrawMap(byte[][] map)
        {
            try
            {
                for (int i = 0; i < map.Length; i++)
                {
                    for (int j = 0; j < map[i].Length; j++)
                    {
                        Image img = (Image)MapGrid.Children.Cast<UIElement>().First(x => Grid.GetRow(x) == i && Grid.GetColumn(x) == j);
                        if (map[i][j] == 0)
                        {
                            img.Source = new BitmapImage(new Uri("../../Image/empty.jpg", UriKind.RelativeOrAbsolute));
                            img.Tag = "0";
                        }
                        else if (map[i][j] == 1)
                        {
                            img.Source = new BitmapImage(new Uri("../../Image/block.jpg", UriKind.RelativeOrAbsolute));
                            img.Tag = "1";
                        }
                        else if (map[i][j] == 2)
                        {
                            img.Source = new BitmapImage(new Uri("../../Image/brick.jpg", UriKind.RelativeOrAbsolute));
                            img.Tag = "2";
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
    }
}
