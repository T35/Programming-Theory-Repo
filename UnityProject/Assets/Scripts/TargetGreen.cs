using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGreen : Target {
    public override EColor eColor => EColor.Green;

    private Vector3 scaleBackedUp;
    
    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChosenRightColor() {
        base.ChosenRightColor();

        scaleBackedUp = transform.localScale;
        transform.localScale += new Vector3(scaleBackedUp.x * 2, 0, 0);
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
