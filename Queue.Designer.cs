namespace FINAL_STACK_AND_QUEUES
{
    partial class Queue
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
            btnQue = new Button();
            btnDeq = new Button();
            btnPeek = new Button();
            textBox1 = new TextBox();
            dgvQueue = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            SuspendLayout();
            // 
            // btnQue
            // 
            btnQue.BackColor = Color.Goldenrod;
            btnQue.FlatStyle = FlatStyle.Flat;
            btnQue.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQue.Location = new Point(135, 157);
            btnQue.Name = "btnQue";
            btnQue.Size = new Size(81, 37);
            btnQue.TabIndex = 2;
            btnQue.Text = "Queue";
            btnQue.UseVisualStyleBackColor = false;
            btnQue.Click += button2_Click;
            // 
            // btnDeq
            // 
            btnDeq.BackColor = Color.Goldenrod;
            btnDeq.FlatStyle = FlatStyle.Flat;
            btnDeq.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeq.Location = new Point(244, 231);
            btnDeq.Name = "btnDeq";
            btnDeq.Size = new Size(81, 37);
            btnDeq.TabIndex = 3;
            btnDeq.Text = "dequeue";
            btnDeq.UseVisualStyleBackColor = false;
            btnDeq.Click += button1_Click_1;
            // 
            // btnPeek
            // 
            btnPeek.BackColor = Color.Goldenrod;
            btnPeek.FlatStyle = FlatStyle.Flat;
            btnPeek.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeek.Location = new Point(136, 316);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(81, 37);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = false;
            btnPeek.Click += btnPeek_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(129, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 31);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvQueue
            // 
            dgvQueue.BackgroundColor = Color.Goldenrod;
            dgvQueue.BorderStyle = BorderStyle.Fixed3D;
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvQueue.GridColor = Color.Khaki;
            dgvQueue.Location = new Point(586, 104);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.RowHeadersWidth = 62;
            dgvQueue.Size = new Size(166, 230);
            dgvQueue.TabIndex = 6;
            dgvQueue.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Queue";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(852, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 46);
            button1.TabIndex = 13;
            button1.Text = "menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Queue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hhhuigf;
            ClientSize = new Size(959, 539);
            Controls.Add(button1);
            Controls.Add(dgvQueue);
            Controls.Add(textBox1);
            Controls.Add(btnPeek);
            Controls.Add(btnDeq);
            Controls.Add(btnQue);
            Name = "Queue";
            Text = "Queue";
            Load += Queue_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQue;
        private Button btnDeq;
        private Button btnPeek;
        private TextBox textBox1;
        private DataGridView dgvQueue;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
    }
}