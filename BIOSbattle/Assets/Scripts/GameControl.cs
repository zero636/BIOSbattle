using System;
using UnityEditor;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private PlayerControl _playerControl;

    [SerializeField] private GameObject defeatText;

    private bool playerDead;

    private void Update()
    {
        
        playerDead = _playerControl.Die();

        if (playerDead)
        {
            PlayerDead();
            Defeat();
            return;
        }
        
        PlayerLive();
    }


    private void PlayerLive()
    {
        Time.timeScale = 1;
    }

    private void PlayerDead()
    {
        Time.timeScale = 0;
    }

    private void Defeat()
    {
        defeatText.SetActive(playerDead);
    }
    
    
}
