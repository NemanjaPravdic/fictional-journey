﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace ResvoyageMobileApp.Models
{
    public class Location
    {
        public Position Position { get; set; }
        public string Address { get; set; }
        public string Label { get; set; }
    }
}
