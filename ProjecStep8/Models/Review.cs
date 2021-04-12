using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjecStep8.Models
{
    public class Review 
    {


        [Required(ErrorMessage = "PLease enter ID")]

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter UserId")]
        public int Userid { get; set; }

        [Required(ErrorMessage = "Please enter a Rating ")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter a Comment ")]
        public string Comments { get; set; }

    }
}
