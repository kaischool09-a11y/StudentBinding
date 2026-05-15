using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        private Student displayedStudent;
        private Student student1;
        private Student student2;
        public Student DisplayedStudent
        {
            get { return displayedStudent; }
            set { displayedStudent = value; OnPropertyChanged(); }
        }
        
        public MainPage()
        {
            InitializeComponent();
           student1 = new Student
            {
                Name = "hampter",
                ImageSource = "hampter.jpg",
                BirthDate = new DateTime(2000, 1, 1)
            };
           student2 = new Student
            {
                Name = "mort",
                ImageSource = "mort.jpg",
                BirthDate = new DateTime(2001, 2, 2)
            };

            DisplayedStudent = student1;
            this.BindingContext = this;

        }
       
      private void StudentSwitchClick(object sender, EventArgs e)
        {
            if (DisplayedStudent== student1)
            {
                DisplayedStudent = student2;
               
            }
            else
            {
                DisplayedStudent = student1;
                
            }
        }
    }
}
