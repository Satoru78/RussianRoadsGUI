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


namespace RussianRoadsGUI.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            LoadDocuments();
        }
        private void LoadDocuments()
        {
            string folderPath = @"C:\Users\Магнат\Documents";  // Укажите путь к вашей директории с документами
             var docFiles = new List<DocumentFile>();

            foreach (var file in Directory.GetFiles(folderPath, "*.docx"))
            {
                docFiles.Add(new DocumentFile
                {
                    Name = Path.GetFileName(file),
                    FullPath = file
                });
            }

            DocumentsListView.ItemsSource = docFiles;
        }
        /// <summary>
        /// Открытие документа по дабл клику(не обязательно)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentsListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (DocumentsListView.SelectedItem is DocumentFile selectedFile)
            {
                System.Diagnostics.Process.Start("explorer", selectedFile.FullPath);
            }
        }
    }

    public class DocumentFile
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
    }
}

