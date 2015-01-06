using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject l_paddle;
    public GameObject r_paddle;

    public GameObject l_paddle_rot_point;
    public GameObject r_paddle_rot_point;

    Quaternion r_paddle_start_Rotation;
    Quaternion l_paddle_start_Rotation;
    Vector3 r_paddle_start_Position;
    Vector3 l_paddle_start_Position;

    Quaternion r_paddle_end_Rotation;
    Quaternion l_paddle_end_Rotation;
    Vector3 r_paddle_end_Position;
    Vector3 l_paddle_end_Position;


    public static int score = 0;
    public static int lives = 3;

	// Use this for initialization
	void Start () {
        score = 0;

        r_paddle_start_Position = r_paddle.transform.position;
        l_paddle_start_Position = l_paddle.transform.position;
        r_paddle_start_Rotation = r_paddle.transform.rotation;
        l_paddle_start_Rotation = l_paddle.transform.rotation;

        l_paddle.transform.RotateAround(l_paddle_rot_point.transform.position, l_paddle.transform.up, -50);
        r_paddle.transform.RotateAround(r_paddle_rot_point.transform.position, r_paddle.transform.up, 50);
        //r_paddle_start_Position = new Quaternion(0.7f, -0.2f, 0.2f, 0.7f);
        //l_paddle_start_Position = new Quaternion(-0.7f, -0.2f, 0.2f, 0.7f);
        //r_paddle_end_Position = new Vector3();
        //l_paddle_end_Position = new Vector3();
        r_paddle_end_Position = r_paddle.transform.position;
        l_paddle_end_Position = l_paddle.transform.position;
        r_paddle_end_Rotation = r_paddle.transform.rotation;
        l_paddle_end_Rotation = l_paddle.transform.rotation;

        l_paddle.transform.RotateAround(l_paddle_rot_point.transform.position, l_paddle.transform.up, 50);
        r_paddle.transform.RotateAround(r_paddle_rot_point.transform.position, r_paddle.transform.up, -50);
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            l_paddle.transform.rotation = Quaternion.Lerp(l_paddle.transform.rotation, l_paddle_end_Rotation, Time.deltaTime * 10f);
            l_paddle.transform.position = Vector3.Lerp(l_paddle.transform.position, l_paddle_end_Position, Time.deltaTime * 10f);
        }
        else
        {
            print("should reset left paddle");
            l_paddle.transform.rotation = Quaternion.Lerp(l_paddle.transform.rotation, l_paddle_start_Rotation, Time.deltaTime * 10f);
            l_paddle.transform.position = Vector3.Lerp(l_paddle.transform.position, l_paddle_start_Position, Time.deltaTime * 10f);
        }

        if (Input.GetKey(KeyCode.L))
        {
            r_paddle.transform.rotation = Quaternion.Lerp(r_paddle.transform.rotation, r_paddle_end_Rotation, Time.deltaTime * 10f);
            r_paddle.transform.position = Vector3.Lerp(r_paddle.transform.position, r_paddle_end_Position, Time.deltaTime * 10f);
        }
        else
        {
            print("should reset right paddle");
            r_paddle.transform.rotation = Quaternion.Lerp(r_paddle.transform.rotation, r_paddle_start_Rotation, Time.deltaTime * 10f);
            r_paddle.transform.position = Vector3.Lerp(r_paddle.transform.position, r_paddle_start_Position, Time.deltaTime * 10f);
        }
	}
}
