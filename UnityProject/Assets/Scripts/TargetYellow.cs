using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetYellow : Target {
    public override EColor eColor => EColor.Yellow;

    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChosenRightColor() {
        base.ChosenRightColor();
        
        transform.Rotate(Vector3.forward, 45f);
    }

    /// <summary>
    /// // POLYMORPHISM
    /// </summary>
    public override void ChoiceBack() {
        if (isRightChoice) {
            transform.rotation = Quaternion.identity;
        }

        base.ChoiceBack();
    }
}
