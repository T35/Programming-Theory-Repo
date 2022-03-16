using System;
using System.Collections;
using System.Collections.Generic;
using UI.Gameplay;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gameplay : MonoBehaviour {
    private GameManager gm;

    public static Gameplay Instance;

    [SerializeField] private TargetBlue targetBlue;
    [SerializeField] private TargetGreen targetGreen;
    [SerializeField] private TargetRed targetRed;
    [SerializeField] private TargetYellow targetYellow;
    [SerializeField] private Cursor cursor;
    
    [SerializeField] public TopLeftGroup UITopLeft;

    private readonly List<Target> targets = new List<Target>();

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
        
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
        Target tmpTarget = targets[Random.Range(0, targets.Count)];
        cursor.GetComponent<SpriteRenderer>().color = tmpTarget.GetRealColor();
        cursor.eColor = tmpTarget.eColor;
    }

    private void DefaultDataForTest() {
        gm.data.SetPlayerNickname("TestPlayer");
    }
}
