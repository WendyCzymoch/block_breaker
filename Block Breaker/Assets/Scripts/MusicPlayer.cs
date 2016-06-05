using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instanceMusicPlayer = null;
	// Use this for initialization
	void Start () {
	    if (instanceMusicPlayer != null)
	    {
	        Destroy(gameObject);
	        print("Duplic music player self-destructing");
	    }
	    else
	    {
	        instanceMusicPlayer = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
