using System;
using System.Collections.Generic;
using System.Text;

namespace FTRC.Data
{
    public class Regimen : SerializableObject
    {
        public Regimen()
        {
            Excercises = new List<int>();
        }

        public List<int> Excercises { get; set; }

    }
}
