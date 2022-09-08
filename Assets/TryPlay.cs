using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Birds");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
