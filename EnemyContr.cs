using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


//движение врага на игрока
public class EnemyContr : MonoBehaviour
{
    NavMeshAgent enmy;
    public GameObject player;
    Transform trns;

    void Start()
    {
        enmy = GetComponent<NavMeshAgent>();
        trns = player.GetComponent<Transform>();
    }
    
    void Update()
    {
        enmy.SetDestination(trns.position);
    }

}
