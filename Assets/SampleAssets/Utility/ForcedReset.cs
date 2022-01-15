using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ForcedReset : MonoBehaviour {
    [System.Obsolete]
    void Update () {
        
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            
            //... reload the scene
            Application.LoadLevelAsync (Application.loadedLevelName);
        }
    }

}
