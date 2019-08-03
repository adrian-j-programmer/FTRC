using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Utilities;

namespace FTRC.Data
{
    public class Excercise : SerializableObject
    {
        public Excercise() : base()
        {
            Excercises = new ObservableCollection<Excercise>();
            Icon = string.Empty;
        }

        public string Icon { get; set; }
        public ObservableCollection<Excercise> Excercises { get; set; }
    }
}
