using System;
using System.Collections.Generic;
using System.Text;

namespace MA.Tables
{
    class Posts
    {
        
        public Guid PostId { get; set; }
        public string Title {get; set;}
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


}
}
