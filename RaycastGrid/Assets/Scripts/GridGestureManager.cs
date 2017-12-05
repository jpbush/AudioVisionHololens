using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GridGestureManager : MonoBehaviour
{
    public static GridGestureManager Instance { get; private set; }

    GestureRecognizer recognizer;

    // Use this for initialization
    void Start()
    {
        Instance = this;

        // Set up a GestureRecognizer to detect Select gestures.
        recognizer = new GestureRecognizer();
        recognizer.Tapped += (args) =>
        {

            SpatialMapping.Instance.DrawVisualMeshes = !SpatialMapping.Instance.DrawVisualMeshes;
        };
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
