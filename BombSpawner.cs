using System.Collections;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
	public GameObject Bomb;

	public float aralik;

	public float time;

	private Coroutine a;

	public GameScript ScriptGame;

	private void Start()
	{
		a = StartCoroutine(SpawnBomb(time));
	}

	private void FixedUpdate()
	{
		if (ScriptGame.lifechance == 0)
		{
			StopCoroutine(a);
		}
	}

	public IEnumerator SpawnBomb(float time)
	{
		while (ScriptGame.timer > 0)
		{
			Object.Instantiate(Bomb, new Vector3(Random.Range(0f - aralik, aralik), 6f, 0f), Quaternion.identity);
			yield return new WaitForSecondsRealtime(time);
		}
	}
}
