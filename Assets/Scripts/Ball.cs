using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Transform paddle;
    private bool hasLaunched = false;
    private Rigidbody2D rigidbody;
    private AudioSource audio;

    void Start () 
    {
        GameObject paddleObject = GameObject.FindGameObjectWithTag("Paddle");
        if (paddleObject != null)
        {
            paddle = paddleObject.transform;
        }

        rigidbody = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
	}
	
	void Update () 
    {
        if (!hasLaunched)
        {
            transform.position = paddle.position + new Vector3(0, 0.25f, 0);
            if (Input.GetButtonDown("Fire1"))
            {
                hasLaunched = true;
                rigidbody.velocity += new Vector2(2,8);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (hasLaunched)
        {
            Vector2 randomBounce = new Vector3(Random.Range(-0.5f, 0.5f), 0);
            if (other.collider.tag.Equals("Paddle"))
            {
                randomBounce.y = Random.Range(0.1f, 0.25f);
            }
            audio.Play();
            rigidbody.velocity += randomBounce;
        }
    }

    public void Reset()
    {
        hasLaunched = false;
        rigidbody.velocity = Vector2.zero;
    }
}
