using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    public GameObject DialogueText;
    public GameObject NameText;
    public GameObject Background;
    void Start()
    {
        NameText.SetActive(false);
        DialogueText.SetActive(false); 
        Background.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player");
        {
            NameText.SetActive(false); 
            Background.SetActive(false);
            
            DialogueText.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(NameText);
        Destroy(DialogueText);
        Destroy(Background);
        Destroy(gameObject);
    }
}
