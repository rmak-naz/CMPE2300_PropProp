namespace ICA2_PropProp
{
    partial class ICA2_PropProp
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
            this.B_Start = new System.Windows.Forms.Button();
            this.BallTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(99, 113);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(75, 23);
            this.B_Start.TabIndex = 0;
            this.B_Start.Text = "Start";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // BallTick
            // 
            this.BallTick.Interval = 50;
            this.BallTick.Tick += new System.EventHandler(this.BallTick_Tick);
            // 
            // ICA2_PropProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.B_Start);
            this.Name = "ICA2_PropProp";
            this.Text = "Prop Prop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Timer BallTick;
    }
}

