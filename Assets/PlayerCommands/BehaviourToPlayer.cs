using System;
using UnityEngine;

public class BehaviourToPlayer : MonoBehaviour
{

    private GameObject Player;
    private Boolean IsReceivingCommand = false;
    [SerializeField] private float speed = 1;
    [SerializeField] private float desiredDistance = 5;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Player != null && !IsReceivingCommand)
        {
            FollowPlayer();
        }
    }

    public void GoForward()
    {
        IsReceivingCommand = true;
        transform.position = speed * Time.deltaTime * Vector3.forward;
    }
    private void FollowPlayer()
    {
        distance = (transform.position - Player.transform.position).magnitude;
        if (distance <= desiredDistance) return;
        transform.position = Vector3.MoveTowards(this.transform.position, Player.transform.position, speed*Time.deltaTime);
        
    }
}
