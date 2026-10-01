using System.Collections;
using UnityEngine;


public class Poop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start death clock
        StartCoroutine(routine:CountdownUntilDeath());
    }

    IEnumerator CountdownUntilDeath()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject); //lowercase is thing attached ot GameObject
    }
    //countdown go away
    
}
