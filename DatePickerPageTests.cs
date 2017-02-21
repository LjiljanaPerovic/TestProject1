using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DatePickerPageTests
    {
        DatePickerPage datePicker;
        [SetUp]
        public void Setup()
        {
            datePicker = new DatePickerPage();
        }
        [Test]
        public void ClickFormatDateMenuItem()
        {
            datePicker.Visit();
            datePicker.ClickFormatDateMenuItem();
        }
    }
}
