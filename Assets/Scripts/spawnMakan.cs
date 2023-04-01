using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMakan : MonoBehaviour
{
    [SerializeField] GameObject[] makananPrefab;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    [SerializeField] float upwardSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMakanan());
    }

    IEnumerator spawnMakanan()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Vector3 pos = new Vector3(Random.Range(minTras, maxTras), -5, Random.Range(minTras, maxTras));
            int index = Random.Range(0, makananPrefab.Length);
            GameObject foodObject = Instantiate(makananPrefab[index], pos, Quaternion.identity);
            Destroy(foodObject, 12f);
            StartCoroutine(MoveFoodUpward(foodObject));
        }
    }

    IEnumerator MoveFoodUpward(GameObject food)
    {
        while (food != null)
        {
            food.transform.position += Vector3.up * Time.deltaTime * upwardSpeed;
            yield return null;
        }
    }

}