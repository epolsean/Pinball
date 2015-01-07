using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static bool leftPaddlePressed = false;
    public static bool rightPaddlePressed = false;
    public static bool springPressed = false;
    public static int score = 0;
    public static int lives = 3;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    public void SetLeftPaddle(bool state)
    {
        GameManager.leftPaddlePressed = state;
    }

    public void SetRightPaddle(bool state)
    {
        GameManager.rightPaddlePressed = state;
    }

    public void SetSpring(bool state)
    {
        GameManager.springPressed = state;
    }
}
