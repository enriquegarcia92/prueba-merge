﻿namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.itemreciever = new System.Windows.Forms.Label();
            this.precioreciever = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "añadir al carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemreciever
            // 
            this.itemreciever.Location = new System.Drawing.Point(119, 54);
            this.itemreciever.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemreciever.Name = "itemreciever";
            this.itemreciever.Size = new System.Drawing.Size(411, 44);
            this.itemreciever.TabIndex = 1;
            this.itemreciever.Text = "label1";
            // 
            // precioreciever
            // 
            this.precioreciever.Location = new System.Drawing.Point(119, 98);
            this.precioreciever.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.precioreciever.Name = "precioreciever";
            this.precioreciever.Size = new System.Drawing.Size(411, 44);
            this.precioreciever.TabIndex = 2;
            this.precioreciever.Text = "label2";
            this.precioreciever.Click += new System.EventHandler(this.precioreciever_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 174);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precioreciever);
            this.Controls.Add(this.itemreciever);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label itemreciever;
        private System.Windows.Forms.Label precioreciever;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}