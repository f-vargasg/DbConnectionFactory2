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
            this.gvFilesOnServer = new System.Windows.Forms.DataGridView();
            this.butDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).BeginInit();
            this.SuspendLayout();
            // 
            // gvFilesOnServer
            // 
            this.gvFilesOnServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFilesOnServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFilesOnServer.Location = new System.Drawing.Point(-3, 2);
            this.gvFilesOnServer.Name = "gvFilesOnServer";
            this.gvFilesOnServer.Size = new System.Drawing.Size(758, 280);
            this.gvFilesOnServer.TabIndex = 3;
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(297, 310);
            this.butDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(170, 107);
            this.butDo.TabIndex = 2;
            this.butDo.Text = "Do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 465);
            this.Controls.Add(this.gvFilesOnServer);
            this.Controls.Add(this.butDo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFilesOnServer;
        private System.Windows.Forms.Button butDo;
    }
}

