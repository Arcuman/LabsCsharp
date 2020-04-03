namespace WindowsFormsApp1
{
    partial class SearchForm
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
            this.Panel3 = new System.Windows.Forms.Panel();
            this.CourseNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SemestrNumber = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LectorSNP = new System.Windows.Forms.TextBox();
            this.FullSearch = new System.Windows.Forms.CheckBox();
            this.Result = new System.Windows.Forms.TreeView();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNumber)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.CourseNumber);
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Location = new System.Drawing.Point(13, 202);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(469, 79);
            this.Panel3.TabIndex = 8;
            // 
            // CourseNumber
            // 
            this.CourseNumber.Location = new System.Drawing.Point(17, 26);
            this.CourseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(160, 22);
            this.CourseNumber.TabIndex = 1;
            this.CourseNumber.ValueChanged += new System.EventHandler(this.CourseNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Курс";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.SemestrNumber);
            this.Panel2.Location = new System.Drawing.Point(13, 111);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(469, 84);
            this.Panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Семестр";
            // 
            // SemestrNumber
            // 
            this.SemestrNumber.FormattingEnabled = true;
            this.SemestrNumber.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SemestrNumber.Location = new System.Drawing.Point(4, 32);
            this.SemestrNumber.Margin = new System.Windows.Forms.Padding(4);
            this.SemestrNumber.Name = "SemestrNumber";
            this.SemestrNumber.Size = new System.Drawing.Size(160, 24);
            this.SemestrNumber.TabIndex = 0;
            this.SemestrNumber.TextChanged += new System.EventHandler(this.SemestrNumber_TextChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.LectorSNP);
            this.Panel1.Controls.Add(this.FullSearch);
            this.Panel1.Location = new System.Drawing.Point(13, 13);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(469, 91);
            this.Panel1.TabIndex = 6;
            this.Panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ф.И.О Лектора";
            // 
            // LectorSNP
            // 
            this.LectorSNP.Location = new System.Drawing.Point(4, 34);
            this.LectorSNP.Margin = new System.Windows.Forms.Padding(4);
            this.LectorSNP.Name = "LectorSNP";
            this.LectorSNP.Size = new System.Drawing.Size(460, 22);
            this.LectorSNP.TabIndex = 1;
            this.LectorSNP.TextChanged += new System.EventHandler(this.LectorSNP_TextChanged);
            // 
            // FullSearch
            // 
            this.FullSearch.AutoSize = true;
            this.FullSearch.Location = new System.Drawing.Point(4, 66);
            this.FullSearch.Margin = new System.Windows.Forms.Padding(4);
            this.FullSearch.Name = "FullSearch";
            this.FullSearch.Size = new System.Drawing.Size(173, 21);
            this.FullSearch.TabIndex = 2;
            this.FullSearch.Text = "Полное соответствие";
            this.FullSearch.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(523, 13);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(376, 285);
            this.Result.TabIndex = 9;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 313);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNumber)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.NumericUpDown CourseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SemestrNumber;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LectorSNP;
        private System.Windows.Forms.CheckBox FullSearch;
        private System.Windows.Forms.TreeView Result;
    }
}