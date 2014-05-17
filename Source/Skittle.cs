using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using AverageBuddy;

namespace KinectSkittles
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Skittle
	{
		#region Properties

		/// <summary>
		/// The color to draw this dude... add a bunch of colors and average them out
		/// </summary>
		public Averager<Vector3> AverageColor { get; set; }

		/// <summary>
		/// The location to draw this dude
		/// </summary>
		public Rectangle Location { get; set; }

		/// <summary>
		/// The amount to scale the rect when rendering it
		/// </summary>
		public float Scale { get; set; }

		#endregion //Properties

		#region Methods

		public Skittle(Rectangle loc)
		{
			Location = loc;
			Scale = 1.0f;
			AverageColor = new Averager<Vector3>(3, Vector3.Zero);
		}

		/// <summary>
		/// Get a rect to be rendered
		/// </summary>
		/// <returns></returns>
		public Rectangle RenderRect()
		{
			//move the X
			float scaleWidth = (Location.Width * Scale);
			int x = (int)(Location.X + scaleWidth);
			int y = (int)(Location.Y + scaleWidth);

			return new Rectangle(x, y, (int)scaleWidth, (int)scaleWidth);
		}

		#endregion //Methods
	}
}
