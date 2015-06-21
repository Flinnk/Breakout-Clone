using UnityEngine;
using System.Collections;

public class MusicInstance : MonoBehaviour {

    static MusicInstance instance;

	void Start () 
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
	}
}
