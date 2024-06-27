namespace ProgRecipeTester
{
    partial class AddRecipeForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbIngredientName = new System.Windows.Forms.TextBox();
            this.txtbIngredientQuantity = new System.Windows.Forms.TextBox();
            this.txtbUnit = new System.Windows.Forms.TextBox();
            this.txtbCalories = new System.Windows.Forms.TextBox();
            this.cbFoodGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 41);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please enter the name of the ingredient";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please enter the quantity the ingredient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please enter the unit of measurement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Please enter the calories in the ingredient";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Please choose one of the food groups for the ingredient";
            // 
            // txtbIngredientName
            // 
            this.txtbIngredientName.Location = new System.Drawing.Point(513, 136);
            this.txtbIngredientName.Name = "txtbIngredientName";
            this.txtbIngredientName.Size = new System.Drawing.Size(154, 22);
            this.txtbIngredientName.TabIndex = 10;
            // 
            // txtbIngredientQuantity
            // 
            this.txtbIngredientQuantity.Location = new System.Drawing.Point(513, 177);
            this.txtbIngredientQuantity.Name = "txtbIngredientQuantity";
            this.txtbIngredientQuantity.Size = new System.Drawing.Size(154, 22);
            this.txtbIngredientQuantity.TabIndex = 11;
            // 
            // txtbUnit
            // 
            this.txtbUnit.Location = new System.Drawing.Point(513, 218);
            this.txtbUnit.Name = "txtbUnit";
            this.txtbUnit.Size = new System.Drawing.Size(154, 22);
            this.txtbUnit.TabIndex = 12;
            // 
            // txtbCalories
            // 
            this.txtbCalories.Location = new System.Drawing.Point(513, 260);
            this.txtbCalories.Name = "txtbCalories";
            this.txtbCalories.Size = new System.Drawing.Size(154, 22);
            this.txtbCalories.TabIndex = 13;
            // 
            // cbFoodGroup
            // 
            this.cbFoodGroup.FormattingEnabled = true;
            this.cbFoodGroup.Items.AddRange(new object[] {
            "Sugars ",
            "Protein",
            "Fats",
            "Carbs"});
            this.cbFoodGroup.Location = new System.Drawing.Point(513, 297);
            this.cbFoodGroup.Name = "cbFoodGroup";
            this.cbFoodGroup.Size = new System.Drawing.Size(154, 24);
            this.cbFoodGroup.TabIndex = 14;
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFoodGroup);
            this.Controls.Add(this.txtbCalories);
            this.Controls.Add(this.txtbUnit);
            this.Controls.Add(this.txtbIngredientQuantity);
            this.Controls.Add(this.txtbIngredientName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AddRecipeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbIngredientName;
        private System.Windows.Forms.TextBox txtbIngredientQuantity;
        private System.Windows.Forms.TextBox txtbUnit;
        private System.Windows.Forms.TextBox txtbCalories;
        private System.Windows.Forms.ComboBox cbFoodGroup;
    }
}