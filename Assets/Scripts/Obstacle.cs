using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{
    LevelManager levelmanager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ClosestCollectable();
        }
    }

    private void Start()
    {
        levelmanager = LevelManager.instance;
    }

    private void ClosestCollectable()
    {
        float distanceToClosestCollectable = Mathf.Infinity;
        Collectable closestCollectable = null;
        Collectable[] allCollectables = GameObject.FindObjectsOfType<Collectable>();

        foreach(Collectable currentCollectable in allCollectables)
        {
            float distanceToCollectable = (currentCollectable.transform.position - this.transform.position).sqrMagnitude;
            if(distanceToCollectable < distanceToClosestCollectable)
            {
                distanceToClosestCollectable = distanceToCollectable;
                closestCollectable = currentCollectable;
            }
        }

        arrangeLostNeed(closestCollectable);
        lostCollectableMoveAnimation(closestCollectable);
        lostCollectableScaleAnimation(closestCollectable);
     
    }

    private void lostCollectableMoveAnimation(Collectable closestCollectable)
    {
        var sequence = DOTween.Sequence();

        sequence.Append(closestCollectable.transform.DOMove( new Vector3(Random.Range(-10,10), 5, Random.Range(-10,10)), 1)
                                                    .SetRelative()
                                                    .SetEase(Ease.InOutSine));

        sequence.Append(closestCollectable.transform.DOMove(-transform.up * 50, 2.5f)
                                                    .SetRelative()
                                                    .SetEase(Ease.InOutSine));

        closestCollectable.GetComponent<Collectable>().enabled = false; // kaybettiğini tekrar kaybedemesin diye
    }

    private void lostCollectableScaleAnimation(Collectable closestCollectable)
    {
        closestCollectable.transform.DOScale(.4f, 1);
    }

    private void arrangeLostNeed(Collectable closestCollectable) //kaybedilen malzemenin ihtiyaç sayısını arttırmak için
    {
        if (closestCollectable.gameObject.tag == "ingredient1")
        {
            levelmanager.ingredient1Amount += 1;
        }

        if (closestCollectable.gameObject.tag == "ingredient2")
        {
            levelmanager.ingredient2Amount += 1;
        }

        if (closestCollectable.gameObject.tag == "ingredient3")
        {
            levelmanager.ingredient3Amount += 1;
        }

        if (closestCollectable.gameObject.tag == "ingredient4")
        {
            levelmanager.ingredient4Amount += 1;
        }
    }
}
