using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour {
    protected GameManager gm;
    
    [SerializeField] private GameObject uiObject;

    public bool IsActive { get; private set; }

    private void Awake() {
        gm = GameManager.Instance;
        SetActive(uiObject.activeSelf);
    }
    
    public void SetActive(bool value) {
        IsActive = value;
        uiObject.SetActive(value);
    }
}
