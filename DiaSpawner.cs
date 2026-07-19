using System.Collections;
using UnityEngine;

public class DiaSpawner : MonoBehaviour
{
	public GameScript Script2;

	public GameObject dia;

	public float aralik;

	public int time;

	private Coroutine a;

	private void Start()
	{
		a = StartCoroutine(diaSpawn(time));
	}

	private void FixedUpdate()
	{
		if (Script2.lifechance == 0)
		{
			StopCoroutine(a);
		}
	}

	public IEnumerator diaSpawn(int time)
	{
		while (Script2.timer > 0)
		{
			Object.Instantiate(dia, new Vector3(Random.Range(0f - aralik, aralik), 6f, 0f), Quaternion.identity);
			yield return new WaitForSecondsRealtime(time);
		}
	}
}
