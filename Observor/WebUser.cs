using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observor
{
    public class WebUser:IWebUser
    {
        public string WebUserName { get; private set; }
        public string WebUserEmail{ get; private set; }
        public WebUser(string name, string email)
        {
            this.WebUserName = name;
            this.WebUserEmail = email;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new product has arrived at the store. An email was sent to {1}"
                ,this.WebUserName, this.WebUserEmail);
        }
    }
    interface IWebUser
    {
        void Update();
    }

}
