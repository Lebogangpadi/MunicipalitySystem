namespace MunicipalitySystem
{
    partial class DisplayIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel statisticsPanel;

        private Panel totalIssuesCard;
        private Panel pendingCard;
        private Panel resolvedCard;

        private Label lblTotalNumber;
        private Label lblPendingNumber;
        private Label lblResolvedNumber;

        private Label lblTotalText;
        private Label lblPendingText;
        private Label lblResolvedText;

        private Panel filterPanel;

        private TextBox txtSearch;
        private ComboBox cmbCategoryFilter;
        private ComboBox cmbStatusFilter;

        private Button btnRefresh;
        private Button btnViewDetails;
        private Button btnBack;

        private DataGridView dgvIssues;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

            statisticsPanel = new Panel();

            totalIssuesCard = new Panel();
            pendingCard = new Panel();
            resolvedCard = new Panel();

            lblTotalNumber = new Label();
            lblPendingNumber = new Label();
            lblResolvedNumber = new Label();

            lblTotalText = new Label();
            lblPendingText = new Label();
            lblResolvedText = new Label();

            filterPanel = new Panel();

            txtSearch = new TextBox();
            cmbCategoryFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();

            btnRefresh = new Button();
            btnViewDetails = new Button();
            btnBack = new Button();

            dgvIssues = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvIssues).BeginInit();

            SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(245, 247, 250);

            ClientSize = new Size(1200, 750);

            MinimumSize = new Size(1000, 650);

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Reported Issues - Municipality Services";

            Load += DisplayIssuesForm_Load;


            // =====================================================
            // HEADER PANEL
            // =====================================================

            headerPanel.BackColor =
                Color.FromArgb(25, 55, 85);

            headerPanel.Dock = DockStyle.Top;

            headerPanel.Height = 120;


            // TITLE

            lblTitle.AutoSize = true;

            lblTitle.Font = new Font(
                "Segoe UI",
                24F,
                FontStyle.Bold
            );

            lblTitle.ForeColor = Color.White;

            lblTitle.Location =
                new Point(40, 20);

            lblTitle.Text =
                "Reported Municipal Issues";


            // SUBTITLE

            lblSubtitle.AutoSize = true;

            lblSubtitle.Font = new Font(
                "Segoe UI",
                11F
            );

            lblSubtitle.ForeColor =
                Color.FromArgb(220, 230, 240);

            lblSubtitle.Location =
                new Point(43, 72);

            lblSubtitle.Text =
                "View, search and monitor all issues reported by citizens.";


            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);


            // =====================================================
            // STATISTICS PANEL
            // =====================================================

            statisticsPanel.BackColor =
                Color.Transparent;

            statisticsPanel.Location =
                new Point(40, 145);

            statisticsPanel.Size =
                new Size(1120, 100);

            statisticsPanel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;


            // =====================================================
            // TOTAL ISSUES CARD
            // =====================================================

            totalIssuesCard.BackColor =
                Color.White;

            totalIssuesCard.Location =
                new Point(0, 0);

            totalIssuesCard.Size =
                new Size(340, 90);


            lblTotalNumber.AutoSize = true;

            lblTotalNumber.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold
                );

            lblTotalNumber.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblTotalNumber.Location =
                new Point(25, 15);

            lblTotalNumber.Text = "0";


            lblTotalText.AutoSize = true;

            lblTotalText.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            lblTotalText.ForeColor =
                Color.FromArgb(90, 100, 110);

            lblTotalText.Location =
                new Point(25, 55);

            lblTotalText.Text =
                "Total Issues Reported";


            totalIssuesCard.Controls.Add(lblTotalNumber);
            totalIssuesCard.Controls.Add(lblTotalText);


            // =====================================================
            // PENDING CARD
            // =====================================================

            pendingCard.BackColor =
                Color.White;

            pendingCard.Location =
                new Point(370, 0);

            pendingCard.Size =
                new Size(340, 90);


            lblPendingNumber.AutoSize = true;

            lblPendingNumber.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold
                );

            lblPendingNumber.ForeColor =
                Color.FromArgb(235, 140, 40);

            lblPendingNumber.Location =
                new Point(25, 15);

            lblPendingNumber.Text = "0";


            lblPendingText.AutoSize = true;

            lblPendingText.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            lblPendingText.ForeColor =
                Color.FromArgb(90, 100, 110);

            lblPendingText.Location =
                new Point(25, 55);

            lblPendingText.Text =
                "Issues Pending";


            pendingCard.Controls.Add(lblPendingNumber);
            pendingCard.Controls.Add(lblPendingText);


            // =====================================================
            // RESOLVED CARD
            // =====================================================

            resolvedCard.BackColor =
                Color.White;

            resolvedCard.Location =
                new Point(740, 0);

            resolvedCard.Size =
                new Size(340, 90);


            lblResolvedNumber.AutoSize = true;

            lblResolvedNumber.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold
                );

            lblResolvedNumber.ForeColor =
                Color.FromArgb(70, 140, 85);

            lblResolvedNumber.Location =
                new Point(25, 15);

            lblResolvedNumber.Text = "0";


            lblResolvedText.AutoSize = true;

            lblResolvedText.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            lblResolvedText.ForeColor =
                Color.FromArgb(90, 100, 110);

            lblResolvedText.Location =
                new Point(25, 55);

            lblResolvedText.Text =
                "Issues Resolved";


            resolvedCard.Controls.Add(lblResolvedNumber);
            resolvedCard.Controls.Add(lblResolvedText);


            statisticsPanel.Controls.Add(totalIssuesCard);
            statisticsPanel.Controls.Add(pendingCard);
            statisticsPanel.Controls.Add(resolvedCard);


            // =====================================================
            // FILTER PANEL
            // =====================================================

            filterPanel.BackColor =
                Color.White;

            filterPanel.Location =
                new Point(40, 265);

            filterPanel.Size =
                new Size(1120, 75);

            filterPanel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;


            // SEARCH BOX

            txtSearch.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            txtSearch.Location =
                new Point(20, 20);

            txtSearch.Size =
                new Size(330, 35);

            txtSearch.PlaceholderText =
                "Search by location or category...";

            txtSearch.TextChanged += FilterChanged;


            // CATEGORY FILTER

            cmbCategoryFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbCategoryFilter.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            cmbCategoryFilter.Location =
                new Point(370, 20);

            cmbCategoryFilter.Size =
                new Size(220, 35);

            cmbCategoryFilter.Items.AddRange(
                new object[]
                {
                    "All Categories",
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

            cmbCategoryFilter.SelectedIndex = 0;

            cmbCategoryFilter.SelectedIndexChanged +=
                FilterChanged;


            // STATUS FILTER

            cmbStatusFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbStatusFilter.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            cmbStatusFilter.Location =
                new Point(610, 20);

            cmbStatusFilter.Size =
                new Size(170, 35);

            cmbStatusFilter.Items.AddRange(
                new object[]
                {
                    "All Statuses",
                    "Pending",
                    "In Progress",
                    "Resolved"
                });

            cmbStatusFilter.SelectedIndex = 0;

            cmbStatusFilter.SelectedIndexChanged +=
                FilterChanged;


            // REFRESH BUTTON

            btnRefresh.BackColor =
                Color.FromArgb(45, 95, 160);

            btnRefresh.ForeColor =
                Color.White;

            btnRefresh.FlatStyle =
                FlatStyle.Flat;

            btnRefresh.FlatAppearance.BorderSize = 0;

            btnRefresh.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            btnRefresh.Location =
                new Point(800, 20);

            btnRefresh.Size =
                new Size(130, 35);

            btnRefresh.Text =
                "Refresh";

            btnRefresh.Click += btnRefresh_Click;


            // VIEW DETAILS BUTTON

            btnViewDetails.BackColor =
                Color.FromArgb(72, 130, 80);

            btnViewDetails.ForeColor =
                Color.White;

            btnViewDetails.FlatStyle =
                FlatStyle.Flat;

            btnViewDetails.FlatAppearance.BorderSize = 0;

            btnViewDetails.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            btnViewDetails.Location =
                new Point(950, 20);

            btnViewDetails.Size =
                new Size(150, 35);

            btnViewDetails.Text =
                "View Details";

            btnViewDetails.Click += btnViewDetails_Click;


            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(cmbCategoryFilter);
            filterPanel.Controls.Add(cmbStatusFilter);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Controls.Add(btnViewDetails);


            // =====================================================
            // DATA GRID
            // =====================================================

            dgvIssues.BackgroundColor =
                Color.White;

            dgvIssues.BorderStyle =
                BorderStyle.None;

            dgvIssues.Location =
                new Point(40, 360);

            dgvIssues.Size =
                new Size(1120, 300);

            dgvIssues.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvIssues.AllowUserToAddRows = false;

            dgvIssues.AllowUserToDeleteRows = false;

            dgvIssues.AllowUserToResizeRows = false;

            dgvIssues.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvIssues.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvIssues.MultiSelect = false;

            dgvIssues.ReadOnly = true;

            dgvIssues.RowHeadersVisible = false;

            dgvIssues.EnableHeadersVisualStyles = false;

            dgvIssues.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 55, 85);

            dgvIssues.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvIssues.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                );

            dgvIssues.ColumnHeadersHeight = 45;

            dgvIssues.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            dgvIssues.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 245);

            dgvIssues.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvIssues.RowTemplate.Height = 45;

            dgvIssues.CellDoubleClick +=
                dgvIssues_CellDoubleClick;


            // =====================================================
            // BACK BUTTON
            // =====================================================

            btnBack.BackColor =
                Color.FromArgb(100, 110, 120);

            btnBack.ForeColor =
                Color.White;

            btnBack.FlatStyle =
                FlatStyle.Flat;

            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                );

            btnBack.Location =
                new Point(40, 680);

            btnBack.Size =
                new Size(180, 45);

            btnBack.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            btnBack.Text =
                "← Back to Main Menu";

            btnBack.Click += btnBack_Click;


            // =====================================================
            // ADD CONTROLS
            // =====================================================

            Controls.Add(btnBack);
            Controls.Add(dgvIssues);
            Controls.Add(filterPanel);
            Controls.Add(statisticsPanel);
            Controls.Add(headerPanel);

            ((System.ComponentModel.ISupportInitialize)dgvIssues).EndInit();

            ResumeLayout(false);
        }

        #endregion
    }
}