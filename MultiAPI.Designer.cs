﻿
namespace neoblox
{
    partial class MultiAPI
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
            this.closeButton = new ns1.SiticoneButton();
            this.minimizeButton = new ns1.SiticoneButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.multiAPIButton = new ns1.SiticoneButton();
            this.krnlInject = new ns1.SiticoneButton();
            this.checkInjectedTimer = new System.Windows.Forms.Timer(this.components);
            this.easyxploitAPIInject = new ns1.SiticoneButton();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.closeButton.HoveredState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(700, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(62, 43);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.minimizeButton.HoveredState.Parent = this.minimizeButton;
            this.minimizeButton.Location = new System.Drawing.Point(641, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(62, 43);
            this.minimizeButton.TabIndex = 25;
            this.minimizeButton.Text = "-";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 38);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Neoblox (Multi API)";
            // 
            // multiAPIButton
            // 
            this.multiAPIButton.CheckedState.Parent = this.multiAPIButton;
            this.multiAPIButton.CustomImages.Parent = this.multiAPIButton;
            this.multiAPIButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.multiAPIButton.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiAPIButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.multiAPIButton.HoveredState.Parent = this.multiAPIButton;
            this.multiAPIButton.Location = new System.Drawing.Point(274, 5);
            this.multiAPIButton.Name = "multiAPIButton";
            this.multiAPIButton.ShadowDecoration.Parent = this.multiAPIButton;
            this.multiAPIButton.Size = new System.Drawing.Size(230, 33);
            this.multiAPIButton.TabIndex = 24;
            this.multiAPIButton.Text = "Click to leave multi API selection";
            this.multiAPIButton.Click += new System.EventHandler(this.multiAPIButton_Click);
            // 
            // krnlInject
            // 
            this.krnlInject.CheckedState.Parent = this.krnlInject;
            this.krnlInject.CustomImages.Parent = this.krnlInject;
            this.krnlInject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.krnlInject.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krnlInject.ForeColor = System.Drawing.Color.PeachPuff;
            this.krnlInject.HoveredState.Parent = this.krnlInject;
            this.krnlInject.Location = new System.Drawing.Point(274, 44);
            this.krnlInject.Name = "krnlInject";
            this.krnlInject.ShadowDecoration.Parent = this.krnlInject;
            this.krnlInject.Size = new System.Drawing.Size(230, 33);
            this.krnlInject.TabIndex = 36;
            this.krnlInject.Text = "Krnl API Inject";
            this.krnlInject.Click += new System.EventHandler(this.krnlInject_Click);
            // 
            // easyxploitAPIInject
            // 
            this.easyxploitAPIInject.CheckedState.Parent = this.easyxploitAPIInject;
            this.easyxploitAPIInject.CustomImages.Parent = this.easyxploitAPIInject;
            this.easyxploitAPIInject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.easyxploitAPIInject.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyxploitAPIInject.ForeColor = System.Drawing.Color.PeachPuff;
            this.easyxploitAPIInject.HoveredState.Parent = this.easyxploitAPIInject;
            this.easyxploitAPIInject.Location = new System.Drawing.Point(274, 83);
            this.easyxploitAPIInject.Name = "easyxploitAPIInject";
            this.easyxploitAPIInject.ShadowDecoration.Parent = this.easyxploitAPIInject;
            this.easyxploitAPIInject.Size = new System.Drawing.Size(230, 33);
            this.easyxploitAPIInject.TabIndex = 37;
            this.easyxploitAPIInject.Text = "EasyXploit API Inject";
            this.easyxploitAPIInject.Click += new System.EventHandler(this.easyxploitAPIInject_Click);
            // 
            // MultiAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(763, 227);
            this.Controls.Add(this.easyxploitAPIInject);
            this.Controls.Add(this.krnlInject);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.multiAPIButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiAPI";
            this.Text = "MultiAPI";
            this.Load += new System.EventHandler(this.MultiAPI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MultiAPI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MultiAPI_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticoneButton closeButton;
        private ns1.SiticoneButton minimizeButton;
        private System.Windows.Forms.Label titleLabel;
        private ns1.SiticoneButton multiAPIButton;
        private ns1.SiticoneButton krnlInject;
        private System.Windows.Forms.Timer checkInjectedTimer;
        private ns1.SiticoneButton easyxploitAPIInject;
    }
}