using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour
{
    public GameObject ball;
    Vector3 BallStartPos;
    GameObject Blocker;
    // Use this for initialization
    void Start()
    {
        Blocker = GameObject.Find("Blocker");
        BallStartPos = ball.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            
            if (GameManager.lives >= 1)
            {
                other.gameObject.transform.position = BallStartPos;
                Blocker.GetComponent<MeshRenderer>().enabled = false;
                Blocker.GetComponent<BoxCollider>().isTrigger = true;
                GameManager.lives--;
            }
            else
            {
                //Game Over, change scene to game over
            }
        }
    }
}
