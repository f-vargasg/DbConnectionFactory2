namespace DbConnectionFactory2
{
    partial class Form1
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
            this.butDo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgSql = new System.Windows.Forms.TabPage();
            this.gvFilesOnServer = new System.Windows.Forms.DataGridView();
            this.tbPgSps = new System.Windows.Forms.TabPage();
            this.butReadCursor = new System.Windows.Forms.Button();
            this.butOutParam = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tbPgTest = new System.Windows.Forms.TabPage();
            this.butFuncTool = new System.Windows.Forms.Button();
            this.butDoTest = new System.Windows.Forms.Button();
            this.txtTestOut = new System.Windows.Forms.TextBox();
            this.butFuncNativa = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPgSql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).BeginInit();
            this.tbPgSps.SuspendLayout();
            this.tbPgTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDo.Location = new System.Drawing.Point(114, 353);
            this.butDo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(255, 165);
            this.butDo.TabIndex = 2;
            this.butDo.Text = "Do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgSql);
            this.tabControl1.Controls.Add(this.tbPgSps);
            this.tabControl1.Controls.Add(this.tbPgTest);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 573);
            this.tabControl1.TabIndex = 4;
            // 
            // tbPgSql
            // 
            this.tbPgSql.Controls.Add(this.gvFilesOnServer);
            this.tbPgSql.Controls.Add(this.butDo);
            this.tbPgSql.Location = new System.Drawing.Point(4, 29);
            this.tbPgSql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPgSql.Name = "tbPgSql";
            this.tbPgSql.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPgSql.Size = new System.Drawing.Size(892, 540);
            this.tbPgSql.TabIndex = 0;
            this.tbPgSql.Text = "Sql Normales";
            this.tbPgSql.UseVisualStyleBackColor = true;
            // 
            // gvFilesOnServer
            // 
            this.gvFilesOnServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFilesOnServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFilesOnServer.Location = new System.Drawing.Point(9, 5);
            this.gvFilesOnServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvFilesOnServer.Name = "gvFilesOnServer";
            this.gvFilesOnServer.Size = new System.Drawing.Size(875, 294);
            this.gvFilesOnServer.TabIndex = 4;
            // 
            // tbPgSps
            // 
            this.tbPgSps.Controls.Add(this.butFuncNativa);
            this.tbPgSps.Controls.Add(this.butReadCursor);
            this.tbPgSps.Controls.Add(this.butOutParam);
            this.tbPgSps.Controls.Add(this.txtOutput);
            this.tbPgSps.Location = new System.Drawing.Point(4, 29);
            this.tbPgSps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPgSps.Name = "tbPgSps";
            this.tbPgSps.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPgSps.Size = new System.Drawing.Size(892, 540);
            this.tbPgSps.TabIndex = 1;
            this.tbPgSps.Text = "Stored Procedures";
            this.tbPgSps.UseVisualStyleBackColor = true;
            // 
            // butReadCursor
            // 
            this.butReadCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butReadCursor.Location = new System.Drawing.Point(417, 461);
            this.butReadCursor.Name = "butReadCursor";
            this.butReadCursor.Size = new System.Drawing.Size(170, 40);
            this.butReadCursor.TabIndex = 2;
            this.butReadCursor.Text = "Read Cursor";
            this.butReadCursor.UseVisualStyleBackColor = true;
            this.butReadCursor.Click += new System.EventHandler(this.butReadCursor_Click);
            // 
            // butOutParam
            // 
            this.butOutParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butOutParam.Location = new System.Drawing.Point(30, 461);
            this.butOutParam.Name = "butOutParam";
            this.butOutParam.Size = new System.Drawing.Size(170, 40);
            this.butOutParam.TabIndex = 1;
            this.butOutParam.Text = "Out Parameter";
            this.butOutParam.UseVisualStyleBackColor = true;
            this.butOutParam.Click += new System.EventHandler(this.butOutParam_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(7, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(885, 434);
            this.txtOutput.TabIndex = 0;
            // 
            // tbPgTest
            // 
            this.tbPgTest.Controls.Add(this.butFuncTool);
            this.tbPgTest.Controls.Add(this.butDoTest);
            this.tbPgTest.Controls.Add(this.txtTestOut);
            this.tbPgTest.Location = new System.Drawing.Point(4, 29);
            this.tbPgTest.Name = "tbPgTest";
            this.tbPgTest.Size = new System.Drawing.Size(892, 540);
            this.tbPgTest.TabIndex = 2;
            this.tbPgTest.Text = "Test";
            this.tbPgTest.UseVisualStyleBackColor = true;
            // 
            // butFuncTool
            // 
            this.butFuncTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butFuncTool.Location = new System.Drawing.Point(260, 461);
            this.butFuncTool.Name = "butFuncTool";
            this.butFuncTool.Size = new System.Drawing.Size(215, 40);
            this.butFuncTool.TabIndex = 5;
            this.butFuncTool.Text = "Test Sps Function";
            this.butFuncTool.UseVisualStyleBackColor = true;
            this.butFuncTool.Click += new System.EventHandler(this.butFuncTool_Click);
            // 
            // butDoTest
            // 
            this.butDoTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDoTest.Location = new System.Drawing.Point(22, 461);
            this.butDoTest.Name = "butDoTest";
            this.butDoTest.Size = new System.Drawing.Size(215, 40);
            this.butDoTest.TabIndex = 4;
            this.butDoTest.Text = "Test Sps Out Parameter";
            this.butDoTest.UseVisualStyleBackColor = true;
            this.butDoTest.Click += new System.EventHandler(this.butDoTest_Click);
            // 
            // txtTestOut
            // 
            this.txtTestOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestOut.Location = new System.Drawing.Point(-1, 3);
            this.txtTestOut.Multiline = true;
            this.txtTestOut.Name = "txtTestOut";
            this.txtTestOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTestOut.Size = new System.Drawing.Size(885, 434);
            this.txtTestOut.TabIndex = 3;
            // 
            // butFuncNativa
            // 
            this.butFuncNativa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butFuncNativa.Location = new System.Drawing.Point(231, 461);
            this.butFuncNativa.Name = "butFuncNativa";
            this.butFuncNativa.Size = new System.Drawing.Size(170, 40);
            this.butFuncNativa.TabIndex = 3;
            this.butFuncNativa.Text = "Function";
            this.butFuncNativa.UseVisualStyleBackColor = true;
            this.butFuncNativa.Click += new System.EventHandler(this.butFuncNativa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 573);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbPgSql.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).EndInit();
            this.tbPgSps.ResumeLayout(false);
            this.tbPgSps.PerformLayout();
            this.tbPgTest.ResumeLayout(false);
            this.tbPgTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgSql;
        private System.Windows.Forms.DataGridView gvFilesOnServer;
        private System.Windows.Forms.TabPage tbPgSps;
        private System.Windows.Forms.Button butOutParam;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butReadCursor;
        private System.Windows.Forms.TabPage tbPgTest;
        private System.Windows.Forms.Button butDoTest;
        private System.Windows.Forms.TextBox txtTestOut;
        private System.Windows.Forms.Button butFuncTool;
        private System.Windows.Forms.Button butFuncNativa;
    }
}

