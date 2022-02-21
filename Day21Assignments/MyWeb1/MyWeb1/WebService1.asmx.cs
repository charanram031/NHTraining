using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWeb1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        /// <summary>
        /// This Method is used to find factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
                fact= fact * i;
            return fact;
        }
        /// <summary>
        /// This method is used to perform Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [WebMethod]
        public int Add(int a,int b)
        {
            return a+b;
        }
        /// <summary>
        /// This method is used to perform Division
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [WebMethod]
        public int Div(int a, int b)
        {
            return a / b;
        }
        /// <summary>
        /// This method is used to perform Multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [WebMethod]
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
