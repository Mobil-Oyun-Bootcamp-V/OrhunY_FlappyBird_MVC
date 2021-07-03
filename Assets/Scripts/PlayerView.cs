/*
 
 View:Kulanıcı arayüzü, gameobje temsil eden classtır. 

-MonoBehaviour olması gerekir bunun nedeni Unity spesifik olan`OnCollisinEnter`,`Start`,`Update`, gibi Unity eventlerini çalıştırabilmesi gerekir

 */


using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Animator _anim;
    public GameObject _platform;
    

    public float velocity;

    public Rigidbody2D Rb
    {
        get => _rb;
    }

    public Animator Anim
    {
        get => _anim;
    }

    public UnityAction ONHit;
    public UnityAction ONTap;
    public UnityAction ONStart;
    public UnityAction ONScore;
    public UIManager UIM;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ONTap?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe"))
        {
            ONHit?.Invoke();
        }

        if (other.CompareTag("Score"))
        {
            ONScore?.Invoke();
        }
    }

    public void StartGame()
    {
        ONStart?.Invoke();
    }
}