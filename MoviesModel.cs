using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI1.Models
{
    public class MoviesModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public int MoviewImageId { get; set; }
        //public string MoviewImage { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Feedback { get; set; }
        public string Images { get; set; }
    }
}