namespace MunicipalitySystem
{
    public partial class AddIssueForm : Form
    {
        private string selectedFilePath = "";

        public AddIssueForm()
        {
            InitializeComponent();
        }


        // ============================================
        // FORM LOAD
        // ============================================

        private void AddIssueForm_Load(object sender, EventArgs e)
        {
            UpdateProgress();
        }


        // ============================================
        // BROWSE FILE
        // ============================================

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;

                txtAttachment.Text =
                    Path.GetFileName(selectedFilePath);

                UpdateProgress();
            }
        }


        // ============================================
        // INPUT FIELD CHANGED
        // ============================================

        private void InputFields_TextChanged(
            object sender,
            EventArgs e)
        {
            UpdateProgress();
        }


        // ============================================
        // UPDATE ENGAGEMENT PROGRESS
        // ============================================

        private void UpdateProgress()
        {
            int completedFields = 0;

            int totalRequiredFields = 3;


            // Location

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                completedFields++;
            }


            // Category

            if (cmbCategory.SelectedIndex > 0)
            {
                completedFields++;
            }


            // Description

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                completedFields++;
            }


            int percentage =
                (completedFields * 100) / totalRequiredFields;


            progressEngagement.Value = percentage;


            // Engagement Messages

            if (percentage == 0)
            {
                lblProgressText.Text =
                    "Let's get started!";
            }
            else if (percentage <= 33)
            {
                lblProgressText.Text =
                    "Good start!";
            }
            else if (percentage <= 66)
            {
                lblProgressText.Text =
                    "You're halfway there!";
            }
            else if (percentage < 100)
            {
                lblProgressText.Text =
                    "Almost complete!";
            }
            else
            {
                lblProgressText.Text =
                    "Ready to submit!";
            }
        }


        // ============================================
        // SUBMIT ISSUE
        // ============================================

        private void btnSubmit_Click(
    object sender,
    EventArgs e)
        {
            // Validate Location

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Location Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLocation.Focus();

                return;
            }


            // Validate Category

            if (cmbCategory.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Please select an issue category.",
                    "Category Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCategory.Focus();

                return;
            }


            // Validate Description

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Description Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                rtbDescription.Focus();

                return;
            }


            // Create Issue Object

            IssueReport newIssue = new IssueReport
            {
                Location = txtLocation.Text.Trim(),

                Category = cmbCategory.SelectedItem.ToString()!,

                Description = rtbDescription.Text.Trim(),

                AttachmentPath = selectedFilePath,

                DateReported = DateTime.Now,

                Status = "Pending"
            };


            // Save Issue

            IssueStorage.AddIssue(newIssue);


            MessageBox.Show(
                "Your issue report has been submitted successfully!\n\n" +
                "Thank you for helping improve our community.",
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


            ClearForm();
        }


        // ============================================
        // CLEAR FORM
        // ============================================

        private void ClearForm()
        {
            txtLocation.Clear();

            cmbCategory.SelectedIndex = 0;

            rtbDescription.Clear();

            txtAttachment.Clear();

            selectedFilePath = "";

            progressEngagement.Value = 0;

            lblProgressText.Text =
                "Let's get started!";
        }


        // ============================================
        // BACK TO MAIN MENU
        // ============================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}