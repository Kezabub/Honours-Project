using System.Collections.Generic;

namespace honproject.Models
{
    public class AdminIndexModels
    {
        public AdminIndexModels()
        {
            this.Users = new List<ApplicationUser>();
        }

        public List<ApplicationUser> Users { get; set; }
    }
}