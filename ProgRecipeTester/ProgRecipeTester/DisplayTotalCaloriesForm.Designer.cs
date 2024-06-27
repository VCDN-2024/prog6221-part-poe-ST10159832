namespace ProgRecipeTester
{
    partial class DisplayTotalCaloriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbRecipeNameInput = new System.Windows.Forms.TextBox();
            this.btnSubmitTotalCalories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name of the recipe you woould like to search for";
            // 
            // txtbRecipeNameInput
            // 
            this.txtbRecipeNameInput.Location = new System.Drawing.Point(75, 153);
            this.txtbRecipeNameInput.Name = "txtbRecipeNameInput";
            this.txtbRecipeNameInput.Size = new System.Drawing.Size(142, 22);
            this.txtbRecipeNameInput.TabIndex = 1;
            this.txtbRecipeNameInput.TextChanged += new System.EventHandler(this.txtbRecipeNameInput_TextChanged);
            // 
            // btnSubmitTotalCalories
            // 
            this.btnSubmitTotalCalories.Location = new System.Drawing.Point(339, 289);
            this.btnSubmitTotalCalories.Name = "btnSubmitTotalCalories";
            this.btnSubmitTotalCalories.Size = new System.Drawing.Size(121, 53);
            this.btnSubmitTotalCalories.TabIndex = 2;
            this.btnSubmitTotalCalories.Text = "Submit";
            this.btnSubmitTotalCalories.UseVisualStyleBackColor = true;
            this.btnSubmitTotalCalories.Click += new System.EventHandler(this.btnSubmitTotalCalories_Click);
            // 
            // DisplayTotalCaloriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitTotalCalories);
            this.Controls.Add(this.txtbRecipeNameInput);
            this.Controls.Add(this.label1);
            this.Name = "DisplayTotalCaloriesForm";
            this.Text = "DisplayTotalCaloriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbRecipeNameInput;
        private System.Windows.Forms.Button btnSubmitTotalCalories;
    }
}