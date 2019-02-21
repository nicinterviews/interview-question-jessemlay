﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notown.Models
{
  public class Address
  {
    public int Id { get; set; }
    public string Street { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public int Zip { get; set; }
    public string PhoneNumber { get; set; }
  }
}
