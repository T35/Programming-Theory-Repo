using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {
    private GameManager _gm;

    private void Awake() {
        _gm = GameManager.Instance;
    }
}
