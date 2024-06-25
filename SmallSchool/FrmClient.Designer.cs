namespace SmallSchool
{
    partial class frmClient
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
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnQuitClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(356, 100);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(232, 26);
            this.txtClient.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(352, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Entrez un nouveau client";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(356, 141);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(115, 32);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "&Ajouter";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 20;
            this.lstClient.Location = new System.Drawing.Point(12, 20);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(302, 464);
            this.lstClient.TabIndex = 6;
            this.lstClient.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(356, 207);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(115, 32);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "&Supprimer";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnQuitClient
            // 
            this.btnQuitClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitClient.Location = new System.Drawing.Point(356, 352);
            this.btnQuitClient.Name = "btnQuitClient";
            this.btnQuitClient.Size = new System.Drawing.Size(115, 32);
            this.btnQuitClient.TabIndex = 8;
            this.btnQuitClient.Text = "&Quitter";
            this.btnQuitClient.UseVisualStyleBackColor = true;
            this.btnQuitClient.Click += new System.EventHandler(this.btnQuitClient_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(356, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Tout \r\nSupprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(600, 516);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.lstClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClient";
            this.Text = "Client Management";
            this.Load += new System.EventHandler(this.frmCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnQuitClient;
        private System.Windows.Forms.Button button1;
    }
}