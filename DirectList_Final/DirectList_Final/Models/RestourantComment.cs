using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class RestourantComment
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Restourant")]
        public int RestourantId { get; set; }
        public Restourant Restourant { get; set; }

        [ForeignKey("CommentPost")]
        public int CommentPostId { get; set; }
        public CommentPost CommentPost { get; set; }



    }
}
