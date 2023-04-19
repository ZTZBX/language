using System;
using System.IO;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace language.Client
{
    public class ClientMain : BaseScript
    {
        YamlConfig lang = new YamlConfig("lang.yaml");

        public ClientMain()
        {
            Exports.Add("no_username", new Func<string>(no_username));
            Exports.Add("no_password", new Func<string>(no_password));
            Exports.Add("no_email", new Func<string>(no_email));
        }
        private string no_username(){return lang.data.no_username;}
        private string no_password(){return lang.data.no_password;}
        private string no_email(){return lang.data.no_email;}
    }
}