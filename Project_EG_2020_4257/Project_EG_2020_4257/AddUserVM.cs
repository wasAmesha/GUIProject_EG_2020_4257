using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Project_EG_2020_4257.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Project_EG_2020_4257
{
    public partial class AddUserVM : ObservableObject

    {
        
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public string gpa;


        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public string detail;

        [ObservableProperty]
        public Image defaultImage;


        [ObservableProperty]
        public BitmapImage selectedImage;

      

        public AddUserVM(User u)
        {
            Student = u;
          
            firstname  = Student.FirstName;
            lastname = Student.LastName;
            age = Student.Age;
            gpa = Student.GPA;
            dateofbirth = Student.DateOfBirth;
            selectedImage=Student.Image;
            
        }
        public AddUserVM()
        {
            
        }


        //get image
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));
                

                MessageBox.Show("Image is Successfully Uploded!", "Successful");
            }
        }


        public User Student { get; private set; }
        public Action CloseAction { get; internal set; }

        public Action ClearData { get; internal set; }

        public Action AddProfilePhoto { get; internal set; }

        [RelayCommand]
        public void Save()
        {
          double gpaVal=Convert.ToDouble(gpa);

            if (gpaVal<0.0 || gpaVal>4.0) {

                MessageBox.Show("GPA value must be between 0 and 4.", "Error" );
                return;
            }

            if(Student==null)
            {

                Student = new User()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,
                    GPA = gpa

                };


            }
            else
            {
                
                Student.FirstName = firstname;
                Student.LastName = lastname;
                Student.Age = age;
                Student.GPA = gpa;
                Student.Image = selectedImage;
                Student.DateOfBirth = dateofbirth;
                
            }
           
            if(Student.FirstName != null ) 
            { 
                CloseAction();
                
            }
            else
            {
                MessageBox.Show("You should enter the First Name !", "Error");
                return;
            }    

        }


        [RelayCommand]
        public void Clear()
        {
            ClearData();
            
        }

        /*
        [RelayCommand]
        public void Cancel()
        {
            
            CloseAction();

            
        }*/

    }
}
