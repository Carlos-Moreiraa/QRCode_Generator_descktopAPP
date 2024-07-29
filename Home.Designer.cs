namespace QrCodeDesktopAPP
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            txtBoxEnterString = new TextBox();
            ptbQrView = new PictureBox();
            bntDownload = new Button();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbQrView).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.Highlight;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ControlText;
            btnCreate.Location = new Point(654, 137);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(134, 56);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtBoxEnterString
            // 
            txtBoxEnterString.BackColor = SystemColors.GradientActiveCaption;
            txtBoxEnterString.Location = new Point(12, 61);
            txtBoxEnterString.Name = "txtBoxEnterString";
            txtBoxEnterString.Size = new Size(776, 23);
            txtBoxEnterString.TabIndex = 1;
            // 
            // ptbQrView
            // 
            ptbQrView.Location = new Point(12, 137);
            ptbQrView.Name = "ptbQrView";
            ptbQrView.Size = new Size(402, 279);
            ptbQrView.TabIndex = 2;
            ptbQrView.TabStop = false;
            // 
            // bntDownload
            // 
            bntDownload.BackColor = Color.YellowGreen;
            bntDownload.FlatStyle = FlatStyle.Popup;
            bntDownload.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDownload.Location = new Point(654, 230);
            bntDownload.Name = "bntDownload";
            bntDownload.Size = new Size(134, 60);
            bntDownload.TabIndex = 3;
            bntDownload.Text = "Download";
            bntDownload.UseVisualStyleBackColor = false;
            bntDownload.Click += bntDownload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 4;
            label1.Text = "Insert text here to transform a QRCode";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(654, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 56);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Clear";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(bntDownload);
            Controls.Add(ptbQrView);
            Controls.Add(txtBoxEnterString);
            Controls.Add(btnCreate);
            Name = "Home";
            Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)ptbQrView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtBoxEnterString;
        private PictureBox ptbQrView;
        private Button bntDownload;
        private Label label1;
        private Button btnDelete;
    }
}
