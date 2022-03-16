using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// // INHERITANCE
/// </summary>
public abstract class Target : MonoBehaviour {
    private SpriteRenderer sp;

    public enum EColor {
        Blue,
        Green,
        Red,
        Yellow
    }

    /// <summary>
    /// // ENCAPSULATION
    /// </summary>
    public abstract EColor color { get; }

    private void Awake() {
        sp = GetComponent<SpriteRenderer>();
    }

    public Color GetRealColor() {
        return sp.color;
    }
}
