//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Grade { get; set; }
        public string LocationType { get; set; }
        public string Location { get; set; }
        public string EmployeeType { get; set; }
        public string Designation { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateOfJoin { get; set; }
        public Nullable<double> PreviousExperience { get; set; }
        public string PassportNumber { get; set; }
        public string Visa { get; set; }
        public string BusinessGroup { get; set; }
        public string CostCenter { get; set; }
        public string Practice { get; set; }
        public string MasterSkillSet { get; set; }
        public string PrimarySkills { get; set; }
        public string SecondarySkills { get; set; }
        public string ResourceStatus { get; set; }
        public string ReservationStatus { get; set; }
        public string AssignmentStatus { get; set; }
        public string Supervisor { get; set; }
        public string ProjectManager { get; set; }
        public Nullable<int> Utilization { get; set; }
        public bool IsServicingNoticePeriod { get; set; }
        public bool IsTravelReady { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> RelievingDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public string ChangedBy { get; set; }
    }
}
