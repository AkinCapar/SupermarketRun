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

    private void Start()
    {
        myCollider = gameObject.GetComponent<Collider>();
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
        if(collision.gameObject.tag == "Player")
        {
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
}
