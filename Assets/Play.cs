using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("V1");
        FindObjectOfType<AudioManager>().Play("V2");
        FindObjectOfType<AudioManager>().Play("V3");
        FindObjectOfType<AudioManager>().Play("V4");
        FindObjectOfType<AudioManager>().Play("V5");
        FindObjectOfType<AudioManager>().Play("V6");

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
