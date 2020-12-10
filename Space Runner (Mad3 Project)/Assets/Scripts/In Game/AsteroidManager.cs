using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] int numberOfAsteroidsOnAnAxis = 10;
    [SerializeField] int gridSpacing = 25;
    [SerializeField] Asteroid asteroidPrefab;
    

    public List<Asteroid> asteroid = new List<Asteroid>();
    private void Start()
    {
        PlaceAsteroids();
    }

    void PlaceAsteroids()
    {
        for(int x = 0; x < numberOfAsteroidsOnAnAxis; x++)
        {
            for (int y = 0; y < numberOfAsteroidsOnAnAxis; y++)
            {
                for (int z = 0; z < numberOfAsteroidsOnAnAxis; z++)
                {
                    InstantiateAsteroid(x, y, z);
                }//z
            }//y
        }//x
        
    }//placeAsteroids

    void InstantiateAsteroid(int x, int y, int z)
    {
       Asteroid temp = Instantiate(asteroidPrefab,
            new Vector3(transform.position.x + (x * gridSpacing) + AsteroidOffSet(),
            transform.position.y + (y * gridSpacing) + AsteroidOffSet(),
            transform.position.z + (z * gridSpacing) + AsteroidOffSet()),
            Quaternion.identity,
               transform) as Asteroid;
        asteroid.Add(temp);
    }

    float AsteroidOffSet()
    {
       return Random.Range(-gridSpacing, gridSpacing);
    }

    
}
