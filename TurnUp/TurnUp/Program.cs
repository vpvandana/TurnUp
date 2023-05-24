using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUp.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //Launch Browser
        IWebDriver driver = new ChromeDriver();
        
        //Login page object initialization and defenition
        Loginpage lp = new Loginpage();
        lp.Loginsteps(driver);

        //Home page object initialization and defenition
        Homepage hp = new Homepage();
        hp.Homesteps(driver);

        //Time and Material page initialization and defenition
        TMpage tm = new TMpage();
        tm.CreateTimerec(driver);
        tm.UpdateTimerec(driver);
        tm.Deleterec(driver);


    }
}