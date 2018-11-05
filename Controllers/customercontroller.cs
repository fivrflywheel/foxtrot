using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        List<customer> customerlist = new List<customer>
             {
                new customer {
                     customerID = 1,
                     customerName = "Rajesh Ramamurthy",
                     phoneNumber = "825-456-4561" 
                 },
                 new customer {
                     customerID = 2,
                     customerName = "Ramya Sitaraman",
                     phoneNumber = "825-456-4562" 
                 },
                 new customer {
                     customerID = 3,
                     customerName = "Rohan Ramamurthy",
                     phoneNumber = "825-456-4563" 
                 }
             };
         public IEnumerable<customer> Get()
         {
             
             return customerlist;
         } 

         
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<customer> Get(int id)
        {
            try 
            {
                var customer = customerlist.Where(p => p.customerID==id).FirstOrDefault();
                return customer;
            }
            catch (Exception)
            {
                return NotFound();
            }
            
            
            
        }
    }
    

}
