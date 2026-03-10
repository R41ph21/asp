using System;

namespace WebApp.Models;
{
    public class Book
    {  
        [Key]
        public int BookId {get; set}

        [Required]
        public string BookTitle {get; set} = string.Empty;

    
        public string BookDescription {get, set;} = string.Empty;

        public string BookAuthor {get; set;} = string.Empty;
    }
}
