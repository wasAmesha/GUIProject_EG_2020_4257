using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Project_EG_2020_4257.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Project_EG_2020_4257
{
    public  partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public  ObservableCollection<User> users;

        [ObservableProperty]
        public User selectedUser=null;



        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            vm.title = "Add Student";
            vm.detail = "Enter the details to add the student to the system";
            

            var window = new AddUserWindow(vm);
            window.ShowDialog();
            
            if (vm.Student.FirstName != null)
            {
                users.Add(vm.Student);

            }
            else
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                
            }
            
        }



        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                
                string name = selectedUser.FirstName;

                MessageBoxResult result = MessageBox.Show($"Are you sure? Do you want to delete {name}?", "Warning!", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    users.Remove(selectedUser);
                    MessageBox.Show($"{name} is Deleted Successfully.", "Message");
                }
                else
                {
                    MessageBox.Show($"Cancled deleting {name}.", "Message");
                }


            }
            else
            {
                MessageBox.Show("Please Select the Student before Delete.", "Error");

            }
        }



        [RelayCommand]
        public void ExecuteEditStudent()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                vm.title = "Edit Student";
                vm.detail = "Edit the student details and save the changes in system";

                var window = new AddUserWindow(vm);
                window.ShowDialog();


                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, vm.Student);

            }
            else
            {
                MessageBox.Show("Please Select the Student", "Warning!");
            }
        }



        public  MainWindowVM()
        {
            users = new ObservableCollection<User>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
            users.Add(new User(11, "FirstName1", "LastName1","1", "11/01/2000",image1));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            users.Add(new User(12, "FirstName2", "LastName2","2", "12/02/2000",image2));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Images/3.png", UriKind.Relative));
            users.Add(new User(13, "FirstName3", "LastName3","3", "13/03/2000",image3));
            BitmapImage image4= new BitmapImage(new Uri("/Model/Images/4.png", UriKind.Relative));
            users.Add(new User(14, "FirstName4", "LastName4","4", "14/04/2000", image4));

        }
    }
}
