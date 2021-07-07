
namespace VLC_Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.playlistVLC = new System.Windows.Forms.ListBox();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 12);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(504, 381);
            this.axVLCPlugin21.TabIndex = 0;
            this.axVLCPlugin21.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.axVLCPlugin21_PreviewKeyDown);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(522, 113);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(145, 33);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "&Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // playlistVLC
            // 
            this.playlistVLC.FormattingEnabled = true;
            this.playlistVLC.Location = new System.Drawing.Point(522, 12);
            this.playlistVLC.Name = "playlistVLC";
            this.playlistVLC.Size = new System.Drawing.Size(145, 95);
            this.playlistVLC.TabIndex = 2;
            this.playlistVLC.SelectedValueChanged += new System.EventHandler(this.playlistVLC_SelectedValueChanged);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(522, 152);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(145, 33);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "&Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 434);
            this.Controls.Add(this.playlistVLC);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.axVLCPlugin21);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ListBox playlistVLC;
        private System.Windows.Forms.Button playBtn;
    }
}

