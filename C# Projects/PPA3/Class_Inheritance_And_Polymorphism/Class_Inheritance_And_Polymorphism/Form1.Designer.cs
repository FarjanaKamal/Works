
namespace Class_Inheritance_And_Polymorphism
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
            this.BtnCreateEmployee = new System.Windows.Forms.Button();
            this.BtnCreateShiftSupervisor = new System.Windows.Forms.Button();
            this.BtnCreateProductionWorkers = new System.Windows.Forms.Button();
            this.Btn_TeamLEaderAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.Location = new System.Drawing.Point(55, 90);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(125, 56);
            this.BtnCreateEmployee.TabIndex = 0;
            this.BtnCreateEmployee.Text = "ADD Employee";
            this.BtnCreateEmployee.UseVisualStyleBackColor = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click);
            // 
            // BtnCreateShiftSupervisor
            // 
            this.BtnCreateShiftSupervisor.Location = new System.Drawing.Point(348, 90);
            this.BtnCreateShiftSupervisor.Name = "BtnCreateShiftSupervisor";
            this.BtnCreateShiftSupervisor.Size = new System.Drawing.Size(125, 56);
            this.BtnCreateShiftSupervisor.TabIndex = 1;
            this.BtnCreateShiftSupervisor.Text = "ADD Shift Supervisor";
            this.BtnCreateShiftSupervisor.UseVisualStyleBackColor = true;
            this.BtnCreateShiftSupervisor.Click += new System.EventHandler(this.BtnCreateShiftSupervisor_Click);
            // 
            // BtnCreateProductionWorkers
            // 
            this.BtnCreateProductionWorkers.Location = new System.Drawing.Point(201, 90);
            this.BtnCreateProductionWorkers.Name = "BtnCreateProductionWorkers";
            this.BtnCreateProductionWorkers.Size = new System.Drawing.Size(125, 56);
            this.BtnCreateProductionWorkers.TabIndex = 3;
            this.BtnCreateProductionWorkers.Text = "ADD Production Workers";
            this.BtnCreateProductionWorkers.UseVisualStyleBackColor = true;
            this.BtnCreateProductionWorkers.Click += new System.EventHandler(this.BtnCreateProductionWorkers_Click);
            // 
            // Btn_TeamLEaderAdd
            // 
            this.Btn_TeamLEaderAdd.Location = new System.Drawing.Point(494, 90);
            this.Btn_TeamLEaderAdd.Name = "Btn_TeamLEaderAdd";
            this.Btn_TeamLEaderAdd.Size = new System.Drawing.Size(125, 56);
            this.Btn_TeamLEaderAdd.TabIndex = 4;
            this.Btn_TeamLEaderAdd.Text = "ADD Team Leader";
            this.Btn_TeamLEaderAdd.UseVisualStyleBackColor = true;
            this.Btn_TeamLEaderAdd.Click += new System.EventHandler(this.Btn_TeamLEaderAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show ProductionWorker Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Shift Super Visor Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 74);
            this.button3.TabIndex = 8;
            this.button3.Text = "Show Employee Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "ADD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F);
            this.label2.Location = new System.Drawing.Point(58, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "View";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 74);
            this.button4.TabIndex = 11;
            this.button4.Text = "Show Team Leader Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 527);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_TeamLEaderAdd);
            this.Controls.Add(this.BtnCreateProductionWorkers);
            this.Controls.Add(this.BtnCreateShiftSupervisor);
            this.Controls.Add(this.BtnCreateEmployee);
            this.Name = "Form1";
            this.Text = "Farjana Bintay Kamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateEmployee;
        private System.Windows.Forms.Button BtnCreateShiftSupervisor;
        private System.Windows.Forms.Button BtnCreateProductionWorkers;
        private System.Windows.Forms.Button Btn_TeamLEaderAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

