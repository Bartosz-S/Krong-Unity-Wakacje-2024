using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitReferenceContainer : MonoBehaviour
{
    [SerializeField] private BehaviourToPlayer _UnitBehaviour;
    [SerializeField] private ListOfUnits _listOfUnits;

    public BehaviourToPlayer BehaviourToPlayer { 
        get { return _UnitBehaviour; } 
    }
    public ListOfUnits ListOfUnits
    {
        get { return _listOfUnits; }
    }
}
