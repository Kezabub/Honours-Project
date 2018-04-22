using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace honproject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Archived { get; set; }

        public string FullName => this.FirstName + " " + this.LastName;
    }

    //creates the database with the required tables
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        /// <summary>&lt;DbSet&gt; of type Responses Used to create instance of the Responses Table</summary>
        public DbSet<Response> Responses { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q1 Used to create instance of the Q1 Table</summary>
        public DbSet<Q1> Q1s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q2 Used to create instance of the Q2 Table</summary>
        public DbSet<Q2> Q2s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q3 Used to create instance of the Q3 Table</summary>
        public DbSet<Q3> Q3s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q4 Used to create instance of the Q4 Table</summary>
        public DbSet<Q4> Q4s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q5 Used to create instance of the Q5 Table</summary>
        public DbSet<Q5> Q5s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q6 Used to create instance of the Q6 Table</summary>
        public DbSet<Q6> Q6s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q7 Used to create instance of the Q7 Table</summary>
        public DbSet<Q7> Q7s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q8 Used to create instance of the Q8 Table</summary>
        public DbSet<Q8> Q8s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q9 Used to create instance of the Q9 Table</summary>
        public DbSet<Q9> Q9s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q10 Used to create instance of the Q10 Table</summary>
        public DbSet<Q10> Q10s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q11 Used to create instance of the Q11 Table</summary>
        public DbSet<Q11> Q11s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q12 Used to create instance of the Q12 Table</summary>
        public DbSet<Q12> Q12s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q13 Used to create instance of the Q13 Table</summary>
        public DbSet<Q13> Q13s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q14 Used to create instance of the Q14 Table</summary>
        public DbSet<Q14> Q14s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q15 Used to create instance of the Q15 Table</summary>
        public DbSet<Q15> Q15s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q16 Used to create instance of the Q16 Table</summary>
        public DbSet<Q16> Q16s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q17 Used to create instance of the Q17 Table</summary>
        public DbSet<Q17> Q17s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q18 Used to create instance of the Q18 Table</summary>
        public DbSet<Q18> Q18s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q19 Used to create instance of the Q19 Table</summary>
        public DbSet<Q19> Q19s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q20 Used to create instance of the Q20 Table</summary>
        public DbSet<Q20> Q20s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q21 Used to create instance of the Q21 Table</summary>
        public DbSet<Q21> Q21s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q22 Used to create instance of the Q22 Table</summary>
        public DbSet<Q22> Q22s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q23 Used to create instance of the Q23 Table</summary>
        public DbSet<Q23> Q23s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q24 Used to create instance of the Q24 Table</summary>
        public DbSet<Q24> Q24s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q25 Used to create instance of the Q25 Table</summary>
        public DbSet<Q25> Q25s { get; set; }
        /// <summary>&lt;DbSet&gt; of type Q26 Used to create instance of the Q26 Table</summary>
        public DbSet<Q26> Q26s { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}