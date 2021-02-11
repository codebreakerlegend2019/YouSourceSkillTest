
namespace YouSourceSkillTest.Views
{
    partial class SortForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sortingStrategy = new System.Windows.Forms.ComboBox();
            this.tb_textToSort = new System.Windows.Forms.TextBox();
            this.btn_doSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sorted_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text To Sort:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sorting Strategy:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_sortingStrategy
            // 
            this.cb_sortingStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sortingStrategy.FormattingEnabled = true;
            this.cb_sortingStrategy.Location = new System.Drawing.Point(109, 44);
            this.cb_sortingStrategy.Name = "cb_sortingStrategy";
            this.cb_sortingStrategy.Size = new System.Drawing.Size(121, 21);
            this.cb_sortingStrategy.TabIndex = 3;
            // 
            // tb_textToSort
            // 
            this.tb_textToSort.Location = new System.Drawing.Point(109, 9);
            this.tb_textToSort.Name = "tb_textToSort";
            this.tb_textToSort.Size = new System.Drawing.Size(121, 20);
            this.tb_textToSort.TabIndex = 4;
            // 
            // btn_doSort
            // 
            this.btn_doSort.Location = new System.Drawing.Point(130, 71);
            this.btn_doSort.Name = "btn_doSort";
            this.btn_doSort.Size = new System.Drawing.Size(75, 23);
            this.btn_doSort.TabIndex = 5;
            this.btn_doSort.Text = "Sort";
            this.btn_doSort.UseVisualStyleBackColor = true;
            this.btn_doSort.Click += new System.EventHandler(this.btn_doSort_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sorted Text:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sorted_text
            // 
            this.lbl_sorted_text.Location = new System.Drawing.Point(106, 104);
            this.lbl_sorted_text.Name = "lbl_sorted_text";
            this.lbl_sorted_text.Size = new System.Drawing.Size(100, 23);
            this.lbl_sorted_text.TabIndex = 7;
            this.lbl_sorted_text.Text = "\"\"";
            this.lbl_sorted_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 169);
            this.Controls.Add(this.lbl_sorted_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_doSort);
            this.Controls.Add(this.tb_textToSort);
            this.Controls.Add(this.cb_sortingStrategy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort Text Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_sortingStrategy;
        private System.Windows.Forms.TextBox tb_textToSort;
        private System.Windows.Forms.Button btn_doSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sorted_text;
    }
}

