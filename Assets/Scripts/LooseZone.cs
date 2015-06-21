using UnityEngine;
using System.Collections;

public class LooseZone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D ball)
    {
        GameManager.instance.UpdateLives(-1);
    }
}
