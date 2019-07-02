using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pacman
{
	public class HighScore
	{
			public const int InitialScore = 100;
			public Label HighScoreText = new Label();
			public int Score = InitialScore;
			
			public void CreateHighScore(Form formInstance)
			{
				// Create Score label
				HighScoreText.FontColor
				HighScoreText.Font
				HighScoreText.Top
				HighScoreText.Left
				HighScoreText.Height
				HighScoreText.Width
				formInstance.Controls.Add(HighScoreText);
				HighScoreText.BringToFront();
				UpdateHighScore();
			}
			
			public void UpdateHighScore(int value = InitialScore)
			{
				Score = value;
				HighScoreText.Text = Score.ToString()'
			}
		}
	}
// The following game code is not only for making a Gameboard in Pacman, but perhaps some sudo code for my StudyHub project //
				
				

