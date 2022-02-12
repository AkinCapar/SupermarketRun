using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManagerAkin : MonoBehaviour
{
    LevelManager levelmanger;
    SceneManagerAkin scenemanager;

    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI ingredient1AmountText;
    [SerializeField] private TextMeshProUGUI ingredient2AmountText;
    [SerializeField] private TextMeshProUGUI ingredient3AmountText;
    [SerializeField] private TextMeshProUGUI ingredient4AmountText;
    [SerializeField] private TextMeshProUGUI walletText;

    // Start is called before the first frame update
    void Start()
    {
        levelmanger = LevelManager.instance;
        scenemanager = SceneManagerAkin.instance;
    }

    // Update is called once per frame
    void Update()
    {
        walletText.text = levelmanger.wallet.ToString();
        ingredient1AmountText.text = "x" + levelmanger.ingredient1Amount.ToString();
        ingredient2AmountText.text = "x" + levelmanger.ingredient2Amount.ToString();
        ingredient3AmountText.text = "x" + levelmanger.ingredient3Amount.ToString();
        ingredient4AmountText.text = "x" + levelmanger.ingredient4Amount.ToString();
    }
}
