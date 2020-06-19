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
            this.tbPgSps = new System.Windows.Forms.TabPage();
            this.gvFilesOnServer = new System.Windows.Forms.DataGridView();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butOutParam = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPgSql.SuspendLayout();
            this.tbPgSps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).BeginInit();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDo.Location = new System.Drawing.Point(332, 347);
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
            // tbPgSps
            // 
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
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(7, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(885, 434);
            this.txtOutput.TabIndex = 0;
            // 
            // butOutParam
            // 
            this.butOutParam.Location = new System.Drawing.Point(30, 461);
            this.butOutParam.Name = "butOutParam";
            this.butOutParam.Size = new System.Drawing.Size(170, 40);
            this.butOutParam.TabIndex = 1;
            this.butOutParam.Text = "Out Parameter";
            this.butOutParam.UseVisualStyleBackColor = true;
            this.butOutParam.Click += new System.EventHandler(this.butOutParam_Click);
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
            this.tbPgSps.ResumeLayout(false);
            this.tbPgSps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).EndInit();
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
    }
}

