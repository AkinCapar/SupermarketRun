using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gate : MonoBehaviour
{
    public static Gate instance;

    [SerializeField] private GameObject prizeIngredient;
    [SerializeField] private int prizeIngredientAmount;
    [SerializeField] private int prizeMoneyAmount;
    [SerializeField] private GameObject prizeMoney;
    LevelManager levelmanager;

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
        levelmanager = LevelManager.instance;
    }


    public void PassedLeftGate()
    {
        if(prizeIngredient.gameObject.tag == "ingredient1")
        {
            levelmanager.ingredient1Amount -= prizeIngredientAmount-1; // -1 koydum çünkü zaten Collectable sctiptinden de bir tane eksiltiyor.
            levelmanager.wallet += levelmanager.ingredient1Cost;
        }

        if (prizeIngredient.gameObject.tag == "ingredient2")
        {
            levelmanager.ingredient2Amount -= prizeIngredientAmount-1;
            levelmanager.wallet += levelmanager.ingredient2Cost;
        }

        if (prizeIngredient.gameObject.tag == "ingredient3")
        {
            levelmanager.ingredient3Amount -= prizeIngredientAmount-1;
            levelmanager.wallet += levelmanager.ingredient3Cost;
        }

        if (prizeIngredient.gameObject.tag == "ingredient4")
        {
            levelmanager.ingredient4Amount -= prizeIngredientAmount-1;
            levelmanager.wallet += levelmanager.ingredient4Cost;
        }
    }

    public void PassedRightGate()
    {
        levelmanager.wallet += prizeMoneyAmount;
        PrizeMoneyAnimation();
    }

    private void PrizeMoneyAnimation()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(prizeMoney.transform.DOMove(transform.up * 3, .3f)
                                            .SetRelative()
                                            .SetEase(Ease.InOutSine)
                                            );

        sequence.Append(prizeMoney.transform.DORotate(new Vector3(0, 270, 90), .25f)
                                            .SetRelative()
                                            .SetEase(Ease.InOutSine)
                                            );
        sequence.Append(prizeMoney.transform.DOScale(0, .3f));
    }
}
