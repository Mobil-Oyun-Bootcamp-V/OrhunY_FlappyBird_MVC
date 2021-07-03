/*
 
 View:Kulanıcı arayüzü, gameobje temsil eden classtır. 

-MonoBehaviour olması gerekir bunun nedeni Unity spesifik olan`OnCollisinEnter`,`Start`,`Update`, gibi Unity eventlerini çalıştırabilmesi gerekir

 */


using System;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerView : MonoBehaviour
{
 [SerializeField] private Rigidbody2D _rb;
 public Rigidbody2D Rb { get => _rb; }
 public UnityAction ONHit;
 public UnityAction ONTap;

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.Space))
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
 }
}