using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Page
    {
        public IWebDriver driver { get { return BaseClass.driver; } }
    }

}
