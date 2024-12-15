namespace FINAL_STACK_AND_QUEUES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button3 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(606, 227);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 1;
            button2.Text = "QUEUE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(287, 228);
            button3.Name = "button3";
            button3.Size = new Size(103, 44);
            button3.TabIndex = 2;
            button3.Text = "STACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Goldenrod;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(826, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 44);
            btnExit.TabIndex = 3;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 536);
            Controls.Add(btnExit);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button btnExit;
    }
}
