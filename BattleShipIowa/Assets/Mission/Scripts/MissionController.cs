using UnityEngine;
using System.Collections;

public class MissionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Time.realtimeSinceStartup;
		if(Time.timeSinceLevelLoad > 10.0)
		{
			//creating random results
			MissionResultsData.results.MissionLength = Time.timeSinceLevelLoad;
			MissionResultsData.results.Score = Random.Range(0, 5000);
			MissionResultsData.results.SecretsFoundInLevel = Random.Range(0, 3);
			MissionResultsData.results.SecretsInLevel = Random.Range(3, 5);
			MissionResultsData.results.ShotsFired = Random.Range(100, 350);
			MissionResultsData.results.Accuracy = Random.Range(0, 100);


			//display results window
			//Application.loadLevel("Results");
		}
	}
}
