using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]//屬性，作描述;要求script要有animator存在才能執行

public class EnemyBehavoir : MonoBehaviour {
    private Animator animator;
	// Use this for initialization
	private void Awake () {
        animator = GetComponent<Animator>();
        animator.SetTrigger("die");
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update () {
		
	}
}
