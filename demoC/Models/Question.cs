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
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int QID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> ChapterID { get; set; }
        public Nullable<int> PID { get; set; }
        public string Text { get; set; }
        public Nullable<double> Mark { get; set; }
        public int Qtype { get; set; }
        public Nullable<bool> MixChoice { get; set; }
        public Nullable<int> Time { get; set; }
        public string ImageData { get; set; }
        public Nullable<double> ImageSize { get; set; }
    
        public virtual Chapter Chapter { get; set; }
        public virtual Course Course { get; set; }
        public virtual QuestionType QuestionType { get; set; }
    }
}
