using UnityEngine;
using System.Collections;

public class SaveScript : MonoBehaviour {

	string[] RancorStats;

	// Use this for initialization
	void Start ()
	{
		RancorStats = new string[4];
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("p"))
		{
			Save();
		}
		else if (Input.GetKeyDown("o"))
		{
			Load();
		}
	}

	void Save()
	{
		RancorStats[0] = PlayerManager.maxHP.ToString();
		RancorStats[1] = PlayerManager.currentHP.ToString();
		RancorStats[2] = PlayerManager.maxMana.ToString();
		RancorStats[3] = PlayerManager.currentMana.ToString();

		System.IO.File.WriteAllLines(@"C:\Users\110342\Desktop\SaveRancor.txt", RancorStats);
	}

	void Load()
	{
		if (System.IO.File.ReadAllLines(@"C:\Users\110342\Desktop\SaveRancor.txt") != null) //make sure it exists
		{
			RancorStats = System.IO.File.ReadAllLines(@"C:\Users\110342\Desktop\SaveRancor.txt");
			PlayerManager.maxHP = System.Convert.ToInt32(RancorStats[0]);
			PlayerManager.currentHP = System.Convert.ToInt32(RancorStats[1]);
			PlayerManager.maxMana = System.Convert.ToInt32(RancorStats[2]);
			PlayerManager.currentMana = System.Convert.ToInt32(RancorStats[3]);
		}
    }
}
