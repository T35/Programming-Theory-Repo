using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {
    private GameManager _gm;
    
    public int firstLaunchedSceneIndex = -1;
    public int previousSceneIndex = -1;

    private void Awake() {
        _gm = GameManager.Instance;
    }
    
    private void PrepareLoadNewScene() {
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    
    public void LoadPreviousScene() {
        int prevSceneIndex = previousSceneIndex;
        PrepareLoadNewScene();
        SceneManager.LoadScene(prevSceneIndex);
    }

    public bool IsFirstLaunched() {
        return firstLaunchedSceneIndex == SceneManager.GetActiveScene().buildIndex;
    }
    
    public bool IsFirstLaunched(int sceneIndex) {
        return firstLaunchedSceneIndex == sceneIndex;
    }
}
