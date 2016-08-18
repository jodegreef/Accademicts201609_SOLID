using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCWeb
{
    public class HelloWorldService : IHelloWorldService
    {
        public string Hello()
        {
            return "World";
        }
    }
}