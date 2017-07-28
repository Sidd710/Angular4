using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Angular4Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {

        public IHttpActionResult GetUser()
        {
            var context = new DataModel();
            var userExist = context.userDetails.Where(t => t.Fname == "").FirstOrDefault();
            if (userExist != null)
            {
                return Ok("true");
            }
            else
            {
                return Ok("false");
            }
        }
        [HttpPost]
        public IHttpActionResult validateUser(UserModel userDetails)
        {
            try
            {
                var context = new DataModel();
                var userExist = context.userDetails.Where(t => t.Fname == "").FirstOrDefault();
                if (userExist != null)
                {
                    return Ok(userDetails.username);
                }
                else
                {
                    return Ok(userDetails.username);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        [HttpPost]
        [ActionName("RegUser")]
        public IHttpActionResult RegisterUser([FromBody]  CustomUserModel userDetails)
        {
            try
            {
                var context = new DataModel();
                userDetail tempDetails = new userDetail();
                tempDetails.Age = userDetails.age;
                tempDetails.Fname = userDetails.firstName;
                tempDetails.Lname = userDetails.lastName;
                context.userDetails.Add(tempDetails);
                context.SaveChanges();
                return Ok();


            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public class UserModel
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        public class CustomUserModel
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            
        }

    }
}
