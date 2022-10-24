using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;


namespace SQA_BootCamp_contour_FYP
{
    [TestClass]
    public class SQA_BootCamp_contour_FY_TestClass
    {
        
        private TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        private static readonly log4net.ILog log =

log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        SQA_BootCamp_contour_FYP_Child_Signin Child_Signin = new SQA_BootCamp_contour_FYP_Child_Signin();
        validinvalidProId validinvalidProid = new validinvalidProId();
        SQA_BootCamp_contour_FYP_UnitConverter UnitConverter = new SQA_BootCamp_contour_FYP_UnitConverter();
        SQA_BootCamp_contour_FYP_Register_Form  RegisterForm = new SQA_BootCamp_contour_FYP_Register_Form();


         [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void TestMethod_SignIN_testcase_SPFTBTC1 ()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            
            string usermail = TestContext.DataRow["usermail"].ToString();

            string pass = TestContext.DataRow["password"].ToString();
            Child_Signin.urlbrowser(browser, urll);
            Child_Signin.Signin_combine(usermail,pass);




        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void TestMethod_SignIN_testcase_SPFTBTC2()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
           
            string usermail = TestContext.DataRow["usermail"].ToString();

            string pass = TestContext.DataRow["rpassword"].ToString();
            Child_Signin.urlbrowser(browser, urll);
            Child_Signin.Signin_combine(usermail, pass);




        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void combinesel_radiobutton5()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();

            string usermail = TestContext.DataRow["usermail"].ToString();

            string pass = TestContext.DataRow["password"].ToString();
            Child_Signin.urlbrowser(browser, urll);
            Child_Signin.Signin_combinesel_radiobutton(usermail, pass);
           // Thread.Sleep(1000);
           // Child_Signin.urlbrowser(browser, urll);




        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void validinvalidProId_SPFTBTC17()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            string validId = TestContext.DataRow["validid"].ToString();



            string pass = TestContext.DataRow["rpassword"].ToString();
            validinvalidProid.urlbrowser(browser, urll);
            validinvalidProid.validInvalidID(validId);
            







        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void validinvalidProId_SPFTBTC18()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            string invalidId = TestContext.DataRow["invalid"].ToString();


            string pass = TestContext.DataRow["rpassword"].ToString();
            validinvalidProid.urlbrowser(browser, urll);
            validinvalidProid.validInvalidId(invalidId);








        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void Verify_search_property_trends_SPFTBTC16()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            UnitConverter.urlbrowser(browser, urll);
            UnitConverter.Verify_search_property_trends();







        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void Verify_the_area_unit_converter14()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            UnitConverter.urlbrowser(browser, urll);
            UnitConverter.should_not_accept_Negative_values15();







        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void should_not_accept_Negative_values15()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            UnitConverter.urlbrowser(browser, urll);
            UnitConverter.should_not_accept_Negative_values15();
            







        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "file.csv", DataAccessMethod.Sequential)]
        public void agent_register_successfullyTC6()
        {
            string browser = TestContext.DataRow["browser"].ToString();
            string urll = TestContext.DataRow["url"].ToString();
            RegisterForm.urlbrowser(browser,urll);
            RegisterForm.agent_register_successfully();

        }





    }


}
