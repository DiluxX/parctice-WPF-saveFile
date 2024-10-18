using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (save.ShowDialog() == true)
            {
                string filePath = save.FileName;
                File.WriteAllText(filePath, textBox.Text); // Сохранение текста в файл
                MessageBox.Show("Текст успешно сохранен!");
            }
            else
            {
                MessageBox.Show("Сохранение отменено");
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Изменяем размер шрифта текстового поля в зависимости от значения слайдера
            textBox.FontSize = e.NewValue;
        }
    }
}