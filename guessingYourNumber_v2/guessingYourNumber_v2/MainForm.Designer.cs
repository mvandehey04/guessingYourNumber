/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 10/9/2019
 * Time: 12:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace guessingYourNumber
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.numberGuessButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numberLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.highButton = new System.Windows.Forms.Button();
			this.lowButton = new System.Windows.Forms.Button();
			this.tenTooHigh = new System.Windows.Forms.Button();
			this.tenTooLow = new System.Windows.Forms.Button();
			this.newGameButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.correctGuessButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numberOfGuessesLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(502, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "I\'m going to guess what number you\'re thinking of (1-100).";
			// 
			// numberGuessButton
			// 
			this.numberGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberGuessButton.ForeColor = System.Drawing.Color.DodgerBlue;
			this.numberGuessButton.Location = new System.Drawing.Point(229, 46);
			this.numberGuessButton.Name = "numberGuessButton";
			this.numberGuessButton.Size = new System.Drawing.Size(180, 23);
			this.numberGuessButton.TabIndex = 1;
			this.numberGuessButton.Text = "Guess My Number";
			this.numberGuessButton.UseVisualStyleBackColor = true;
			this.numberGuessButton.Click += new System.EventHandler(this.NumberGuessButton_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(185, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Is your number ...";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numberLabel
			// 
			this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberLabel.Location = new System.Drawing.Point(352, 80);
			this.numberLabel.Name = "numberLabel";
			this.numberLabel.Size = new System.Drawing.Size(56, 23);
			this.numberLabel.TabIndex = 0;
			this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(416, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "?";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// highButton
			// 
			this.highButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highButton.Location = new System.Drawing.Point(143, 120);
			this.highButton.Name = "highButton";
			this.highButton.Size = new System.Drawing.Size(87, 36);
			this.highButton.TabIndex = 2;
			this.highButton.Text = "Too High";
			this.highButton.UseVisualStyleBackColor = true;
			this.highButton.Click += new System.EventHandler(this.HighButton_Click);
			// 
			// lowButton
			// 
			this.lowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lowButton.Location = new System.Drawing.Point(404, 120);
			this.lowButton.Name = "lowButton";
			this.lowButton.Size = new System.Drawing.Size(87, 36);
			this.lowButton.TabIndex = 3;
			this.lowButton.Text = "Too Low";
			this.lowButton.UseVisualStyleBackColor = true;
			this.lowButton.Click += new System.EventHandler(this.LowButton_Click);
			// 
			// tenTooHigh
			// 
			this.tenTooHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tenTooHigh.Location = new System.Drawing.Point(143, 213);
			this.tenTooHigh.Name = "tenTooHigh";
			this.tenTooHigh.Size = new System.Drawing.Size(113, 36);
			this.tenTooHigh.TabIndex = 5;
			this.tenTooHigh.Text = "10 Too High";
			this.tenTooHigh.UseVisualStyleBackColor = true;
			this.tenTooHigh.Click += new System.EventHandler(this.TenTooHigh_Click);
			// 
			// tenTooLow
			// 
			this.tenTooLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tenTooLow.Location = new System.Drawing.Point(378, 213);
			this.tenTooLow.Name = "tenTooLow";
			this.tenTooLow.Size = new System.Drawing.Size(113, 36);
			this.tenTooLow.TabIndex = 6;
			this.tenTooLow.Text = "10 Too Low";
			this.tenTooLow.UseVisualStyleBackColor = true;
			this.tenTooLow.Click += new System.EventHandler(this.TenTooLow_Click);
			// 
			// newGameButton
			// 
			this.newGameButton.BackColor = System.Drawing.Color.Green;
			this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newGameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.newGameButton.Location = new System.Drawing.Point(143, 312);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(87, 60);
			this.newGameButton.TabIndex = 7;
			this.newGameButton.Text = "&New Game";
			this.newGameButton.UseVisualStyleBackColor = false;
			this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.DarkRed;
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.exitButton.Location = new System.Drawing.Point(416, 312);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(87, 60);
			this.exitButton.TabIndex = 8;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// correctGuessButton
			// 
			this.correctGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.correctGuessButton.Location = new System.Drawing.Point(255, 160);
			this.correctGuessButton.Name = "correctGuessButton";
			this.correctGuessButton.Size = new System.Drawing.Size(128, 36);
			this.correctGuessButton.TabIndex = 4;
			this.correctGuessButton.Text = "You guessed it!";
			this.correctGuessButton.UseVisualStyleBackColor = true;
			this.correctGuessButton.Click += new System.EventHandler(this.CorrectGuessButton_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(181, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Number of Guesses:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numberOfGuessesLabel
			// 
			this.numberOfGuessesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.numberOfGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberOfGuessesLabel.Location = new System.Drawing.Point(352, 271);
			this.numberOfGuessesLabel.Name = "numberOfGuessesLabel";
			this.numberOfGuessesLabel.Size = new System.Drawing.Size(58, 23);
			this.numberOfGuessesLabel.TabIndex = 13;
			this.numberOfGuessesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AcceptButton = this.numberGuessButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(650, 384);
			this.Controls.Add(this.numberOfGuessesLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.correctGuessButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.newGameButton);
			this.Controls.Add(this.tenTooLow);
			this.Controls.Add(this.tenTooHigh);
			this.Controls.Add(this.lowButton);
			this.Controls.Add(this.highButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numberLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numberGuessButton);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "guessingYourNumber";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label numberOfGuessesLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button correctGuessButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button tenTooLow;
		private System.Windows.Forms.Button tenTooHigh;
		private System.Windows.Forms.Button lowButton;
		private System.Windows.Forms.Button highButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label numberLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button numberGuessButton;
		private System.Windows.Forms.Label label1;
	}
}
