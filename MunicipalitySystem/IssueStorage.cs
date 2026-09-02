using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem
{
    public static class IssueStorage
    {
        private static readonly List<IssueReport> issues = new();

        private static int nextId = 1;

        public static List<IssueReport> GetIssues()
        {
            return issues;
        }

        public static void AddIssue(IssueReport issue)
        {
            issue.Id = nextId++;

            issues.Add(issue);
        }
    }
}
