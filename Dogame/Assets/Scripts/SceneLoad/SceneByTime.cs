using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneByTime : MonoBehaviour {

    [SerializeField]
    private float timeToChange;
    [SerializeField]
    private string levelToChange;

    public Animator animator;

	void Start () {
        StartCoroutine(LoadLevelAfterTime(timeToChange));
	}

    IEnumerator LoadLevelAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeDone()
    {
        SceneManager.LoadScene(levelToChange);
    }
	
}
