namespace AirConditionerShop_NguyenHoaiNam
{
    partial class AirConditionerManagementForm
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
            label1 = new Label();
            label2 = new Label();
            lblFeature = new Label();
            txtName = new TextBox();
            txtFeature = new TextBox();
            dgvAirConditionerList = new DataGridView();
            btnSearch = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAirConditionerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(574, 54);
            label1.TabIndex = 0;
            label1.Text = "Air Conditioner Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 116);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeature.Location = new Point(450, 116);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(90, 31);
            lblFeature.TabIndex = 2;
            lblFeature.Text = "Feature";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(144, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 38);
            txtName.TabIndex = 0;
            // 
            // txtFeature
            // 
            txtFeature.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFeature.Location = new Point(552, 113);
            txtFeature.Name = "txtFeature";
            txtFeature.Size = new Size(243, 38);
            txtFeature.TabIndex = 1;
            // 
            // dgvAirConditionerList
            // 
            dgvAirConditionerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAirConditionerList.Location = new Point(30, 189);
            dgvAirConditionerList.Name = "dgvAirConditionerList";
            dgvAirConditionerList.RowHeadersWidth = 51;
            dgvAirConditionerList.Size = new Size(930, 497);
            dgvAirConditionerList.TabIndex = 3;
            dgvAirConditionerList.SelectionChanged += dgvAirConditionerList_SelectionChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(835, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1011, 215);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 40);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1011, 344);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1011, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1011, 615);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AirConditionerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 712);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(dgvAirConditionerList);
            Controls.Add(txtFeature);
            Controls.Add(txtName);
            Controls.Add(lblFeature);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AirConditionerManagementForm";
            Text = "Air Conditioner Management";
            FormClosing += AirConditionerManagementForm_FormClosing;
            Load += AirConditionerManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAirConditionerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFeature;
        private TextBox txtName;
        private TextBox txtFeature;
        private DataGridView dgvAirConditionerList;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
    }
}