using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                key.transform.position = new Vector3(r, 0, c);
                key.Setup();
            }
        }
    }
}