using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimatedScore : MonoBehaviour
{

    public TMP_Text roundsText;

    // when the script start
    void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        roundsText.text = "0";
        int round = 0;

        // wait for some seconds before the animation starts
        yield return new WaitForSeconds(.7f);

        while (round < Score.PinCount)
        {
            round++;
            roundsText.text = round.ToString();
            // delay for few seconds
            yield return new WaitForSeconds(.05f);
        }
    }
}
