using System.Linq;
using Murillo.ContentContext;
using Murillo.SubscriptionContext;

namespace Murillo
{
  class Program
  {
    static void Main(string[] args)
    {
      var payPalSubscription = new PayPalSubscription();

      var student = new Student();
      student.CreateSubscription(payPalSubscription);
    }
  }
}