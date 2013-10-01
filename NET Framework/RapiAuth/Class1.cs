using System;
using System.Collections.Generic;
using System.Text;

namespace RapiAuth
{
    public class Authenticator
    {
        string api_Key;
        public Authenticator(string key)
        {
            api_Key = key;
        }

        public bool KontrolEt(string Token, string Kod)
        {            
            string adres = "http://auth.fatihbakir.net/v2/yeniAuth.php?basit=basit&api=" + api_Key + "&userToken=" + Token + "&kod=" + Kod;
            return sayfaAl(adres) == "success";
        }        

        string sayfaAl(string adres)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string kaynak = client.DownloadString(adres);
            return kaynak;
        }
    }
}
