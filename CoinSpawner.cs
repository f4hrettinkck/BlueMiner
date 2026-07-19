using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	public GameObject coin;

	public float aralik;

	public GameScript scriptGame;

	public float time;

	private Coroutine a;

	private void Start()
	{
		a = StartCoroutine(coinSpawn(time));
	}

	private void FixedUpdate()
	{
		if (scriptGame.lifechance == 0)
		{
			StopCoroutine(a);
		}
	}

	public IEnumerator coinSpawn(float time)
	{
		while (scriptGame.timer > 0)
		{
			Object.Instantiate(coin, new Vector3(Random.Range(0f - aralik, aralik), 6f, 0f), Quaternion.identity);
			yield return new WaitForSecondsRealtime(time);
		}
	}
}
