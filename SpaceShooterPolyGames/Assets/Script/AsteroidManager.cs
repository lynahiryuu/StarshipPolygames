using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {

    [SerializeField] Asteroide asteroid;
    [SerializeField] int AsteroidPerAxis = 10;
    [SerializeField] int AsteroidSpacing = 20;

    // Use this for initialization
    void Start () {

        PlaceAsteroid();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlaceAsteroid()
    {
        for (int i = -AsteroidPerAxis/2; i < AsteroidPerAxis / 2; i++)
        {
            for (int j = -AsteroidPerAxis / 2; j < AsteroidPerAxis / 2; j++)
            {
                for (int k = -AsteroidPerAxis / 2; k < AsteroidPerAxis / 2; k++)
                {
                    InitiateAsteroid(i, j, k);
                }
            }
        }
    }

    void InitiateAsteroid(int i, int j, int k)
    {
        float randomOffset = Random.Range(-AsteroidSpacing / 2, AsteroidSpacing / 2);
        Instantiate(asteroid, new Vector3(i + randomOffset, j + randomOffset, k + randomOffset) * AsteroidSpacing + transform.position, Quaternion.identity, transform);
    }
}
