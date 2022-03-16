using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Data : MonoBehaviour {
    private GameManager gm;

    /// <summary>
    /// // ENCAPSULATION
    /// </summary>
    public string playerNickname { get; private set; }

    private void Awake() {
        gm = GameManager.Instance;
    }

    public bool SetPlayerNickname(string newPlayerNickname) {
        if (!Regex.IsMatch(newPlayerNickname, "^[a-zA-Zа-яА-Я]\\w{2,14}$")) {
            return false;
        }

        playerNickname = newPlayerNickname;
        return true;
    }
}
