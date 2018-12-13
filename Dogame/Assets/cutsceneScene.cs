using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneScene : MonoBehaviour {

    [SerializeField]
    private float timeToChange;

    public GameObject changer;

    void Start()
    {
        StartCoroutine(LoadLevelAfterTime(timeToChange));
    }

    IEnumerator LoadLevelAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        changer.GetComponent<Animator>().SetTrigger("FadeOut");
    }
}
