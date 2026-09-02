namespace MunicipalitySystem
{
    public partial class DisplayIssuesForm : Form
    {
        private List<IssueReport> allIssues = new();

        public DisplayIssuesForm()
        {
            InitializeComponent();
        }


        // =====================================================
        // FORM LOAD
        // =====================================================

        private void DisplayIssuesForm_Load(
            object sender,
            EventArgs e)
        {
            LoadIssues();
        }


        // =====================================================
        // LOAD ISSUES
        // =====================================================

        private void LoadIssues()
        {
            allIssues = IssueStorage.GetIssues().ToList();

            DisplayIssues(allIssues);

            UpdateStatistics();
        }


        // =====================================================
        // DISPLAY ISSUES
        // =====================================================

        private void DisplayIssues(
            List<IssueReport> issues)
        {
            dgvIssues.DataSource = null;

            var displayData = issues.Select(issue => new
            {
                ID = issue.Id,

                Location = issue.Location,

                Category = issue.Category,

                Description = issue.Description,

                Date_Reported =
                    issue.DateReported.ToString(
                        "dd MMM yyyy HH:mm"
                    ),

                Status = issue.Status,

                Attachment =
                    string.IsNullOrEmpty(issue.AttachmentPath)
                        ? "No Attachment"
                        : "Attached"
            })
            .ToList();


            dgvIssues.DataSource = displayData;


            if (dgvIssues.Columns.Count > 0)
            {
                dgvIssues.Columns["ID"].FillWeight = 40;

                dgvIssues.Columns["Location"].FillWeight = 120;

                dgvIssues.Columns["Category"].FillWeight = 120;

                dgvIssues.Columns["Description"].FillWeight = 180;

                dgvIssues.Columns["Date_Reported"].FillWeight = 110;

                dgvIssues.Columns["Status"].FillWeight = 80;

                dgvIssues.Columns["Attachment"].FillWeight = 80;
            }
        }


        // =====================================================
        // UPDATE STATISTICS
        // =====================================================

        private void UpdateStatistics()
        {
            int total =
                allIssues.Count;

            int pending =
                allIssues.Count(
                    x => x.Status == "Pending"
                );

            int resolved =
                allIssues.Count(
                    x => x.Status == "Resolved"
                );


            lblTotalNumber.Text =
                total.ToString();

            lblPendingNumber.Text =
                pending.ToString();

            lblResolvedNumber.Text =
                resolved.ToString();
        }


        // =====================================================
        // FILTER ISSUES
        // =====================================================

        private void FilterChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilters();
        }


        private void ApplyFilters()
        {
            IEnumerable<IssueReport> filteredIssues =
                allIssues;


            // SEARCH FILTER

            string search =
                txtSearch.Text.Trim().ToLower();


            if (!string.IsNullOrEmpty(search))
            {
                filteredIssues =
                    filteredIssues.Where(issue =>
                        issue.Location
                            .ToLower()
                            .Contains(search)

                        ||

                        issue.Category
                            .ToLower()
                            .Contains(search)

                        ||

                        issue.Description
                            .ToLower()
                            .Contains(search)
                    );
            }


            // CATEGORY FILTER

            if (cmbCategoryFilter.SelectedIndex > 0)
            {
                string category =
                    cmbCategoryFilter.SelectedItem.ToString()!;

                filteredIssues =
                    filteredIssues.Where(issue =>
                        issue.Category == category
                    );
            }


            // STATUS FILTER

            if (cmbStatusFilter.SelectedIndex > 0)
            {
                string status =
                    cmbStatusFilter.SelectedItem.ToString()!;

                filteredIssues =
                    filteredIssues.Where(issue =>
                        issue.Status == status
                    );
            }


            DisplayIssues(
                filteredIssues.ToList()
            );
        }


        // =====================================================
        // REFRESH
        // =====================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            cmbCategoryFilter.SelectedIndex = 0;

            cmbStatusFilter.SelectedIndex = 0;

            LoadIssues();
        }


        // =====================================================
        // VIEW DETAILS
        // =====================================================

        private void btnViewDetails_Click(
            object sender,
            EventArgs e)
        {
            ShowSelectedIssueDetails();
        }


        // =====================================================
        // DOUBLE CLICK ROW
        // =====================================================

        private void dgvIssues_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowSelectedIssueDetails();
            }
        }


        // =====================================================
        // SHOW ISSUE DETAILS
        // =====================================================

        private void ShowSelectedIssueDetails()
        {
            if (dgvIssues.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an issue first.",
                    "No Issue Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }


            int issueId =
                Convert.ToInt32(
                    dgvIssues.SelectedRows[0]
                        .Cells["ID"]
                        .Value
                );


            IssueReport? selectedIssue =
                allIssues.FirstOrDefault(
                    x => x.Id == issueId
                );


            if (selectedIssue == null)
                return;


            string attachmentStatus =
                string.IsNullOrEmpty(
                    selectedIssue.AttachmentPath
                )
                    ? "No attachment"
                    : selectedIssue.AttachmentPath;


            MessageBox.Show(
                $"Issue ID: {selectedIssue.Id}\n\n" +
                $"Location: {selectedIssue.Location}\n\n" +
                $"Category: {selectedIssue.Category}\n\n" +
                $"Description:\n{selectedIssue.Description}\n\n" +
                $"Date Reported: {selectedIssue.DateReported:dd MMMM yyyy HH:mm}\n\n" +
                $"Status: {selectedIssue.Status}\n\n" +
                $"Attachment: {attachmentStatus}",

                "Issue Report Details",

                MessageBoxButtons.OK,

                MessageBoxIcon.Information
            );
        }


        // =====================================================
        // BACK
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}