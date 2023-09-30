using System;
using System.Net.Http.Headers;

namespace staff.core
{
    public class staffObj
    {
        public int staffId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private int _level;
        public int Level
        {
            get { return _level; }
            set { if (value == 1 || value == 2 || value == 3) 
                        {
                     _level = value ;
                        } else 
                           {
                    _level = 1;
                           }   
                }
        }

        private string _department; // prevents stack overflow 
        public string Department 
        {
            get { return _department; } 
            set {
                if (value == "Accounting" || value == "Engineer" || value == "Sales")
                {
                    _department = value;
                }
                    else 
                    {
                    _department = "Enter one of these Departments [Accounting,Engineer,Sales,]";
                    }
                } 
        }
    }
}
