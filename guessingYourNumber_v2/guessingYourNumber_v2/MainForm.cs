/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 10/9/2019
 * Time: 12:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace guessingYourNumber
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int minimum = 1;
		int maximum = 100;
		int median = 50;
		int count = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void NumberGuessButton_Click(object sender, EventArgs e)
		{
			numberLabel.Text = median.ToString();
			
			//count
			count ++;
			numberOfGuessesLabel.Text = count.ToString();
			
		}
		
		void HighButton_Click(object sender, EventArgs e)
		{
			//range has to be between (median - 10) and minimum value (first time it should be 1-30)
			maximum = median - 10;
			median = (maximum + minimum) / 2;
			
			//count
			count ++;
			numberOfGuessesLabel.Text = count.ToString();
			
			//display guess in label
			numberLabel.Text = median.ToString();
			
			if (median <= 0)
			{
				median = 1;
				numberLabel.Text = median.ToString();
			}
				else
				{
					//display guess in label
					numberLabel.Text = median.ToString();
				}
				
				if (numberLabel.Text == Font.Bold)
				{
					
				}
		}
		
		void LowButton_Click(object sender, EventArgs e)
		{
			//range has to be between (median + 10) and maximum value (first time it should be 70-100)
			minimum = median + 10;
			median = (minimum + maximum) / 2;
			
			//count
			count ++;
			numberOfGuessesLabel.Text = count.ToString();
			
			//display guess in label
			numberLabel.Text = median.ToString();
				
		}
		
		void TenTooHigh_Click(object sender, EventArgs e)
		{
			//range is between median and (median - 10)
			median -= 10;
			
			//count
			count ++;
			numberOfGuessesLabel.Text = count.ToString();
			
			//display guess in label
			numberLabel.Text = median.ToString();
			
		}
		
		void TenTooLow_Click(object sender, EventArgs e)
		{
			//range is between median and (median + 10)
			median += 10;
			
			//count
			count ++;
			numberOfGuessesLabel.Text = count.ToString();
			
			//display guess in label
			numberLabel.Text = median.ToString();
		
		}
		
		void CorrectGuessButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Yay! Want to play again? Press the 'New Game' button.");
		}
		
		void NewGameButton_Click(object sender, EventArgs e)
		{
			//reset count and median
			count = 0;
			median = 50;
			
			//reset labels
			numberOfGuessesLabel.Text = count.ToString();
			numberLabel.Text = "";
		}
		
		void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}