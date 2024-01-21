using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    GameManager score_game;

    GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        score_game = gameManager.GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("obstacle"))
        {
            PlayerPrefs.SetInt("Score", score_game.score_int);
            SceneManager.LoadScene("GameOver");
        }

        if (col.gameObject.CompareTag("coin"))
        {
            Destroy(col.gameObject);
            score_game.UpdateScore(2);
        }
    }
}
