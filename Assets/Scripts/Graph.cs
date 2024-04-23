using UnityEngine;

public class Graph : MonoBehaviour {

    [SerializeField]
    Transform pointPrefab;

    private void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * ((i + 0.5f) /5f - 1f);
            point.localScale = Vector3.one / 5f;


        }








        ///////////////////////////////////////
        //point.localPosition = Vector3.right;/
        ///////////////////////////////////////
        //point = Instantiate (pointPrefab);///
        //point.localPosition=Vector3.right*2f;
        ///////////////////////////////////////
    }
}