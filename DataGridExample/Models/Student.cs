using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample.Models
{
    public class Student : AbstractNotifyPropertyChanged
    {
        private string firstName;
        private string secondName;
        private bool isSemesterWorkDone;
        private float firstTermScore;
        private float secondTermScore;

        public string FirstName
        {
            get => firstName;
            set
            {
                SetAndRaise(ref firstName, value);
            }
        }

        public string SecondName
        {
            get => secondName;
            set
            {
                SetAndRaise(ref secondName, value);
            }
        }

        public bool IsSemesterWorkDone
        {
            get => isSemesterWorkDone;
            set
            {
                SetAndRaise(ref isSemesterWorkDone, value);
            }
        }

        public float FirstTermScore
        {
            get => firstTermScore;
            set
            {
                SetAndRaise(ref firstTermScore, value);
            }
        }

        public float SecondTermScore
        {
            get => secondTermScore;
            set
            {
                SetAndRaise(ref secondTermScore, value);
            }
        }
    }
}
