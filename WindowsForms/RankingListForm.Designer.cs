
namespace WindowsForms
{
    partial class RankingListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAttendanceRanking = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlayerRanking = new System.Windows.Forms.DataGridView();
            this.PlayerImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YellowCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintPlayerTable = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnPrintAttendanceTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendanceRanking
            // 
            this.dgvAttendanceRanking.AllowUserToAddRows = false;
            this.dgvAttendanceRanking.AllowUserToDeleteRows = false;
            this.dgvAttendanceRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceRanking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAttendanceRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Attendance,
            this.HomeTeam,
            this.AwayTeam});
            resources.ApplyResources(this.dgvAttendanceRanking, "dgvAttendanceRanking");
            this.dgvAttendanceRanking.Name = "dgvAttendanceRanking";
            this.dgvAttendanceRanking.ReadOnly = true;
            this.dgvAttendanceRanking.RowHeadersVisible = false;
            // 
            // Location
            // 
            resources.ApplyResources(this.Location, "Location");
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Attendance
            // 
            resources.ApplyResources(this.Attendance, "Attendance");
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // HomeTeam
            // 
            resources.ApplyResources(this.HomeTeam, "HomeTeam");
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.ReadOnly = true;
            // 
            // AwayTeam
            // 
            resources.ApplyResources(this.AwayTeam, "AwayTeam");
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.ReadOnly = true;
            // 
            // dgvPlayerRanking
            // 
            this.dgvPlayerRanking.AllowUserToAddRows = false;
            this.dgvPlayerRanking.AllowUserToDeleteRows = false;
            this.dgvPlayerRanking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPlayerRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerImage,
            this.PlayerName,
            this.YellowCards,
            this.Goals});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayerRanking.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvPlayerRanking, "dgvPlayerRanking");
            this.dgvPlayerRanking.Name = "dgvPlayerRanking";
            this.dgvPlayerRanking.ReadOnly = true;
            this.dgvPlayerRanking.RowHeadersVisible = false;
            // 
            // PlayerImage
            // 
            resources.ApplyResources(this.PlayerImage, "PlayerImage");
            this.PlayerImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.ReadOnly = true;
            this.PlayerImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PlayerName
            // 
            resources.ApplyResources(this.PlayerName, "PlayerName");
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // YellowCards
            // 
            resources.ApplyResources(this.YellowCards, "YellowCards");
            this.YellowCards.Name = "YellowCards";
            this.YellowCards.ReadOnly = true;
            // 
            // Goals
            // 
            resources.ApplyResources(this.Goals, "Goals");
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            // 
            // btnPrintPlayerTable
            // 
            resources.ApplyResources(this.btnPrintPlayerTable, "btnPrintPlayerTable");
            this.btnPrintPlayerTable.Name = "btnPrintPlayerTable";
            this.btnPrintPlayerTable.UseVisualStyleBackColor = true;
            this.btnPrintPlayerTable.Click += new System.EventHandler(this.btnPrintPlayerTable_Click);
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnPrintAttendanceTable
            // 
            resources.ApplyResources(this.btnPrintAttendanceTable, "btnPrintAttendanceTable");
            this.btnPrintAttendanceTable.Name = "btnPrintAttendanceTable";
            this.btnPrintAttendanceTable.UseVisualStyleBackColor = true;
            this.btnPrintAttendanceTable.Click += new System.EventHandler(this.btnPrintAttendanceTable_Click);
            // 
            // RankingListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.RankingBG;
            this.Controls.Add(this.btnPrintAttendanceTable);
            this.Controls.Add(this.btnPrintPlayerTable);
            this.Controls.Add(this.dgvPlayerRanking);
            this.Controls.Add(this.dgvAttendanceRanking);
            this.Name = "RankingListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendanceRanking;
        private System.Windows.Forms.DataGridView dgvPlayerRanking;
        private System.Windows.Forms.Button btnPrintPlayerTable;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnPrintAttendanceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeam;
        private System.Windows.Forms.DataGridViewImageColumn PlayerImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YellowCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
    }
}