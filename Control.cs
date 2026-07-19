using UnityEngine;

public class Control : MonoBehaviour
{
	public int speed;

	public float jump;

	public AudioSource ClaimScore;

	public AudioSource Bomb;

	public AudioSource Effect;

	private Rigidbody2D character;

	private float movementdirect;

	public GameScript ScriptGame;

	public destroy destroyscript;

	public heart3 heal3;

	private bool characterdirection = true;

	private Animator PlayerAnimator;

	private void Start()
	{
		character = GetComponent<Rigidbody2D>();
		PlayerAnimator = GetComponent<Animator>();
	}

	private void FixedUpdate()
	{
		movementdirect = Input.GetAxis("Horizontal");
		PlayerAnimator.SetFloat("Speed", Mathf.Abs(movementdirect));
		if (PlayerAnimator.GetFloat("Speed") > 0f)
		{
			Effect.Play();
		}
		else
		{
			Effect.Stop();
		}
		character.velocity = new Vector2(movementdirect * (float)speed, character.velocity.y);
		if (!characterdirection && movementdirect > 0f)
		{
			Turn();
		}
		else if (characterdirection && movementdirect < 0f)
		{
			Turn();
		}
	}

	public void Turn()
	{
		characterdirection = !characterdirection;
		Vector3 localScale = base.transform.localScale;
		localScale.x *= -1f;
		base.transform.localScale = localScale;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "upscorefordia")
		{
			ScriptGame.upScoreForDia();
			PlaySoundforScore();
		}
		if (collision.gameObject.tag == "upscore")
		{
			ScriptGame.upScore();
			PlaySoundforScore();
		}
		if (collision.gameObject.tag == "bomb")
		{
			ScriptGame.lifechance--;
			heal3.DownHeal();
			PlaySoundforBomb();
		}
	}

	public void PlaySoundforScore()
	{
		ClaimScore.Play();
	}

	public void PlaySoundforBomb()
	{
		Bomb.Play();
	}
}
