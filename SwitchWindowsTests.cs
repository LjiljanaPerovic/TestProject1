using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SwitchWindowsTests
    {
        SwitchWindows switchWindows = new SwitchWindows();
        [Test]
        public void OpenAndCheckJavascriptAlert()
        {
            switchWindows.Visit();
            switchWindows.ClickAlertButton();
            switchWindows.CheckTextInAlertPopup();
        }
    }
}
