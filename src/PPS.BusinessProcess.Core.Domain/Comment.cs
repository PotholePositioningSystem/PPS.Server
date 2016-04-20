using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.BusinessProcess.Core.Domain
{
    public class Comment
    {
        public Comment()
        {
            CommentId = GuidComb.Generate();
        }

        public Guid CommentId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}
