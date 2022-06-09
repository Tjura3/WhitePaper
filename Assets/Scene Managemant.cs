using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagemant : MonoBehaviour
{
    bool coroutineStart;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("Menu");
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void LoadString(string a)
    {
        SceneManager.LoadScene(a);
    } 
    public void LoadInt(int b)
    {
        SceneManager.LoadScene(b);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (coroutineStart == false)
            {
                coroutineStart = true;
                StartCoroutine(Winningcoroutine());
            }
        }
    }
    IEnumerator Winningcoroutine()
    {
        animator.SetTrigger("endingDance");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(5);
    }

}
