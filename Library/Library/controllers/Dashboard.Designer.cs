
namespace Library.controllers
{
    partial class Dashboard
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnal = new System.Windows.Forms.DateTimePicker();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonViewBorrowed = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonViewBooks = new System.Windows.Forms.Button();
            this.labelBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(105, 402);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(190, 40);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change terminal";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(12, 402);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(87, 36);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(747, 310);
            this.dataGridViewBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Returnal date";
            // 
            // dateTimePickerReturnal
            // 
            this.dateTimePickerReturnal.Location = new System.Drawing.Point(816, 125);
            this.dateTimePickerReturnal.Name = "dateTimePickerReturnal";
            this.dateTimePickerReturnal.Size = new System.Drawing.Size(288, 22);
            this.dateTimePickerReturnal.TabIndex = 4;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.Location = new System.Drawing.Point(816, 168);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(106, 42);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonViewBorrowed
            // 
            this.buttonViewBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBorrowed.Location = new System.Drawing.Point(816, 229);
            this.buttonViewBorrowed.Name = "buttonViewBorrowed";
            this.buttonViewBorrowed.Size = new System.Drawing.Size(288, 48);
            this.buttonViewBorrowed.TabIndex = 6;
            this.buttonViewBorrowed.Text = "View borrowed books";
            this.buttonViewBorrowed.UseVisualStyleBackColor = true;
            this.buttonViewBorrowed.Click += new System.EventHandler(this.buttonViewBorrowed_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(12, 13);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(61, 25);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Hello";
            // 
            // buttonViewBooks
            // 
            this.buttonViewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBooks.Location = new System.Drawing.Point(816, 300);
            this.buttonViewBooks.Name = "buttonViewBooks";
            this.buttonViewBooks.Size = new System.Drawing.Size(237, 48);
            this.buttonViewBooks.TabIndex = 8;
            this.buttonViewBooks.Text = "View all books";
            this.buttonViewBooks.UseVisualStyleBackColor = true;
            this.buttonViewBooks.Click += new System.EventHandler(this.buttonViewBooks_Click);
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooks.Location = new System.Drawing.Point(12, 49);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(165, 25);
            this.labelBooks.TabIndex = 9;
            this.labelBooks.Text = "Available books";
            this.labelBooks.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 454);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.buttonViewBooks);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonViewBorrowed);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.dateTimePickerReturnal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonChange);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnal;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonViewBorrowed;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonViewBooks;
        private System.Windows.Forms.Label labelBooks;
    }
}