using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject l_paddle;
    public GameObject r_paddle;

    public GameObject l_paddle_rot_point;
    public GameObject r_paddle_rot_point;

    Transform r_paddle_start;
    Transform l_paddle_start;


    public static int score;

	// Use this for initialization
	void Start () {
        score = 0;
        r_paddle_start = r_paddle.transform;
        l_paddle_start = l_paddle.transform;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            l_paddle.transform.RotateAround(l_paddle_rot_point.transform.position, l_paddle.transform.up, -50);
        }
        else
        {
            print("should reset left paddle");
            l_paddle.transform.rotation = l_paddle_start.rotation;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            r_paddle.transform.RotateAround(r_paddle_rot_point.transform.position, r_paddle.transform.up, 50);
        }
        else
        {
            print("should reset right paddle");
            r_paddle.transform.rotation = r_paddle_start.rotation;
        }
	}
}
