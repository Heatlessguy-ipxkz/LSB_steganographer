using System;

namespace LSB_steganography_v1
{
    partial class message_selector
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
            this.Select_text = new System.Windows.Forms.Button();
            this.Select_img = new System.Windows.Forms.Button();
            this.Input_text_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select_text
            // 
            this.Select_text.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Select_text.Location = new System.Drawing.Point(94, 39);
            this.Select_text.Name = "Select_text";
            this.Select_text.Size = new System.Drawing.Size(85, 23);
            this.Select_text.TabIndex = 0;
            this.Select_text.Text = "Text";
            this.Select_text.UseVisualStyleBackColor = true;
            this.Select_text.Click += new System.EventHandler(this.Select_text_Click);
            // 
            // Select_img
            // 
            this.Select_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_img.Enabled = false;
            this.Select_img.Location = new System.Drawing.Point(185, 39);
            this.Select_img.Name = "Select_img";
            this.Select_img.Size = new System.Drawing.Size(107, 23);
            this.Select_img.TabIndex = 1;
            this.Select_img.Text = "Image TBD";
            this.Select_img.UseVisualStyleBackColor = true;
            this.Select_img.Click += new System.EventHandler(this.Select_img_Click);
            // 
            // Input_text_box
            // 
            this.Input_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_text_box.Location = new System.Drawing.Point(13, 13);
            this.Input_text_box.Name = "Input_text_box";
            this.Input_text_box.Size = new System.Drawing.Size(279, 20);
            this.Input_text_box.TabIndex = 2;
            this.Input_text_box.Text = "Input text here";
            this.Input_text_box.TextChanged += new System.EventHandler(this.Input_text_box_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 77);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input_text_box);
            this.Controls.Add(this.Select_img);
            this.Controls.Add(this.Select_text);
            this.Name = "message_selector";
            this.Text = "Select Msg";
            this.Load += new System.EventHandler(this.message_selector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button Select_text;
        private System.Windows.Forms.Button Select_img;
        private System.Windows.Forms.TextBox Input_text_box;
        private System.Windows.Forms.Button button1;
    }
}