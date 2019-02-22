using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notown.Models
{
  public class Musician
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string SSN { get; set; }
    public Address Address { get; set; }    
  }
}
