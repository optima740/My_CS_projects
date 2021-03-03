namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			
			void GoDownToSteps(int steps)
            {
				for (int i = 1; i < steps; i++)
				robot.MoveTo(Direction.Down);
            }

			void GoRightToSteps(int steps)
			{
				for (int i = 1; i < steps; i++)
				robot.MoveTo(Direction.Right);
			}			
			GoDownToSteps(height - 2);
			GoRightToSteps(width - 2);
		}

	}
}