using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observor
{
    class Program
    {
        static void Main(string[] args)
        {
            WebUserHandler subject = new WebUserHandler();
            // Observer1 takes a subscription to the store
            WebUser observer1 = new WebUser("James SMith","smithy@jay.com");
            subject.Subscribe(observer1);
            // Observer2 also subscribes to the store
            subject.Subscribe(new WebUser("Dean Martin","DeanyBabes1@DeanMister.com"));
            subject.Inventory++;



            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            Console.WriteLine("\n\n--------\n\n");
            subject.Unsubscribe(observer1);
            subject.Subscribe(new WebUser("Dave Smith", "Dsmith@smithworld.com"));
            subject.Inventory++;
            Console.ReadLine();
        }
    }
}
