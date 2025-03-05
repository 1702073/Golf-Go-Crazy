using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutines : MonoBehaviour
{
    Coroutine myCoroutine;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StopCoroutine(myCoroutine);
         myCoroutine = StartCoroutine(Mycoroutine(10));
    }

    IEnumerator Mycoroutine(int countLimit)
    {
        int i = 0;

        while (i < countLimit)
        {
            i++;
            Debug.Log(i);
            yield return new WaitForSeconds(1);
            //yield return null;
            //yield return new WaitForEndOfFrame;
            //yield return WaitUntil(i);
        }
        Debug.Log(" I'm done counting!");
    }
}
