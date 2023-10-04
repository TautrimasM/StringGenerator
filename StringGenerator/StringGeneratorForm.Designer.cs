namespace StringGenerator
{
    partial class StringGeneratorForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Strings", System.Windows.Forms.HorizontalAlignment.Left);
            this.stringList = new System.Windows.Forms.ListView();
            this.threadId = new System.Windows.Forms.ColumnHeader();
            this.generatedString = new System.Windows.Forms.ColumnHeader();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ThreadAmount = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(30, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Threads:";
            // 
            // stringList
            // 
            this.stringList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.threadId,
            this.generatedString});
            listViewGroup2.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup2.Header = "Strings";
            listViewGroup2.Name = "listViewGroup1";
            this.stringList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.stringList.HideSelection = true;
            this.stringList.Location = new System.Drawing.Point(30, 111);
            this.stringList.Name = "stringList";
            this.stringList.Size = new System.Drawing.Size(322, 419);
            this.stringList.TabIndex = 4;
            this.stringList.UseCompatibleStateImageBehavior = false;
            this.stringList.View = System.Windows.Forms.View.Details;
            // 
            // threadId
            // 
            this.threadId.Text = "Thread ID";
            this.threadId.Width = 75;
            // 
            // generatedString
            // 
            this.generatedString.Text = "Generated String";
            this.generatedString.Width = 200;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(277, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(277, 50);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ThreadAmount
            // 
            this.ThreadAmount.Location = new System.Drawing.Point(30, 50);
            this.ThreadAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ThreadAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThreadAmount.Name = "ThreadAmount";
            this.ThreadAmount.Size = new System.Drawing.Size(120, 23);
            this.ThreadAmount.TabIndex = 2;
            this.ThreadAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StringGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.stringList);
            this.Controls.Add(label1);
            this.Controls.Add(this.ThreadAmount);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "StringGeneratorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ThreadAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private ListView stringList;
        public ColumnHeader threadId;
        private ColumnHeader generatedString;
        public NumericUpDown ThreadAmount;
    }
}