using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
		
	private float elapsedTime = 0;
	private bool isFinished = false;

	void Update()
    {
		// If all four goals are solved then the game is over
		isFinished = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

		if (!isFinished)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
	}

	
	void OnGUI()
    {
        if (isFinished)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");

			GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());	
		}
		else
		{
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
		
	}
}