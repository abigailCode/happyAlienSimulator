using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject prefabEnemy;
    [SerializeField] private List<Transform> points;
    [SerializeField] private float enemyTime;
    [SerializeField] private float nextEnemyTime;
    [SerializeField] private float maxEnemies= 6;
    private float counter = 0;

  

    private void Update()
    {
        int randomIndex = Random.Range(0, points.Count);

        nextEnemyTime += Time.deltaTime;
        if(nextEnemyTime >= enemyTime)
        {
            nextEnemyTime = 0;
            if(counter < maxEnemies)
            {
            generateEnemy(randomIndex);
            counter++;
            }
        }
    }

    private void generateEnemy(int randomIndex)
    {
        Vector2 randomPosition = new Vector2(points[randomIndex].position.x, points[randomIndex].position.y);
        Instantiate(prefabEnemy, randomPosition, Quaternion.identity);
        points.RemoveAt(randomIndex);
    }
    // public float distance=10;
    // void Start()
    // {
    //     GenerateEnemies();
    // }

    //public void GenerateEnemies()
    //{
    //     GameObject[] surfaces = GameObject.FindGameObjectsWithTag("Floor");
    //     int surfacesCount = surfaces.Length;
    //     Debug.Log(surfacesCount);

    //     for(int i= 0; i< surfacesCount; i++)
    //     {
    //         Vector3 position;

    //         for(int j= 0; j< GetRandom(); j++)
    //         {
    //             position = surfaces[i].transform.position;

    //             Instantiate(prefabEnemy, position, Quaternion.identity);
    //         }



    //     }
    // }

    // private int GetRandom()
    // {
    //     return Random.Range(1, 4); 
    // }



}
