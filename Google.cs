using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


public class UnitTest2
{
    //IWebdriver driver = new ChromeDriver();
    ChromeDriver driver;
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");
        
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("--------Test1-----------");
        driver =new ChromeDriver();
        driver.Url="https://www.google.com/";
        Thread.Sleep(2000);
        driver.Manage().Window.Maximize();
        Thread.Sleep(2000);
        driver.FindElement(By.Name("q")).SendKeys("Selenium");
        Thread.Sleep(4000);
        driver.FindElement(By.Name("btnK")).Click();
        Thread.Sleep(5000);
        
       // driver.Close();


        //Assert.Pass();
    }
   
    

    
                    }