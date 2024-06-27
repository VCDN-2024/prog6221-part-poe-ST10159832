namespace ProgRecipeTester
{
    partial class DisplayRecipeListForm
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
            this.lstbDisplayRecipe = new System.Windows.Forms.ListBox();
            this.labeldisplayingRecipes = new System.Windows.Forms.Label();
            this.txtbSearchforRecipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbDisplayRecipe
            // 
            this.lstbDisplayRecipe.FormattingEnabled = true;
            this.lstbDisplayRecipe.ItemHeight = 16;
            this.lstbDisplayRecipe.Location = new System.Drawing.Point(101, 81);
            this.lstbDisplayRecipe.Name = "lstbDisplayRecipe";
            this.lstbDisplayRecipe.Size = new System.Drawing.Size(264, 212);
            this.lstbDisplayRecipe.TabIndex = 0;
            this.lstbDisplayRecipe.SelectedIndexChanged += new System.EventHandler(this.lstbDisplayRecipe_SelectedIndexChanged);
            // 
            // labeldisplayingRecipes
            // 
            this.labeldisplayingRecipes.AutoSize = true;
            this.labeldisplayingRecipes.Location = new System.Drawing.Point(101, 44);
            this.labeldisplayingRecipes.Name = "labeldisplayingRecipes";
            this.labeldisplayingRecipes.Size = new System.Drawing.Size(220, 16);
            this.labeldisplayingRecipes.TabIndex = 1;
            this.labeldisplayingRecipes.Text = "List of all the recipes in alphabetical ";
            // 
            // txtbSearchforRecipe
            // 
            this.txtbSearchforRecipe.Location = new System.Drawing.Point(101, 372);
            this.txtbSearchforRecipe.Name = "txtbSearchforRecipe";
            this.txtbSearchforRecipe.Size = new System.Drawing.Size(162, 22);
            this.txtbSearchforRecipe.TabIndex = 2;
            this.txtbSearchforRecipe.TextChanged += new System.EventHandler(this.txtbSearchforRecipe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the recipe you would like to view:";
            // 
            // btnDisplayRecipe
            // 
            this.btnDisplayRecipe.Location = new System.Drawing.Point(594, 323);
            this.btnDisplayRecipe.Name = "btnDisplayRecipe";
            this.btnDisplayRecipe.Size = new System.Drawing.Size(119, 71);
            this.btnDisplayRecipe.TabIndex = 4;
            this.btnDisplayRecipe.Text = "Display Recipe";
            this.btnDisplayRecipe.UseVisualStyleBackColor = true;
            this.btnDisplayRecipe.Click += new System.EventHandler(this.btnDisplayRecipe_Click);
            // 
            // DisplayRecipeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 500);
            this.Controls.Add(this.btnDisplayRecipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbSearchforRecipe);
            this.Controls.Add(this.labeldisplayingRecipes);
            this.Controls.Add(this.lstbDisplayRecipe);
            this.Name = "DisplayRecipeListForm";
            this.Text = "DisplayRecipeListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbDisplayRecipe;
        private System.Windows.Forms.Label labeldisplayingRecipes;
        private System.Windows.Forms.TextBox txtbSearchforRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayRecipe;
    }
}