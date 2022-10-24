using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;
using System.Threading.Tasks;

namespace SQA_BootCamp_contour_FYP
{
    public class SQA_BootCamp_contour_FYP_Child_Signin : SQA_BootCamp_contour_FY_BaseClass
    {
        
        By Sign1_loc = By.CssSelector("div[title='Login']");
        By emailTxt = By.CssSelector("input[name='email']");
        By psdTxt = By.Id("password");
        By radiobtn = By.Id("rememberMe");
        By subClick = By.CssSelector("button[type='submit']");

        public void Signin_combine(String email,String psd)
        {

            try
            {
                string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
                Assert.AreEqual("Search properties for sale in Pakistan", ab);
                Click(Sign1_loc);
                string oR_text = driver.FindElement(By.XPath("//span[contains(text(),'OR')]")).Text.ToString();
                Assert.AreEqual("OR", oR_text);
                Write(emailTxt, email);
                Write(psdTxt, psd);
                Click(subClick);
            }
            catch(Exception e)
            {

            }
            finally
            {

            }
           


        }

        public void Signin_combinesel_radiobutton(String email, String psd)
        {
            try
            {
                string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
                Assert.AreEqual("Search properties for sale in Pakistan", ab);
                Click(Sign1_loc);
                string oR_text = driver.FindElement(By.XPath("//span[contains(text(),'OR')]")).Text.ToString();
                Assert.AreEqual("OR", oR_text);
                Write(emailTxt, email);
                Write(psdTxt, psd);
                Click(radiobtn);
                Click(subClick);
                CloseDriver();

                
            }
            catch (Exception e)
            {

            }
        }


    }
}
