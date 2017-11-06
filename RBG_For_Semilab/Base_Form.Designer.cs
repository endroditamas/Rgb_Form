namespace RBG_For_Semilab
{
    partial class Base_Form
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
            this.Color_Label = new System.Windows.Forms.Label();
            this.RedScrollBar = new System.Windows.Forms.HScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.BlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.RedScrollBarValueLabel = new System.Windows.Forms.Label();
            this.GreenScrollBarValueLabel = new System.Windows.Forms.Label();
            this.BlueScrollBarValueLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RgbDataGridView = new System.Windows.Forms.DataGridView();
            this.RedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GreenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RgbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Color_Label
            // 
            this.Color_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_Label.Location = new System.Drawing.Point(192, 12);
            this.Color_Label.Name = "Color_Label";
            this.Color_Label.Size = new System.Drawing.Size(503, 240);
            this.Color_Label.TabIndex = 0;
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.Location = new System.Drawing.Point(192, 271);
            this.RedScrollBar.Maximum = 264;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(503, 17);
            this.RedScrollBar.TabIndex = 0;
            this.RedScrollBar.Value = 1;
            this.RedScrollBar.ValueChanged += new System.EventHandler(this.RedScrollBar_ValueChanged);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.Location = new System.Drawing.Point(192, 303);
            this.GreenScrollBar.Maximum = 264;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(503, 17);
            this.GreenScrollBar.TabIndex = 1;
            this.GreenScrollBar.Value = 1;
            this.GreenScrollBar.ValueChanged += new System.EventHandler(this.GreenScrollBar_ValueChanged);
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.Location = new System.Drawing.Point(192, 334);
            this.BlueScrollBar.Maximum = 264;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(503, 17);
            this.BlueScrollBar.TabIndex = 2;
            this.BlueScrollBar.Value = 1;
            this.BlueScrollBar.ValueChanged += new System.EventHandler(this.BlueScrollBar_ValueChanged);
            // 
            // RedScrollBarValueLabel
            // 
            this.RedScrollBarValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedScrollBarValueLabel.Location = new System.Drawing.Point(12, 271);
            this.RedScrollBarValueLabel.Name = "RedScrollBarValueLabel";
            this.RedScrollBarValueLabel.Size = new System.Drawing.Size(174, 17);
            this.RedScrollBarValueLabel.TabIndex = 6;
            // 
            // GreenScrollBarValueLabel
            // 
            this.GreenScrollBarValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenScrollBarValueLabel.Location = new System.Drawing.Point(12, 303);
            this.GreenScrollBarValueLabel.Name = "GreenScrollBarValueLabel";
            this.GreenScrollBarValueLabel.Size = new System.Drawing.Size(174, 17);
            this.GreenScrollBarValueLabel.TabIndex = 7;
            // 
            // BlueScrollBarValueLabel
            // 
            this.BlueScrollBarValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueScrollBarValueLabel.Location = new System.Drawing.Point(12, 334);
            this.BlueScrollBarValueLabel.Name = "BlueScrollBarValueLabel";
            this.BlueScrollBarValueLabel.Size = new System.Drawing.Size(174, 17);
            this.BlueScrollBarValueLabel.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 370);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Hozzáadás a listához";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RgbDataGridView
            // 
            this.RgbDataGridView.AllowUserToAddRows = false;
            this.RgbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RgbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedColumn,
            this.GreenColumn,
            this.BlueColumn});
            this.RgbDataGridView.Location = new System.Drawing.Point(12, 12);
            this.RgbDataGridView.Name = "RgbDataGridView";
            this.RgbDataGridView.RowHeadersVisible = false;
            this.RgbDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RgbDataGridView.Size = new System.Drawing.Size(174, 240);
            this.RgbDataGridView.TabIndex = 11;
            this.RgbDataGridView.TabStop = false;
            this.RgbDataGridView.CurrentCellChanged += new System.EventHandler(this.RgbDataGridView_CurrentCellChanged);
            // 
            // RedColumn
            // 
            this.RedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedColumn.HeaderText = "R";
            this.RedColumn.Name = "RedColumn";
            this.RedColumn.ReadOnly = true;
            this.RedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GreenColumn
            // 
            this.GreenColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GreenColumn.HeaderText = "G";
            this.GreenColumn.Name = "GreenColumn";
            this.GreenColumn.ReadOnly = true;
            this.GreenColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BlueColumn
            // 
            this.BlueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlueColumn.HeaderText = "B";
            this.BlueColumn.Name = "BlueColumn";
            this.BlueColumn.ReadOnly = true;
            this.BlueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(592, 370);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Bezár";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 418);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RgbDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BlueScrollBarValueLabel);
            this.Controls.Add(this.GreenScrollBarValueLabel);
            this.Controls.Add(this.RedScrollBarValueLabel);
            this.Controls.Add(this.BlueScrollBar);
            this.Controls.Add(this.GreenScrollBar);
            this.Controls.Add(this.RedScrollBar);
            this.Controls.Add(this.Color_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Base_Form";
            this.ShowIcon = false;
            this.Text = "Szín készítő";
            this.Load += new System.EventHandler(this.Base_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RgbDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Color_Label;
        private System.Windows.Forms.HScrollBar RedScrollBar;
        private System.Windows.Forms.HScrollBar GreenScrollBar;
        private System.Windows.Forms.HScrollBar BlueScrollBar;
        private System.Windows.Forms.Label RedScrollBarValueLabel;
        private System.Windows.Forms.Label GreenScrollBarValueLabel;
        private System.Windows.Forms.Label BlueScrollBarValueLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView RgbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GreenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueColumn;
        private System.Windows.Forms.Button CloseButton;
    }
}

