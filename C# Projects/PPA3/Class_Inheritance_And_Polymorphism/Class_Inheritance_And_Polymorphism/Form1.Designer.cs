
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnCreateProductionWorkers = new System.Windows.Forms.Button();
            this.Btn_TeamLEaderAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.Location = new System.Drawing.Point(436, 57);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(98, 56);
            this.BtnCreateEmployee.TabIndex = 0;
            this.BtnCreateEmployee.Text = "ADD Employee";
            this.BtnCreateEmployee.UseVisualStyleBackColor = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click);
            // 
            // BtnCreateShiftSupervisor
            // 
            this.BtnCreateShiftSupervisor.Location = new System.Drawing.Point(436, 244);
            this.BtnCreateShiftSupervisor.Name = "BtnCreateShiftSupervisor";
            this.BtnCreateShiftSupervisor.Size = new System.Drawing.Size(98, 56);
            this.BtnCreateShiftSupervisor.TabIndex = 1;
            this.BtnCreateShiftSupervisor.Text = "ADD Shift Supervisor";
            this.BtnCreateShiftSupervisor.UseVisualStyleBackColor = true;
            this.BtnCreateShiftSupervisor.Click += new System.EventHandler(this.BtnCreateShiftSupervisor_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(46, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 340);
            this.listBox1.TabIndex = 2;
            // 
            // BtnCreateProductionWorkers
            // 
            this.BtnCreateProductionWorkers.Location = new System.Drawing.Point(436, 149);
            this.BtnCreateProductionWorkers.Name = "BtnCreateProductionWorkers";
            this.BtnCreateProductionWorkers.Size = new System.Drawing.Size(98, 62);
            this.BtnCreateProductionWorkers.TabIndex = 3;
            this.BtnCreateProductionWorkers.Text = "ADD Production Workers";
            this.BtnCreateProductionWorkers.UseVisualStyleBackColor = true;
            this.BtnCreateProductionWorkers.Click += new System.EventHandler(this.BtnCreateProductionWorkers_Click);
            // 
            // Btn_TeamLEaderAdd
            // 
            this.Btn_TeamLEaderAdd.Location = new System.Drawing.Point(436, 338);
            this.Btn_TeamLEaderAdd.Name = "Btn_TeamLEaderAdd";
            this.Btn_TeamLEaderAdd.Size = new System.Drawing.Size(98, 59);
            this.Btn_TeamLEaderAdd.TabIndex = 4;
            this.Btn_TeamLEaderAdd.Text = "ADD Team Leader";
            this.Btn_TeamLEaderAdd.UseVisualStyleBackColor = true;
            this.Btn_TeamLEaderAdd.Click += new System.EventHandler(this.Btn_TeamLEaderAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show ProductionWorker Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Shift Super Visor Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_TeamLEaderAdd);
            this.Controls.Add(this.BtnCreateProductionWorkers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnCreateShiftSupervisor);
            this.Controls.Add(this.BtnCreateEmployee);
            this.Name = "Form1";
            this.Text = "Farjana Bintay Kamal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateEmployee;
        private System.Windows.Forms.Button BtnCreateShiftSupervisor;
        private System.Windows.Forms.Button BtnCreateProductionWorkers;
        private System.Windows.Forms.Button Btn_TeamLEaderAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

