using System;
using System.IO;
using System.Threading.Tasks;
using CitizenFX.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using static CitizenFX.Core.Native.API;

namespace language.Server
{
    public class ServerMain : BaseScript
    {

         YamlConfig lang = new YamlConfig("server_lang.yaml");

        public ServerMain()
        {
            Exports.Add("user_wrong", new Func<string>(user_wrong));
            Exports.Add("user_parameters_login_error", new Func<string>(user_parameters_login_error));
            Exports.Add("already_logged", new Func<string>(already_logged));
            Exports.Add("email_exists", new Func<string>(email_exists));
            Exports.Add("user_exists", new Func<string>(user_exists));
            Exports.Add("password_to_short", new Func<string>(password_to_short));
            Exports.Add("user_parameters_register_error", new Func<string>(user_parameters_register_error));
            Exports.Add("already_logged_registered", new Func<string>(already_logged_registered));
            Exports.Add("not_valid_email", new Func<string>(not_valid_email));
        }

        private string user_wrong(){return lang.data.user_wrong;}
        private string user_parameters_login_error(){return lang.data.user_parameters_login_error;}
        private string already_logged(){return lang.data.already_logged;}
        private string email_exists(){return lang.data.email_exists;}
        private string user_exists(){return lang.data.user_exists;}
        private string password_to_short(){return lang.data.password_to_short;}
        private string user_parameters_register_error(){return lang.data.user_parameters_register_error;}
        private string already_logged_registered(){return lang.data.already_logged_registered;}

        private string not_valid_email(){return lang.data.not_valid_email;}


    }
}