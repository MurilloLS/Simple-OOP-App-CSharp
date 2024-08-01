using Murillo.NotificationContext;
using Murillo.SharedContext;

namespace Murillo.ContentContext
{
  public class CareerItem : BaseContent
  {
    public CareerItem(int ordem, string title, string description, Course course)
    {
      if (course == null)
        AddNotification(new Notification("Course", "Curso Invalido"));
        
      Order = ordem;
      Title = title;
      Description = description;
      Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}