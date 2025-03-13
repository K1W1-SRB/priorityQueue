namespace PriorityQueue
{
    partial class QueueManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Implementation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Actions = new System.Windows.Forms.Panel();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_IsEmpty = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Peek = new System.Windows.Forms.Button();
            this.Panel_Output = new System.Windows.Forms.Panel();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Panel_Add = new System.Windows.Forms.Panel();
            this.Btn_AddQueue = new System.Windows.Forms.Button();
            this.Num_Priority = new System.Windows.Forms.NumericUpDown();
            this.Txt_Person = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panel_Actions.SuspendLayout();
            this.Panel_Output.SuspendLayout();
            this.Panel_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Priority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Priority Queue Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_Implementation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 82);
            this.panel1.TabIndex = 1;
            // 
            // CB_Implementation
            // 
            this.CB_Implementation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Implementation.FormattingEnabled = true;
            this.CB_Implementation.Items.AddRange(new object[] {
            "Sorted Array", "Unsorted Array", "Unsorted Linked", "Sorted Linked", "Heap"});
            this.CB_Implementation.Location = new System.Drawing.Point(5, 45);
            this.CB_Implementation.Name = "CB_Implementation";
            this.CB_Implementation.Size = new System.Drawing.Size(162, 26);
            this.CB_Implementation.TabIndex = 3;
            this.CB_Implementation.SelectedIndexChanged += new System.EventHandler(this.CB_Implementation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose implementation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Actions
            // 
            this.Panel_Actions.Controls.Add(this.Btn_Print);
            this.Panel_Actions.Controls.Add(this.Btn_IsEmpty);
            this.Panel_Actions.Controls.Add(this.Btn_Remove);
            this.Panel_Actions.Controls.Add(this.label3);
            this.Panel_Actions.Controls.Add(this.Btn_Peek);
            this.Panel_Actions.Location = new System.Drawing.Point(12, 149);
            this.Panel_Actions.Name = "Panel_Actions";
            this.Panel_Actions.Size = new System.Drawing.Size(174, 204);
            this.Panel_Actions.TabIndex = 2;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.Location = new System.Drawing.Point(21, 163);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(139, 32);
            this.Btn_Print.TabIndex = 7;
            this.Btn_Print.Text = "Print Queue";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_IsEmpty
            // 
            this.Btn_IsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IsEmpty.Location = new System.Drawing.Point(20, 125);
            this.Btn_IsEmpty.Name = "Btn_IsEmpty";
            this.Btn_IsEmpty.Size = new System.Drawing.Size(139, 32);
            this.Btn_IsEmpty.TabIndex = 6;
            this.Btn_IsEmpty.Text = "Check if Empty";
            this.Btn_IsEmpty.UseVisualStyleBackColor = true;
            this.Btn_IsEmpty.Click += new System.EventHandler(this.Btn_IsEmpty_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.Location = new System.Drawing.Point(19, 87);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(139, 32);
            this.Btn_Remove.TabIndex = 5;
            this.Btn_Remove.Text = "Remove Top Item";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Peek
            // 
            this.Btn_Peek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Peek.Location = new System.Drawing.Point(19, 48);
            this.Btn_Peek.Name = "Btn_Peek";
            this.Btn_Peek.Size = new System.Drawing.Size(139, 32);
            this.Btn_Peek.TabIndex = 0;
            this.Btn_Peek.Text = "Display Top Item";
            this.Btn_Peek.UseVisualStyleBackColor = true;
            this.Btn_Peek.Click += new System.EventHandler(this.Btn_Peek_Click);
            // 
            // Panel_Output
            // 
            this.Panel_Output.Controls.Add(this.Lbl_Output);
            this.Panel_Output.Location = new System.Drawing.Point(192, 149);
            this.Panel_Output.Name = "Panel_Output";
            this.Panel_Output.Size = new System.Drawing.Size(444, 204);
            this.Panel_Output.TabIndex = 3;
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Output.Location = new System.Drawing.Point(3, 9);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(438, 186);
            this.Lbl_Output.TabIndex = 8;
            this.Lbl_Output.Text = "Awating choice...";
            this.Lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Add
            // 
            this.Panel_Add.Controls.Add(this.label5);
            this.Panel_Add.Controls.Add(this.label4);
            this.Panel_Add.Controls.Add(this.Btn_AddQueue);
            this.Panel_Add.Controls.Add(this.Num_Priority);
            this.Panel_Add.Controls.Add(this.Txt_Person);
            this.Panel_Add.Location = new System.Drawing.Point(192, 61);
            this.Panel_Add.Name = "Panel_Add";
            this.Panel_Add.Size = new System.Drawing.Size(444, 82);
            this.Panel_Add.TabIndex = 4;
            // 
            // Btn_AddQueue
            // 
            this.Btn_AddQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddQueue.Location = new System.Drawing.Point(319, 42);
            this.Btn_AddQueue.Name = "Btn_AddQueue";
            this.Btn_AddQueue.Size = new System.Drawing.Size(117, 32);
            this.Btn_AddQueue.TabIndex = 8;
            this.Btn_AddQueue.Text = "Add";
            this.Btn_AddQueue.UseVisualStyleBackColor = true;
            this.Btn_AddQueue.Click += new System.EventHandler(this.Btn_AddQueue_Click);
            // 
            // Num_Priority
            // 
            this.Num_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Priority.Location = new System.Drawing.Point(194, 46);
            this.Num_Priority.Name = "Num_Priority";
            this.Num_Priority.Size = new System.Drawing.Size(120, 24);
            this.Num_Priority.TabIndex = 4;
            // 
            // Txt_Person
            // 
            this.Txt_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Person.Location = new System.Drawing.Point(9, 46);
            this.Txt_Person.Name = "Txt_Person";
            this.Txt_Person.Size = new System.Drawing.Size(179, 24);
            this.Txt_Person.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueueManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 365);
            this.Controls.Add(this.Panel_Add);
            this.Controls.Add(this.Panel_Output);
            this.Controls.Add(this.Panel_Actions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "QueueManager";
            this.Text = "Queue Manager";
            this.panel1.ResumeLayout(false);
            this.Panel_Actions.ResumeLayout(false);
            this.Panel_Output.ResumeLayout(false);
            this.Panel_Add.ResumeLayout(false);
            this.Panel_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Priority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Implementation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Actions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Peek;
        private System.Windows.Forms.Panel Panel_Output;
        private System.Windows.Forms.Panel Panel_Add;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_IsEmpty;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.Button Btn_AddQueue;
        private System.Windows.Forms.NumericUpDown Num_Priority;
        private System.Windows.Forms.TextBox Txt_Person;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

