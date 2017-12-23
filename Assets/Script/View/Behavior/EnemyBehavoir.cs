using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]//屬性，作描述;要求script要有animator存在才能執行
[RequireComponent(typeof(MeshFader))]
[RequireComponent(typeof(AudioSource))]

public class EnemyBehavoir : MonoBehaviour {
    private Animator animator;
    private MeshFader meshFader;
    private AudioSource audioSource;
    public AudioClip hurtClip;
	// Use this for initialization
	private void Awake () {
        animator = GetComponent<Animator>();
        meshFader = GetComponent<MeshFader>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        StartCoroutine(meshFader.FadeIn());
    }
    public void DoDemage(float attack) {
        animator.SetTrigger("hurt");
        audioSource.clip = hurtClip;
        audioSource.Play();
    }
    private void Update() {
        if (Input.GetButtonDown("Fire1")) {

            DoDemage(10);
        }

    }
  
}
