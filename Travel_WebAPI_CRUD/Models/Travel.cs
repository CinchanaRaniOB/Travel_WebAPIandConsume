using System;
using System.Collections.Generic;

namespace Travel_WebAPI_CRUD.Models
{
    public partial class Travel
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public string City { get; set; }
        public DateTime? Date { get; set; }
        public string Amount { get; set; }
    }
}
