using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour {

    public float speed;

    public float minLimit;
    public float maxLimit;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () 
    {
        float direction = Input.GetAxis("Horizontal");
        Move(direction);
	}

    void Move(float direction)
    {
        Vector3 movementVector = new Vector3(direction * speed, 0, 0);
        transform.position += movementVector;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minLimit, maxLimit), transform.position.y, transform.position.z);
    }
}
