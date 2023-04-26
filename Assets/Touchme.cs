using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touchme : MonoBehaviour
{

    [SerializeField]
    string[] responses;

    [SerializeField]
    Text btnText;

    public void BitchYouThought()
    {
        float newX = Random.Range(0, Screen.width);
        float newY = Random.Range(0, Screen.height);
        Vector2 newLoc = new Vector2(newX, newY);

        transform.position = newLoc;

        int newIndex = Random.Range(0, responses.Length - 1);

        if (newIndex < 0 || newIndex >= responses.Length)
            newIndex = 0;

        if (btnText)
            btnText.text = responses[newIndex];

    }
}
