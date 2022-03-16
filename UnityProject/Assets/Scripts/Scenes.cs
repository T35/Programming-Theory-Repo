using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {
    public int firstLaunchedSceneIndex = -1;
    public int previousSceneIndex = -1;

    public enum SceneNames {
        TitleScreen = 0,
        Gameplay = 1
    }
    
    private void Awake() {
        firstLaunchedSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    
    private void PrepareLoadNewScene() {
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    
    public void LoadPreviousScene() {
        if (previousSceneIndex < 0) {
            Debug.LogError("No previous scene!");
            return;
        }
        LoadScene(previousSceneIndex);
    }

    public void LoadScene(SceneNames sceneName) {
        LoadScene((int)sceneName);
    }

    public void LoadScene(int sceneIndex) {
        PrepareLoadNewScene();
        SceneManager.LoadScene(sceneIndex);
    }

    public bool IsFirstLaunched() {
        return firstLaunchedSceneIndex == SceneManager.GetActiveScene().buildIndex;
    }
    
    public bool IsFirstLaunched(int sceneIndex) {
        return firstLaunchedSceneIndex == sceneIndex;
    }

    public void LoadGameplayScene() {
        LoadScene(SceneNames.Gameplay);
    }
}
