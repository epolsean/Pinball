using UnityEngine;
using System.Collections;

public class PostSpringStopper : MonoBehaviour 
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
