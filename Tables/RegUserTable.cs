using System;
using System.Collections.Generic;
using System.Text;

namespace MA.Tables
{
    class RegUserTable
    {
        public Guid USerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string description { get; set; }
        public string FullName { get; set; }
        public bool is_admin { get; set; }
    }
}