using UnityEngine;

public class PoopPlacer : MonoBehaviour
{
    public GameObject PoopPrefab;
    public void Place(Vector3 position)
    {
        //what, where, rotation
        // give it angle and don't rotate it
        Instantiate(PoopPrefab, position, Quaternion.identity); //if instantiating, must be a prefab
    }
}
