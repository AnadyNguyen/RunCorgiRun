using UnityEngine;

 public static class GameParameters //: MonoBehaviour is not a static class, so not possible
 {
     public static float CorgiMoveSpeed = 6f;
     
     public static float PoopSecondsOnScreen = 1f;
     public static float BeerSecondsOnScreen = 7f;
     public static float BoneSecondsOnScreen = 3f;
     public static float PillSecondsOnScreen = 1f;
     
     public static float BeerMinimumSecondsToWait = 1f;
     public static float BeerMaximumSecondsToWait = 3f;
     
     public static float BoneMinimumSecondsToWait = 2f;
     public static float BoneMaximumSecondsToWait = 5f;
     
     public static float PillMinimumSecondsToWait = 3f;
     public static float PillMaximumSecondsToWait = 6f;
 }
