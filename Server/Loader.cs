using System.IO;
using static CitizenFX.Core.Native.API;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace language.Server
{
    public class LoadServerSide
    {
        public string user_wrong { get; set; }
        public string user_parameters_login_error { get; set; }
        public string already_logged { get; set; }
        public string user_exists { get; set; }
        public string password_to_short { get; set; }
        public string email_exists { get; set; }
        public string user_parameters_register_error { get; set; }
        public string already_logged_registered { get; set; }
        public string not_valid_email { get; set; }
        public string no_username { get; set; }
        public string no_password { get; set; }
        public string no_email { get; set; }
        public string banned_message { get; set; }
    }

    public class YamlConfig
    {
        public LoadServerSide data;
        public YamlConfig(string filePath)
        {
            string contents = File.ReadAllText($"{GetResourcePath(GetCurrentResourceName())}/languagePacks/{filePath}");
            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
            data = deserializer.Deserialize<LoadServerSide>(contents);
        }
    }
}