/*
 Model: İşi data tutmak olan classtır.

- MonoBehaviour değildir, olmaması gerekir.
- Minimum düzeyde Unity spesifik kodları içermesi gerekir, mümkünse hiç içermemelidir
*/
using UnityEngine;
using UnityEngine.Events;

public class PlayerModel
{
    public UnityAction OnTap;
    
    private Vector3 _position;
    private bool _hit;
    
    public Vector3 Position
    {
        get => _position;
        set => _position = value;
    }
}