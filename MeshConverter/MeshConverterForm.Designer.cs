namespace MeshConverter
{
    partial class MeshConverterForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeshConverterForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelToolbar = new System.Windows.Forms.Panel();
			this.btnMeshReductionGo = new System.Windows.Forms.Button();
			this.textNameSuffix = new System.Windows.Forms.TextBox();
			this.textReductionTargetTriangle = new System.Windows.Forms.TextBox();
			this.labelNameSuffix = new System.Windows.Forms.Label();
			this.labelTriangles = new System.Windows.Forms.Label();
			this.splitLeftRight = new System.Windows.Forms.SplitContainer();
			this.browserLeft = new MeshConverter.Controls.MeshBrowser();
			this.tableRightSide = new System.Windows.Forms.TableLayoutPanel();
			this.browserRight = new MeshConverter.Controls.MeshBrowser();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.progressStatus = new System.Windows.Forms.ProgressBar();
			this.textMaxFilesPerFolder = new System.Windows.Forms.TextBox();
			this.labelMaxPerFolder = new System.Windows.Forms.Label();
			this.checkLimitFilesPerFolder = new System.Windows.Forms.CheckBox();
			this.checkIncludeSubFolders = new System.Windows.Forms.CheckBox();
			this.checkMeshReduction = new System.Windows.Forms.CheckBox();
			this.checkAddNameSuffix = new System.Windows.Forms.CheckBox();
			this.labelStatusText = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).BeginInit();
			this.splitLeftRight.Panel1.SuspendLayout();
			this.splitLeftRight.Panel2.SuspendLayout();
			this.splitLeftRight.SuspendLayout();
			this.tableRightSide.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelTop.Controls.Add(this.panelToolbar);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Padding = new System.Windows.Forms.Padding(8);
			this.panelTop.Size = new System.Drawing.Size(1142, 42);
			this.panelTop.TabIndex = 0;
			// 
			// panelToolbar
			// 
			this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelToolbar.Location = new System.Drawing.Point(8, 8);
			this.panelToolbar.Name = "panelToolbar";
			this.panelToolbar.Size = new System.Drawing.Size(1126, 26);
			this.panelToolbar.TabIndex = 0;
			// 
			// btnMeshReductionGo
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnMeshReductionGo, 2);
			this.btnMeshReductionGo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMeshReductionGo.Location = new System.Drawing.Point(3, 3);
			this.btnMeshReductionGo.Name = "btnMeshReductionGo";
			this.btnMeshReductionGo.Size = new System.Drawing.Size(214, 46);
			this.btnMeshReductionGo.TabIndex = 4;
			this.btnMeshReductionGo.Text = "Copy >";
			this.btnMeshReductionGo.UseVisualStyleBackColor = true;
			this.btnMeshReductionGo.Click += new System.EventHandler(this.btnMeshReductionGo_Click);
			// 
			// textNameSuffix
			// 
			this.textNameSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textNameSuffix.Location = new System.Drawing.Point(113, 124);
			this.textNameSuffix.Name = "textNameSuffix";
			this.textNameSuffix.Size = new System.Drawing.Size(104, 23);
			this.textNameSuffix.TabIndex = 3;
			this.toolTip1.SetToolTip(this.textNameSuffix, "Suffix that is added to each filename");
			this.textNameSuffix.Visible = false;
			// 
			// textReductionTargetTriangle
			// 
			this.textReductionTargetTriangle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textReductionTargetTriangle.Location = new System.Drawing.Point(113, 178);
			this.textReductionTargetTriangle.Name = "textReductionTargetTriangle";
			this.textReductionTargetTriangle.Size = new System.Drawing.Size(104, 23);
			this.textReductionTargetTriangle.TabIndex = 2;
			this.textReductionTargetTriangle.Visible = false;
			this.textReductionTargetTriangle.TextChanged += new System.EventHandler(this.textReductionTargetTriangle_TextChanged);
			// 
			// labelNameSuffix
			// 
			this.labelNameSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNameSuffix.AutoSize = true;
			this.labelNameSuffix.Location = new System.Drawing.Point(3, 125);
			this.labelNameSuffix.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.labelNameSuffix.Name = "labelNameSuffix";
			this.labelNameSuffix.Size = new System.Drawing.Size(72, 15);
			this.labelNameSuffix.TabIndex = 1;
			this.labelNameSuffix.Text = "Name Suffix";
			this.toolTip1.SetToolTip(this.labelNameSuffix, "Suffix that is added to each filename");
			this.labelNameSuffix.Visible = false;
			// 
			// labelTriangles
			// 
			this.labelTriangles.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelTriangles.AutoSize = true;
			this.labelTriangles.Location = new System.Drawing.Point(3, 182);
			this.labelTriangles.Name = "labelTriangles";
			this.labelTriangles.Size = new System.Drawing.Size(53, 15);
			this.labelTriangles.TabIndex = 0;
			this.labelTriangles.Text = "Triangles";
			this.labelTriangles.Visible = false;
			// 
			// splitLeftRight
			// 
			this.splitLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitLeftRight.Location = new System.Drawing.Point(8, 0);
			this.splitLeftRight.Name = "splitLeftRight";
			// 
			// splitLeftRight.Panel1
			// 
			this.splitLeftRight.Panel1.Controls.Add(this.browserLeft);
			// 
			// splitLeftRight.Panel2
			// 
			this.splitLeftRight.Panel2.Controls.Add(this.tableRightSide);
			this.splitLeftRight.Size = new System.Drawing.Size(1126, 635);
			this.splitLeftRight.SplitterDistance = 477;
			this.splitLeftRight.TabIndex = 1;
			// 
			// browserLeft
			// 
			this.browserLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browserLeft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browserLeft.Location = new System.Drawing.Point(0, 0);
			this.browserLeft.Name = "browserLeft";
			this.browserLeft.Size = new System.Drawing.Size(477, 635);
			this.browserLeft.TabIndex = 0;
			// 
			// tableRightSide
			// 
			this.tableRightSide.ColumnCount = 2;
			this.tableRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableRightSide.Controls.Add(this.browserRight, 1, 0);
			this.tableRightSide.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableRightSide.Location = new System.Drawing.Point(0, 0);
			this.tableRightSide.Name = "tableRightSide";
			this.tableRightSide.RowCount = 1;
			this.tableRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableRightSide.Size = new System.Drawing.Size(645, 635);
			this.tableRightSide.TabIndex = 1;
			// 
			// browserRight
			// 
			this.browserRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browserRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browserRight.Location = new System.Drawing.Point(237, 3);
			this.browserRight.Name = "browserRight";
			this.browserRight.Size = new System.Drawing.Size(405, 629);
			this.browserRight.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 635);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.progressStatus, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textMaxFilesPerFolder, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxPerFolder, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.checkLimitFilesPerFolder, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.checkIncludeSubFolders, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.btnMeshReductionGo, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNameSuffix, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textNameSuffix, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelTriangles, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.checkMeshReduction, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textReductionTargetTriangle, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.checkAddNameSuffix, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelStatusText, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 140);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 12;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 355);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// progressStatus
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.progressStatus, 2);
			this.progressStatus.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressStatus.Location = new System.Drawing.Point(3, 70);
			this.progressStatus.Name = "progressStatus";
			this.progressStatus.Size = new System.Drawing.Size(214, 23);
			this.progressStatus.TabIndex = 0;
			this.progressStatus.Visible = false;
			// 
			// textMaxFilesPerFolder
			// 
			this.textMaxFilesPerFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textMaxFilesPerFolder.Location = new System.Drawing.Point(113, 257);
			this.textMaxFilesPerFolder.Name = "textMaxFilesPerFolder";
			this.textMaxFilesPerFolder.Size = new System.Drawing.Size(104, 23);
			this.textMaxFilesPerFolder.TabIndex = 9;
			this.textMaxFilesPerFolder.Visible = false;
			// 
			// labelMaxPerFolder
			// 
			this.labelMaxPerFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelMaxPerFolder.AutoSize = true;
			this.labelMaxPerFolder.Location = new System.Drawing.Point(3, 261);
			this.labelMaxPerFolder.Name = "labelMaxPerFolder";
			this.labelMaxPerFolder.Size = new System.Drawing.Size(86, 15);
			this.labelMaxPerFolder.TabIndex = 8;
			this.labelMaxPerFolder.Text = "Max Per Folder";
			this.toolTip1.SetToolTip(this.labelMaxPerFolder, "Max number of files to copy per folder");
			this.labelMaxPerFolder.Visible = false;
			// 
			// checkLimitFilesPerFolder
			// 
			this.checkLimitFilesPerFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkLimitFilesPerFolder.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkLimitFilesPerFolder, 2);
			this.checkLimitFilesPerFolder.Location = new System.Drawing.Point(3, 232);
			this.checkLimitFilesPerFolder.Name = "checkLimitFilesPerFolder";
			this.checkLimitFilesPerFolder.Size = new System.Drawing.Size(135, 19);
			this.checkLimitFilesPerFolder.TabIndex = 7;
			this.checkLimitFilesPerFolder.Text = "Limit Files Per Folder";
			this.toolTip1.SetToolTip(this.checkLimitFilesPerFolder, "Limit number of files to copy");
			this.checkLimitFilesPerFolder.UseVisualStyleBackColor = true;
			this.checkLimitFilesPerFolder.CheckedChanged += new System.EventHandler(this.checkLimitFilesPerFolder_CheckedChanged);
			// 
			// checkIncludeSubFolders
			// 
			this.checkIncludeSubFolders.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkIncludeSubFolders.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkIncludeSubFolders, 2);
			this.checkIncludeSubFolders.Location = new System.Drawing.Point(3, 207);
			this.checkIncludeSubFolders.Name = "checkIncludeSubFolders";
			this.checkIncludeSubFolders.Size = new System.Drawing.Size(124, 19);
			this.checkIncludeSubFolders.TabIndex = 6;
			this.checkIncludeSubFolders.Text = "Include Subfolders";
			this.checkIncludeSubFolders.UseVisualStyleBackColor = true;
			// 
			// checkMeshReduction
			// 
			this.checkMeshReduction.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkMeshReduction.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkMeshReduction, 2);
			this.checkMeshReduction.Location = new System.Drawing.Point(3, 153);
			this.checkMeshReduction.Name = "checkMeshReduction";
			this.checkMeshReduction.Size = new System.Drawing.Size(112, 19);
			this.checkMeshReduction.TabIndex = 5;
			this.checkMeshReduction.Text = "Mesh Reduction";
			this.checkMeshReduction.UseVisualStyleBackColor = true;
			this.checkMeshReduction.CheckedChanged += new System.EventHandler(this.checkMeshReduction_CheckedChanged);
			// 
			// checkAddNameSuffix
			// 
			this.checkAddNameSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkAddNameSuffix.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkAddNameSuffix, 2);
			this.checkAddNameSuffix.Location = new System.Drawing.Point(3, 99);
			this.checkAddNameSuffix.Name = "checkAddNameSuffix";
			this.checkAddNameSuffix.Size = new System.Drawing.Size(116, 19);
			this.checkAddNameSuffix.TabIndex = 10;
			this.checkAddNameSuffix.Text = "Add Name Suffix";
			this.checkAddNameSuffix.UseVisualStyleBackColor = true;
			this.checkAddNameSuffix.CheckedChanged += new System.EventHandler(this.checkAddNameSuffix_CheckedChanged);
			// 
			// labelStatusText
			// 
			this.labelStatusText.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelStatusText.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelStatusText, 2);
			this.labelStatusText.Location = new System.Drawing.Point(3, 52);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new System.Drawing.Size(16, 15);
			this.labelStatusText.TabIndex = 11;
			this.labelStatusText.Text = "...";
			this.labelStatusText.Visible = false;
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.splitLeftRight);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 42);
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.panelMain.Size = new System.Drawing.Size(1142, 635);
			this.panelMain.TabIndex = 2;
			// 
			// panelBottom
			// 
			this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 677);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(1142, 55);
			this.panelBottom.TabIndex = 3;
			// 
			// MeshConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1142, 732);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelBottom);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MeshConverterForm";
			this.Text = "Mesh Commander";
			this.Load += new System.EventHandler(this.MeshExplorer_Load);
			this.panelTop.ResumeLayout(false);
			this.splitLeftRight.Panel1.ResumeLayout(false);
			this.splitLeftRight.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).EndInit();
			this.splitLeftRight.ResumeLayout(false);
			this.tableRightSide.ResumeLayout(false);
			this.tableRightSide.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelMain.ResumeLayout(false);
			this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitLeftRight;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Panel panelMain;
        private Controls.MeshBrowser browserLeft;
        private Controls.MeshBrowser browserRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnMeshReductionGo;
        private System.Windows.Forms.TextBox textNameSuffix;
        private System.Windows.Forms.TextBox textReductionTargetTriangle;
        private System.Windows.Forms.Label labelNameSuffix;
        private System.Windows.Forms.Label labelTriangles;
		private System.Windows.Forms.TableLayoutPanel tableRightSide;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox checkMeshReduction;
		private System.Windows.Forms.TextBox textMaxFilesPerFolder;
		private System.Windows.Forms.Label labelMaxPerFolder;
		private System.Windows.Forms.CheckBox checkLimitFilesPerFolder;
		private System.Windows.Forms.CheckBox checkIncludeSubFolders;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.CheckBox checkAddNameSuffix;
		private System.Windows.Forms.ProgressBar progressStatus;
		private System.Windows.Forms.Label labelStatusText;
	}
}

