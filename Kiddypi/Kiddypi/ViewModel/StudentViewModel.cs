﻿using Firebase.Xamarin.Database;
using Kiddypi.Firebase;
using Kiddypi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kiddypi.ViewModel
{

    public class StudentViewModel : ViewModelBase
    {
        public string propertyName;

        public ObservableCollection<Student> Studentdetails { get; set; }

        public ICommand GetStudentCommand { get; set; }

        public StudentViewModel()
        {
            Studentdetails = new ObservableCollection<Student>();
            Title = "Student";
            GetStudentCommand = RefreshCommand = new Command(
                async () => await GetStudents(),
                () => !IsBusy);
        }


        async Task GetStudents()
        {
            if (IsBusy)
                return;

            Exception error = null;
            try
            {
                IsBusy = true;

                var firebase = new FirebaseClient("https://studentappfirebase-667c5.firebaseio.com/");

                var Items = await firebase.Child("StudentDetails").OnceAsync<Student>();

                //await DisplayAlert("ok", Items.ToString(), "ok");

                //Load Student into list
                Studentdetails.Clear();

                foreach (var item in Items)
                {

                    Studentdetails.Add(item.Object);
                }


               
                    
            }
            catch (Exception ex)
            {
               // Debug.WriteLine("Error: " + ex);
                error = ex;
                await Application.Current.MainPage.DisplayAlert("Error!", error.Message, "OK");

            }
            finally
            {
                IsBusy = false;
            }

            if (error != null)
                await Application.Current.MainPage.DisplayAlert("Error!", error.Message, "OK");
        }

    }

}


