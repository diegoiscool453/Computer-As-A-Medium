using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject gameOverUI;
    public GameObject enemyDialogueUI;
    public TextMeshProUGUI enemyDialogueText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameEnd();
    }

    void GameEnd()
    {
        if (playerHealth.health <= 0)
        {
            playerHealth.healthText.text = "Health: 0";
            player.SetActive(false);
            gameOverUI.SetActive(true);
        }
    }
        public void EnemySay(string line)
    {
        StartCoroutine(EnemyDeathLine(line));
    }

    IEnumerator EnemyDeathLine(string line)
    {
        enemyDialogueUI.SetActive(true);
        enemyDialogueText.text = "";

        foreach (char c in line)
        {
            enemyDialogueText.text += c;
            yield return new WaitForSeconds(0.04f);
        }

        yield return new WaitForSeconds(2f);
        enemyDialogueUI.SetActive(false);
    }

}
