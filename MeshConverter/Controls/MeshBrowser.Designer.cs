﻿namespace MeshManager.Controls
{
    partial class MeshBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gridMeshes = new System.Windows.Forms.DataGridView();
			this.tableFilePath = new System.Windows.Forms.TableLayoutPanel();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.flowFolders = new System.Windows.Forms.FlowLayoutPanel();
			this.textNewFolder = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textPath = new System.Windows.Forms.TextBox();
			this.browseUp = new MeshManager.Controls.BrowseButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
			this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
			this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
			this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoryCertainty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTriangleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMeshes)).BeginInit();
			this.tableFilePath.SuspendLayout();
			this.flowFolders.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.gridMeshes, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableFilePath, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 592);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// gridMeshes
			// 
			this.gridMeshes.AllowUserToAddRows = false;
			this.gridMeshes.AllowUserToResizeRows = false;
			this.gridMeshes.BackgroundColor = System.Drawing.Color.White;
			this.gridMeshes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridMeshes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridMeshes.ColumnHeadersHeight = 24;
			this.gridMeshes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.colFileName,
            this.colCategory,
            this.colCategoryCertainty,
            this.colFileSize,
            this.colPoints,
            this.colTriangleCount});
			this.gridMeshes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gridMeshes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMeshes.GridColor = System.Drawing.Color.LightGray;
			this.gridMeshes.Location = new System.Drawing.Point(4, 151);
			this.gridMeshes.Margin = new System.Windows.Forms.Padding(4);
			this.gridMeshes.Name = "gridMeshes";
			this.gridMeshes.RowHeadersVisible = false;
			this.gridMeshes.RowHeadersWidth = 62;
			this.gridMeshes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.gridMeshes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
			this.gridMeshes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gridMeshes.RowTemplate.Height = 128;
			this.gridMeshes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMeshes.Size = new System.Drawing.Size(542, 437);
			this.gridMeshes.TabIndex = 1;
			this.gridMeshes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeshes_CellDoubleClick);
			this.gridMeshes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMeshes_CellMouseClick);
			this.gridMeshes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMeshes_CellMouseDown);
			this.gridMeshes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeshes_CellMouseLeave);
			this.gridMeshes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMeshes_CellMouseUp);
			this.gridMeshes.SelectionChanged += new System.EventHandler(this.GridMeshes_SelectionChanged);
			// 
			// tableFilePath
			// 
			this.tableFilePath.AutoSize = true;
			this.tableFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableFilePath.ColumnCount = 3;
			this.tableFilePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableFilePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableFilePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableFilePath.Controls.Add(this.btnBrowse, 2, 0);
			this.tableFilePath.Controls.Add(this.flowFolders, 1, 1);
			this.tableFilePath.Controls.Add(this.panel1, 1, 0);
			this.tableFilePath.Controls.Add(this.browseUp, 0, 0);
			this.tableFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableFilePath.Location = new System.Drawing.Point(3, 3);
			this.tableFilePath.Name = "tableFilePath";
			this.tableFilePath.RowCount = 2;
			this.tableFilePath.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilePath.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilePath.Size = new System.Drawing.Size(544, 141);
			this.tableFilePath.TabIndex = 2;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
			this.btnBrowse.FlatAppearance.BorderSize = 0;
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Image = global::MeshManager.Properties.Resources.FolderClosedBlue;
			this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBrowse.Location = new System.Drawing.Point(500, 3);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(41, 20);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "..";
			this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// flowFolders
			// 
			this.flowFolders.AutoScroll = true;
			this.flowFolders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowFolders.Controls.Add(this.textNewFolder);
			this.flowFolders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowFolders.Location = new System.Drawing.Point(53, 41);
			this.flowFolders.Margin = new System.Windows.Forms.Padding(0);
			this.flowFolders.Name = "flowFolders";
			this.flowFolders.Size = new System.Drawing.Size(444, 100);
			this.flowFolders.TabIndex = 0;
			this.flowFolders.Visible = false;
			// 
			// textNewFolder
			// 
			this.textNewFolder.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textNewFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textNewFolder.Location = new System.Drawing.Point(3, 3);
			this.textNewFolder.Name = "textNewFolder";
			this.textNewFolder.Size = new System.Drawing.Size(133, 15);
			this.textNewFolder.TabIndex = 0;
			this.textNewFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextNewFolder_KeyDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textPath);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(56, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 35);
			this.panel1.TabIndex = 2;
			// 
			// textPath
			// 
			this.textPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textPath.Location = new System.Drawing.Point(0, 0);
			this.textPath.Margin = new System.Windows.Forms.Padding(4);
			this.textPath.Name = "textPath";
			this.textPath.Size = new System.Drawing.Size(438, 22);
			this.textPath.TabIndex = 1;
			//this.textPath.Text = "C:\\Users\\gusla\\source\\repos\\external\\Manifold40";
			this.textPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPath_KeyDown);
			// 
			// browseUp
			// 
			this.browseUp.AutoSize = true;
			this.browseUp.FlatAppearance.BorderSize = 0;
			this.browseUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseUp.Image = global::MeshManager.Properties.Resources.FolderClosedBlue;
			this.browseUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.browseUp.Location = new System.Drawing.Point(3, 3);
			this.browseUp.Name = "browseUp";
			this.browseUp.Size = new System.Drawing.Size(47, 35);
			this.browseUp.TabIndex = 1;
			this.browseUp.Text = "↑";
			this.browseUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.browseUp.Url = null;
			this.browseUp.UseVisualStyleBackColor = true;
			this.browseUp.Click += new System.EventHandler(this.BrowseUp_Click);
			// 
			// colIcon
			// 
			this.colIcon.DataPropertyName = "Icon";
			this.colIcon.HeaderText = "";
			this.colIcon.MinimumWidth = 8;
			this.colIcon.Name = "colIcon";
			this.colIcon.ReadOnly = true;
			this.colIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colIcon.Width = 128;
			// 
			// colFileName
			// 
			this.colFileName.DataPropertyName = "FileName";
			this.colFileName.HeaderText = "Name";
			this.colFileName.MinimumWidth = 8;
			this.colFileName.Name = "colFileName";
			this.colFileName.ReadOnly = true;
			this.colFileName.Width = 150;
			// 
			// colCategory
			// 
			this.colCategory.DataPropertyName = "Category";
			this.colCategory.HeaderText = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.ReadOnly = true;
			// 
			// colCategoryCertainty
			// 
			this.colCategoryCertainty.DataPropertyName = "CategoryCertainty";
			this.colCategoryCertainty.HeaderText = "Certainty";
			this.colCategoryCertainty.Name = "colCategoryCertainty";
			this.colCategoryCertainty.ReadOnly = true;
			// 
			// colFileSize
			// 
			this.colFileSize.DataPropertyName = "FileSize";
			this.colFileSize.HeaderText = "File Size";
			this.colFileSize.Name = "colFileSize";
			this.colFileSize.ReadOnly = true;
			// 
			// colPoints
			// 
			this.colPoints.DataPropertyName = "VertexCount";
			this.colPoints.HeaderText = "Vertices";
			this.colPoints.MinimumWidth = 8;
			this.colPoints.Name = "colPoints";
			this.colPoints.ReadOnly = true;
			// 
			// colTriangleCount
			// 
			this.colTriangleCount.DataPropertyName = "FaceCount";
			this.colTriangleCount.HeaderText = "Faces";
			this.colTriangleCount.MinimumWidth = 8;
			this.colTriangleCount.Name = "colTriangleCount";
			this.colTriangleCount.ReadOnly = true;
			// 
			// MeshBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MeshBrowser";
			this.Size = new System.Drawing.Size(550, 592);
			this.Load += new System.EventHandler(this.MeshBrowser_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMeshes)).EndInit();
			this.tableFilePath.ResumeLayout(false);
			this.tableFilePath.PerformLayout();
			this.flowFolders.ResumeLayout(false);
			this.flowFolders.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowFolders;
        private System.Windows.Forms.DataGridView gridMeshes;
        private System.Windows.Forms.TableLayoutPanel tableFilePath;
        private BrowseButton browseUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textNewFolder;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog3;
		private System.Windows.Forms.DataGridViewImageColumn colIcon;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryCertainty;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTriangleCount;
	}
}
