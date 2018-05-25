namespace TLTAnalyser
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
            this.components = new System.ComponentModel.Container();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dgDoorData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecompletionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecompleteonorderacknowledgementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differencedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewdifferencebetweenplannedandactualcompletionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new TLTAnalyser.order_databaseDataSet();
            this.orderdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_difference_between_planned_and_actual_completionTableAdapter = new TLTAnalyser.order_databaseDataSetTableAdapters.view_difference_between_planned_and_actual_completionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDoorCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEarly = new System.Windows.Forms.TextBox();
            this.txtOntime = new System.Windows.Forms.TextBox();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPEarly = new System.Windows.Forms.TextBox();
            this.txtPOnTime = new System.Windows.Forms.TextBox();
            this.txtPLate = new System.Windows.Forms.TextBox();
            this.chkExclude = new System.Windows.Forms.CheckBox();
            this.txtUnAcknowledged = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdifferencebetweenplannedandactualcompletionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(12, 117);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(161, 20);
            this.dtStart.TabIndex = 0;
            this.dtStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(12, 143);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(161, 20);
            this.dtEnd.TabIndex = 1;
            // 
            // dgDoorData
            // 
            this.dgDoorData.AutoGenerateColumns = false;
            this.dgDoorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDoorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderrefDataGridViewTextBoxColumn,
            this.doorrefDataGridViewTextBoxColumn,
            this.dateorderDataGridViewTextBoxColumn,
            this.datecompletionDataGridViewTextBoxColumn,
            this.datecompleteonorderacknowledgementDataGridViewTextBoxColumn,
            this.differencedateDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dgDoorData.DataSource = this.viewdifferencebetweenplannedandactualcompletionBindingSource;
            this.dgDoorData.Location = new System.Drawing.Point(13, 196);
            this.dgDoorData.Name = "dgDoorData";
            this.dgDoorData.Size = new System.Drawing.Size(1065, 367);
            this.dgDoorData.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // orderrefDataGridViewTextBoxColumn
            // 
            this.orderrefDataGridViewTextBoxColumn.DataPropertyName = "order_ref";
            this.orderrefDataGridViewTextBoxColumn.HeaderText = "order_ref";
            this.orderrefDataGridViewTextBoxColumn.Name = "orderrefDataGridViewTextBoxColumn";
            // 
            // doorrefDataGridViewTextBoxColumn
            // 
            this.doorrefDataGridViewTextBoxColumn.DataPropertyName = "door_ref";
            this.doorrefDataGridViewTextBoxColumn.HeaderText = "door_ref";
            this.doorrefDataGridViewTextBoxColumn.Name = "doorrefDataGridViewTextBoxColumn";
            // 
            // dateorderDataGridViewTextBoxColumn
            // 
            this.dateorderDataGridViewTextBoxColumn.DataPropertyName = "date_order";
            this.dateorderDataGridViewTextBoxColumn.HeaderText = "date_order";
            this.dateorderDataGridViewTextBoxColumn.Name = "dateorderDataGridViewTextBoxColumn";
            // 
            // datecompletionDataGridViewTextBoxColumn
            // 
            this.datecompletionDataGridViewTextBoxColumn.DataPropertyName = "date_completion";
            this.datecompletionDataGridViewTextBoxColumn.HeaderText = "date_completion";
            this.datecompletionDataGridViewTextBoxColumn.Name = "datecompletionDataGridViewTextBoxColumn";
            // 
            // datecompleteonorderacknowledgementDataGridViewTextBoxColumn
            // 
            this.datecompleteonorderacknowledgementDataGridViewTextBoxColumn.DataPropertyName = "date_complete_on_order_acknowledgement";
            this.datecompleteonorderacknowledgementDataGridViewTextBoxColumn.HeaderText = "date_complete_on_order_acknowledgement";
            this.datecompleteonorderacknowledgementDataGridViewTextBoxColumn.Name = "datecompleteonorderacknowledgementDataGridViewTextBoxColumn";
            // 
            // differencedateDataGridViewTextBoxColumn
            // 
            this.differencedateDataGridViewTextBoxColumn.DataPropertyName = "difference_date";
            this.differencedateDataGridViewTextBoxColumn.HeaderText = "difference_date";
            this.differencedateDataGridViewTextBoxColumn.Name = "differencedateDataGridViewTextBoxColumn";
            this.differencedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // viewdifferencebetweenplannedandactualcompletionBindingSource
            // 
            this.viewdifferencebetweenplannedandactualcompletionBindingSource.DataMember = "view_difference_between_planned_and_actual_completion";
            this.viewdifferencebetweenplannedandactualcompletionBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdatabaseDataSetBindingSource
            // 
            this.orderdatabaseDataSetBindingSource.DataSource = this.order_databaseDataSet;
            this.orderdatabaseDataSetBindingSource.Position = 0;
            // 
            // view_difference_between_planned_and_actual_completionTableAdapter
            // 
            this.view_difference_between_planned_and_actual_completionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDoorCount
            // 
            this.txtDoorCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDoorCount.Location = new System.Drawing.Point(963, 88);
            this.txtDoorCount.Name = "txtDoorCount";
            this.txtDoorCount.Size = new System.Drawing.Size(53, 20);
            this.txtDoorCount.TabIndex = 4;
            this.txtDoorCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Doors(With/Without Acknowledgements):";
            // 
            // txtEarly
            // 
            this.txtEarly.Location = new System.Drawing.Point(963, 114);
            this.txtEarly.Name = "txtEarly";
            this.txtEarly.Size = new System.Drawing.Size(53, 20);
            this.txtEarly.TabIndex = 6;
            this.txtEarly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOntime
            // 
            this.txtOntime.Location = new System.Drawing.Point(963, 140);
            this.txtOntime.Name = "txtOntime";
            this.txtOntime.Size = new System.Drawing.Size(53, 20);
            this.txtOntime.TabIndex = 7;
            this.txtOntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLate
            // 
            this.txtLate.Location = new System.Drawing.Point(963, 166);
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(53, 20);
            this.txtLate.TabIndex = 8;
            this.txtLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doors Early/Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doors On Time/Percentage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doors Late/Percentage:";
            // 
            // txtPEarly
            // 
            this.txtPEarly.ForeColor = System.Drawing.Color.Green;
            this.txtPEarly.Location = new System.Drawing.Point(1022, 114);
            this.txtPEarly.Name = "txtPEarly";
            this.txtPEarly.Size = new System.Drawing.Size(56, 20);
            this.txtPEarly.TabIndex = 12;
            this.txtPEarly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPOnTime
            // 
            this.txtPOnTime.Location = new System.Drawing.Point(1022, 140);
            this.txtPOnTime.Name = "txtPOnTime";
            this.txtPOnTime.Size = new System.Drawing.Size(56, 20);
            this.txtPOnTime.TabIndex = 13;
            this.txtPOnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPLate
            // 
            this.txtPLate.ForeColor = System.Drawing.Color.Red;
            this.txtPLate.Location = new System.Drawing.Point(1022, 166);
            this.txtPLate.Name = "txtPLate";
            this.txtPLate.Size = new System.Drawing.Size(56, 20);
            this.txtPLate.TabIndex = 14;
            this.txtPLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkExclude
            // 
            this.chkExclude.AutoSize = true;
            this.chkExclude.Location = new System.Drawing.Point(13, 169);
            this.chkExclude.Name = "chkExclude";
            this.chkExclude.Size = new System.Drawing.Size(156, 17);
            this.chkExclude.TabIndex = 15;
            this.chkExclude.Text = "Exclude Abnormal Numbers";
            this.chkExclude.UseVisualStyleBackColor = true;
            // 
            // txtUnAcknowledged
            // 
            this.txtUnAcknowledged.ForeColor = System.Drawing.Color.Red;
            this.txtUnAcknowledged.Location = new System.Drawing.Point(1022, 88);
            this.txtUnAcknowledged.Name = "txtUnAcknowledged";
            this.txtUnAcknowledged.Size = new System.Drawing.Size(56, 20);
            this.txtUnAcknowledged.TabIndex = 16;
            this.txtUnAcknowledged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "S:\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Order Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUnAcknowledged);
            this.Controls.Add(this.chkExclude);
            this.Controls.Add(this.txtPLate);
            this.Controls.Add(this.txtPOnTime);
            this.Controls.Add(this.txtPEarly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLate);
            this.Controls.Add(this.txtOntime);
            this.Controls.Add(this.txtEarly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoorCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDoorData);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Name = "Form1";
            this.Text = "Lead Time Analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdifferencebetweenplannedandactualcompletionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView dgDoorData;
        private System.Windows.Forms.BindingSource orderdatabaseDataSetBindingSource;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource viewdifferencebetweenplannedandactualcompletionBindingSource;
        private order_databaseDataSetTableAdapters.view_difference_between_planned_and_actual_completionTableAdapter view_difference_between_planned_and_actual_completionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderrefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorrefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecompletionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecompleteonorderacknowledgementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn differencedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDoorCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEarly;
        private System.Windows.Forms.TextBox txtOntime;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPEarly;
        private System.Windows.Forms.TextBox txtPOnTime;
        private System.Windows.Forms.TextBox txtPLate;
        private System.Windows.Forms.CheckBox chkExclude;
        private System.Windows.Forms.TextBox txtUnAcknowledged;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

