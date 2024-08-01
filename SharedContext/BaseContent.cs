using Murillo.NotificationContext;

namespace Murillo.SharedContext 
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