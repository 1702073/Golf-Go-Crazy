using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Coroutine myCoroutine;
    Coroutine mySecondCoroutine;
    private void Start()
    {
        if (myCoroutine != null)
        {
        StopAllCoroutines(); // Only effect Coroutines started by the script with this
        StopCoroutine(MyCoroutine(5));
        }

    }
    IEnumerator MyCoroutine(int countLimit) // Similar to Async but have stopping points while Async work in the background
    {
        // You need a yield command if you dont want a error for the Coroutine
        int i = 0;
        while (i < countLimit)
        {
            i++;
            Debug.Log(i);
            yield return new WaitForSeconds(1); // Wait a number of desonds before doing the Coroutine again
            //yield return null; // Wait for one frame before doing the coroutine again
            //yield return new WaitForEndOfFrame(); // This waits until the frame is over befpr talomg an action good for screemshot and the like
            //yield return new WaitUntil(Bool); // Use Delegate instead if traditional check
            //yield return StartCoroutine(MySecondCoroutine()); // Start a diffrent Coroutine and then eait uintil it's over to continue it's coding magic
            // Coroutines automatically stop once it reaches the end
            //yield break; // Ends the Coroutine early 
        }
        Debug.Log("Im done with this biz");
    }
    IEnumerator MySecondCoroutine(int noblePeacePrizesInMyPossetion = 18)
    {
        int i = 0;
        while (i < 4)
        {
            i++;
            Debug.Log("I am the coding master and have this many nobel peace prizes " + noblePeacePrizesInMyPossetion);
            yield return StartCoroutine(MySecondCoroutine());
        }
    }
}
