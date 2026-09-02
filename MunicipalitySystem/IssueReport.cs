using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem
{
    public class IssueReport
    {
        public int Id { get; set; }
        public string Location { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string AttachmentPath { get; set; } = "";
        public DateTime DateReported { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
