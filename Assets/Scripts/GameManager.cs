using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject explode;
    Audios audios;
    UIManager uIManager;
    void Awake()
    {
        audios = FindObjectOfType<Audios>();
        uIManager = FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Game Over
        if(collision.tag == "enemy" )
        {
            audios.PlayCrashClip();
            //Destroy(gameObject);
            transform.localScale = new Vector3(0, 0, 0);
            Instantiate(explode, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            StartCoroutine(wow());
        }
        

    }
    IEnumerator wow()
    {
        yield return new WaitForSeconds(0.5f);
        uIManager.GameOverUI();
    }

}
