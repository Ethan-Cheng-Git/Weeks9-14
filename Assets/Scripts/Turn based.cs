using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform duck;
    public float t = 0;
    public float y;
    public AnimationCurve curve;

    Coroutine duckGrow;
    void Start()
    {
        duck.localScale = Vector2.zero;
    }

    // Update is called once per frame
    IEnumerator GrowNow()
    {

        yield return duckGrow = StartCoroutine(GrowDuck());
      
    }

    IEnumerator GrowDuck()
    {
        while (t < 1)
        {
            t += Time.deltaTime;
            duck.localScale = Vector2.one * t;
            y = curve.Evaluate(t);
            transform.localScale = Vector3.one * curve.Evaluate(t);
            yield return null;
        }
    }
}
