using Kiddypi.Firebase;
using Kiddypi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kiddypi.ViewModel
{
 
        public class StudentViewModel : INotifyPropertyChanged
        {
            public string propertyName;



            public List<Student> StudentListxml = new List<Student>();

            public List<Student> studentlist
            {
                get { return StudentListxml; }
                set
                {
                    StudentListxml = value;
                    OnPropertyChanged();
                }
            }

            public StudentViewModel()
            {
                InitializationDataAsync();
            }


            private async Task InitializationDataAsync()
            {
                var stucentservices = new GetStudent();

                StudentListxml = stucentservices.Getstudent();

            }
            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
            {

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

