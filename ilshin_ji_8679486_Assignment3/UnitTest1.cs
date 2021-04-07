/*Project: IJAssignment03
 *Purpose: Unit Test with Selenium of an application. PROG2070 Assignemnt03 
 *History: 
 *Created by Ilshin Ji April 7, 2021
 */


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace ilshin_ji_8679486_Assignment3
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase(null)]
        [TestCase("A")]
        [TestCase("John")]
        [TestCase("Ilshin")]
        public void TestSellerName(string name)
        {
            //Arrange
            driver.Url = "http://localhost/web/";
            IWebElement txtSellerName = driver.FindElement(By.Id("txtSellerName"));
            IWebElement txtSellerNameValidation = driver.FindElement(By.Id("txtSellerNameValidation"));

            //Act
            txtSellerName.SendKeys(name);
            txtSellerName.SendKeys("\t");

            //Assert
            string validationText = txtSellerNameValidation.GetAttribute("innerHTML");
            if(validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("a")]
        [TestCase(1)]
        [TestCase("207 Holbeach Crescent")]
        public void TestAddress(string address)
        {
            //Arrange
            driver.Url = "http://localhost/web/";
  
            IWebElement txtAddress = driver.FindElement(By.Id("txtSellerName"));
            IWebElement txtAddressValidation = driver.FindElement(By.Id("txtAddressValidation"));

            //Act
            txtAddress.SendKeys(address);

            //Assert
            string validationText = txtAddressValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("b")]
        [TestCase(2)]
        [TestCase("Waterloo")]
        public void TestCity(string city)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtCity = driver.FindElement(By.Id("txtCity"));
            IWebElement txtCityValidation = driver.FindElement(By.Id("txtCityValidation"));

            //Act
            txtCity.SendKeys(city);

            //Assert
            string validationText = txtCityValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("C")]
        [TestCase(0)]
        [TestCase("ON")]
        [TestCase("ontario")]
        public void TestProvince(string province)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtProvince = driver.FindElement(By.Id("txtCity"));
            IWebElement txtProvinceValidation = driver.FindElement(By.Id("txtProvinceValidation"));

            //Act
            txtProvince.SendKeys(province);

            //Assert
            string validationText = txtProvinceValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("A")]
        [TestCase(000000)]
        [TestCase("N2J 4Y3")]
        [TestCase("n2j4y3")]
        [TestCase("2b4y3u")]
        public void TestPostalCode(string postalCode)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtPostalCode = driver.FindElement(By.Id("txtPostalCode"));
            IWebElement txtPostalCodeValidation = driver.FindElement(By.Id("txtPostalCodeValidation"));

            //Act
            txtPostalCode.SendKeys(postalCode);

            //Assert
            string validationText = txtPostalCodeValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("0110000000")]
        [TestCase("000000")]
        [TestCase("1231231234")]
        [TestCase("555-555-5555")]
        [TestCase("514.244.4544")]
        public void TestPhoneNumber(string phoneNumber)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtPhoneNumber = driver.FindElement(By.Id("txtPhoneNumber"));
            IWebElement txtPhoneNumberValidation = driver.FindElement(By.Id("txtPhoneNumberValidation"));

            //Act
            txtPhoneNumber.SendKeys(phoneNumber);

            //Assert
            string validationText = txtPhoneNumberValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("a@")]
        [TestCase("ilshin@conestogac.on.ca")]
        [TestCase("ilshin@gmail.com")]
        [TestCase("lala@hotmail")]
        [TestCase("mail")]
        public void TestEmail (string email)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtEmail = driver.FindElement(By.Id("txtEmail"));
            IWebElement txtEmailValidation = driver.FindElement(By.Id("txtEmailValidation"));

            //Act
            txtEmail.SendKeys(email);

            //Assert
            string validationText = txtEmailValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase("ford")]
        [TestCase("Hyundai")]
        public void TestMake(string make)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtMake = driver.FindElement(By.Id("txtMake"));
            IWebElement txtMakeValidation = driver.FindElement(By.Id("txtMakeValidation"));

            //Act
            txtMake.SendKeys(make);

            //Assert
            string validationText = txtMakeValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase(0)]
        [TestCase("Mustang")]
        public void TestModel(string model)
        {
            //Arrange
            driver.Url = "http://localhost/web/";

            IWebElement txtModel = driver.FindElement(By.Id("txtModel"));
            IWebElement txtModelValidation = driver.FindElement(By.Id("txtModelValidation"));

            //Act
            txtModel.SendKeys(model);

            //Assert
            string validationText = txtModelValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestCase(null)]
        [TestCase(0)]
        [TestCase("1900")]
        [TestCase("2012")]
        [TestCase("3000")]
        public void TestYear(string year)
        {
            //Arrange
            driver.Url = "http://localhost/web/";
            IWebElement txtYear = driver.FindElement(By.Id("txtYear"));
            IWebElement txtYearValidation = driver.FindElement(By.Id("txtYearValidation"));

            //Act
            txtYear.SendKeys(year);

            //Assert
            string validationText = txtYearValidation.GetAttribute("innerHTML");
            if (validationText == "")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }


        [TestCase("AA", "bb", "2012")]
        [TestCase("Hyundai", "Elantra", "2018")]
        public void TestUrl(string make, string model, string year)
        {
            //Arrange
            driver.Url = "http://localhost/web/";


            IWebElement txtSellerName = driver.FindElement(By.Id("txtSellerName"));
            IWebElement txtAddress = driver.FindElement(By.Id("txtAddress"));
            IWebElement txtCity = driver.FindElement(By.Id("txtCity"));
            IWebElement txtProvince = driver.FindElement(By.Id("txtProvince"));
            IWebElement txtPostalCode = driver.FindElement(By.Id("txtPostalCode"));
            IWebElement txtPhoneNumber = driver.FindElement(By.Id("txtPhoneNumber"));
            IWebElement txtEmail = driver.FindElement(By.Id("txtEmail"));
            IWebElement txtMake = driver.FindElement(By.Id("txtMake"));
            IWebElement txtModel = driver.FindElement(By.Id("txtModel"));
            IWebElement txtYear = driver.FindElement(By.Id("txtYear"));
            IWebElement btnSave = driver.FindElement(By.Id("btnSave"));
            IWebElement result = driver.FindElement(By.Id("result"));

            //Act
            txtSellerName.SendKeys("John");
            txtAddress.SendKeys("11 University Ave");
            txtCity.SendKeys("Waterloo");
            txtProvince.SendKeys("ON");
            txtPostalCode.SendKeys("N2J 4Y3");
            txtPhoneNumber.SendKeys("226-222-2222");
            txtEmail.SendKeys("john@conestogac.on.ca");
            txtSellerName.SendKeys("John");
            txtMake.SendKeys(make);
            txtModel.SendKeys(model);
            txtYear.SendKeys(year);
            btnSave.Click();
        
            IWebElement link = driver.FindElement(By.TagName("a"));
            string url = link.GetAttribute("href");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Foo";
            request.Accept = "*/*";
            var response = (HttpWebResponse)request.GetResponse();

            //Assert
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Assert.Pass();
                response.Close();
            }
            else
            {
                Assert.Fail();
            }

        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}