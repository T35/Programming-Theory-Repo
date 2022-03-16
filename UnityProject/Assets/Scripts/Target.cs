using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// // INHERITANCE
/// </summary>
public abstract class Target : MonoBehaviour {
    private SpriteRenderer sp;
    private BoxCollider2D boxCollider;

    public enum EColor {
        Blue,
        Green,
        Red,
        Yellow
    }

    /// <summary>
    /// // ENCAPSULATION
    /// </summary>
    public abstract EColor eColor { get; }

    private void Awake() {
        sp = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public Color GetRealColor() {
        return sp.color;
    }

    protected void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Cursor cursor = other.GetComponent<Cursor>();

            if (eColor == cursor.eColor) {
                ChosenRightColor();
            }
            else {
                ChosenWrongColor();
            }
        }
    }

    protected void OnTriggerExit2D(Collider2D other) {
        ChoiceBack();
    }

    /// <summary>
    /// // ABSTRACTION
    /// </summary>
    public virtual void ChosenRightColor() {
        Gameplay.Instance.UITopLeft.indicator.IndicateRight();
    }

    /// <summary>
    /// // ABSTRACTION
    /// </summary>
    public virtual void ChosenWrongColor() {
        Gameplay.Instance.UITopLeft.indicator.IndicateWrong();
    }

    /// <summary>
    /// // ABSTRACTION
    /// </summary>
    public virtual void ChoiceBack() {
        Gameplay.Instance.UITopLeft.indicator.IndicateNot();
    }
}
