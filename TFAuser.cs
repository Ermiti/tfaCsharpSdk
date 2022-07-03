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

        public string user(string UserId, string TokenId)
         {
            string Server = "https://tele-fa-api.herokuapp.com/api/access/";
            string v=  $"{Server}{TokenId}/{UserId}";
          
             return JsonConvert.SerializeObject(v);
        }

      
    }
}
