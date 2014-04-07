using UnityEngine;
using System.Collections;

public class LevelSelectScript : MonoBehaviour {

	public Texture background;
	
	
	void OnGUI()
	{
		// Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		
	
	}
}
