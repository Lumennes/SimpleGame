using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(5);
        text.text = "Текстовый";
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //} 
}
