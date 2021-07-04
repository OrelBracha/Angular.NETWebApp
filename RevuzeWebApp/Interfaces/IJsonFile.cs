using RevuzeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevuzeWebApp
{
  public interface IJsonFile
    {

        IList<UserData> JsonFileAction(string path);
     

    }
}
