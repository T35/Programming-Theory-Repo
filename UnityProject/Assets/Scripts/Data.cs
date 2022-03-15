using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Data : MonoBehaviour {
    private GameManager _gm;

    public string playerNickname { get; private set; }

    private void Awake() {
        _gm = GameManager.Instance;
    }

    public bool SetPlayerNickname(string newPlayerNickname) {
        if (!Regex.IsMatch(newPlayerNickname, "^[a-zA-Zа-яА-Я]\\w{2,14}$")) {
            return false;
        }

        _gm.data.playerNickname = newPlayerNickname;
        return true;
    }
}
