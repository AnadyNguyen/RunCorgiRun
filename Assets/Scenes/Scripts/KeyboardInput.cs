using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    // Update is called once per frame
    public void Update()
    {
        //get buttons pressed
        Keyboard keyboard = Keyboard.current;
        if (keyboard.wKey.wasPressedThisFrame)
        {
            
        }
        else if (keyboard.sKey.wasPressedThisFrame)
        {
            
        }
        else if (keyboard.aKey.wasPressedThisFrame)
        {
            
        }
        else if (keyboard.dKey.wasPressedThisFrame)
        {
            
        }        
        //move target
    }
}
