using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI1.Models
{
    public class MoviesReview
    {
        //public int ReviewId { get; set; }
        public string MoviewReviewName { get; set; }
        public int MovieId { get; set; }
        public int MovieRating { get; set; }
        //public string MoviewImage { get; set; }
        public int MoviewImageId { get; set; }
        public string Feedback { get; set; }
        public string Username { get; set; }

    }
}