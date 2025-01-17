using Murillo.ContentContext.Enums;
using Murillo.SharedContext;

namespace Murillo.ContentContext
{
  public class Lecture : BaseContent
  {
    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}