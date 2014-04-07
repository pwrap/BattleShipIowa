using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public Texture background;
	public Texture play;


	void OnGUI()
	{
		// Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);

		// Draw button
		if (GUI.Button (new Rect ((float)(Screen.width * 0.60), (float)(Screen.height * 0.60), (float)(Screen.width + play.width), (float)(Screen.height + play.height)), play, "")) 
		{
			Application.LoadLevel ("LevelSelect");
		}


	}
}