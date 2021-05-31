namespace FlightInfoWinforms.Views
{
    partial class FlightInfoView
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
            this.label3 = new System.Windows.Forms.Label();
            this.PollBox = new System.Windows.Forms.CheckBox();
            this.arrivalStatusLabel = new System.Windows.Forms.Label();
            this.departureStatusLabel = new System.Windows.Forms.Label();
            this.enrouteStatusLabel = new System.Windows.Forms.Label();
            this.ArrivalsGridView = new System.Windows.Forms.DataGridView();
            this.DeparturesGridView = new System.Windows.Forms.DataGridView();
            this.EnroutesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeparturesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnroutesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arrivals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(283, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enroute";
            // 
            // PollBox
            // 
            this.PollBox.AutoSize = true;
            this.PollBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PollBox.Location = new System.Drawing.Point(819, 53);
            this.PollBox.Name = "PollBox";
            this.PollBox.Size = new System.Drawing.Size(150, 44);
            this.PollBox.TabIndex = 3;
            this.PollBox.Text = "Poll Data";
            this.PollBox.UseVisualStyleBackColor = true;
            this.PollBox.CheckedChanged += new System.EventHandler(this.PollBox_CheckedChanged);
            // 
            // arrivalStatusLabel
            // 
            this.arrivalStatusLabel.AutoSize = true;
            this.arrivalStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalStatusLabel.Location = new System.Drawing.Point(452, 139);
            this.arrivalStatusLabel.Name = "arrivalStatusLabel";
            this.arrivalStatusLabel.Size = new System.Drawing.Size(71, 25);
            this.arrivalStatusLabel.TabIndex = 4;
            this.arrivalStatusLabel.Text = "Status: ";
            // 
            // departureStatusLabel
            // 
            this.departureStatusLabel.AutoSize = true;
            this.departureStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureStatusLabel.Location = new System.Drawing.Point(452, 386);
            this.departureStatusLabel.Name = "departureStatusLabel";
            this.departureStatusLabel.Size = new System.Drawing.Size(71, 25);
            this.departureStatusLabel.TabIndex = 5;
            this.departureStatusLabel.Text = "Status: ";
            // 
            // enrouteStatusLabel
            // 
            this.enrouteStatusLabel.AutoSize = true;
            this.enrouteStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrouteStatusLabel.Location = new System.Drawing.Point(452, 619);
            this.enrouteStatusLabel.Name = "enrouteStatusLabel";
            this.enrouteStatusLabel.Size = new System.Drawing.Size(71, 25);
            this.enrouteStatusLabel.TabIndex = 6;
            this.enrouteStatusLabel.Text = "Status: ";
            // 
            // ArrivalsGridView
            // 
            this.ArrivalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrivalsGridView.Location = new System.Drawing.Point(283, 168);
            this.ArrivalsGridView.Name = "ArrivalsGridView";
            this.ArrivalsGridView.Size = new System.Drawing.Size(1290, 184);
            this.ArrivalsGridView.TabIndex = 7;
            this.ArrivalsGridView.Text = "dataGridView1";
            // 
            // DeparturesGridView
            // 
            this.DeparturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeparturesGridView.Location = new System.Drawing.Point(283, 414);
            this.DeparturesGridView.Name = "DeparturesGridView";
            this.DeparturesGridView.Size = new System.Drawing.Size(1290, 184);
            this.DeparturesGridView.TabIndex = 7;
            this.DeparturesGridView.Text = "dataGridView1";
            // 
            // EnroutesGridView
            // 
            this.EnroutesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnroutesGridView.Location = new System.Drawing.Point(283, 648);
            this.EnroutesGridView.Name = "EnroutesGridView";
            this.EnroutesGridView.Size = new System.Drawing.Size(1290, 184);
            this.EnroutesGridView.TabIndex = 7;
            this.EnroutesGridView.Text = "dataGridView1";
            // 
            // FlightInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 880);
            this.Controls.Add(this.EnroutesGridView);
            this.Controls.Add(this.DeparturesGridView);
            this.Controls.Add(this.ArrivalsGridView);
            this.Controls.Add(this.enrouteStatusLabel);
            this.Controls.Add(this.departureStatusLabel);
            this.Controls.Add(this.arrivalStatusLabel);
            this.Controls.Add(this.PollBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightInfoView";
            this.Text = "FlightInfoView";
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeparturesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnroutesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PollBox;
        private System.Windows.Forms.Label arrivalStatusLabel;
        private System.Windows.Forms.Label departureStatusLabel;
        private System.Windows.Forms.Label enrouteStatusLabel;
        private System.Windows.Forms.DataGridView ArrivalsGridView;
        private System.Windows.Forms.DataGridView DeparturesGridView;
        private System.Windows.Forms.DataGridView EnroutesGridView;
    }
}