﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure the twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                _twitterAddress = value.StartsWith("@") ? value : throw new Exception("The twitter address must begin with @");
            }
        }
        public School()
        {

            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;

        }
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public static int AverageThreeScores(int a, int b, int c)
        {

            var result = (a + b + c) / 3;
            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.Append(State);
            sb.Append(",");
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}
