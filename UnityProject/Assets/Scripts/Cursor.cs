using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
    [SerializeField] private Camera mainCamera;

    public Target.EColor eColor;

    private void OnMouseDrag() {
        transform.position = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
