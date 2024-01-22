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

namespace MusicListC
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Genre_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el género del botón clickeado
            string genre = (sender as Button).Tag.ToString();

            // Obtener canciones del género seleccionado
            List<string> songs = GetSongsByGenre(genre);

            // Limpiar ListBox
            ListBoxSongs.Items.Clear();

            // Agregar las canciones al ListBox
            foreach (string song in songs)
            {
                ListBoxSongs.Items.Add(song);
            }

            // Posicionar ListBox debajo del botón clickeado
            var button = sender as Button;
            var transform = button.TransformToAncestor(this);
            var location = transform.Transform(new Point(0, 0));

            ListBoxSongs.Margin = new Thickness(location.X, location.Y + button.ActualHeight, 0, 0);
        }

        private List<string> GetSongsByGenre(string genre)
        {
            // Simulando obtener canciones del género seleccionado
            // Puedes reemplazar esto con tu propia lógica para obtener las canciones
            List<string> songs = new List<string>();
            for (int i = 1; i <= GetRandomSongCount(); i++)
            {
                songs.Add($"Cancion {i}");
            }
            return songs;
        }

        private int GetRandomSongCount()
        {
            // Simulando obtener un número aleatorio de canciones
            // Puedes reemplazar esto con tu propia lógica para obtener el número de canciones
            Random random = new Random();
            return random.Next(1, 6); // Cambia el rango según tus necesidades
        }
    }
}