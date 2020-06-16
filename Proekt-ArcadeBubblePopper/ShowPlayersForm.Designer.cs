namespace Proekt_ArcadeBubblePopper
{
    partial class ShowPlayersForm
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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.lbPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 25;
            this.lbPlayers.Location = new System.Drawing.Point(12, 12);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPlayers.Size = new System.Drawing.Size(586, 300);
            this.lbPlayers.TabIndex = 0;
            // 
            // ShowPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 340);
            this.Controls.Add(this.lbPlayers);
            this.Name = "ShowPlayersForm";
            this.Text = "Играчи кои ја завршиле играта";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayers;
    }
}