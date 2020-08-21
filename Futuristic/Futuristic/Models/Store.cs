﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Futuristic.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Frenchise { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int OutSideLine { get; set; }
        public int CheckOutLine { get; set; }
        public string Address { get; set; }
        public double Latitutude { get; set; }
        public double Longtitude { get; set; }
        public double Distance { get; set; }
        public string DistanceString { get; set; }
        public string OpenCloseTime { get; set; }
        public string TimeLabel { get; set; }
        public string TimeLabelColor { get; set; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }
        public string commaStoreTimings { get; set; }
        public string WeeklyTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
