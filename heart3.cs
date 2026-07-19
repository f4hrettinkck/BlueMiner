using UnityEngine;
using UnityEngine.UI;

public class heart3 : MonoBehaviour
{
	public Image heart;

	public Image heart2;

	public Image heartlast;

	public GameScript scriptGame;

	public void DownHeal()
	{
		if (scriptGame.lifechance == 2)
		{
			Color color = ((Graphic)heartlast).color;
			color.a = 0f;
			((Graphic)heartlast).color = color;
		}
		if (scriptGame.lifechance == 1)
		{
			Color color2 = ((Graphic)heart2).color;
			color2.a = 0f;
			((Graphic)heart2).color = color2;
		}
		if (scriptGame.lifechance == 0)
		{
			Color color3 = ((Graphic)heart).color;
			color3.a = 0f;
			((Graphic)heart).color = color3;
		}
	}
}
