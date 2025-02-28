using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    // Unity events allow you to create generic scripts instead of repeating yourself across scripts
    public UnityEvent onTriggerEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Run each functions assigned in the inspectir
        onTriggerEnter.Invoke();
    }

    //for a funtion to be compatible with unity events it must be pubic, a void, and take a simple variable type.
    // By simple, I mean string, int, bool, or float 
    public void Switchscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
