using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegisterScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // settting the score for GameData
        GameData.singleton.science = this.GetComponent<Text>();
    }

   
}
