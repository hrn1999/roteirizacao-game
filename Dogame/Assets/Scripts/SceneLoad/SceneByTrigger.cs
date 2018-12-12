using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneByTrigger : MonoBehaviour {

    [SerializeField]
    private float timeToChange;
    [SerializeField]
    private GameObject changer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(LoadLevelAfterTrigger(timeToChange));
        }
    }

    IEnumerator LoadLevelAfterTrigger(float time)
    {
        yield return new WaitForSeconds(time);
        changer.GetComponent<Animator>().SetTrigger("FadeOut");    
    }
}
