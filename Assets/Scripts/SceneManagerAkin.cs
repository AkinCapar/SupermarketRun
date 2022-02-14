using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAkin : MonoBehaviour
{
    public static SceneManagerAkin instance;
    public int sceneNo;

    [SerializeField] public GameObject startCanvas;
    [SerializeField] public GameObject gameCanvas;
    [SerializeField] public GameObject winCanvas;
    [SerializeField] public GameObject loseCanvas;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        sceneNo = SceneManager.GetActiveScene().buildIndex;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(sceneNo == 0)
        {
            StartCoroutine(LoadFirstLevel());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator LoadFirstLevel()
    {
        yield return new WaitForSeconds(5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadNextLevel()
    {
        if (sceneNo == 3)
        {
            SceneManager.LoadScene(1);
        }

        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNo + 1);
        }
    }

    public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNo);
    }

    public void ActivateGameCanvas()
    {
        gameCanvas.SetActive(true);
    }

    public void DeactivateGameCanvas()
    {
        gameCanvas.SetActive(false);
    }

    public void ActivateWinCanvas()
    {
        winCanvas.SetActive(true);
    }

    public void ActivateLoseCanvas()
    {
        loseCanvas.SetActive(true);
    }

    public void DeactivateStartCanvas()
    {
        startCanvas.SetActive(false);
    }


}
