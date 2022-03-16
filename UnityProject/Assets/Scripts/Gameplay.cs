using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gameplay : MonoBehaviour {
    private GameManager gm;
    
    [SerializeField] private TargetBlue targetBlue;
    [SerializeField] private TargetGreen targetGreen;
    [SerializeField] private TargetRed targetRed;
    [SerializeField] private TargetYellow targetYellow;
    [SerializeField] private Cursor cursor;

    private readonly List<Target> targets = new List<Target>();

    private void Awake() {
        gm = GameManager.Instance;

        if (gm.scenes.IsFirstLaunched()) {
            DefaultDataForTest();
        }
        
        targets.Add(targetBlue);
        targets.Add(targetGreen);
        targets.Add(targetRed);
        targets.Add(targetYellow);
    }

    private void Start() {
        cursor.GetComponent<SpriteRenderer>().color = targets[Random.Range(0, targets.Count)].GetRealColor();
    }

    private void DefaultDataForTest() {
        gm.data.SetPlayerNickname("TestPlayer");
    }
}
