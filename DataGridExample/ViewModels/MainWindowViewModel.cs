
using DataGridExample.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace DataGridExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<int> ints;
        private ObservableCollection<Student> students;

        public MainWindowViewModel()
        {
            Ints = new ObservableCollection<int>();
            Ints.Add(1);
            Ints.Add(2);
            Ints.Add(3);
            Ints.Add(4);
            Ints.Add(5);

            Students = new ObservableCollection<Student>();
            Students.Add(
                new Student
                {
                    FirstName = "Anton",
                    SecondName = "Mileshko",
                    FirstTermScore = 0.6F,
                    SecondTermScore = 1.6F,
                    IsSemesterWorkDone = false,
                }
                );

            students.Add(
                new Student
                {
                    FirstName = "Anton",
                    SecondName = "Mileshko",
                    FirstTermScore = 1.2F,
                    SecondTermScore = 0.4F,
                    IsSemesterWorkDone = true,
                });

            students.Add(
                new Student
                {
                    FirstName = "Anton",
                    SecondName = "Mileshko",
                    FirstTermScore = 0.6F,
                    SecondTermScore = 1.6F,
                    IsSemesterWorkDone = false,
                });
        }

        public ObservableCollection<int> Ints
        {
            get => ints;
            set
            {
                this.RaiseAndSetIfChanged(ref ints, value);
            }
        }

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                this.RaiseAndSetIfChanged(ref students, value);
            }
        }
    }
}