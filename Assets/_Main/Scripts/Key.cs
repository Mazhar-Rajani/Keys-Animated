using UnityEngine;
using DG.Tweening;
using TMPro;

public class Key : MonoBehaviour
{
    [SerializeField] private Transform keyTransform = default;
    [SerializeField] private TMP_Text text = default;
    [SerializeField] private float animTime = default;
    [SerializeField] private int vibrato = default;
    [SerializeField] private float elasticity = default;
    [SerializeField] private float height = default;
    [SerializeField] private float maxDelay = default;

    public void Setup()
    {
        char c = (char)Random.Range('A', 'Z');
        text.SetText(c.ToString());
        Animate();
    }

    private void Animate()
    {
        keyTransform.DOPunchPosition(new Vector3(0, height, 0), animTime, vibrato, elasticity).SetDelay(Random.Range(0f, maxDelay)).OnComplete(Animate);
    }
}