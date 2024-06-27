namespace ProgRecipeTester
{
    partial class SearchforRecipe
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
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.lblSearchRecipe = new System.Windows.Forms.Label();
            this.txtbSearchRecipeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(338, 270);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(116, 38);
            this.btnSearchRecipe.TabIndex = 0;
            this.btnSearchRecipe.Text = "Search";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            // 
            // lblSearchRecipe
            // 
            this.lblSearchRecipe.AutoSize = true;
            this.lblSearchRecipe.Location = new System.Drawing.Point(228, 77);
            this.lblSearchRecipe.Name = "lblSearchRecipe";
            this.lblSearchRecipe.Size = new System.Drawing.Size(372, 16);
            this.lblSearchRecipe.TabIndex = 1;
            this.lblSearchRecipe.Text = "Please enter the name of the ingredient you want to search for ";
            this.lblSearchRecipe.Click += new System.EventHandler(this.lblSearchRecipe_Click);
            // 
            // txtbSearchRecipeName
            // 
            this.txtbSearchRecipeName.Location = new System.Drawing.Point(329, 137);
            this.txtbSearchRecipeName.Name = "txtbSearchRecipeName";
            this.txtbSearchRecipeName.Size = new System.Drawing.Size(142, 22);
            this.txtbSearchRecipeName.TabIndex = 2;
            // 
            // SearchforRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbSearchRecipeName);
            this.Controls.Add(this.lblSearchRecipe);
            this.Controls.Add(this.btnSearchRecipe);
            this.Name = "SearchforRecipe";
            this.Text = "SearchforRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRecipe;
        private System.Windows.Forms.Label lblSearchRecipe;
        private System.Windows.Forms.TextBox txtbSearchRecipeName;
    }
}