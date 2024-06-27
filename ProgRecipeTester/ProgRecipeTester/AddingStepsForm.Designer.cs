namespace ProgRecipeTester
{
    partial class AddingStepsForm
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
            this.LblAddingsteps = new System.Windows.Forms.Label();
            this.txtbAddingSteps = new System.Windows.Forms.TextBox();
            this.btnSubmitSteps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAddingsteps
            // 
            this.LblAddingsteps.AutoSize = true;
            this.LblAddingsteps.Location = new System.Drawing.Point(291, 102);
            this.LblAddingsteps.Name = "LblAddingsteps";
            this.LblAddingsteps.Size = new System.Drawing.Size(189, 16);
            this.LblAddingsteps.TabIndex = 0;
            this.LblAddingsteps.Text = "Please enter the step required ";
            // 
            // txtbAddingSteps
            // 
            this.txtbAddingSteps.Location = new System.Drawing.Point(294, 155);
            this.txtbAddingSteps.Name = "txtbAddingSteps";
            this.txtbAddingSteps.Size = new System.Drawing.Size(173, 22);
            this.txtbAddingSteps.TabIndex = 1;
            // 
            // btnSubmitSteps
            // 
            this.btnSubmitSteps.Location = new System.Drawing.Point(311, 276);
            this.btnSubmitSteps.Name = "btnSubmitSteps";
            this.btnSubmitSteps.Size = new System.Drawing.Size(127, 43);
            this.btnSubmitSteps.TabIndex = 2;
            this.btnSubmitSteps.Text = "Submit";
            this.btnSubmitSteps.UseVisualStyleBackColor = true;
            this.btnSubmitSteps.Click += new System.EventHandler(this.btnSubmitSteps_Click);
            // 
            // AddingStepsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitSteps);
            this.Controls.Add(this.txtbAddingSteps);
            this.Controls.Add(this.LblAddingsteps);
            this.Name = "AddingStepsForm";
            this.Text = "AddingStepsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddingsteps;
        private System.Windows.Forms.TextBox txtbAddingSteps;
        private System.Windows.Forms.Button btnSubmitSteps;
    }
}