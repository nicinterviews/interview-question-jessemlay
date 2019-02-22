using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notown.Models
{
  public class MuscianSongs
  {
    public int Id { get; set; }
    public Musician Musician { get; set; }
    public Song Song { get; set; }
  }
}
