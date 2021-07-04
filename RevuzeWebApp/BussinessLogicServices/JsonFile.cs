using Newtonsoft.Json;
using RevuzeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RevuzeWebApp.BussinessLogicServices
{
    public class JsonFile : IJsonFile
    {
        private readonly IJsonFile _jsonFile;
        private  string _filepath;

      public IList<UserData> usersList;
        public IList<UserData> JsonFileAction(string filepath)
        {
            _filepath = filepath;
            var webClient = new WebClient();
            var json = webClient.DownloadString(_filepath);
            var users = JsonConvert.DeserializeObject<IList<UserData>>(json);
            usersList = users;
            return usersList;
        }

      
        



    }
}


    