/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 3:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Color_Theme
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton normalRadioButton;
		private System.Windows.Forms.RadioButton whiteRadioButton;
		private System.Windows.Forms.RadioButton redRadioButton;
		private System.Windows.Forms.RadioButton yellowRadioButton;
		private System.Windows.Forms.Button Exitbutton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.normalRadioButton = new System.Windows.Forms.RadioButton();
			this.whiteRadioButton = new System.Windows.Forms.RadioButton();
			this.redRadioButton = new System.Windows.Forms.RadioButton();
			this.yellowRadioButton = new System.Windows.Forms.RadioButton();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.normalRadioButton);
			this.groupBox1.Controls.Add(this.whiteRadioButton);
			this.groupBox1.Controls.Add(this.redRadioButton);
			this.groupBox1.Controls.Add(this.yellowRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(64, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(233, 189);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select a Background Color";
			// 
			// normalRadioButton
			// 
			this.normalRadioButton.Location = new System.Drawing.Point(44, 136);
			this.normalRadioButton.Name = "normalRadioButton";
			this.normalRadioButton.Size = new System.Drawing.Size(131, 24);
			this.normalRadioButton.TabIndex = 3;
			this.normalRadioButton.TabStop = true;
			this.normalRadioButton.Text = "Back to Normal";
			this.normalRadioButton.UseVisualStyleBackColor = true;
			this.normalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButtonCheckedChanged);
			// 
			// whiteRadioButton
			// 
			this.whiteRadioButton.Location = new System.Drawing.Point(44, 105);
			this.whiteRadioButton.Name = "whiteRadioButton";
			this.whiteRadioButton.Size = new System.Drawing.Size(104, 24);
			this.whiteRadioButton.TabIndex = 2;
			this.whiteRadioButton.TabStop = true;
			this.whiteRadioButton.Text = "White";
			this.whiteRadioButton.UseVisualStyleBackColor = true;
			this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.WhiteRadioButtonCheckedChanged);
			// 
			// redRadioButton
			// 
			this.redRadioButton.Location = new System.Drawing.Point(44, 74);
			this.redRadioButton.Name = "redRadioButton";
			this.redRadioButton.Size = new System.Drawing.Size(104, 24);
			this.redRadioButton.TabIndex = 1;
			this.redRadioButton.TabStop = true;
			this.redRadioButton.Text = "Red";
			this.redRadioButton.UseVisualStyleBackColor = true;
			this.redRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButtonCheckedChanged);
			// 
			// yellowRadioButton
			// 
			this.yellowRadioButton.Location = new System.Drawing.Point(44, 43);
			this.yellowRadioButton.Name = "yellowRadioButton";
			this.yellowRadioButton.Size = new System.Drawing.Size(104, 24);
			this.yellowRadioButton.TabIndex = 0;
			this.yellowRadioButton.TabStop = true;
			this.yellowRadioButton.Text = "Yellow";
			this.yellowRadioButton.UseVisualStyleBackColor = true;
			this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.YellowRadioButtonCheckedChanged);
			// 
			// Exitbutton
			// 
			this.Exitbutton.Location = new System.Drawing.Point(137, 247);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(75, 36);
			this.Exitbutton.TabIndex = 1;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = true;
			this.Exitbutton.Click += new System.EventHandler(this.ExitbuttonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 308);
			this.Controls.Add(this.Exitbutton);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Color Theme";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
