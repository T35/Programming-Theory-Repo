using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI.Gameplay {
    public class TopRightGroup : UIGroup {
        [SerializeField] private TMP_Text playerNickname;

        private void Start() {
            playerNickname.text = gm.data.playerNickname;
        }
    }
}
