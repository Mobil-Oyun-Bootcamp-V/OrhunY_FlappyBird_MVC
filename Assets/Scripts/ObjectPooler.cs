using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public sealed class ObjectPooler : MonoBehaviour
{
    private static ObjectPooler _instance = null;

    [SerializeField]
    private List<GameObject> pipePool = new List<GameObject>();
    

    public static ObjectPooler GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject("PipeCreator").AddComponent<ObjectPooler>();
        }

        return _instance;
    }

    public List<GameObject> Initialize(int pipeCount, GameObject pipePref)
    {
        for (int i = 0; i < pipeCount; i++)
        {
            GameObject pipe = Instantiate(pipePref, transform);
            pipe.transform.position = new Vector3(i * 5, Random.Range(-2, 1), 0);
            pipePool.Add(pipe);
        }
        MovePipe();
        return pipePool;
    }

    public void MovePipe()
    {
        foreach (GameObject pipe in pipePool)
        {
            pipe.transform.DOMoveX(pipe.transform.position.x - 15, 5, false).SetEase(Ease.Linear).OnComplete(() =>
            {
                DestroyPipe();
            });
        }
    }

    private void DestroyPipe()
    {
        GameObject pipeRef = pipePool[0];
        pipeRef.transform.DOKill();
        pipePool.Remove(pipeRef);
        
        Destroy(pipeRef);
        
    }
}
