namespace GlumSak_MetaViewer.UI
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
            this.Images_WrapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Games_List = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmuConfig_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Images_WrapPanel
            // 
            this.Images_WrapPanel.AutoScroll = true;
            this.Images_WrapPanel.Location = new System.Drawing.Point(12, 51);
            this.Images_WrapPanel.Name = "Images_WrapPanel";
            this.Images_WrapPanel.Size = new System.Drawing.Size(639, 220);
            this.Images_WrapPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Images";
            // 
            // Games_List
            // 
            this.Games_List.FormattingEnabled = true;
            this.Games_List.Location = new System.Drawing.Point(12, 303);
            this.Games_List.Name = "Games_List";
            this.Games_List.Size = new System.Drawing.Size(639, 134);
            this.Games_List.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Games";
            // 
            // EmuConfig_Label
            // 
            this.EmuConfig_Label.AutoSize = true;
            this.EmuConfig_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmuConfig_Label.Location = new System.Drawing.Point(284, 463);
            this.EmuConfig_Label.Name = "EmuConfig_Label";
            this.EmuConfig_Label.Size = new System.Drawing.Size(75, 13);
            this.EmuConfig_Label.TabIndex = 5;
            this.EmuConfig_Label.Text = "EmuConfig: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmuConfig_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Games_List);
            this.Controls.Add(this.Images_WrapPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cache Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Images_WrapPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Games_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmuConfig_Label;
    }
}