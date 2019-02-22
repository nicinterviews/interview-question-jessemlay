using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notown.Models
{
  public class Album
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CopyRightDate { get; set; }
    public string Format { get; set; }
    public int AlbumIdentifier { get; set; }

    public string ProducerName { get; set; }
    public Musician Producer { get; set; }
  }
}
