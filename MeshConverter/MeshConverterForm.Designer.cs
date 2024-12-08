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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeshConverterForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMeshReductionGo = new System.Windows.Forms.Button();
            this.textReductionFileSuffix = new System.Windows.Forms.TextBox();
            this.textReductionTargetTriangle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitLeftRight = new System.Windows.Forms.SplitContainer();
            this.browserLeft = new MeshConverter.Controls.MeshBrowser();
            this.browserRight = new MeshConverter.Controls.MeshBrowser();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).BeginInit();
            this.splitLeftRight.Panel1.SuspendLayout();
            this.splitLeftRight.Panel2.SuspendLayout();
            this.splitLeftRight.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(983, 100);
            this.panelTop.TabIndex = 0;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.groupBox1);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolbar.Location = new System.Drawing.Point(8, 8);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(967, 84);
            this.panelToolbar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMeshReductionGo);
            this.groupBox1.Controls.Add(this.textReductionFileSuffix);
            this.groupBox1.Controls.Add(this.textReductionTargetTriangle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(224, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesh Reduction";
            // 
            // btnMeshReductionGo
            // 
            this.btnMeshReductionGo.Location = new System.Drawing.Point(241, 33);
            this.btnMeshReductionGo.Name = "btnMeshReductionGo";
            this.btnMeshReductionGo.Size = new System.Drawing.Size(75, 23);
            this.btnMeshReductionGo.TabIndex = 4;
            this.btnMeshReductionGo.Text = "Go";
            this.btnMeshReductionGo.UseVisualStyleBackColor = true;
            this.btnMeshReductionGo.Click += new System.EventHandler(this.btnMeshReductionGo_Click);
            // 
            // textReductionFileSuffix
            // 
            this.textReductionFileSuffix.Location = new System.Drawing.Point(135, 48);
            this.textReductionFileSuffix.Name = "textReductionFileSuffix";
            this.textReductionFileSuffix.Size = new System.Drawing.Size(100, 23);
            this.textReductionFileSuffix.TabIndex = 3;
            // 
            // textReductionTargetTriangle
            // 
            this.textReductionTargetTriangle.Location = new System.Drawing.Point(135, 20);
            this.textReductionTargetTriangle.Name = "textReductionTargetTriangle";
            this.textReductionTargetTriangle.Size = new System.Drawing.Size(100, 23);
            this.textReductionTargetTriangle.TabIndex = 2;
            this.textReductionTargetTriangle.TextChanged += new System.EventHandler(this.textReductionTargetTriangle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name Suffix:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Triangle Count:";
            // 
            // splitLeftRight
            // 
            this.splitLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftRight.Location = new System.Drawing.Point(8, 8);
            this.splitLeftRight.Name = "splitLeftRight";
            // 
            // splitLeftRight.Panel1
            // 
            this.splitLeftRight.Panel1.Controls.Add(this.browserLeft);
            // 
            // splitLeftRight.Panel2
            // 
            this.splitLeftRight.Panel2.Controls.Add(this.browserRight);
            this.splitLeftRight.Size = new System.Drawing.Size(967, 351);
            this.splitLeftRight.SplitterDistance = 458;
            this.splitLeftRight.TabIndex = 1;
            // 
            // browserLeft
            // 
            this.browserLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserLeft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserLeft.Location = new System.Drawing.Point(0, 0);
            this.browserLeft.Name = "browserLeft";
            this.browserLeft.Size = new System.Drawing.Size(458, 351);
            this.browserLeft.TabIndex = 0;
            // 
            // browserRight
            // 
            this.browserRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserRight.Location = new System.Drawing.Point(0, 0);
            this.browserRight.Name = "browserRight";
            this.browserRight.Size = new System.Drawing.Size(505, 351);
            this.browserRight.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitLeftRight);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(8);
            this.panelMain.Size = new System.Drawing.Size(983, 367);
            this.panelMain.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 467);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(983, 100);
            this.panelBottom.TabIndex = 3;
            // 
            // MeshConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 567);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeshConverterForm";
            this.Text = "Mesh Converter";
            this.Load += new System.EventHandler(this.MeshExplorer_Load);
            this.panelTop.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitLeftRight.Panel1.ResumeLayout(false);
            this.splitLeftRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).EndInit();
            this.splitLeftRight.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMeshReductionGo;
        private System.Windows.Forms.TextBox textReductionFileSuffix;
        private System.Windows.Forms.TextBox textReductionTargetTriangle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

