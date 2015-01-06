using UnityEngine;
using System.Collections;

public class BounceController : MonoBehaviour {

    public float bounceStength = 100f;
    public int points = 10;
	void OnCollisionEnter (Collision other)
    {
        other.rigidbody.AddExplosionForce(bounceStength, this.transform.position, 5);
        GameManager.score += points;
    }
}
