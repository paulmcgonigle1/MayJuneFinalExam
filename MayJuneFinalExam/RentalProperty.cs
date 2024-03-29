﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MayJuneFinalExam
{
    public enum RentalType//enum
    {
        House,
        Flat,
        Share
    }
    public class RentalProperty//class for property
    {
        //properties
        public int ID { get; set; }

        public RentalType RentalType { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string PropImage { get; set; }

        //constructors

        //methods
        public void IncreaseRent(decimal increase)
        {
            Price +=   Price * increase;
        }

        public override string ToString()
        {
            return Location + " " + $"€{Price}" ;
        }
    }//end of class

    public class RentalData1 : DbContext
    {
        public RentalData1() : base("RentalData1") { }

        public DbSet<RentalProperty> Properties { get; set; }
    }
}
