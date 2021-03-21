
namespace Trees
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
            this.btnTrees = new System.Windows.Forms.Button();
            this.lbTrees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTrees
            // 
            this.btnTrees.Location = new System.Drawing.Point(520, 146);
            this.btnTrees.Name = "btnTrees";
            this.btnTrees.Size = new System.Drawing.Size(132, 54);
            this.btnTrees.TabIndex = 0;
            this.btnTrees.Text = "Abstract Trees";
            this.btnTrees.UseVisualStyleBackColor = true;
            this.btnTrees.Click += new System.EventHandler(this.btnTrees_Click);
            // 
            // lbTrees
            // 
            this.lbTrees.FormattingEnabled = true;
            this.lbTrees.ItemHeight = 16;
            this.lbTrees.Location = new System.Drawing.Point(26, 22);
            this.lbTrees.Name = "lbTrees";
            this.lbTrees.Size = new System.Drawing.Size(182, 324);
            this.lbTrees.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTrees);
            this.Controls.Add(this.btnTrees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrees;
        private System.Windows.Forms.ListBox lbTrees;
    }
}

