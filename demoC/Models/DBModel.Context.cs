//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<MatchQuestion> MatchQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
    }
}
