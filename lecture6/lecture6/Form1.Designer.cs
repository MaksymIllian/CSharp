
namespace lecture6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 383);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(115, 383);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(520, 383);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(394, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(394, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Text = "LastName";
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Location = new System.Drawing.Point(394, 79);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Size = new System.Drawing.Size(201, 20);
            this.homePhoneTextBox.TabIndex = 5;
            this.homePhoneTextBox.Text = "HomePhone";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(394, 105);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(201, 20);
            this.mobileTextBox.TabIndex = 6;
            this.mobileTextBox.Text = "Mobile";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(323, 303);
            this.listBox.TabIndex = 8;
            this.listBox.Click += new System.EventHandler(this.listbox_Click);
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(394, 131);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(201, 20);
            this.groupTextBox.TabIndex = 9;
            this.groupTextBox.Text = "Group";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameLastNameToolStripMenuItem,
            this.byGroupToolStripMenuItem,
            this.byIdToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // byNameLastNameToolStripMenuItem
            // 
            this.byNameLastNameToolStripMenuItem.Name = "byNameLastNameToolStripMenuItem";
            this.byNameLastNameToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.byNameLastNameToolStripMenuItem.Text = "By name and lastName";
            this.byNameLastNameToolStripMenuItem.Click += new System.EventHandler(this.byNameLastNameToolStripMenuItem_Click);
            // 
            // byGroupToolStripMenuItem
            // 
            this.byGroupToolStripMenuItem.Name = "byGroupToolStripMenuItem";
            this.byGroupToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.byGroupToolStripMenuItem.Text = "By group";
            this.byGroupToolStripMenuItem.Click += new System.EventHandler(this.byGroupToolStripMenuItem_Click);
            // 
            // byIdToolStripMenuItem
            // 
            this.byIdToolStripMenuItem.Name = "byIdToolStripMenuItem";
            this.byIdToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.byIdToolStripMenuItem.Text = "By id";
            this.byIdToolStripMenuItem.Click += new System.EventHandler(this.byIdToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = global::lecture6.Properties.Resources.Безымянный1;
            this.pictureBox.InitialImage = global::lecture6.Properties.Resources.Безымянный1;
            this.pictureBox.Location = new System.Drawing.Point(394, 167);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(201, 163);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 432);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.homePhoneTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ContactManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameLastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGroupToolStripMenuItem;
    }
}

