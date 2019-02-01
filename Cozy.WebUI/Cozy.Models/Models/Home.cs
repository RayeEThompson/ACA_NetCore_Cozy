﻿using System;
namespace Cozy.Domain.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ImageURL { get; set; }

        //Foriegn Key (FK)
        public string LandLordId { get; set; }
        //navigational reference
        public Landlord Landlord { get; set; }
    }
}