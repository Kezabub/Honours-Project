using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace honproject.Models
{
    public class Response
    {
        /// <summary>int Unique Identifier for a Q1</summary>
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Author")]
        public string Author { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        [DisplayName("Creation Date")]
        public DateTime CreationDate { get; set; }

        /// <summary>int Unique Identifier for a Q1</summary>
        [DisplayName("Question 1 Answer")]
        public int Q1Id { get; set; }

        /// <summary>int Unique Identifier for a Q2</summary>
        [DisplayName("Question 2 Answer")]
        public int Q2Id { get; set; }

        /// <summary>int Unique Identifier for a Q3</summary>
        [DisplayName("Question 3 Answer")]
        public int Q3Id { get; set; }

        /// <summary>int Unique Identifier for a Q4</summary>
        [DisplayName("Question 4 Answer")]
        public int Q4Id { get; set; }

        /// <summary>int Unique Identifier for a Q5</summary>
        [DisplayName("Question 5 Answer")]
        public int Q5Id { get; set; }

        /// <summary>int Unique Identifier for a Q6</summary>
        [DisplayName("Question 6 Answer")]
        public int Q6Id { get; set; }

        /// <summary>int Unique Identifier for a Q7</summary>
        [DisplayName("Question 7 Answer")]
        public int Q7Id { get; set; }

        /// <summary>int Unique Identifier for a Q8</summary>
        [DisplayName("Question 8 Answer")]
        public int Q8Id { get; set; }

        /// <summary>int Unique Identifier for a Q9</summary>
        [DisplayName("Question 9 Answer")]
        public int Q9Id { get; set; }

        /// <summary>int Unique Identifier for a Q10</summary>
        [DisplayName("Question 10 Answer")]
        public int Q10Id { get; set; }

        /// <summary>int Unique Identifier for a Q11</summary>
        [DisplayName("Question 11 Answer")]
        public int Q11Id { get; set; }

        /// <summary>int Unique Identifier for a Q12</summary>
        [DisplayName("Question 12 Answer")]
        public int Q12Id { get; set; }

        /// <summary>int Unique Identifier for a Q13</summary>
        [DisplayName("Question 13 Answer")]
        public int Q13Id { get; set; }

        /// <summary>int Unique Identifier for a Q14</summary>
        [DisplayName("Question 14 Answer")]
        public int Q14Id { get; set; }

        /// <summary>int Unique Identifier for a Q15</summary>
        [DisplayName("Question 15 Answer")]
        public int Q15Id { get; set; }

        /// <summary>int Unique Identifier for a Q16</summary>
        [DisplayName("Question 16 Answer")]
        public int Q16Id { get; set; }

        /// <summary>int Unique Identifier for a Q17</summary>
        [DisplayName("Question 17 Answer")]
        public int Q17Id { get; set; }

        /// <summary>int Unique Identifier for a Q18</summary>
        [DisplayName("Question 18 Answer")]
        public int Q18Id { get; set; }

        /// <summary>int Unique Identifier for a Q19</summary>
        [DisplayName("Question 19 Answer")]
        public int Q19Id { get; set; }

        /// <summary>int Unique Identifier for a Q20</summary>
        [DisplayName("Question 20 Answer")]
        public int Q20Id { get; set; }

        /// <summary>int Unique Identifier for a Q21</summary>
        [DisplayName("Question 21 Answer")]
        public int Q21Id { get; set; }

        /// <summary>int Unique Identifier for a Q22</summary>
        [DisplayName("Question 22 Answer")]
        public int Q22Id { get; set; }

        /// <summary>int Unique Identifier for a Q23</summary>
        [DisplayName("Question 23 Answer")]
        public int Q23Id { get; set; }

        /// <summary>int Unique Identifier for a Q24</summary>
        [DisplayName("Question 24 Answer")]
        public int Q24Id { get; set; }

        /// <summary>int Unique Identifier for a Q25</summary>
        [DisplayName("Question 25 Answer")]
        public int Q25Id { get; set; }

        /// <summary>int Unique Identifier for a Q26</summary>
        [DisplayName("Question 26 Answer")]
        public int Q26Id { get; set; }

        /// <summary>Category The instance of Q1 to which this specific product belongs</summary>
        public virtual Q1 Q1 { get; set; }

        /// <summary>Category The instance of Q2 to which this specific product belongs</summary>
        public virtual Q2 Q2 { get; set; }

        /// <summary>Category The instance of Q3 to which this specific product belongs</summary>
        public virtual Q3 Q3 { get; set; }

        /// <summary>Category The instance of Q4 to which this specific product belongs</summary>
        public virtual Q4 Q4 { get; set; }

        /// <summary>Category The instance of Q5 to which this specific product belongs</summary>
        public virtual Q5 Q5 { get; set; }

        /// <summary>Category The instance of Q6 to which this specific product belongs</summary>
        public virtual Q6 Q6 { get; set; }

        /// <summary>Category The instance of Q7 to which this specific product belongs</summary>
        public virtual Q7 Q7 { get; set; }

        /// <summary>Category The instance of Q8 to which this specific product belongs</summary>
        public virtual Q8 Q8 { get; set; }

        /// <summary>Category The instance of Q9 to which this specific product belongs</summary>
        public virtual Q9 Q9 { get; set; }

        /// <summary>Category The instance of Q10 to which this specific product belongs</summary>
        public virtual Q10 Q10 { get; set; }

        /// <summary>Category The instance of Q11 to which this specific product belongs</summary>
        public virtual Q11 Q11 { get; set; }

        /// <summary>Category The instance of Q12 to which this specific product belongs</summary>
        public virtual Q12 Q12 { get; set; }

        /// <summary>Category The instance of Q13 to which this specific product belongs</summary>
        public virtual Q13 Q13 { get; set; }

        /// <summary>Category The instance of Q14 to which this specific product belongs</summary>
        public virtual Q14 Q14 { get; set; }

        /// <summary>Category The instance of Q15 to which this specific product belongs</summary>
        public virtual Q15 Q15 { get; set; }

        /// <summary>Category The instance of Q16 to which this specific product belongs</summary>
        public virtual Q16 Q16 { get; set; }

        /// <summary>Category The instance of Q17 to which this specific product belongs</summary>
        public virtual Q17 Q17 { get; set; }

        /// <summary>Category The instance of Q18 to which this specific product belongs</summary>
        public virtual Q18 Q18 { get; set; }

        /// <summary>Category The instance of Q19 to which this specific product belongs</summary>
        public virtual Q19 Q19 { get; set; }

        /// <summary>Category The instance of Q20 to which this specific product belongs</summary>
        public virtual Q20 Q20 { get; set; }

        /// <summary>Category The instance of Q21 to which this specific product belongs</summary>
        public virtual Q21 Q21 { get; set; }

        /// <summary>Category The instance of Q22 to which this specific product belongs</summary>
        public virtual Q22 Q22 { get; set; }

        /// <summary>Category The instance of Q23 to which this specific product belongs</summary>
        public virtual Q23 Q23 { get; set; }

        /// <summary>Category The instance of Q24 to which this specific product belongs</summary>
        public virtual Q24 Q24 { get; set; }

        /// <summary>Category The instance of Q25 to which this specific product belongs</summary>
        public virtual Q25 Q25 { get; set; }

        /// <summary>Category The instance of Q26 to which this specific product belongs</summary>
        public virtual Q26 Q26 { get; set; }
    }
}