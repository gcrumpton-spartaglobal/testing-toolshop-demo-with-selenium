using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium
{
    public record Page
    {
        public static HomePage HomePage { get; set; }
        public static CheckoutPage CheckoutPage { get; set; }
        public static SignInPage SignInPage { get; set; }
        public static RegisterAccountPage RegisterAccountPage { get; set; }
    }
}
