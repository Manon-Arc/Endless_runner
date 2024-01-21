using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text score;

    public int score_int = 0;

    public void UpdateScore(int a)
    {
        score_int += a;
        score.text = score_int.ToString();
    }
}