using UnityEngine;

public class destroy : MonoBehaviour
{
	public float destroytime;

	public GameScript ScriptGame;

	private void Start()
	{
		Object.Destroy(base.gameObject, destroytime);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Object.Destroy(base.gameObject);
		}
	}
}
