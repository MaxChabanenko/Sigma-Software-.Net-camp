﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassApp.Data
{
    internal static class PersonsParser
    {

        public static Person Parse(string text)
        {
            Random random = new Random();
            string[] atributes = text.Split();
          
            return new Person
                (atributes[0], 
                atributes[1],
                int.Parse(atributes[2]),
                double.Parse(atributes[3]),
                int.Parse(atributes[4]));
        }
    }
}
