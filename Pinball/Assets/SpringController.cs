using UnityEngine;
using System.Collections;

public class SpringController : MonoBehaviour 
{
    public int force = 200;
    public float MaxDistance = 3f;
	
	// Update is called once per frame
	void Update () 
    {
        if (GameManager.springPressed)
        {
            GetComponent<SpringJoint>().spring = 0;
            GetComponent<SpringJoint>().damper = 0;
            if (gameObject.transform.position.z > (GetComponent<SpringJoint>().connectedAnchor.z - MaxDistance))
            {
                GetComponent<Rigidbody>().AddForce(0, 0, -1 * force * Time.deltaTime);
            }
        }
        else
        {
            GetComponent<SpringJoint>().spring = 8000;
            GetComponent<SpringJoint>().damper = 10;
        }
	}
}
