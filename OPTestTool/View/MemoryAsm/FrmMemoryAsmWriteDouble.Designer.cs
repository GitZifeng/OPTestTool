﻿
namespace ScriptTestTools.View.MemoryAsm
{
    partial class FrmMemoryAsmWriteDouble
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
            btnSure = new Button();
            btnCancel = new Button();
            txtWriteContent = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSure
            // 
            btnSure.Location = new Point(64, 90);
            btnSure.Name = "btnSure";
            btnSure.Size = new Size(75, 23);
            btnSure.TabIndex = 2;
            btnSure.Text = "确定";
            btnSure.UseVisualStyleBackColor = true;
            btnSure.Click += btnSure_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(154, 90);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtWriteContent
            // 
            txtWriteContent.Location = new Point(89, 24);
            txtWriteContent.Name = "txtWriteContent";
            txtWriteContent.Size = new Size(161, 21);
            txtWriteContent.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 12);
            label1.TabIndex = 4;
            label1.Text = "写入的值:";
            // 
            // FrmMemoryAsmWriteDouble
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 136);
            Controls.Add(txtWriteContent);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSure);
            Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMemoryAsmWriteDouble";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMemoryAsmWriteDouble";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWriteContent;
        private System.Windows.Forms.Label label1;
    }
}