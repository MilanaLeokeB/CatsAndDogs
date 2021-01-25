namespace CatsAndDogs
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
            this.DogPicture = new System.Windows.Forms.PictureBox();
            this.GetAdog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Location = new System.Drawing.Point(768, 74);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(334, 359);
            this.DogPicture.TabIndex = 1;
            this.DogPicture.TabStop = false;
            // 
            // GetAdog
            // 
            this.GetAdog.Location = new System.Drawing.Point(874, 497);
            this.GetAdog.Name = "GetAdog";
            this.GetAdog.Size = new System.Drawing.Size(115, 38);
            this.GetAdog.TabIndex = 2;
            this.GetAdog.Text = "Get dog image";
            this.GetAdog.UseVisualStyleBackColor = true;
            this.GetAdog.Click += new System.EventHandler(this.GetAdog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 709);
            this.Controls.Add(this.GetAdog);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.Button GetAdog;
    }
}

