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
using System.Windows.Shapes;
using Project_EG_2020_4257.Model;
using Microsoft.Win32;

namespace Project_EG_2020_4257
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        
        public AddUserWindow(AddUserVM vm)

        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => closeAddUserWindow();
            vm.ClearData= () => clearData();
            vm.AddProfilePhoto = () => UploadPhoto();
        }

        private void Add_Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
            this.Close();
            Application.Current.MainWindow.Show();

        }


        public void UploadPhoto()
        {

            //selected_Image.Source = new BitmapImage();

        }

        public void clearData()
        {
            firstName_txt.Clear();
            lastName_txt.Clear();
            age_txt.Clear();
            dob_txt.Clear();
            gpa_txt.Clear();
            
            
        }

        public void closeAddUserWindow()
        {
            
            this.Close();
            
        }
    }
}
