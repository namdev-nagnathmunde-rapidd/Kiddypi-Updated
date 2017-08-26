using Kiddypi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Kiddypi.Firebase
{
    public class GetStudent
    {

        public List<Student> Getstudent()
        {

            var List = new List<Student>()
            { new Student
            { StudentName="Namdev",
                StudentID ="2647",
                Age ="12",
                DOB ="12/34/2008",
                Image ="URL"},
                new Student{ StudentName="Namdev",
                    StudentID ="2647"
                    ,Age="12",
                    DOB ="12/34/2008",
                    Image ="URL"} };
 
            return List;
        }
    }
}