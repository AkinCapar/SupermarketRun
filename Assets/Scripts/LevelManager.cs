using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [Header("Ingredients")]
    [SerializeField] public GameObject ingredient1;
    [SerializeField] public GameObject ingredient2;
    [SerializeField] public GameObject ingredient3;
    [SerializeField] public GameObject ingredient4;

    [Header("Ingredients Amount & Costs")]
    [SerializeField] public int ingredient1Amount;
    [SerializeField] public int ingredient1Cost;
    [SerializeField] public int ingredient2Amount;
    [SerializeField] public int ingredient2Cost;
    [SerializeField] public int ingredient3Amount;
    [SerializeField] public int ingredient3Cost;
    [SerializeField] public int ingredient4Amount;
    [SerializeField] public int ingredient4Cost;

    [Header("Non-Ingredients")]
    [SerializeField] public GameObject nonIngredient1;
    [SerializeField] public GameObject nonIngredient2;
    [SerializeField] public GameObject nonIngredient3;
    [SerializeField] public GameObject nonIngredient4;

    [Header("Non-Ingredients Costs")]
    [SerializeField] public int nonIngredient1Cost;
    [SerializeField] public int nonIngredient2Cost;
    [SerializeField] public int nonIngredient3Cost;
    [SerializeField] public int nonIngredient4Cost;

    [SerializeField] public int wallet;
    [SerializeField] public TextMeshProUGUI shoppingList;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WinOrLoseCondition()
    {
        if (ingredient1Amount == 0 && ingredient2Amount == 0 && ingredient3Amount == 0 && ingredient4Amount == 0 && wallet >= 0)
        {
            // WIN
            //TODO finish noktasını geçince yemeği yapabilecek
        }

        else
        {
            //dandik bozuk yemek görünecek
        }

    }

}
