using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    LevelManager levelmanager;

    // Start is called before the first frame update
    void Start()
    {
        levelmanager = LevelManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //malzemelerin ihtiyaçtan ve cüzdandaki paradan düşmesi
    {
        if(collision.gameObject.tag == "ingredient1")
        {
            levelmanager.ingredient1Amount -= 1;
            levelmanager.wallet -= levelmanager.ingredient1Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "ingredient2")
        {
            levelmanager.ingredient2Amount -= 1;
            levelmanager.wallet -= levelmanager.ingredient2Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "ingredient3")
        {
            levelmanager.ingredient3Amount -= 1;
            levelmanager.wallet -= levelmanager.ingredient2Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "ingredient4")
        {
            levelmanager.ingredient4Amount -= 1;
            levelmanager.wallet -= levelmanager.ingredient2Cost;
            collision.gameObject.SetActive(false);
        }

        //buradan aşağıdakiler istenmeyen malzemeler bunlarla collision yapıldığında kırmızı negatif bi ifade koyacağız cüzdandan eksilirken
        if(collision.gameObject.tag == "nonIngredient1")
        {
            levelmanager.wallet -= levelmanager.nonIngredient1Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "nonIngredient2")
        {
            levelmanager.wallet -= levelmanager.nonIngredient2Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "nonIngredient3")
        {
            levelmanager.wallet -= levelmanager.nonIngredient3Cost;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "nonIngredient4")
        {
            levelmanager.wallet -= levelmanager.nonIngredient4Cost;
            collision.gameObject.SetActive(false);
        }
    }
}
