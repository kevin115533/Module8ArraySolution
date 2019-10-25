namespace Module8ArrayProject
{
    partial class frmOfIceBridge
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblArrayDisplay = new System.Windows.Forms.Label();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Array";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(100, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 26);
            this.txtNumber.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Number";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(29, 37);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(65, 20);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Number";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(33, 150);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(167, 51);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Array";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblArrayDisplay
            // 
            this.lblArrayDisplay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblArrayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrayDisplay.Location = new System.Drawing.Point(233, 9);
            this.lblArrayDisplay.Name = "lblArrayDisplay";
            this.lblArrayDisplay.Size = new System.Drawing.Size(125, 432);
            this.lblArrayDisplay.TabIndex = 6;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.BackColor = System.Drawing.Color.LightBlue;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(379, 9);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(398, 432);
            this.lblMessageBox.TabIndex = 7;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(33, 221);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(167, 51);
            this.btnStats.TabIndex = 8;
            this.btnStats.Text = "Array Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // frmOfIceBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.lblArrayDisplay);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.KeyPreview = true;
            this.Name = "frmOfIceBridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show me the Numbers";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOfIceBridge_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblArrayDisplay;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Button btnStats;
    }
}

