using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
	public class Ghost
	{
		private const int GhostAmount = 4;
		
		public int Ghosts = GhostAmount;
		private ImageList GhostImages = new ImageList();
		public PictureBox[] GhostImage = new PictureBox[GhostAmount];
		public int[] Stsate = new int[GhostAmount];
		private Timer timer = new Timer()'
		private Timer killabletimer = new Timer();
		private Timer statetimer = new Timer();
		private Timer hometimer = new Timer();
		public int[] xCoordinate = new int[GhostAmount];
		public int[] yCoordinate = new int[GhostAmount];
		private int[] xStart = new int[GhostAmount];
		private int[] yStart = new int[GhostAmount];
		public int[] Direction = new int[GhostAmount];
		private Random ran = new Random();
		private bool GhostOn = false;
		
		public Ghost()
        {
            GhostImages.Images.Add(Properties.Resources.Ghost_0_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_1_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_2_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_3_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_4);
            GhostImages.Images.Add(Properties.Resources.Ghost_5);

            GhostImages.ImageSize = new Size(27, 28);
						
						timer.Interval = 100;
						timer.Enabled = true;
						timer.Tick += new EventHandler(timer_Tick);
						
						killabletimer.Interval = 200;
						killabletimer.Enabled = false;
						killabletimer.Tick += new EventHandler(killabletimer_Tick);
						
						statetimer.Interval = 10000;
						statetimer.Enabled = false;
						statetimer.Tick += new EventHandler(statetimer_Tick);
						
						hometimer.Interval = 5;
						hometimer.Enabled = false;
						hometimer.Tick += new EventHandler(hometimer_Tick);
					}
					
					public void CreateGhostImage(Form formInstance)
					{
						// Create Ghost Image
						for (int x=0; x<Ghosts; x++)
						{
							GhostImage[x] = new PictureBox();
							GhostImage[x].Name = "GhostImage" + x.ToString();
							GhostImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
							formInstance.Controls.Add(GhostImage[x])'
							GhostImage[x].BringToFront();
						}
						Set_Ghosts();
						ResetGhosts();
					}
					
					public void Set_Ghosts()
					{
						// Find Ghost locations
						int Amount = -1;
						for (int y = 0; y < 30; x++)
						{
							for (int x = 0; x < 27; x++)
							{
							if (Form1.gameboard.Matrix[y, x] == 15)
							{
								Amount++;
								xStart[Amount] = x;
								yStart[Amount] = y;
							}
						}
					}
				}
				
				
		
		
