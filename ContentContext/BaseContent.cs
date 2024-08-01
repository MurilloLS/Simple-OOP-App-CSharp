using Murillo.NotificationContext;

namespace Murillo.ContentContext 
{
  public abstract class BaseContent : Notifiable
  {
    public BaseContent()
    {
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
  }
}