using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject virus;
    public float respawnTime =2.0f;
    public float screenX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VirusWare());
    }
    private void SpawnEnemy()
    {
        Debug.Log("ok");
        GameObject a = Instantiate(virus) as GameObject;
        a.transform.position = new Vector2(screenX , Random.Range(minY, maxY));
    }

    // Update is called once per frame
    IEnumerator VirusWare()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            SpawnEnemy();
        }
    }
}
