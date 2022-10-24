using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace SQA_BootCamp_contour_FYP
{
    public class validinvalidProId: SQA_BootCamp_contour_FY_BaseClass
    {
        By validInvalidI = By.CssSelector("input[placeholder='Property ID']");
        By byclick = By.ClassName("_83386fbf");
        public void validInvalidID(String propertyId)
        {
            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            Write(validInvalidI, propertyId);
            Click(byclick);
            Thread.Sleep(1000);
            string Id_text = driver.FindElement(By.CssSelector("#body-wrapper > main > div._75f200b9 > div > div > span")).Text.ToString();
           
            Assert.AreEqual("House "+propertyId, Id_text);

        }
        public void validInvalidId(String propertyId)
        {
            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            Write(validInvalidI, propertyId);
            Click(byclick);
            //Thread.Sleep(1000);
            // string Id_text = driver.FindElement(By.CssSelector("#body-wrapper > main > div._75f200b9 > div > div > span")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
           

        }
    }
}
