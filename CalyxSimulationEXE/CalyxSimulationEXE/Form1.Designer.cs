﻿namespace CalyxSimulationEXE
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.purpleBox = new System.Windows.Forms.TextBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.purpleLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.gardenOfPlentyBox = new System.Windows.Forms.CheckBox();
            this.worstCaseBox = new System.Windows.Forms.CheckBox();
            this.bestCaseBox = new System.Windows.Forms.CheckBox();
            this.plentyDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(337, 415);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Calculate";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // purpleBox
            // 
            this.purpleBox.Location = new System.Drawing.Point(112, 174);
            this.purpleBox.Name = "purpleBox";
            this.purpleBox.Size = new System.Drawing.Size(100, 20);
            this.purpleBox.TabIndex = 1;
            this.purpleBox.Text = "0";
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(337, 174);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(100, 20);
            this.blueBox.TabIndex = 2;
            this.blueBox.Text = "0";
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(571, 174);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(100, 20);
            this.greenBox.TabIndex = 3;
            this.greenBox.Text = "0";
            // 
            // purpleLabel
            // 
            this.purpleLabel.AutoSize = true;
            this.purpleLabel.Location = new System.Drawing.Point(71, 180);
            this.purpleLabel.Name = "purpleLabel";
            this.purpleLabel.Size = new System.Drawing.Size(37, 13);
            this.purpleLabel.TabIndex = 4;
            this.purpleLabel.Text = "Purple";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(294, 180);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "Blue";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(529, 180);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(36, 13);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Green";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(297, 282);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(10, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = " ";
            // 
            // gardenOfPlentyBox
            // 
            this.gardenOfPlentyBox.AutoSize = true;
            this.gardenOfPlentyBox.Location = new System.Drawing.Point(337, 100);
            this.gardenOfPlentyBox.Name = "gardenOfPlentyBox";
            this.gardenOfPlentyBox.Size = new System.Drawing.Size(105, 17);
            this.gardenOfPlentyBox.TabIndex = 8;
            this.gardenOfPlentyBox.Text = "Garden of Plenty";
            this.gardenOfPlentyBox.UseVisualStyleBackColor = true;
            this.gardenOfPlentyBox.CheckedChanged += new System.EventHandler(this.gardenOfPlentyBox_CheckedChanged);
            // 
            // worstCaseBox
            // 
            this.worstCaseBox.AutoSize = true;
            this.worstCaseBox.Location = new System.Drawing.Point(337, 123);
            this.worstCaseBox.Name = "worstCaseBox";
            this.worstCaseBox.Size = new System.Drawing.Size(126, 17);
            this.worstCaseBox.TabIndex = 9;
            this.worstCaseBox.Text = "Worst Case Scenario";
            this.worstCaseBox.UseVisualStyleBackColor = true;
            // 
            // bestCaseBox
            // 
            this.bestCaseBox.AutoSize = true;
            this.bestCaseBox.Location = new System.Drawing.Point(337, 146);
            this.bestCaseBox.Name = "bestCaseBox";
            this.bestCaseBox.Size = new System.Drawing.Size(119, 17);
            this.bestCaseBox.TabIndex = 10;
            this.bestCaseBox.Text = "Best Case Scenario";
            this.bestCaseBox.UseVisualStyleBackColor = true;
            // 
            // plentyDays
            // 
            this.plentyDays.Enabled = false;
            this.plentyDays.Location = new System.Drawing.Point(337, 74);
            this.plentyDays.Name = "plentyDays";
            this.plentyDays.Size = new System.Drawing.Size(100, 20);
            this.plentyDays.TabIndex = 11;
            this.plentyDays.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Garden of Plenty Days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plentyDays);
            this.Controls.Add(this.bestCaseBox);
            this.Controls.Add(this.worstCaseBox);
            this.Controls.Add(this.gardenOfPlentyBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.purpleLabel);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.purpleBox);
            this.Controls.Add(this.confirmButton);
            this.Name = "Form1";
            this.Text = "Calyx Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox purpleBox;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.Label purpleLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox gardenOfPlentyBox;
        private System.Windows.Forms.CheckBox worstCaseBox;
        private System.Windows.Forms.CheckBox bestCaseBox;
        private System.Windows.Forms.TextBox plentyDays;
        private System.Windows.Forms.Label label1;
    }
}

