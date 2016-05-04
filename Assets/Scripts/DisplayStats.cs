using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour {

	public Text Money;
	public Text Level;
	public Text HP;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Money.text = SimpleSave.money.ToString();
		Level.text= SimpleSave.level.ToString();
		HP.text = SimpleSave.hp.ToString();

	}
}
