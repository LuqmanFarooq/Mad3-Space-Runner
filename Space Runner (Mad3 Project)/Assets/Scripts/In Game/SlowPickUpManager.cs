using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPickUpManager : MonoBehaviour
{
    public GameObject activateText;
    public GameObject deActivateText;
    public GameObject slowPotionPickup;
    int numberOfPotionsOnAnAxis = 2;
    int gridSpacing = 250;
    public bool slowPotion = false;
    private void Start()
    {
        PlacePotions();
        activateText.SetActive(false);
        deActivateText.SetActive(false);
    }

    void PlacePotions()
    {
        for (int x = 0; x < numberOfPotionsOnAnAxis; x++)
        {
            for (int y = 0; y < numberOfPotionsOnAnAxis; y++)
            {
                for (int z = 0; z < numberOfPotionsOnAnAxis; z++)
                {
                    InstantiatePotions(x, y, z);
                }//z
            }//y
        }//x
    }//placeAsteroids

    void InstantiatePotions(int x, int y, int z)
    {
        Instantiate(slowPotionPickup,
            new Vector3(transform.position.x + (x * gridSpacing) + PotionsOffSet(),
            transform.position.y + (y * gridSpacing) + PotionsOffSet(),
            transform.position.z + (z * gridSpacing) + PotionsOffSet()),
            Quaternion.identity,
               transform);
    }

    float PotionsOffSet()
    {
        return Random.Range(-gridSpacing, gridSpacing);
    }
    private void Update()
    {
        if (activateText.activeInHierarchy)
        {
            Invoke("HideActivated", 1);
            Invoke("DisplayDeactivate", 9);
            Invoke("HideDeactivate", 11);
        }
    }
   public void DisplayActivate()
    {
        activateText.SetActive(true);

    }
    void HideActivated()
    {
        activateText.SetActive(false);
    }
    void DisplayDeactivate()
    {
        deActivateText.SetActive(true);
    }
    void HideDeactivate()
    {
        deActivateText.SetActive(false);
    }
}
