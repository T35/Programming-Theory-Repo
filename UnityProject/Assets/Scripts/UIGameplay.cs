using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameplay : UIController {
    [SerializeField] private TMP_Text playerNickname;

    private void Start() {
        playerNickname.text = gm.data.playerNickname;
    }
}
