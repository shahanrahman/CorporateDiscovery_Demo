using System;
using System.Linq;
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
    [Parallelizable]
    class DescoverHomePageTest02Demo
    {
        IWebDriver _driver = new ChromeDriver();

        [SetUp]
        public void Init()
        {
            _driver.Navigate().GoToUrl("https://corporate.discovery.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void TEST02_MenuMainLinkVerification()
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

                // Navigate to Our BusinessesBrands 

                IWebElement BusinessesBrands = _driver.FindElement(By.Id("menu-item-20053"));
                BusinessesBrands.Click();
                if (_driver.Url.Contains("businesses-and-brands/"))
                {
                    Console.WriteLine("Navigation to Businesses & Brands Home Page: Pass");
                }
                else
                {
                    Console.WriteLine("Navigation Businesses & Brands Home Page: Failed");
                }

                // Navigate to Newsroom 
                _driver.FindElement(By.ClassName("menu-toggle")).Click();
                IWebElement Newsroom = _driver.FindElement(By.Id("menu-item-23678"));
                System.Threading.Thread.Sleep(2000);

                Newsroom.Click();
                if (_driver.Url.Contains("discovery-newsroom/"))
                {
                    Console.WriteLine("Navigation to Newsroom Home Page: Pass");
                }
                else
                {
                    Console.WriteLine("Navigation Newsroom Home Page: Failed");
                }

                System.Threading.Thread.Sleep(2000);
                // Navigate to Investor Relations
                _driver.FindElement(By.ClassName("menu-toggle")).Click();

                IWebElement Relations = _driver.FindElement(By.Id("menu-item-1446"));
                System.Threading.Thread.Sleep(2000);

                Relations.Click();

                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
                if (_driver.Url.Contains("phx.corporate-ir"))
                {
                    Console.WriteLine("Navigation to Investor Relations Home Page: Pass");
                    _driver.SwitchTo().Window(_driver.WindowHandles.First());
                }
                else
                {
                    Console.WriteLine("Navigation Investor Relations Home Page: Failed");
                }

                // Navigate to Careers 
                IWebElement Careers = _driver.FindElement(By.Id("menu-item-1446"));
                System.Threading.Thread.Sleep(2000);

                Careers.Click();
                if (_driver.Url.Contains("careers/"))
                {
                    Console.WriteLine("Navigation to Careers Home Page: Pass");
                }
                else
                {
                    Console.WriteLine("Navigation Careers Home Page: Failed");
                }


                // Navigate to Blog 
                _driver.FindElement(By.ClassName("menu-toggle")).Click();
                IWebElement Blog = _driver.FindElement(By.Id("menu-item-1445"));
                System.Threading.Thread.Sleep(2000);

                Blog.Click();
                if (_driver.Url.Contains("blog/"))
                {
                    Console.WriteLine("Navigation to Blog Home Page: Pass");
                }
                else
                {
                    Console.WriteLine("Navigation Blog Home Page: Failed");
                }

                // Navigate to Discover your impact 
                _driver.FindElement(By.ClassName("menu-toggle")).Click();
                IWebElement impact = _driver.FindElement(By.Id("menu-item-25673"));
                System.Threading.Thread.Sleep(2000);

                impact.Click();
                if (_driver.Url.Contains("blog/"))
                {
                    Console.WriteLine("Navigation to Discover your impact Home Page: Pass");
                }
                else
                {
                    Console.WriteLine("Navigation Blog Discover your impact Page: Failed");
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
