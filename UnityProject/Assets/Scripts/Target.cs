using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// // INHERITANCE
/// </summary>
public abstract class Target : MonoBehaviour {
    protected SpriteRenderer sr;
    protected BoxCollider2D boxCollider;

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

    protected bool isChosen = false;
    protected bool isRightChoice = false;

    private void Awake() {
        sr = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public Color GetRealColor() {
        return sr.color;
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
    /// // POLYMORPHISM
    /// </summary>
    public virtual void ChosenRightColor() {
        isChosen = true;
        isRightChoice = true;
        Gameplay.Instance.UITopLeft.indicator.IndicateRight();
    }

    /// <summary>
    /// // ABSTRACTION
    /// </summary>
    public void ChosenWrongColor() {
        isChosen = true;
        isRightChoice = false;
        Gameplay.Instance.UITopLeft.indicator.IndicateWrong();
        
        Color newColor = sr.color;
        newColor.a = 0.5f;
        sr.color = newColor;
    }

    /// <summary>
    /// // ABSTRACTION
    /// // POLYMORPHISM
    /// </summary>
    public virtual void ChoiceBack() {
        if (!isRightChoice) {
            Color newColor = sr.color;
            newColor.a = 1f;
            sr.color = newColor;
        }
        
        isChosen = false;
        isRightChoice = false;
        Gameplay.Instance.UITopLeft.indicator.IndicateNot();
    }
}
