using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UT_MotoRotHandler : MonoBehaviour
{
    public GameObject rotorpref;
    public float rotspeed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotorpref.transform.Rotate(0, rotspeed, 0);
    }
}
