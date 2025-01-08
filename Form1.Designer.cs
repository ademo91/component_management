namespace ComponentsManagement
{
    partial class Form1
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
            loginPanel = new Panel();
            button1 = new Button();
            password = new TextBox();
            email = new TextBox();
            label1 = new Label();
            dashboardPanel = new Panel();
            exportbtn = new Button();
            clearSearchButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            deleteButton = new Button();
            saveChangesButton = new Button();
            editComponentButton = new Button();
            dataGridView = new DataGridView();
            displayall = new Button();
            AddComponent = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            taker = new TextBox();
            ComponentsQuantity = new TextBox();
            componentName = new TextBox();
            loginPanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(button1);
            loginPanel.Controls.Add(password);
            loginPanel.Controls.Add(email);
            loginPanel.Controls.Add(label1);
            loginPanel.Location = new Point(208, 49);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(383, 368);
            loginPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(51, 230);
            button1.Name = "button1";
            button1.Size = new Size(283, 37);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(51, 168);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(283, 23);
            password.TabIndex = 2;
            // 
            // email
            // 
            email.Location = new Point(51, 101);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(283, 23);
            email.TabIndex = 1;
            email.TextChanged += email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 43);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(exportbtn);
            dashboardPanel.Controls.Add(clearSearchButton);
            dashboardPanel.Controls.Add(searchButton);
            dashboardPanel.Controls.Add(searchTextBox);
            dashboardPanel.Controls.Add(deleteButton);
            dashboardPanel.Controls.Add(saveChangesButton);
            dashboardPanel.Controls.Add(editComponentButton);
            dashboardPanel.Controls.Add(dataGridView);
            dashboardPanel.Controls.Add(displayall);
            dashboardPanel.Controls.Add(AddComponent);
            dashboardPanel.Controls.Add(label5);
            dashboardPanel.Controls.Add(label4);
            dashboardPanel.Controls.Add(label3);
            dashboardPanel.Controls.Add(taker);
            dashboardPanel.Controls.Add(ComponentsQuantity);
            dashboardPanel.Controls.Add(componentName);
            dashboardPanel.Location = new Point(3, 5);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(792, 440);
            dashboardPanel.TabIndex = 1;
            dashboardPanel.Visible = false;
            // 
            // exportbtn
            // 
            exportbtn.Location = new Point(555, 371);
            exportbtn.Name = "exportbtn";
            exportbtn.Size = new Size(105, 37);
            exportbtn.TabIndex = 16;
            exportbtn.Text = "Export data";
            exportbtn.UseVisualStyleBackColor = true;
            exportbtn.Click += button2_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.BackColor = Color.Red;
            clearSearchButton.ForeColor = SystemColors.ControlLight;
            clearSearchButton.Location = new Point(376, 102);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(29, 26);
            clearSearchButton.TabIndex = 15;
            clearSearchButton.Text = "X";
            clearSearchButton.UseVisualStyleBackColor = false;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(411, 102);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(98, 26);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(113, 105);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Enter component name";
            searchTextBox.Size = new Size(256, 23);
            searchTextBox.TabIndex = 13;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(555, 321);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(105, 25);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.LimeGreen;
            saveChangesButton.ForeColor = SystemColors.ControlLightLight;
            saveChangesButton.Location = new Point(555, 274);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(105, 26);
            saveChangesButton.TabIndex = 11;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // editComponentButton
            // 
            editComponentButton.BackColor = SystemColors.ActiveCaption;
            editComponentButton.Location = new Point(555, 230);
            editComponentButton.Name = "editComponentButton";
            editComponentButton.Size = new Size(105, 23);
            editComponentButton.TabIndex = 10;
            editComponentButton.Text = "Edit Component";
            editComponentButton.UseVisualStyleBackColor = false;
            editComponentButton.Click += editComponentButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.ButtonFace;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ControlLightLight;
            dataGridView.Location = new Point(113, 153);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(396, 256);
            dataGridView.TabIndex = 9;
            // 
            // displayall
            // 
            displayall.Location = new Point(555, 171);
            displayall.Name = "displayall";
            displayall.Size = new Size(105, 41);
            displayall.TabIndex = 8;
            displayall.Text = "Display all";
            displayall.UseVisualStyleBackColor = true;
            displayall.Click += displayall_Click;
            // 
            // AddComponent
            // 
            AddComponent.BackColor = Color.DarkGray;
            AddComponent.Location = new Point(641, 39);
            AddComponent.Name = "AddComponent";
            AddComponent.Size = new Size(129, 26);
            AddComponent.TabIndex = 7;
            AddComponent.Text = "Add component";
            AddComponent.UseVisualStyleBackColor = false;
            AddComponent.Click += AddComponent_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 44);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 6;
            label5.Text = "who took it?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 43);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantity";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Component name";
            // 
            // taker
            // 
            taker.Location = new Point(474, 41);
            taker.Name = "taker";
            taker.Size = new Size(155, 23);
            taker.TabIndex = 3;
            // 
            // ComponentsQuantity
            // 
            ComponentsQuantity.Location = new Point(327, 41);
            ComponentsQuantity.Name = "ComponentsQuantity";
            ComponentsQuantity.Size = new Size(63, 23);
            ComponentsQuantity.TabIndex = 2;
            // 
            // componentName
            // 
            componentName.Location = new Point(113, 41);
            componentName.Name = "componentName";
            componentName.Size = new Size(148, 23);
            componentName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dashboardPanel);
            Controls.Add(loginPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button button1;
        private TextBox password;
        private TextBox email;
        private Label label1;
        private Panel dashboardPanel;
        private TextBox ComponentsQuantity;
        private TextBox componentName;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox taker;
        private Button AddComponent;
        private Button displayall;
        private DataGridView dataGridView;
        private Button editComponentButton;
        private Button saveChangesButton;
        private Button deleteButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private Button clearSearchButton;
        private Button exportbtn;
    }
}
