﻿namespace ReflectionApplication
{
    partial class EntryForm
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
            this.lblTypes = new System.Windows.Forms.Label();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.btnSetProperty = new System.Windows.Forms.Button();
            this.btnGetProperty = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(13, 13);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(93, 13);
            this.lblTypes.TabIndex = 0;
            this.lblTypes.Text = "Types in assembly";
            // 
            // cboTypes
            // 
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(16, 42);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(327, 21);
            this.cboTypes.TabIndex = 1;
            this.cboTypes.SelectedIndexChanged += new System.EventHandler(this.cboTypes_SelectedIndexChanged);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(16, 70);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(327, 134);
            this.lstInfo.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.Location = new System.Drawing.Point(16, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(157, 23);
            this.lblResult.TabIndex = 3;
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(16, 241);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(75, 23);
            this.btnCallMethod.TabIndex = 4;
            this.btnCallMethod.Text = "Call Method";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // btnSetProperty
            // 
            this.btnSetProperty.Location = new System.Drawing.Point(98, 241);
            this.btnSetProperty.Name = "btnSetProperty";
            this.btnSetProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSetProperty.TabIndex = 5;
            this.btnSetProperty.Text = "Set Property";
            this.btnSetProperty.UseVisualStyleBackColor = true;
            this.btnSetProperty.Click += new System.EventHandler(this.btnSetProperty_Click);
            // 
            // btnGetProperty
            // 
            this.btnGetProperty.Location = new System.Drawing.Point(180, 241);
            this.btnGetProperty.Name = "btnGetProperty";
            this.btnGetProperty.Size = new System.Drawing.Size(163, 23);
            this.btnGetProperty.TabIndex = 6;
            this.btnGetProperty.Text = "Get Property";
            this.btnGetProperty.UseVisualStyleBackColor = true;
            this.btnGetProperty.Click += new System.EventHandler(this.btnGetProperty_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(180, 214);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(163, 20);
            this.txtValue.TabIndex = 7;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 276);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnGetProperty);
            this.Controls.Add(this.btnSetProperty);
            this.Controls.Add(this.btnCallMethod);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.cboTypes);
            this.Controls.Add(this.lblTypes);
            this.Name = "EntryForm";
            this.Text = "Reflection Application";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.Button btnSetProperty;
        private System.Windows.Forms.Button btnGetProperty;
        private System.Windows.Forms.TextBox txtValue;
    }
}

