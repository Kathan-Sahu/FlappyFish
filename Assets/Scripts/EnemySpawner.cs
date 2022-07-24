using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] float wait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Hi());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator Hi()
    {
        Instantiate(enemy, new Vector2(5, Random.Range(1f,-1f)), Quaternion.identity);
        yield return new WaitForSeconds(wait);
        StartCoroutine(Hi());
    }
}
