using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace MessageEncrypter.App_Code
{
    public class Encrypter : IHttpModule
    {

        public Encrypter() { }

        public String ModuleName
        {
            get { return "Encrypter"; }
        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += (new EventHandler(this.Application_BeginRequest));
            application.EndRequest += (new EventHandler(this.Application_EndRequest));
        }

        private void Application_BeginRequest(Object source,EventArgs e)
        {
            
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            try
            {
                NameValueCollection nvc = context.Request.Form;
                string initialMessage = String.Empty;
                if (nvc != null)
                {
                    initialMessage = nvc["txtMessage"];

                    if (initialMessage != null && !initialMessage.Equals(String.Empty))
                    {
                        var encryptedMessage = encryptMessage(initialMessage);

                        context.Response.Write("<h3>" + encryptedMessage + "</h3>");
                    }
                }
            }
            catch (Exception ex)
            {
                context.Response.Write("Exception occured in OnError: [{0}]"+ ex.ToString());
            }
        }
        public string encryptMessage(string str)
        {

            System.Text.StringBuilder encryptedText = new System.Text.StringBuilder();

            char[] initialTextArray = str.ToLower().ToCharArray();

            foreach (char c in initialTextArray)
            {
                encryptedText.Append(encryptAlphabet(c));
            }


            return encryptedText.ToString();
        }

        public char encryptAlphabet(char c)
        {
            List<char> letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            if (c.Equals('z'))
            {
                return 'a';
            }
            else
            {
                return letters.ElementAt(letters.IndexOf(c) + 1);
            }
        }

        public void Dispose() { }

    }
}