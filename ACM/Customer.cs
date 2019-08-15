﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + ", " + LastName;
            }
        }
        public string EmailAddress { get; set; }
        public string WorkAddress { get; set; }
    }
}