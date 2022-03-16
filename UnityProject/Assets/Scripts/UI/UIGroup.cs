using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI {
    public class UIGroup : MonoBehaviour {
        protected GameManager gm;

        public bool IsActive { get; private set; }

        private void Awake() {
            gm = GameManager.Instance;
            IsActive = gameObject.activeSelf;
        }

        public void SetActive(bool value) {
            IsActive = value;
            gameObject.SetActive(value);
        }
    }
}
