﻿using System;
using System.Collections.Generic;
using System.Text;
using static task8.FileReader;

namespace task8
{
    class Flat
    {
        int number;
        public int FlatNumber
        {
            get { return number; }
            set { _ = value > 0 ? number = value : number = 0; }
        }

        public string OwnerSurname { get; set; }

        int first;
        public int StartIndication
        {
            get { return first; }
            set { _ = value > 0 ? first = value : first = 0; }
        }

        int last;
        public int EndIndication
        {
            get { return last; }
            set { _ = value > 0 ? last = value : last = 0; }
        }

        int date1;
        public int FirstDate
        {
            get { return date1; }
            set { _ = value > 0 ? date1 = value : date1 = 0; }
        }
        int date2;
        public int SecondDate
        {
            get { return date2; }
            set { _ = value > 0 ? date2 = value : date2 = 0; }
        }
        int date3;
        public int ThirdDate
        {
            get { return date3; }
            set { _ = value > 0 ? date3 = value : date3 = 0; }
        }


        int Quarter;

        public override string ToString()
        {
            return String.Format("Квартира №{0,3}; Прізвище власника = {1,15}; Початкові покази = {2,5}; Кінцеві покази = {3,5};" +
                " Дати передачі показів :{4,8}, {5,8}, {6,8}",
               FlatNumber,
                OwnerSurname,
               StartIndication,
                EndIndication,
                (FirstDate.ToString() + '.' + (Quarter - 1) * 3 + ".22"),
                (SecondDate.ToString() + '.' + ((Quarter - 1) * 3 + 1) + ".22"),
                (ThirdDate.ToString() + '.' + ((Quarter - 1) * 3 + 2) + ".22")) + '\n';
        }
        public Flat(int flatnumber,string owner,int start,int last,int d1,int d2,int d3, int q=0)
        {
            FlatNumber = flatnumber;
            OwnerSurname = owner;
            StartIndication = start;
            EndIndication = last;
            FirstDate = d1;
            SecondDate = d2;
            ThirdDate = d3;
            Quarter = q;
        }



       
        public static bool operator ==(Flat a, Flat b)
        {
            if (a.FlatNumber == b.FlatNumber && a.OwnerSurname == b.OwnerSurname)
                return true;

            return false;
        }
        public static bool operator !=(Flat a, Flat b)
        {
            if (a.FlatNumber != b.FlatNumber && a.OwnerSurname != b.OwnerSurname)
                return true;

            return false;
        }
    }
}
