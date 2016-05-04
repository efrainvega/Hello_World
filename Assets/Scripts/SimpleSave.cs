using UnityEngine;
using System.Collections;

public class SimpleSave : MonoBehaviour {
	
	static public int money = 100; //playerData index 0
	static public int level = 10; //playerData index 1
	static public int hp = 500; //playerData index 2
	string[] playerData;

	public GoldPiece[] goldPieces;
	bool[] piecesCollected;


	// Use this for initialization
	void Start ()
	{
		playerData = new string[3];
		playerData[0] = money.ToString();
		playerData[1] = level.ToString();
		playerData[2] = hp.ToString();

		int arraySize = goldPieces.Length;

		piecesCollected = new bool[arraySize];

		

	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown("v"))
		{
			SaveFile();
		}

		else if(Input.GetKeyDown("l"))
		{
			LoadFile();
		}
	}

	void SaveFile()
	{
		int count = 0;

        while (count < goldPieces.Length)
		{
			piecesCollected[count] = goldPieces[count].goldActive;

			count++;
        }


		//for (int count = 0; count < goldPieces.Length; count++)
		//{
		//	piecesCollected[count] = goldPieces[count].collected;
		//}

		System.IO.File.WriteAllLines(@"C:\Users\110342\Desktop\Classes\Unity\Little Alchemist\Assets\SaveTest.txt", playerData);
	}

	void LoadFile()
	{
		if (System.IO.File.ReadAllLines(@"C:\Users\110342\Desktop\Classes\Unity\Little Alchemist\Assets\SaveTest.txt") != null)
		{
			playerData = System.IO.File.ReadAllLines(@"C:\Users\110342\Desktop\Classes\Unity\Little Alchemist\Assets\SaveTest.txt");
			money = System.Convert.ToInt32(playerData[0]);
			level = System.Convert.ToInt32(playerData[1]);
			hp = System.Convert.ToInt32(playerData[2]);

		}

		int count = 0;

		while (count < goldPieces.Length)
		{
			goldPieces[count].gameObject.SetActive(piecesCollected[count]);

			count++;
		}
	}
}
