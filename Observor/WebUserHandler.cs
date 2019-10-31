using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observor
{
    interface IWebUserHandler
    {
        void Subscribe(WebUser newUser);
        void Unsubscribe(WebUser removeUser);
        void Notify();
    }
    public class WebUserHandler: IWebUserHandler
    {
        private List<WebUser> ListOfWebUsersSubsribedMailingList = new List<WebUser>();
        private int inventory_count;
        public int Inventory
        {
            get
            {
                return inventory_count;
            }
            set
            {
                if (value > inventory_count)
                {
                    Notify();
                }
                inventory_count = value;
            }
        }
        public void Subscribe(WebUser newUser)
        {
            ListOfWebUsersSubsribedMailingList.Add(newUser);
        }

        public void Unsubscribe(WebUser removeUser)
        {
            ListOfWebUsersSubsribedMailingList.Remove(removeUser);
        }

        public void Notify()
        {
            ListOfWebUsersSubsribedMailingList.ForEach(x => x.Update());
        }
    }

}
