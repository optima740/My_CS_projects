using System;
namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{			
			var stepsToLong = (int)Math.Round(Math.Max((double)width, (double)height) / Math.Min((double)width, (double)height));
			for (int i = 1; i < Math.Max(width, height) - 2; i += stepsToLong)
            {			
				if (height < width)
				{
					GoRightToSteps(robot, stepsToLong);
					if (i < (Math.Max(width, height) - 2) - stepsToLong)
						GoDownToSteps(robot, 1);
				}
				else if (width < height)
				{
					GoDownToSteps(robot, stepsToLong);
					if (i < (Math.Max(width, height) - 2) - stepsToLong)
						GoRightToSteps(robot, 1);
				}
				else
				{
					GoDownToSteps(robot, stepsToLong);
					if (i < (Math.Max(width, height) - 2) - stepsToLong)
						GoRightToSteps(robot, stepsToLong);
				}						
			}
		}
		public static void GoDownToSteps(Robot robot, int steps)
		{
			for (int i = 1; i <= steps; i++)
				robot.MoveTo(Direction.Down);
		}

		public static void GoRightToSteps(Robot robot, int steps)
		{
			for (int i = 1; i <= steps; i++)
				robot.MoveTo(Direction.Right);
		}
	}
}