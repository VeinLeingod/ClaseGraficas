using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource as1;
    public AudioSource as2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(sound1());
        }
    }

    IEnumerator sound1()
    {
        as1.Play();
        while(as1.isPlaying)
        {
            print("Playing s1");
            yield return null;
        }
        print("Stop s1 sound");

        as2.Play();
        while(as2.isPlaying)
        {
            print("Playing s2");
            yield return null;
        }
        print("Stop s2 sound");
    }
}
