using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScene : MonoBehaviour {
    [SerializeField] private GameObject prefabGameManager;

    private void Awake() {
        Instantiate(prefabGameManager);
    }
}
