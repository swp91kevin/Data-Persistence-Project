using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI readyText;
    public TextMeshProUGUI highScoreText;
    [SerializeField] private string nameText;


    // Start is called before the first frame update
    void Start()
    {
        HighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Starts a new game
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }


    public void NameInput(string nameInput)
    {
        nameText = nameInput;
        readyText.text = "Are you ready " + nameText + "?";
        DataPersistence.Instance.playerName = nameText;
    }

    public void HighScore()
    {
        highScoreText.text = "HIGH SCORE: " + DataPersistence.Instance.bestPlayer + " : " + DataPersistence.Instance.bestScore;
    }
}
