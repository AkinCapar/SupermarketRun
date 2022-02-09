using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collectable : MonoBehaviour
{
    [SerializeField] public Transform collectingPlace;
    private Collider myCollider;
    [SerializeField] float moveTowardsSpeed;
    private bool collected = false;
    private int cost;
    LevelManager levelmanager;

    private void Start()
    {
        levelmanager = LevelManager.instance;
        myCollider = gameObject.GetComponent<Collider>();
        CheckingWhichIngredient();
    }

    private void Update()
    {
        if (collected == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, collectingPlace.position, moveTowardsSpeed * 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && cost <= levelmanager.wallet)
        {
            levelmanager.wallet -= cost;
            myCollider.enabled = false;
            MoveToCarSequence();
            Scaling();
            collected = true;
        }
    }

    private void MoveToCarSequence()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(
            transform.DOMove(Vector3.up * 3, .25f)
                     .SetRelative()
                     .SetEase(Ease.InOutSine)                     
            );
    }

    private void Scaling()
    {
        transform.DOScale(0, 2);
    }


    private void CheckingWhichIngredient()
    {
        if (gameObject.tag == "ingredient1")
        {
            cost = levelmanager.ingredient1Cost;
        }

        if (gameObject.tag == "ingredient2")
        {
            cost = levelmanager.ingredient2Cost;
        }

        if (gameObject.tag == "ingredient3")
        {
            cost = levelmanager.ingredient3Cost;
        }

        if (gameObject.tag == "ingredient4")
        {
            cost = levelmanager.ingredient4Cost;
        }

        if (gameObject.tag == "nonIngredient1")
        {
            cost = levelmanager.nonIngredient1Cost;
        }

        if (gameObject.tag == "nonIngredient2")
        {
            cost = levelmanager.nonIngredient2Cost;
        }

        if(gameObject.tag == "nonIngredient3")
        {
            cost = levelmanager.nonIngredient3Cost;
        }

        if (gameObject.tag == "nonIngredient4")
        {
            cost = levelmanager.nonIngredient4Cost;
        }
    }

}
