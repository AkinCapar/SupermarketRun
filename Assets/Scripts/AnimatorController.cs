using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animOpen;
    public Animator animPingPong;
     public Animator animDance;
    [SerializeField] GameObject shineEffect;
    [SerializeField] GameObject confettiParticleEffect1;
    [SerializeField] GameObject confettiParticleEffect2;
    [SerializeField] GameObject cooker;
    [SerializeField] private Cinemachine.CinemachineVirtualCamera firstCamera;
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
        // animDance.SetBool("Dance",true);
        shineEffect.SetActive(true);
        confettiParticleEffect1.SetActive(true);
        confettiParticleEffect2.SetActive(true);

        yield return new WaitForSeconds(1f);

        // camera degis
        firstCamera.enabled = false;
         yield return new WaitForSeconds(0.5f);
        cooker.SetActive(true);
        animDance.SetBool("Dance",true);
        shineEffect.transform.position = new Vector3(0.04f, 0.04f, -2.9f);
        
    }
}