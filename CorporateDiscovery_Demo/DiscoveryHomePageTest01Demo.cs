using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;


namespace CorporateDiscovery_Demo
{
    [TestFixture]
   // [Parallelizable]
    public class DiscoveryHomePageTest01Demo
    {
         IWebDriver _driver = new ChromeDriver();
 
       [SetUp]
        public void Init()
        {
            _driver.Navigate().GoToUrl("https://corporate.discovery.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test()]
        public void TEST01_HomePage()
        {
            if (_driver.FindElement(By.CssSelector(
                "#masthead > div.site-branding > a"))
                != null)
            {
                Console.WriteLine("Verification of Side Menu: Pass");
                IWebElement sideMenuDiscovery = 
                    _driver.FindElement(
                    By.CssSelector(
                        "#masthead > div.site-branding > a"));

                sideMenuDiscovery.Click();

                if (_driver.FindElement(
                    By.Id(
                    "mm-0"))
                    != null)
                {
                    Console.WriteLine("Verification of Side Menu Functionality: Pass");

                    Console.WriteLine("");
                    Console.WriteLine("Current Links Displayed via Side Menu : " + 
                        _driver.FindElement(By.Id("menu-main-menu")).Text);
                    Console.WriteLine("");

                    //Expand 'Our Company to view sub links'

                    IWebElement ourCompanySub = _driver.FindElement(By.CssSelector("#menu-item-1663 > a.mm-subopen"));
                    ourCompanySub.Click();
                    Console.WriteLine("Following Sub Links via Our Company : " + _driver.FindElement(By.Id("mm-1")).Text);
                    Console.WriteLine("");

                    IWebElement contactSub = _driver.FindElement(By.CssSelector("#menu-item-21706 > a.mm-subopen"));
                    contactSub.Click();
                    Console.WriteLine("Following Sub Links via Contact : " + _driver.FindElement(By.Id("mm-2")).Text);

                    _driver.FindElement(By.CssSelector("#mm-blocker")).Click();

                }

                System.Threading.Thread.Sleep(3000);

                // Verification of Search Display  
                IWebElement discoverySearch = _driver.FindElement(
                    By.CssSelector(
                    "#masthead > div.site-search > div.right-header-container > div.header-search-container > form > div"));
                discoverySearch.Click();

                if (_driver.FindElement(
                    By.CssSelector(
                    "#masthead > div.site-search > div.right-header-container > div.header-search-container > form > div"))
                    != null)
                {
                    Console.WriteLine("Verification Of Search Option: Pass");
                }
                discoverySearch.Click();

                // Verification of Stock Ticker 
                if (
                    _driver.FindElement(
                        By.CssSelector(
                            "#masthead > div.site-search > div.right-header-container > div.stock-ticker-container")) !=
                    null)
                {
                    Console.WriteLine("Verification of Stock Ticker Display : Pass");
                    Console.WriteLine("Current Stock Ticker Information : " + _driver.FindElement(By.CssSelector("#masthead > div.site-search > div.right-header-container > div.stock-ticker-container")).Text);
                }


              // Verify User is displayed all social Media Links 
                if (_driver.FindElement(By.Id("menu-social-icons-menu")) != null)
                {
                    //FB
                    if (_driver.FindElement(By.Id("menu-item-1383")) != null)
                    {
                        Console.WriteLine("Verification of FB Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of FB Link: Fail");
                    }

                    //Twitter
                    if (_driver.FindElement(By.Id("menu-item-1382")) != null)
                    {
                        Console.WriteLine("Verification of Twitter Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of Twitter Link: Fail");
                    }

                    //Instagram
                    if (_driver.FindElement(By.Id("menu-item-1661")) != null)
                    {
                        Console.WriteLine("Verification of Instagram Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of Instagram Link: Fail");
                    }

                    //youtube
                    if (_driver.FindElement(By.Id("menu-item-1384")) != null)
                    {
                        Console.WriteLine("Verification of youtube Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of youtube Link: Fail");
                    }

                    //LinkedIn
                    if (_driver.FindElement(By.Id("menu-item-1662")) != null)
                    {
                        Console.WriteLine("Verification of LinkedIn Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of LinkedIn Link: Fail");
                    }


                    //Email
                    if (_driver.FindElement(By.Id("menu-item-24709")) != null)
                    {
                        Console.WriteLine("Verification of Email Link: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Verification of Email Link: Fail");
                    }


                }
                else
                {
                    Console.WriteLine("Verification of Social Media Links: Failed");
                }



            }
            
            
        }



        [TearDown]
        public void CleanUp()
        {
            System.Threading.Thread.Sleep(5000);
            _driver.Close();
            
        }
    }
}
    

