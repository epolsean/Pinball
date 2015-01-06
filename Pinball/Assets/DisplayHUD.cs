using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayHUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        GetComponent<Text>().text = "LIVES REMAINING : " + GameManager.lives + "\n SCORE : " + GameManager.score;
	}
}
