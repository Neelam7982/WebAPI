using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Api_crud.Models
{
    public class employeemodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}