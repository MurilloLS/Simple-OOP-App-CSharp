using Murillo.SharedContext;

namespace Murillo.SubscriptionContext
{
  public class User : BaseContent
  {
    public string Username { get; set; }
    public string Password { get; set; }
  }
}