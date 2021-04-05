using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Web_project.Models
{
    
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
