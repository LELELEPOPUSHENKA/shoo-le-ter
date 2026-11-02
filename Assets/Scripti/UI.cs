using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Igrok player;
    public TextMeshProUGUI pointsText;
    public GameObject defeatUI;

    void Start()
    {
        if (defeatUI != null) defeatUI.SetActive(false);
    }

    void Update()
    {
        if (player != null && player.gameObject.activeSelf)
        {
            pointsText.text = player.points.ToString();
        }
        else
        {
            if (defeatUI != null) defeatUI.SetActive(true);
        }
    }

    public void OnClickRestart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}