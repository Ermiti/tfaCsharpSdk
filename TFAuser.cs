using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace tfaCSharpSdk
{
    class TFAuser
    {
        static string accessToken;
        public string user(string UserToken)
         {
            string Server = "https://tele-fa-api.herokuapp.com/api/access/";
            string v=  $"{Server}{accessToken}/{UserToken}";

            return JsonConvert.SerializeObject(v);
        }

      
    }
}
