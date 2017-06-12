using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [Range(0.1f, 10.0f)] public float distancia = 15;
   
    Transform player;
	UnityEngine.AI.NavMeshAgent nav;
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, player.transform.position) < distancia)
        {
            nav.SetDestination(player.position);
        }
	}
}
