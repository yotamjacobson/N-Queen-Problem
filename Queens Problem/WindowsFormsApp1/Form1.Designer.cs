namespace QueensProblem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Solve = new System.Windows.Forms.Button();
            this.sizeController = new System.Windows.Forms.NumericUpDown();
            this.Next = new System.Windows.Forms.Button();
            this.Try = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeController)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(121, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(12, 15);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(103, 46);
            this.Solve.TabIndex = 1;
            this.Solve.TabStop = false;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // sizeController
            // 
            this.sizeController.Location = new System.Drawing.Point(12, 67);
            this.sizeController.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.sizeController.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeController.Name = "sizeController";
            this.sizeController.Size = new System.Drawing.Size(103, 20);
            this.sizeController.TabIndex = 3;
            this.sizeController.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeController.ValueChanged += new System.EventHandler(this.sizeController_ValueChanged);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Red;
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(12, 395);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(103, 46);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next Solution";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Try
            // 
            this.Try.Location = new System.Drawing.Point(13, 344);
            this.Try.Name = "Try";
            this.Try.Size = new System.Drawing.Size(102, 45);
            this.Try.TabIndex = 5;
            this.Try.Text = "Try Yourself";
            this.Try.UseVisualStyleBackColor = true;
            this.Try.Click += new System.EventHandler(this.Try_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.Try);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.sizeController);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.NumericUpDown sizeController;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Try;
    }
}

