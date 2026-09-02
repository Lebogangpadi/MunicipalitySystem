namespace MunicipalitySystem
{
    partial class AddIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel contentPanel;

        private Label lblLocation;
        private TextBox txtLocation;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblDescription;
        private RichTextBox rtbDescription;

        private Label lblAttachment;
        private TextBox txtAttachment;
        private Button btnBrowse;

        private Label lblEngagement;
        private ProgressBar progressEngagement;
        private Label lblProgressText;

        private Button btnSubmit;
        private Button btnBack;

        private OpenFileDialog openFileDialog;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            headerPanel = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            contentPanel = new Panel();

            lblLocation = new Label();
            txtLocation = new TextBox();

            lblCategory = new Label();
            cmbCategory = new ComboBox();

            lblDescription = new Label();
            rtbDescription = new RichTextBox();

            lblAttachment = new Label();
            txtAttachment = new TextBox();
            btnBrowse = new Button();

            lblEngagement = new Label();
            progressEngagement = new ProgressBar();
            lblProgressText = new Label();

            btnSubmit = new Button();
            btnBack = new Button();

            openFileDialog = new OpenFileDialog();

            SuspendLayout();


            // ============================================
            // ADD ISSUE FORM
            // ============================================

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(245, 247, 250);

            ClientSize = new Size(950, 700);

            MinimumSize = new Size(850, 650);

            StartPosition = FormStartPosition.CenterScreen;

            Name = "AddIssueForm";

            Text = "Report an Issue - Municipality Services";

            Load += AddIssueForm_Load;


            // ============================================
            // HEADER PANEL
            // ============================================

            headerPanel.BackColor = Color.FromArgb(25, 55, 85);

            headerPanel.Dock = DockStyle.Top;

            headerPanel.Height = 130;


            // ============================================
            // TITLE
            // ============================================

            lblTitle.AutoSize = true;

            lblTitle.Font = new Font(
                "Segoe UI",
                24F,
                FontStyle.Bold
            );

            lblTitle.ForeColor = Color.White;

            lblTitle.Location = new Point(45, 25);

            lblTitle.Text = "Report a Municipal Issue";


            // ============================================
            // SUBTITLE
            // ============================================

            lblSubtitle.AutoSize = true;

            lblSubtitle.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular
            );

            lblSubtitle.ForeColor = Color.FromArgb(220, 230, 240);

            lblSubtitle.Location = new Point(48, 78);

            lblSubtitle.Text =
                "Help us improve your community by reporting issues in your area.";


            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);


            // ============================================
            // CONTENT PANEL
            // ============================================

            contentPanel.BackColor = Color.White;

            contentPanel.Location = new Point(40, 160);

            contentPanel.Size = new Size(870, 480);

            contentPanel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            contentPanel.Padding = new Padding(35);


            // ============================================
            // LOCATION LABEL
            // ============================================

            lblLocation.AutoSize = true;

            lblLocation.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            lblLocation.ForeColor =
                Color.FromArgb(50, 60, 70);

            lblLocation.Location = new Point(35, 30);

            lblLocation.Text = "Issue Location";


            // ============================================
            // LOCATION TEXTBOX
            // ============================================

            txtLocation.Font = new Font(
                "Segoe UI",
                11F
            );

            txtLocation.Location = new Point(35, 60);

            txtLocation.Size = new Size(800, 35);

            txtLocation.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            txtLocation.PlaceholderText =
                "Enter the location where the issue occurred...";

            txtLocation.TextChanged += InputFields_TextChanged;


            // ============================================
            // CATEGORY LABEL
            // ============================================

            lblCategory.AutoSize = true;

            lblCategory.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            lblCategory.ForeColor =
                Color.FromArgb(50, 60, 70);

            lblCategory.Location = new Point(35, 115);

            lblCategory.Text = "Issue Category";


            // ============================================
            // CATEGORY COMBOBOX
            // ============================================

            cmbCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbCategory.Font = new Font(
                "Segoe UI",
                11F
            );

            cmbCategory.Location = new Point(35, 145);

            cmbCategory.Size = new Size(800, 35);

            cmbCategory.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            cmbCategory.Items.AddRange(new object[]
            {
                "-- Select Issue Category --",
                "Roads and Potholes",
                "Water Supply",
                "Electricity",
                "Sanitation",
                "Waste Management",
                "Street Lighting",
                "Public Safety",
                "Parks and Recreation",
                "Other"
            });

            cmbCategory.SelectedIndex = 0;

            cmbCategory.SelectedIndexChanged += InputFields_TextChanged;


            // ============================================
            // DESCRIPTION LABEL
            // ============================================

            lblDescription.AutoSize = true;

            lblDescription.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            lblDescription.ForeColor =
                Color.FromArgb(50, 60, 70);

            lblDescription.Location = new Point(35, 200);

            lblDescription.Text = "Issue Description";


            // ============================================
            // DESCRIPTION RICHTEXTBOX
            // ============================================

            rtbDescription.Font = new Font(
                "Segoe UI",
                10.5F
            );

            rtbDescription.Location = new Point(35, 230);

            rtbDescription.Size = new Size(800, 110);

            rtbDescription.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            rtbDescription.BorderStyle =
                BorderStyle.FixedSingle;

            rtbDescription.TextChanged += InputFields_TextChanged;


            // ============================================
            // ATTACHMENT LABEL
            // ============================================

            lblAttachment.AutoSize = true;

            lblAttachment.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            lblAttachment.ForeColor =
                Color.FromArgb(50, 60, 70);

            lblAttachment.Location = new Point(35, 360);

            lblAttachment.Text = "Attach Media or Document (Optional)";


            // ============================================
            // ATTACHMENT TEXTBOX
            // ============================================

            txtAttachment.Font = new Font(
                "Segoe UI",
                10F
            );

            txtAttachment.Location = new Point(35, 390);

            txtAttachment.Size = new Size(620, 35);

            txtAttachment.ReadOnly = true;

            txtAttachment.BackColor =
                Color.FromArgb(245, 247, 250);

            txtAttachment.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;


            // ============================================
            // BROWSE BUTTON
            // ============================================

            btnBrowse.BackColor =
                Color.FromArgb(45, 95, 160);

            btnBrowse.FlatAppearance.BorderSize = 0;

            btnBrowse.FlatStyle = FlatStyle.Flat;

            btnBrowse.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnBrowse.ForeColor = Color.White;

            btnBrowse.Location = new Point(670, 390);

            btnBrowse.Size = new Size(165, 35);

            btnBrowse.Text = "Browse File";

            btnBrowse.Cursor = Cursors.Hand;

            btnBrowse.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            btnBrowse.Click += btnBrowse_Click;


            // ============================================
            // ENGAGEMENT LABEL
            // ============================================

            lblEngagement.AutoSize = true;

            lblEngagement.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            lblEngagement.ForeColor =
                Color.FromArgb(50, 60, 70);

            lblEngagement.Location = new Point(35, 445);

            lblEngagement.Text =
                "Report Completion";


            // ============================================
            // PROGRESS BAR
            // ============================================

            progressEngagement.Location =
                new Point(170, 448);

            progressEngagement.Size =
                new Size(400, 20);

            progressEngagement.Value = 0;


            // ============================================
            // PROGRESS TEXT
            // ============================================

            lblProgressText.AutoSize = true;

            lblProgressText.Font = new Font(
                "Segoe UI",
                9F
            );

            lblProgressText.ForeColor =
                Color.FromArgb(90, 100, 110);

            lblProgressText.Location =
                new Point(590, 446);

            lblProgressText.Text =
                "Let's get started!";


            // ============================================
            // SUBMIT BUTTON
            // ============================================

            btnSubmit.BackColor =
                Color.FromArgb(72, 130, 80);

            btnSubmit.FlatAppearance.BorderSize = 0;

            btnSubmit.FlatStyle = FlatStyle.Flat;

            btnSubmit.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            btnSubmit.ForeColor = Color.White;

            btnSubmit.Location =
                new Point(620, 650);

            btnSubmit.Size =
                new Size(290, 50);

            btnSubmit.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            btnSubmit.Text =
                "Submit Issue Report";

            btnSubmit.Cursor =
                Cursors.Hand;

            btnSubmit.Click += btnSubmit_Click;


            // ============================================
            // BACK BUTTON
            // ============================================

            btnBack.BackColor =
                Color.FromArgb(100, 110, 120);

            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.FlatStyle = FlatStyle.Flat;

            btnBack.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnBack.ForeColor = Color.White;

            btnBack.Location =
                new Point(40, 650);

            btnBack.Size =
                new Size(170, 50);

            btnBack.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            btnBack.Text =
                "← Back to Main Menu";

            btnBack.Cursor =
                Cursors.Hand;

            btnBack.Click += btnBack_Click;


            // ============================================
            // OPEN FILE DIALOG
            // ============================================

            openFileDialog.Title =
                "Select an Attachment";

            openFileDialog.Filter =
                "Supported Files|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx|" +
                "Image Files|*.jpg;*.jpeg;*.png|" +
                "Documents|*.pdf;*.doc;*.docx|" +
                "All Files|*.*";


            // ============================================
            // ADD CONTROLS
            // ============================================

            Controls.Add(btnBack);
            Controls.Add(btnSubmit);

            contentPanel.Controls.Add(lblLocation);
            contentPanel.Controls.Add(txtLocation);

            contentPanel.Controls.Add(lblCategory);
            contentPanel.Controls.Add(cmbCategory);

            contentPanel.Controls.Add(lblDescription);
            contentPanel.Controls.Add(rtbDescription);

            contentPanel.Controls.Add(lblAttachment);
            contentPanel.Controls.Add(txtAttachment);
            contentPanel.Controls.Add(btnBrowse);

            contentPanel.Controls.Add(lblEngagement);
            contentPanel.Controls.Add(progressEngagement);
            contentPanel.Controls.Add(lblProgressText);

            Controls.Add(contentPanel);
            Controls.Add(headerPanel);

            ResumeLayout(false);
        }

        #endregion
    }
}