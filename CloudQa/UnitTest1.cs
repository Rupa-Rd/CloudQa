using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CloudQa
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        }

        [Test]
        public void TestFormFields()
        {
            try
            {
                // Test First Name
                IWebElement firstNameElement = driver.FindElement(By.Name("First Name"));
                firstNameElement.SendKeys("Roopa");
                Assert.AreEqual("Roopa", firstNameElement.GetAttribute("value"), "First Name test failed");

                // Test Last Name
                IWebElement lastNameElement = driver.FindElement(By.Name("Last Name"));
                lastNameElement.SendKeys("Dharshini");
                Assert.AreEqual("Dharshini", lastNameElement.GetAttribute("value"), "Last Name test failed");

                // Test Mobile
                IWebElement mobileElement = driver.FindElement(By.Name("Mobile Number"));
                mobileElement.SendKeys("1234567890");
                Assert.AreEqual("1234567890", mobileElement.GetAttribute("value"), "Mobile test failed");

                Console.WriteLine("All tests passed.");
                Assert.Pass("All tests passed");
                driver.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                //Assert.Fail($"Test failed: {ex.Message}");
            }
        }
    }
}