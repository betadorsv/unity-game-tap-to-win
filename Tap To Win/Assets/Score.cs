using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public TextMesh scoreText;
    public float scoreAmount;
    public float poinIncreasePerSecond;
    void Start()
    {
        scoreAmount = 0f;
        poinIncreasePerSecond = 2f;
        textMeshProUGUI = FindObjectOfType<TextMeshProUGUI>();
    }
    void Update()
    {
        textMeshProUGUI.SetText($"{(int)scoreAmount}");
        scoreAmount += poinIncreasePerSecond = Time.deltaTime;
    }
}
