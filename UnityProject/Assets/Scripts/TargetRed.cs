using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRed : Target {
    public override EColor eColor => EColor.Red;
    
    private Vector3 scaleBackedUp;
    
    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChosenRightColor() {
        base.ChosenRightColor();

        scaleBackedUp = transform.localScale;
        transform.localScale += new Vector3(0, scaleBackedUp.x * 2, 0);
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
