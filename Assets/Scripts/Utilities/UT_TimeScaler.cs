using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UT_TimeScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 20.0f;
        StartCoroutine(CusTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CusTimer()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(720);
            Time.timeScale = 1.0f;
            print(Time.timeScale);
            yield return new WaitForSecondsRealtime(120);
            Time.timeScale = 20.0f;
            print(Time.timeScale);
        }
    }
}
