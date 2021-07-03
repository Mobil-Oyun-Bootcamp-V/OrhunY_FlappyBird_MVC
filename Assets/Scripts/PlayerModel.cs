/*
 Model: İşi data tutmak olan classtır.

- MonoBehaviour değildir, olmaması gerekir.
- Minimum düzeyde Unity spesifik kodları içermesi gerekir, mümkünse hiç içermemelidir
*/
using UnityEngine;
using UnityEngine.Events;

public class PlayerModel
{
    public enum Scenes{Opening, InGame, EndGame}
    public Scenes currentScene;
    
    private Vector3 _position;
    private bool _hit;
    private float _velocity;
    private int _bestScore;
    private int _currentScore;
    private Vector3 startPos;
    
    public Vector3 Position
    {
        get => _position;
        set => _position = value;
    }

    public float Velocity
    {
        get => _velocity;
        set => _velocity = value;
    }

    public int BestScore
    {
        get => _bestScore;
        set => _bestScore = value;
    }

    public int currentScore
    {
        get => _currentScore;
        set => _currentScore = value;
    }
    
    public Vector3 StartPos
    {
        get => startPos;
        set => startPos = value;
    }
}