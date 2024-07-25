using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfUnits : MonoBehaviour
{
    private List<GameObject> listOfUnits = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        listOfUnits.AddRange(GameObject.FindGameObjectsWithTag("Minion"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetRandomUnit()
    {
        return listOfUnits[Random.Range(0, listOfUnits.Count-1)];
    }
}
