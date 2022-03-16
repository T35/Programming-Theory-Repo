using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlue : Target {
    public override EColor eColor => EColor.Blue;

    private Vector3 scaleBackedUp;
    
    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChosenRightColor() {
        base.ChosenRightColor();

        scaleBackedUp = transform.localScale;
        transform.localScale *= 2;
    }

    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChoiceBack() {
        if (isRightChoice) {
            transform.localScale = scaleBackedUp;
        }

        base.ChoiceBack();
    }
}
