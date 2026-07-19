using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
	public int timer;

	public int score;

	public Text ScoreText;

	public int lifechance = 3;

	private void Start()
	{
		score = 0;
		ScoreText.text = score.ToString();
	}

	public void upScoreForDia()
	{
		score += 5;
		ScoreText.text = score.ToString();
	}

	public void upScore()
	{
		score++;
		ScoreText.text = score.ToString();
	}
}
