using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Gameplay {
    public class Indicator : MonoBehaviour {
        private Image panel;

        [SerializeField] private Color colorDefault;
        [SerializeField] private Color colorRight;
        [SerializeField] private Color colorWrong;

        private void Awake() {
            panel = gameObject.GetComponent<Image>();
            IndicateNot();
        }

        private void SetPanelColor(Color color) {
            panel.color = color;
        }

        public void IndicateNot() {
            SetPanelColor(colorDefault);
        }
        
        public void IndicateRight() {
            SetPanelColor(colorRight);
        }

        public void IndicateWrong() {
            SetPanelColor(colorWrong);
        }
    }
}
