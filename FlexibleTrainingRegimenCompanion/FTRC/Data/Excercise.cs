using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FTRC.Data
{
    public class Excercise : SerializableObject
    {
        public Excercise() : base()
        {
            Excercises = new List<int>();
            Icon = string.Empty;
        }

        public string Icon { get; set; }
        public List<int> Excercises { get; set; }
    }
}
