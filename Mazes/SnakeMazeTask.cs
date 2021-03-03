namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{			
			for (int i = 1; i <= height -2; i += 4)
            {								
				GoRightToSteps(robot, width - 2);				
				GoDownToSteps(robot, 2);
				GoLeftToSteps(robot, width - 2);
				if (i < (height - 2) - 2) GoDownToSteps(robot, 2);
			}
		}

		public static void GoLeftToSteps(Robot robot, int steps)
		{
			for (int i = 1; i < steps; i++)
				robot.MoveTo(Direction.Left);
		}

		public static void GoDownToSteps(Robot robot, int steps)
		{
			for (int i = 1; i <= steps; i++)
				robot.MoveTo(Direction.Down);
		}

		public static void GoRightToSteps(Robot robot, int steps)
		{
			for (int i = 1; i < steps; i++)
				robot.MoveTo(Direction.Right);
		}
	}
}