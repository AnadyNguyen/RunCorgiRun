using System.Collections;
using UnityEngine;

public class BeerPlacers : MonoBehaviour
{
    public GameObject BeerPrefab;

    public void Update()
    {
        StartCoroutine(CountDownUntilCreation());
    }
    
    IEnumerator CountDownUntilCreation()
    {
        yield return new WaitForSeconds(3f);
        Place();
    }
    

    public void Place()
    {
        Instantiate(BeerPrefab, SpawnTools.RandomLocationWorldSpace(),
            Quaternion.identity);
    }
}
