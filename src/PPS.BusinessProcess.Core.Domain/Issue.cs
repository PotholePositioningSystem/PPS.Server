using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.BusinessProcess.Core.Domain
{
    public class Issue
    {
        public Issue()
        {
            IssueId = GuidComb.Generate();
        }
        public Guid IssueId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime SubmittedOn { get; set; }
        public IssueType IssueType { get; set; }
    }
}
