using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SQA_BootCamp_contour_FYP
{
    public class SQA_BootCamp_contour_FYP_UnitConverter: SQA_BootCamp_contour_FY_BaseClass
    {
        By ptrend = By.Id("propertyTrendsId");
        By cityclick = By.XPath("//label[contains(text(),'City')]");
        By cityId = By.Id("search_text");
        By citydone = By.CssSelector("li[data-text='lahore']");
        By location = By.Id("tab_cat_id_field");
        By purpose = By.XPath("//label[contains(text(),'Purpose')]"); 
        By purposeselect = By.XPath("//li[contains(text(),'Rental Trends')]");
        By propertyType = By.CssSelector("div[data-dd_class='ptype-dropdown']");
        By propertytypeSelect = By.XPath("//li[contains(text(),'Houses')]");
        By find = By.Id("search_trends");
        By converter = By.Id("areaUnitConverterId");
        
        By firstconveration = By.CssSelector("label[for='marla|square-yard']"); 
            By secondconveration = By.CssSelector("label[for='square-meter|square-yard']");
        By thirdconveration = By.CssSelector("label[for='kanal|marla']");
        By negativevalueclick = By.CssSelector("input[value='1']");


        public void Verify_search_property_trends()
        {
            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            Click(ptrend);
            //Thread.Sleep(1000);
            string verifytrendpage= driver.FindElement(By.XPath("//h1[contains(text(),'Find most searched locations in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Find most searched locations in Pakistan", verifytrendpage);
            Click(cityclick);
            Write(cityId, "Lahore");
            Click(citydone);
            Write(location, "DHA");
            Click(purpose);
            Click(purposeselect);
            Thread.Sleep(1000);
            //Click(propertyType);
            //Click(propertytypeSelect);
            Click(find);
            string verifytrendSearchpage = driver.FindElement(By.XPath("//h2[contains(text(),'Rental Trends for Properties in Lahore')]")).Text.ToString();
            //Assert.AreEqual("Rental Trends for Properties in Lahore " +
             //   " Buying Trends", verifytrendSearchpage);
            		

        }

        public void Verify_the_area_unit_converter14()
        {



            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Click(converter);
            string verifyunitconpage = driver.FindElement(By.XPath("//h1[contains(text(),'Area Unit Converter')]")).Text.ToString();
            Assert.AreEqual("Area Unit Converter", verifyunitconpage);
            Click(firstconveration);
            string verifymarla = driver.FindElement(By.XPath("//div[contains(text(),'Marla')]")).Text.ToString();
            Assert.AreEqual("Marla", verifymarla);
            string SquareYards = driver.FindElement(By.XPath("//div[contains(text(),'Square Yards (Sq. yd.)')]")).Text.ToString();
            Assert.AreEqual("Square Yards (Sq. yd.)", SquareYards);
            Thread.Sleep(1000);
            Click(secondconveration);
            string squaremeter = driver.FindElement(By.XPath("//div[contains(text(),'Square Meters (Sq. m.)')]")).Text.ToString();
            Assert.AreEqual("Square Meters (Sq. m.)", squaremeter);
            
            Assert.AreEqual("Square Yards (Sq. yd.)", SquareYards);
            Thread.Sleep(1000);
            Click(thirdconveration); 
                string Kanal = driver.FindElement(By.XPath("//div[contains(text(),'Kanal')]")).Text.ToString();
            Assert.AreEqual("Kanal", Kanal);
            Assert.AreEqual("Marla", verifymarla);

        }
        public void should_not_accept_Negative_values15()

        {
            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Click(converter);
            Thread.Sleep(1000);
            string verifyunitconpage = driver.FindElement(By.XPath("//h1[contains(text(),'Area Unit Converter')]")).Text.ToString();
            Assert.AreEqual("Area Unit Converter", verifyunitconpage);
            Clear(negativevalueclick);
            Write(negativevalueclick, "90");
        }

    }
}
