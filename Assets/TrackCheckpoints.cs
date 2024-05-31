using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    public bool test = true;
        private void Awake()
        {
            Transform checkpointsTransform = transform.Find("Checkpoint");

            foreach(Transform CheckPointsTransform in checkpointsTransform)
            {
                CheckPoint cho = checkpointsTransform.GetComponent<CheckPoint>();
                cho.SetTrackCheckPoints(this);


            }


        }

        public void PlayerThroughCheckpoint(CheckPoint checkpoint)
        {
            test = false;

        }
}
