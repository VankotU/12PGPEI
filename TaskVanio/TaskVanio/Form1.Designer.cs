namespace TaskVanio
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTxtComment = new System.Windows.Forms.RichTextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnShowDialog);
            this.gbUser.Controls.Add(this.btnShow);
            this.gbUser.Controls.Add(this.btnSave);
            this.gbUser.Controls.Add(this.lblComment);
            this.gbUser.Controls.Add(this.richTxtComment);
            this.gbUser.Controls.Add(this.btnChooseImage);
            this.gbUser.Controls.Add(this.pbAvatar);
            this.gbUser.Controls.Add(this.txtName);
            this.gbUser.Controls.Add(this.lblName);
            this.gbUser.Controls.Add(this.btnHello);
            this.gbUser.Location = new System.Drawing.Point(21, 14);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(405, 417);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Потребител";
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(324, 388);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Здравей!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Име:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(20, 74);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(130, 172);
            this.pbAvatar.TabIndex = 3;
            this.pbAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(243, 370);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(75, 41);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "Избери снимка";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            this.openPictureDialog.Filter = "Image Files(*.JPG;*.GIF)|*.JPG;*.GIF| All files (*.*)|*.*";
            // 
            // richTxtComment
            // 
            this.richTxtComment.Location = new System.Drawing.Point(217, 81);
            this.richTxtComment.Name = "richTxtComment";
            this.richTxtComment.Size = new System.Drawing.Size(128, 164);
            this.richTxtComment.TabIndex = 5;
            this.richTxtComment.Text = "";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(214, 65);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(57, 13);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Коментар";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(162, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(81, 388);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Покажи";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(6, 370);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 41);
            this.btnShowDialog.TabIndex = 9;
            this.btnShowDialog.Text = "Show Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 441);
            this.Controls.Add(this.gbUser);
            this.Name = "Form1";
            this.Text = "Task";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.RichTextBox richTxtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowDialog;
    }
}

