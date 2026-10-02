using UnityEngine;

public class bone : TimedObject
{
    public void Start()
    {
        secondsOnScreen = GameParameters.BoneSecondsOnScreen;
        base.Start();
    }
}
