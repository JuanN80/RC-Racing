using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using Dan.Main;
public class Leaderboard : MonoBehaviour
{
    [SerializeField]private List<TextMeshProUGUI> names;

    [SerializeField]private List<TextMeshProUGUI> scores;
    private string publicLeaderboardKey = "978d2eba8c2f4234b9e645ac229d760b48b8684d322ca2d44c97680621a5d380";


void Start()
{

    GetLeaderboard();
    
}
    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => 
        {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for(int i = 0; i < loopLength; i++) 
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));

    }

    public void SetLeaderboardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey,username, score, ((msg)=> 
        {  
            GetLeaderboard();
        }));


    }
}
