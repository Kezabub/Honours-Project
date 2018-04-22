using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace honproject.Models
{
    public class Q23
    {
        /// <summary>int Unique Identifier for an instace of Question</summary>
        [Key]
        [DisplayName("Question ID")]
        public int ID { get; set; }

        /// <summary>string Name of Answer</summary>
        [DisplayName("Answer")]
        public string Name { get; set; }

        /// <summary>virtual collection Contains all the products belonging to a specific instance of Category</summary>
        public virtual ICollection<Response> Responses { get; set; }
    }
}