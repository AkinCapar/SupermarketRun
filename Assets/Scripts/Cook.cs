using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cook : MonoBehaviour
{
    LevelManager levelmanager;
    Gate gate;
    private int collectCount = 0;
    [SerializeField] public GameObject collectableVisuals1;
    [SerializeField] public GameObject collectableVisuals2;
    [SerializeField] public GameObject collectableVisuals3;
    [SerializeField] public GameObject collectableVisuals4;
    [SerializeField] public GameObject collectableVisuals5;
    [SerializeField] public GameObject collectableVisuals6;
    [SerializeField] public GameObject collectableVisuals7;
    [SerializeField] public GameObject collectableVisuals8;

    // Start is called before the first frame update
    void Start()
    {
        levelmanager = LevelManager.instance;
        gate = FindObjectOfType<Gate>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //malzemelerin ihtiyaçtan ve cüzdandaki paradan düşmesi
    {
        if(collision.gameObject.tag == "ingredient1" && levelmanager.wallet >= levelmanager.ingredient1Cost)
        {
            levelmanager.ingredient1Amount -= 1;
            //levelmanager.wallet -= levelmanager.ingredient1Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "ingredient2" && levelmanager.wallet >= levelmanager.ingredient2Cost)
        {
            levelmanager.ingredient2Amount -= 1;
            //levelmanager.wallet -= levelmanager.ingredient2Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "ingredient3" && levelmanager.wallet >= levelmanager.ingredient3Cost)
        {
            levelmanager.ingredient3Amount -= 1;
            //levelmanager.wallet -= levelmanager.ingredient3Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "ingredient4" && levelmanager.wallet >= levelmanager.ingredient4Cost)
        {
            levelmanager.ingredient4Amount -= 1;
            //levelmanager.wallet -= levelmanager.ingredient4Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if(collision.gameObject.name == "leftDoorPrize")
        {
            gate.PassedLeftGate();
        }

        if(collision.gameObject.name == "rightDoorPrize")
        {
            gate.PassedRightGate(collision.gameObject);
            Debug.Log("lolololo");
        }

        //buradan aşağıdakiler istenmeyen malzemeler bunlarla collision yapıldığında kırmızı negatif bi ifade koyacağız cüzdandan eksilirken
        if(collision.gameObject.tag == "nonIngredient1" && levelmanager.wallet >= levelmanager.nonIngredient1Cost)
        {
            //levelmanager.wallet -= levelmanager.nonIngredient1Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "nonIngredient2" && levelmanager.wallet >= levelmanager.nonIngredient2Cost)
        {
            //levelmanager.wallet -= levelmanager.nonIngredient2Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "nonIngredient3" && levelmanager.wallet >= levelmanager.nonIngredient3Cost)
        {
            //levelmanager.wallet -= levelmanager.nonIngredient3Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "nonIngredient4" && levelmanager.wallet >= levelmanager.nonIngredient4Cost)
        {
            //levelmanager.wallet -= levelmanager.nonIngredient4Cost;
            collectCount++;
            MarketCarVisuals();
        }

        if (collision.gameObject.tag == "obstacle")
        {
            transform.DOMove(-transform.forward * 5, .25f)
                     .SetRelative()
                     .SetEase(Ease.OutCubic);
        }
    }

    private void MarketCarVisuals()
    {
        if(collectCount == 3)
        {
            collectableVisuals1.SetActive(true);
        }

        if (collectCount == 5)
        {
            collectableVisuals2.SetActive(true);
        }

        if (collectCount == 7)
        {
            collectableVisuals3.SetActive(true);
        }

        if (collectCount == 9)
        {
            collectableVisuals4.SetActive(true);
        }

        if (collectCount == 11)
        {
            collectableVisuals5.SetActive(true);
        }

        if (collectCount == 13)
        {
            collectableVisuals6.SetActive(true);
        }

        if (collectCount == 16)
        {
            collectableVisuals7.SetActive(true);
        }

        if (collectCount == 18)
        {
            collectableVisuals8.SetActive(true);
        }
    }
}
