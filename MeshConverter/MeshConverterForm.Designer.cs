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
			this.btnCopy = new System.Windows.Forms.Button();
			this.textNameSuffix = new System.Windows.Forms.TextBox();
			this.textReductionTargetTriangle = new System.Windows.Forms.TextBox();
			this.labelNameSuffix = new System.Windows.Forms.Label();
			this.labelTriangles = new System.Windows.Forms.Label();
			this.splitLeftRight = new System.Windows.Forms.SplitContainer();
			this.browserLeft = new MeshConverter.Controls.MeshBrowser();
			this.tableRightSide = new System.Windows.Forms.TableLayoutPanel();
			this.browserRight = new MeshConverter.Controls.MeshBrowser();
			this.tableMiddle = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radioMove = new System.Windows.Forms.RadioButton();
			this.textMaxFilesPerFolder = new System.Windows.Forms.TextBox();
			this.labelMaxPerFolder = new System.Windows.Forms.Label();
			this.checkLimitFilesPerFolder = new System.Windows.Forms.CheckBox();
			this.checkIncludeSubFolders = new System.Windows.Forms.CheckBox();
			this.checkMeshReduction = new System.Windows.Forms.CheckBox();
			this.checkAddNameSuffix = new System.Windows.Forms.CheckBox();
			this.checkRandomFiles = new System.Windows.Forms.CheckBox();
			this.radioCopy = new System.Windows.Forms.RadioButton();
			this.tableStatus = new System.Windows.Forms.TableLayoutPanel();
			this.progressStatus = new System.Windows.Forms.ProgressBar();
			this.labelStatusText = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.checkImageGeneration = new System.Windows.Forms.CheckBox();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).BeginInit();
			this.splitLeftRight.Panel1.SuspendLayout();
			this.splitLeftRight.Panel2.SuspendLayout();
			this.splitLeftRight.SuspendLayout();
			this.tableRightSide.SuspendLayout();
			this.tableMiddle.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableStatus.SuspendLayout();
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
			// btnCopy
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnCopy, 2);
			this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCopy.Location = new System.Drawing.Point(3, 53);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(180, 46);
			this.btnCopy.TabIndex = 4;
			this.btnCopy.Text = "Copy >";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// textNameSuffix
			// 
			this.textNameSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textNameSuffix.Location = new System.Drawing.Point(96, 130);
			this.textNameSuffix.Name = "textNameSuffix";
			this.textNameSuffix.Size = new System.Drawing.Size(87, 23);
			this.textNameSuffix.TabIndex = 3;
			this.toolTip1.SetToolTip(this.textNameSuffix, "Suffix that is added to each filename");
			this.textNameSuffix.Visible = false;
			// 
			// textReductionTargetTriangle
			// 
			this.textReductionTargetTriangle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textReductionTargetTriangle.Location = new System.Drawing.Point(96, 209);
			this.textReductionTargetTriangle.Name = "textReductionTargetTriangle";
			this.textReductionTargetTriangle.Size = new System.Drawing.Size(87, 23);
			this.textReductionTargetTriangle.TabIndex = 2;
			this.textReductionTargetTriangle.Visible = false;
			this.textReductionTargetTriangle.TextChanged += new System.EventHandler(this.textReductionTargetTriangle_TextChanged);
			// 
			// labelNameSuffix
			// 
			this.labelNameSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNameSuffix.AutoSize = true;
			this.labelNameSuffix.Location = new System.Drawing.Point(3, 131);
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
			this.labelTriangles.Location = new System.Drawing.Point(3, 213);
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
			this.tableRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableRightSide.Controls.Add(this.browserRight, 1, 0);
			this.tableRightSide.Controls.Add(this.tableMiddle, 0, 0);
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
			this.browserRight.Location = new System.Drawing.Point(203, 3);
			this.browserRight.Name = "browserRight";
			this.browserRight.Size = new System.Drawing.Size(439, 629);
			this.browserRight.TabIndex = 0;
			// 
			// tableMiddle
			// 
			this.tableMiddle.AutoSize = true;
			this.tableMiddle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableMiddle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableMiddle.ColumnCount = 1;
			this.tableMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableMiddle.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableMiddle.Controls.Add(this.tableStatus, 0, 0);
			this.tableMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableMiddle.Location = new System.Drawing.Point(0, 0);
			this.tableMiddle.Margin = new System.Windows.Forms.Padding(0);
			this.tableMiddle.Name = "tableMiddle";
			this.tableMiddle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tableMiddle.RowCount = 2;
			this.tableMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableMiddle.Size = new System.Drawing.Size(200, 635);
			this.tableMiddle.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.radioMove, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textMaxFilesPerFolder, 1, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxPerFolder, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.checkLimitFilesPerFolder, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.checkIncludeSubFolders, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.btnCopy, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelNameSuffix, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textNameSuffix, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelTriangles, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.checkMeshReduction, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.textReductionTargetTriangle, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.checkAddNameSuffix, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.checkRandomFiles, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.radioCopy, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.checkImageGeneration, 0, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 257);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 14;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 375);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// radioMove
			// 
			this.radioMove.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radioMove.AutoSize = true;
			this.radioMove.Location = new System.Drawing.Point(96, 15);
			this.radioMove.Name = "radioMove";
			this.radioMove.Size = new System.Drawing.Size(55, 19);
			this.radioMove.TabIndex = 13;
			this.radioMove.Text = "Move";
			this.radioMove.UseVisualStyleBackColor = true;
			this.radioMove.CheckedChanged += new System.EventHandler(this.radioCopy_CheckedChanged);
			// 
			// textMaxFilesPerFolder
			// 
			this.textMaxFilesPerFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textMaxFilesPerFolder.Location = new System.Drawing.Point(96, 288);
			this.textMaxFilesPerFolder.Name = "textMaxFilesPerFolder";
			this.textMaxFilesPerFolder.Size = new System.Drawing.Size(87, 23);
			this.textMaxFilesPerFolder.TabIndex = 9;
			this.toolTip1.SetToolTip(this.textMaxFilesPerFolder, "Max number of files to copy per folder");
			this.textMaxFilesPerFolder.Visible = false;
			// 
			// labelMaxPerFolder
			// 
			this.labelMaxPerFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelMaxPerFolder.AutoSize = true;
			this.labelMaxPerFolder.Location = new System.Drawing.Point(3, 292);
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
			this.checkLimitFilesPerFolder.Location = new System.Drawing.Point(3, 263);
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
			this.checkIncludeSubFolders.Location = new System.Drawing.Point(3, 238);
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
			this.checkMeshReduction.Location = new System.Drawing.Point(3, 184);
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
			this.checkAddNameSuffix.Location = new System.Drawing.Point(3, 105);
			this.checkAddNameSuffix.Name = "checkAddNameSuffix";
			this.checkAddNameSuffix.Size = new System.Drawing.Size(116, 19);
			this.checkAddNameSuffix.TabIndex = 10;
			this.checkAddNameSuffix.Text = "Add Name Suffix";
			this.checkAddNameSuffix.UseVisualStyleBackColor = true;
			this.checkAddNameSuffix.CheckedChanged += new System.EventHandler(this.checkAddNameSuffix_CheckedChanged);
			// 
			// checkRandomFiles
			// 
			this.checkRandomFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkRandomFiles.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkRandomFiles, 2);
			this.checkRandomFiles.Location = new System.Drawing.Point(3, 320);
			this.checkRandomFiles.Name = "checkRandomFiles";
			this.checkRandomFiles.Size = new System.Drawing.Size(97, 19);
			this.checkRandomFiles.TabIndex = 11;
			this.checkRandomFiles.Text = "Random Files";
			this.toolTip1.SetToolTip(this.checkRandomFiles, "Randomly select which files to copy");
			this.checkRandomFiles.UseVisualStyleBackColor = true;
			this.checkRandomFiles.Visible = false;
			// 
			// radioCopy
			// 
			this.radioCopy.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radioCopy.AutoSize = true;
			this.radioCopy.Checked = true;
			this.radioCopy.Location = new System.Drawing.Point(3, 15);
			this.radioCopy.Name = "radioCopy";
			this.radioCopy.Size = new System.Drawing.Size(53, 19);
			this.radioCopy.TabIndex = 12;
			this.radioCopy.TabStop = true;
			this.radioCopy.Text = "Copy";
			this.radioCopy.UseVisualStyleBackColor = true;
			this.radioCopy.CheckedChanged += new System.EventHandler(this.radioCopy_CheckedChanged);
			// 
			// tableStatus
			// 
			this.tableStatus.ColumnCount = 2;
			this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.18182F));
			this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.81818F));
			this.tableStatus.Controls.Add(this.progressStatus, 0, 1);
			this.tableStatus.Controls.Add(this.labelStatusText, 0, 0);
			this.tableStatus.Controls.Add(this.btnCancel, 1, 1);
			this.tableStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableStatus.Location = new System.Drawing.Point(7, 194);
			this.tableStatus.Name = "tableStatus";
			this.tableStatus.RowCount = 2;
			this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableStatus.Size = new System.Drawing.Size(186, 57);
			this.tableStatus.TabIndex = 5;
			this.tableStatus.Visible = false;
			// 
			// progressStatus
			// 
			this.progressStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressStatus.Location = new System.Drawing.Point(3, 27);
			this.progressStatus.Name = "progressStatus";
			this.progressStatus.Size = new System.Drawing.Size(111, 27);
			this.progressStatus.TabIndex = 0;
			// 
			// labelStatusText
			// 
			this.labelStatusText.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelStatusText.AutoSize = true;
			this.tableStatus.SetColumnSpan(this.labelStatusText, 2);
			this.labelStatusText.Location = new System.Drawing.Point(3, 4);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new System.Drawing.Size(16, 15);
			this.labelStatusText.TabIndex = 11;
			this.labelStatusText.Text = "...";
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(120, 27);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(63, 27);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
			// checkImageGeneration
			// 
			this.checkImageGeneration.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkImageGeneration, 2);
			this.checkImageGeneration.Location = new System.Drawing.Point(3, 159);
			this.checkImageGeneration.Name = "checkImageGeneration";
			this.checkImageGeneration.Size = new System.Drawing.Size(120, 19);
			this.checkImageGeneration.TabIndex = 14;
			this.checkImageGeneration.Text = "Image Generation";
			this.checkImageGeneration.UseVisualStyleBackColor = true;
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
			this.tableMiddle.ResumeLayout(false);
			this.tableMiddle.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableStatus.ResumeLayout(false);
			this.tableStatus.PerformLayout();
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
        private System.Windows.Forms.Button btnCopy;
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
		private System.Windows.Forms.TableLayoutPanel tableMiddle;
		private System.Windows.Forms.CheckBox checkAddNameSuffix;
		private System.Windows.Forms.ProgressBar progressStatus;
		private System.Windows.Forms.Label labelStatusText;
		private System.Windows.Forms.TableLayoutPanel tableStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox checkRandomFiles;
		private System.Windows.Forms.RadioButton radioCopy;
		private System.Windows.Forms.RadioButton radioMove;
		private System.Windows.Forms.CheckBox checkImageGeneration;
	}
}

