using UnityEngine;
using System.Collections;

public class MissionResultsData : MonoBehaviour {

	public static MissionResultsData results;

	private int levelScore;
	private int accuracy;
	private float missionTime;
	private int secretsFound;
	private int secrets;
	private int shellsUsed;

	public int Score{ get{ return levelScore; } set { levelScore = value; } }
	public int Accuracy { get{ return accuracy; } set { accuracy = value; }}
	public float MissionLength { get { return missionTime; } set { missionTime = value; } }
	public int SecretsFoundInLevel  { get { return secretsFound; } set { secretsFound = value; } }
	public int SecretsInLevel  { get { return secrets; } set { secrets = value; } }
	public int ShotsFired { get { return shellsUsed; } set { shellsUsed = value; } }


	void Awake()
	{
		if(results != null)
		{
			GameObject.Destroy(this);
		}
		else
		{
			results = this;
		}
		DontDestroyOnLoad (this);
	}
}
