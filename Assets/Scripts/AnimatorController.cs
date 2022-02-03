using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animOpen;
    public Animator animPingPong;
     public Animator animDance;
    [SerializeField] GameObject shineEffect;
    void Start()
    {
        StartCoroutine(PlayAnim());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animOpen.SetBool("Open", true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            animPingPong.SetBool("PingPong", true);
        }
    }

    IEnumerator PlayAnim()
    {
        animPingPong.SetBool("PingPong", true);
        yield return new WaitForSeconds(1.8f);
        animOpen.SetBool("Open", true);
        yield return new WaitForSeconds(1.5f);
        animDance.SetBool("Dance",true);
        shineEffect.SetActive(true);
    }
}
