using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SQA_BootCamp_contour_FYP
{
public class SQA_BootCamp_contour_FYP_Register_Form: SQA_BootCamp_contour_FY_BaseClass
    {
        By Sign1_loc = By.CssSelector("div[title='Login']");
        By become_member_btn = By.XPath("//button[contains(text(),'Become a free member')]");
        By email = By.Id("email");
        By reg_password = By.Id("reg_password");
        By reg_password_again = By.Id("reg_password_again");
        By name = By.Id("name");
        By countrycode = By.CssSelector("div[tabindex='0']");
        By mobile = By.Id("mobile");
        By phone = By.Id("phone");
        By select2countrycontainer = By.Id("select2-country-container");
        By selecon = By.CssSelector("span[title='Pakistan']");
        By select2 = By.Id("select2-pak_cities-container");
        By seleconcity = By.CssSelector("#pak_cities > option:nth-child(14)");
        By role_input = By.Id("role_input");
        //By role_input_indiv = By.Id("label[for='role_2']");
        //By role_2 = By.Id("role_2");
        
        By captcha_code = By.Id("captcha_code");
        //string captchacopy = driver.FindElement(By.CssSelector("div[maxlength='4']")).Text.ToString();
        By agree = By.Id("agree");
        By update = By.Id("update");
        By register = By.XPath("//button[contains(text(),'register')]");

        //
        public void agent_register_successfully()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            string ab = driver.FindElement(By.XPath("//h1[contains(text(),'Search properties for sale in Pakistan')]")).Text.ToString();
            Assert.AreEqual("Search properties for sale in Pakistan", ab);
            Click(Sign1_loc);
            Thread.Sleep(5000);
            string oR_text = driver.FindElement(By.CssSelector("#strat-strat-dialog-5715-container > div > div > div > div > div > div._68fb91f6 > form > span")).Text.ToString();
            Assert.AreEqual("OR", oR_text);
            Click(become_member_btn);
            Thread.Sleep(1000);
            string become_member = driver.FindElement(By.XPath("//h1[contains(text(),'Become A Free Member')]")).Text.ToString();
            Assert.AreEqual("Become A Free Member", become_member);
            //Click(countrycode);
            Write(email,"234re");
            Write(reg_password, "2367");
            Write(reg_password_again, "234");
            Write(name, "sdgk");
            Write(mobile, "12345678");
            Write(phone, "1234568");
            Click(select2countrycontainer);
            Click(selecon);
            Thread.Sleep(1000);
            Click(select2);
            Click(seleconcity);
            Click(role_input);
            IWebElement role_2 = driver.FindElement(By.Id("role_2"));
            var selectdrop = new SelectElement(role_2);
            selectdrop.SelectByText("Owner/Investor");
            role_2.Click();
           
           
            //Click(role_2);

        }
    }
}
