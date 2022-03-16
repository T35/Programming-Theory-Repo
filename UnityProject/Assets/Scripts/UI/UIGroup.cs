using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI {
    public class UIGroup : MonoBehaviour {
        public bool IsActive { get; private set; }

        protected void Awake() {
            IsActive = gameObject.activeSelf;
        }

        public void SetActive(bool value) {
            IsActive = value;
            gameObject.SetActive(value);
        }
    }
}
