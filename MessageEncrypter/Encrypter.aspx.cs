using System;
using System.Web;

namespace MessageEncrypter
{
    public partial class Encrypter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Request URL: " + HttpContext.Current.Request.Url);
            Response.Write("</br>");

            Response.Write("Number of Session variable: " + HttpContext.Current.Session.Count);
            Response.Write("</br>");

            Response.Write("current Timestamp: " + HttpContext.Current.Timestamp);
            Response.Write("</br>");

            Response.Write("Object in Application level: " + HttpContext.Current.Application.Count);
            Response.Write("</br>");

            Response.Write("Is Debug Enable in current Mode?: " + HttpContext.Current.IsDebuggingEnabled);
            Response.Write("</br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void txtMessage_TextChanged(object sender, EventArgs e)
        {
            Response.Cookies["userName"].Value = "patrick";
            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(1);

            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
			//Git Test
        }
    }
}