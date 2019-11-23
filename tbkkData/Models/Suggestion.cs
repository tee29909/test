using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Suggestion
    {
        public int SuggestionID { get; set; }
        public string SugDetail { get; set; }
        public int SugSumPoint { get; set; }
        public DateTime Date { get; set; }
        public virtual Employee Suggestion_EmployeeID { get; set; }
        public virtual GradeHistory Suggestion_GradeHistoryID { get; set; }
    }
}
