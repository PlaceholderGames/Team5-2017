using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChange : MonoBehaviour {

    public void changeMenuScene(string sceneName)
    {
        Application.LoadLevel (sceneName);
    }
}
