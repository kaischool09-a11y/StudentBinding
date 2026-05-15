using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    public class Student: ObservableObject

    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); } 
        }

        private string imageSource;
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; OnPropertyChanged(); }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set { birthDate = value; OnPropertyChanged(); }
        }
    }
}
