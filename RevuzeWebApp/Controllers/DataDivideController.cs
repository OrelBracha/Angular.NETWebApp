using Microsoft.AspNetCore.Mvc;
using RevuzeWebApp.BussinessLogicServices;
using RevuzeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevuzeWebApp.Constants;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RevuzeWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataDivideController : ControllerBase
    {

        public string path = RevuzeWebApp.Constants.Constants.PATH;
        IJsonFile _js;
       // IList<UserData> changedList;
        List<groupUsers> result = new List<groupUsers>();
        groupUsers group1 = new groupUsers();
        groupUsers group2 = new groupUsers();
        groupUsers group3 = new groupUsers();
        groupUsers group4 = new groupUsers();
        
        
        
        public DataDivideController(IJsonFile js)
        {

            _js = js;


        }
        // GET: api/<DataDivideController>
        
        [HttpGet]
        public IList<groupUsers> Get()
        {

          return  monthDivide(_js.JsonFileAction(path));
        }

        public void monthGroupOrganize()
        {
            group1.from = 1;
            group1.to = 3;
            group2.from = 4;
            group2.to = 6;
            group3.from = 7;
            group3.to = 9;
            group4.from = 10;
            group4.to = 12;
        }
        
        public void intansiation()
        {
            group1.users = new List<userNewDetails>();
            group2.users = new List<userNewDetails>();
            group3.users = new List<userNewDetails>();
            group4.users = new List<userNewDetails>();
        }
        
        public IList<groupUsers> monthDivide (IList<UserData> listdata)
        {
            intansiation();
            monthGroupOrganize();
            for(int i=0; i<listdata.Count;i++)
            {
                int resultMonth = monthDetect(listdata[i].date);
                if(resultMonth>=1 && resultMonth<=3)
                {
                    userNewDetails tempGroup= new userNewDetails();
                    
                    tempGroup.addDetails(listdata[i].name, listdata[i].date, listdata[i].address);
                    
                    
                    group1.users.Add(tempGroup);
                }

                else if(resultMonth>=4 && resultMonth<=6)
                {
                    userNewDetails tempGroup = new userNewDetails();

                    tempGroup.addDetails(listdata[i].name, listdata[i].date, listdata[i].address);

                    group2.users.Add(tempGroup);
                }
                else if(resultMonth>=7 && resultMonth<=9)
                {
                    userNewDetails tempGroup = new userNewDetails();

                    tempGroup.addDetails(listdata[i].name, listdata[i].date, listdata[i].address);

                    group3.users.Add(tempGroup);
                }
                else
                {
                    userNewDetails tempGroup = new userNewDetails();

                    tempGroup.addDetails(listdata[i].name, listdata[i].date, listdata[i].address);

                    group4.users.Add(tempGroup);
                }
            }

            result.Add(group1);
            result.Add(group2);
            result.Add(group3);
            result.Add(group4);
            return result;
        }

        

        public int monthDetect (string bitrhDate)
        {
             string monthNumber = bitrhDate.Substring(5, 2);
             int month = Int16.Parse(monthNumber);
            return month;
        }
        
        // GET api/<DataDivideController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataDivideController>
        [HttpPost]
        public void Post()
        {
        
        }

        // PUT api/<DataDivideController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataDivideController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
