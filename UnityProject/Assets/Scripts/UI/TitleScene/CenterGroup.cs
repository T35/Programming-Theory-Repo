using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI.TitleScene {
    public class CenterGroup : UIGroup {
        [SerializeField] private TMP_InputField nicknameInputField;

        private void Update() {
            if (IsActive) {
                if (Input.GetKeyUp(KeyCode.Return)) {
                    StartButton();
                }
            }
        }

        public void StartButton() {
            if (!gm.data.SetPlayerNickname(nicknameInputField.text)) {
                Debug.LogError("The Nickname must be 3 and 15 characters long. And start with a letter.");
                return;
            }

            gm.scenes.LoadGameplayScene();
        }
    }
}
