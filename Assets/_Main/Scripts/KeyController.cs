using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KeyController : MonoBehaviour
{
    [SerializeField] private int rows = default;
    [SerializeField] private int columns = default;
    [SerializeField] private Key keyPrefab = default;

    private void Awake()
    {
        for (int c = 0; c < columns; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                Key key = Instantiate(keyPrefab);
                key.transform.SetParent(transform);
                key.transform.position = transform.position + new Vector3(r, 0, c);
                key.Setup();
            }
        }
    }

    private void Start()
    {
        transform.DOMoveX(-rows, 1f).SetSpeedBased().SetEase(Ease.Linear).OnComplete(Move);
    }

    private void Move()
    {
        transform.position = new Vector3(rows, 0, 0);
        transform.DOMoveX(-rows, 1f).SetSpeedBased().SetEase(Ease.Linear).OnComplete(Move);
    }
}