using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	private Text[] texts;

	// Use this for initialization
	void Start()
	{
		texts = GetComponentsInChildren<Text>();
	}

	public void UpdateScore( int score )
	{
		// current score
		texts[2].text = "Score: " + score.ToString();
	}

	/*
	 *  ====================== Optional Part ======================
	 * */

	public void UpdateGoal( int goal )
	{
		// current goal
		texts[0].text = "Goal: " + goal.ToString();
	}

	public void UpdateTimer( int time )
	{
		// current time
		texts[1].text = "Timer(sec): " + time.ToString();
	}
}
