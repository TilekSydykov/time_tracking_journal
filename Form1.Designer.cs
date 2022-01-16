
namespace Journal
{
    partial class Journal
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
            this.components = new System.ComponentModel.Container();
            this.TableEmpleyee = new System.Windows.Forms.DataGridView();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTeleNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddAge = new System.Windows.Forms.NumericUpDown();
            this.AddPosition = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.CameBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TableHistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeleNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableEmpleyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // TableEmpleyee
            // 
            this.TableEmpleyee.AllowUserToAddRows = false;
            this.TableEmpleyee.AllowUserToDeleteRows = false;
            this.TableEmpleyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableEmpleyee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColSurname,
            this.ColAge,
            this.ColPosition,
            this.ColTeleNick});
            this.TableEmpleyee.Location = new System.Drawing.Point(12, 51);
            this.TableEmpleyee.MultiSelect = false;
            this.TableEmpleyee.Name = "TableEmpleyee";
            this.TableEmpleyee.ReadOnly = true;
            this.TableEmpleyee.RowHeadersWidth = 51;
            this.TableEmpleyee.RowTemplate.Height = 24;
            this.TableEmpleyee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableEmpleyee.Size = new System.Drawing.Size(650, 361);
            this.TableEmpleyee.TabIndex = 3;
            this.TableEmpleyee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableEmpleyee_CellClick);
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(152, 436);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(262, 22);
            this.AddName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // AddSurname
            // 
            this.AddSurname.Location = new System.Drawing.Point(152, 464);
            this.AddSurname.Name = "AddSurname";
            this.AddSurname.Size = new System.Drawing.Size(262, 22);
            this.AddSurname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telegram Nickname";
            // 
            // AddTeleNick
            // 
            this.AddTeleNick.Location = new System.Drawing.Point(152, 492);
            this.AddTeleNick.Name = "AddTeleNick";
            this.AddTeleNick.Size = new System.Drawing.Size(262, 22);
            this.AddTeleNick.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age";
            // 
            // AddAge
            // 
            this.AddAge.Location = new System.Drawing.Point(528, 433);
            this.AddAge.Name = "AddAge";
            this.AddAge.Size = new System.Drawing.Size(120, 22);
            this.AddAge.TabIndex = 12;
            // 
            // AddPosition
            // 
            this.AddPosition.FormattingEnabled = true;
            this.AddPosition.Items.AddRange(new object[] {
            "dir",
            "smm",
            "hr",
            "dev"});
            this.AddPosition.Location = new System.Drawing.Point(527, 459);
            this.AddPosition.Name = "AddPosition";
            this.AddPosition.Size = new System.Drawing.Size(121, 24);
            this.AddPosition.TabIndex = 13;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(224, 551);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(211, 50);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add new";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.BackColor = System.Drawing.Color.Red;
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Location = new System.Drawing.Point(894, 562);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(150, 50);
            this.LeftBtn.TabIndex = 15;
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = false;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // CameBtn
            // 
            this.CameBtn.BackColor = System.Drawing.Color.Green;
            this.CameBtn.Enabled = false;
            this.CameBtn.Location = new System.Drawing.Point(702, 562);
            this.CameBtn.Name = "CameBtn";
            this.CameBtn.Size = new System.Drawing.Size(150, 50);
            this.CameBtn.TabIndex = 16;
            this.CameBtn.Text = "Came";
            this.CameBtn.UseVisualStyleBackColor = false;
            this.CameBtn.Click += new System.EventHandler(this.CameBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.NameLbl.Location = new System.Drawing.Point(778, 12);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(219, 36);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Name Surname";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DateTimePicker.Location = new System.Drawing.Point(679, 62);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(388, 22);
            this.DateTimePicker.TabIndex = 18;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // TableHistory
            // 
            this.TableHistory.AllowUserToAddRows = false;
            this.TableHistory.AllowUserToDeleteRows = false;
            this.TableHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Status});
            this.TableHistory.Location = new System.Drawing.Point(679, 99);
            this.TableHistory.MultiSelect = false;
            this.TableHistory.Name = "TableHistory";
            this.TableHistory.ReadOnly = true;
            this.TableHistory.RowHeadersWidth = 51;
            this.TableHistory.RowTemplate.Height = 24;
            this.TableHistory.Size = new System.Drawing.Size(388, 393);
            this.TableHistory.TabIndex = 19;
            this.TableHistory.SelectionChanged += new System.EventHandler(this.TableHistory_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Employees";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.FillWeight = 2F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.FillWeight = 1F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalLbl.Location = new System.Drawing.Point(707, 510);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(69, 29);
            this.TotalLbl.TabIndex = 21;
            this.TotalLbl.Text = "Total";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 100;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 150;
            // 
            // ColSurname
            // 
            this.ColSurname.HeaderText = "Surname";
            this.ColSurname.MinimumWidth = 100;
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.ReadOnly = true;
            this.ColSurname.Width = 150;
            // 
            // ColAge
            // 
            this.ColAge.HeaderText = "Age";
            this.ColAge.MinimumWidth = 10;
            this.ColAge.Name = "ColAge";
            this.ColAge.ReadOnly = true;
            this.ColAge.Width = 50;
            // 
            // ColPosition
            // 
            this.ColPosition.HeaderText = "Postition";
            this.ColPosition.MinimumWidth = 10;
            this.ColPosition.Name = "ColPosition";
            this.ColPosition.ReadOnly = true;
            this.ColPosition.Width = 50;
            // 
            // ColTeleNick
            // 
            this.ColTeleNick.HeaderText = "Telegram Nickname";
            this.ColTeleNick.MinimumWidth = 100;
            this.ColTeleNick.Name = "ColTeleNick";
            this.ColTeleNick.ReadOnly = true;
            this.ColTeleNick.Width = 150;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TableHistory);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.CameBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddPosition);
            this.Controls.Add(this.AddAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTeleNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.TableEmpleyee);
            this.MaximizeBox = false;
            this.Name = "Journal";
            this.ShowIcon = false;
            this.Text = "Journal";
            ((System.ComponentModel.ISupportInitialize)(this.TableEmpleyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TableEmpleyee;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddTeleNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AddAge;
        private System.Windows.Forms.ComboBox AddPosition;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button CameBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView TableHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeleNick;
    }
}

