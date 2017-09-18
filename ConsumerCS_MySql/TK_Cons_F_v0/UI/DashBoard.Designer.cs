namespace TK_Cons_F_v0.UI
{
    partial class frmDashBoard
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDataFlow = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(205, 40);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(196, 259);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "&AYARLAR";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUser.Enabled = false;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUser.Location = new System.Drawing.Point(205, 305);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(196, 123);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "KULLANICI(D)";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnDataFlow
            // 
            this.btnDataFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDataFlow.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDataFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataFlow.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDataFlow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDataFlow.Location = new System.Drawing.Point(407, 169);
            this.btnDataFlow.Name = "btnDataFlow";
            this.btnDataFlow.Size = new System.Drawing.Size(196, 259);
            this.btnDataFlow.TabIndex = 0;
            this.btnDataFlow.Text = "&VERİ AKIŞI";
            this.btnDataFlow.UseVisualStyleBackColor = false;
            this.btnDataFlow.Click += new System.EventHandler(this.btnDF_Click);
            // 
            // btnClock
            // 
            this.btnClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClock.Enabled = false;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClock.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClock.Location = new System.Drawing.Point(407, 40);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(196, 123);
            this.btnClock.TabIndex = 0;
            this.btnClock.Text = "SAAT";
            this.btnClock.UseVisualStyleBackColor = false;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 455);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnDataFlow);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnSettings);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashBoard";
            this.VisibleChanged += new System.EventHandler(this.frmDashBoard_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDataFlow;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Timer timerClock;
    }
}