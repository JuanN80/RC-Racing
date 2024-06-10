using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class recordManager : MonoBehaviour
{

    private int record;
    [SerializeField] TextMeshProUGUI inputScore;
    [SerializeField] TMP_InputField inputName;
    
    void Start()
    {
        record = (int) SaveManager.instance.BestLapTime;

        inputScore.SetText(record.ToString());

    }

    public UnityEvent<string, int> submitScoreEvent;

    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, record);



    }
    



}
