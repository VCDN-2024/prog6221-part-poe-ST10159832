﻿namespace ProgRecipeTester
{
    partial class SearchforRecipeForm
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
            this.txtbSearchRecipeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name of the recipe you would like to search for";
            // 
            // txtbSearchRecipeName
            // 
            this.txtbSearchRecipeName.Location = new System.Drawing.Point(280, 216);
            this.txtbSearchRecipeName.Name = "txtbSearchRecipeName";
            this.txtbSearchRecipeName.Size = new System.Drawing.Size(187, 22);
            this.txtbSearchRecipeName.TabIndex = 1;
            this.txtbSearchRecipeName.TextChanged += new System.EventHandler(this.txtbSearchRecipeName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchforRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbSearchRecipeName);
            this.Controls.Add(this.label1);
            this.Name = "SearchforRecipeForm";
            this.Text = "SearchforRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbSearchRecipeName;
        private System.Windows.Forms.Button button1;
    }
}