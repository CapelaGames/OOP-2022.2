using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : Zone
{
    [SerializeField] protected Text _winnerText;
    protected static List<GameObject> _winners;

    protected void Start()
    {
        if (_winners == null)
        {
            _winners = new List<GameObject>();
        }
        _winnerText.text = "";
    }
    protected void DisplayWinningText(string marbleName)
    {
        _winnerText.text += marbleName + "\n";
    }

    protected override void ZoneTrigger(GameObject marble)
    {
        if (!_winners.Contains(marble))
        {
            _winners.Add(marble);
        }
        DisplayWinningText(marble.name);
        //optional
        //marble.SetActive(false);
        //StartCoroutine(DisableWithDelay(marble));
        StartCoroutine(DisableWithDelay(marble, 3f));

    }



}
