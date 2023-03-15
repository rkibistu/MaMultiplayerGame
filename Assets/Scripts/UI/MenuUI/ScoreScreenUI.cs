using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScreenUI : MonoBehaviour
{
    [SerializeField] private GameObject _listHolder;
    [SerializeField] private GameObject _playerScoreItemPrefab;

    private void Start() {

        Debug.Log("Start ScoreScreenUI");
        foreach(var player in RoomPlayer.Players) {

           
            var obj = Instantiate(_playerScoreItemPrefab, _listHolder.transform).GetComponent<PlayerScoreItemUI>();
            obj.Init(player.PlayerScore);
        }
    }


}
