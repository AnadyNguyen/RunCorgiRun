using UnityEngine;

public class PoopPlacer : MonoBehaviour
{
    public GameObject PoopPrefab;
    public void Place(Vector3 position)
    {
        //what, where, rotation
        Instantiate(PoopPrefab, position, Quaternion.identity); //if instantiating, must be a prefab
    }
}
