using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI_Execption.Models;
using WEBAPI_Execption.CustomFilterRepo;
using System.Web.Http.Description;

namespace WEBAPI_Execption.Controllers
{
    
    /// <summary>
    /// Apply the Exception Filter at the Class level
    /// </summary>
    public class EmployeeInfoAPIController : ApiController
    {
        ApplicationEntities ctx;

        public EmployeeInfoAPIController()
        {
            ctx = new ApplicationEntities(); 
        }
        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Get(int id)
        {
            var emp = ctx.EmployeeInfoes.Find(id);

            if (emp == null)
            {
                throw new ProcessException("Record Not Found, It may be removed");
            }
            return Ok(emp);
        }

        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Post(EmployeeInfo employeeInfo)
        {
            if (!ModelState.IsValid)
            {
                //Throw the Exception by settings Error Message
                
                throw new ProcessException("One or more entered values are invalid, please check");
            }

            ctx.EmployeeInfoes.Add(employeeInfo);
            ctx.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeInfo.EmpNo }, employeeInfo);
        }
    }
}