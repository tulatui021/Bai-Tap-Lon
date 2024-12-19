//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Models
{
    using StudentManagement.ViewModels;
    using System;
    using System.Collections.Generic;
    
    public partial class Semester : BaseViewModel
    {
        public Semester()
        {
            this.SubjectClasses = new HashSet<SubjectClass>();
            this.TrainingScores = new HashSet<TrainingScore>();
        }
    
        private System.Guid _id { get; set; }
        public System.Guid Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        private string _batch { get; set; }
        public string Batch { get => _batch; set { _batch = value; OnPropertyChanged(); } }
        private string _displayName { get; set; }
        public string DisplayName { get => _displayName; set { _displayName = value; OnPropertyChanged(); } }
        private Nullable<int> _courseRegisterStatus { get; set; }
        public Nullable<int> CourseRegisterStatus { get => _courseRegisterStatus; set { _courseRegisterStatus = value; OnPropertyChanged(); } }
    
        public virtual ICollection<SubjectClass> SubjectClasses { get; set; }
        public virtual ICollection<TrainingScore> TrainingScores { get; set; }
    }
}
