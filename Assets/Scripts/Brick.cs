using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{

    public int maxNumberHits = 0;
    public AudioClip destroySound;
    private int numberHits = 0;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals ("Ball"))
        {
            numberHits++;
            if (numberHits >= maxNumberHits)
            {
                AudioSource.PlayClipAtPoint(destroySound,transform.position,20);
                GameManager.instance.UpdateScore(10);
                Destroy(gameObject);
            }
        }
    }
}
