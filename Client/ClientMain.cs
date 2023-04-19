using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace language.Client
{
    public class LoadClientSide
    {
        public string no_username { get; set; }
        public string no_password { get; set; }
        public string no_email { get; set; }
    }

    public class YamlConfig
    {
        public LoadClientSide data;
        public YamlConfig()
        {
            string contents = File.ReadAllText($"{GetResourcePath(GetCurrentResourceName())}/languagePacks/{filePath}");
            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
            data = deserializer.Deserialize<LoadServerSide>(contents);
        }
    }
}