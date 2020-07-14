//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PanisProba.EntityFrameworkModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployee()
        {
            this.tblReports = new HashSet<tblReport>();
        }
    
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string JMBG { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }
        public Nullable<bool> IsMenager { get; set; }
        public Nullable<int> SectorID { get; set; }
        public Nullable<int> AccessLevelID { get; set; }
    
        public virtual tblAccessLevel tblAccessLevel { get; set; }
        public virtual tblSector tblSector { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReport> tblReports { get; set; }
    }
}
