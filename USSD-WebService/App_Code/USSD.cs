using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for USSD
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class USSD : System.Web.Services.WebService
{
    static string status = string.Empty;
    static string sid = string.Empty;
    public USSD()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    [ScriptMethod(UseHttpGet = true)]
    public void ussd(string userid, string password, string MSISDN, string input, string SID)
    {
        if (SID.CompareTo(sid) != 0)
        {
            sid = SID;
            status = String.Empty;
        }
        status = status + input;
        if (input == "check input")
        {
            status = status.Replace("check input", "");
            Continue(Menus.First);
            return;
        }
   
       
        #region Wrong Answer
        WrongAnswer();
        return;
        #endregion

    }
    private void Continue(string menu)
    {
        HttpContext.Current.Response.Output.WriteLine(menu);
        HttpContext.Current.Response.AddHeader("Freeflow", "FC");
        return;
    }
    private void End(string menu)
    {
        HttpContext.Current.Response.Output.WriteLine(menu);
        HttpContext.Current.Response.AddHeader("Freeflow", "FB");
        return;
    }

    private void WrongAnswer()
    {
        HttpContext.Current.Response.Output.WriteLine(Menus.WrongAnswer);
        HttpContext.Current.Response.AddHeader("Freeflow", "FB");
        return;
    }

}
