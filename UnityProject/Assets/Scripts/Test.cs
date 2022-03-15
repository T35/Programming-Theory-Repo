using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour {
    private GameManager gm;

    [SerializeField] private TMP_Text testText;
    
    private void Awake() {
        gm = GameManager.Instance;
    }

    private void Start() {
        testText.text = gm.data.playerNickname;
    }
}
