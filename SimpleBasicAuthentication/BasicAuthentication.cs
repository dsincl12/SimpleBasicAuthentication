using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBasicAuthentication
{
    public static class BasicAuthentication
    {
        public static AuthenticationHeaderValue Create(string username, string password)
        {
            string credentials = string.Format("{0}:{1}", username, password);
            var byteCredentials = Encoding.ASCII.GetBytes(credentials);
            var base64Credentials = Convert.ToBase64String(byteCredentials);

            return new AuthenticationHeaderValue("Basic", base64Credentials);
        }
    }
}
