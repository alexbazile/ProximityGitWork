using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageEncrypter
{
    public class EncryptionHelper
    {
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
		//Git Test2
    }
}