namespace FavouriteLanguanges
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
            this.label1 = new System.Windows.Forms.Label();
            this.listLang = new System.Windows.Forms.ListBox();
            this.TxtLang = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTimeDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Favourite Programming Languages";
            // 
            // listLang
            // 
            this.listLang.FormattingEnabled = true;
            this.listLang.ItemHeight = 16;
            this.listLang.Location = new System.Drawing.Point(61, 95);
            this.listLang.Name = "listLang";
            this.listLang.Size = new System.Drawing.Size(896, 260);
            this.listLang.TabIndex = 1;
            // 
            // TxtLang
            // 
            this.TxtLang.Location = new System.Drawing.Point(61, 380);
            this.TxtLang.Name = "TxtLang";
            this.TxtLang.Size = new System.Drawing.Size(896, 22);
            this.TxtLang.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Location = new System.Drawing.Point(61, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD LANGUAGE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(253, 429);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dateTimeDisplay
            // 
            this.dateTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDisplay.Location = new System.Drawing.Point(75, 502);
            this.dateTimeDisplay.Name = "dateTimeDisplay";
            this.dateTimeDisplay.Size = new System.Drawing.Size(403, 37);
            this.dateTimeDisplay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 548);
            this.Controls.Add(this.dateTimeDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtLang);
            this.Controls.Add(this.listLang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Favourite Programming Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listLang;
        private System.Windows.Forms.TextBox TxtLang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label dateTimeDisplay;
    }
}

