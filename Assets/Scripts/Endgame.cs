using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endgame : MonoBehaviour
{
    [SerializeField] public Text endTextScore;

    void Start()
    {
        endTextScore.text = PlayerPrefs.GetInt("scoreEnd").ToString();
    }
}
