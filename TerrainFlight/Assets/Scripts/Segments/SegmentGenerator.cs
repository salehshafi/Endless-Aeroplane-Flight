using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SegmentGenerator : MonoBehaviour {
	private int totalSegmentsSpawned; // total segments spawned 
    public int totalSegmentsTillEnd;// Total segments after which we have to end the game(spawn End Segment).. 
    int currActiveSeg=0; // number of cuurently active segments(segments in scene)
    public int maxNumberOfActiveSegments;// Maximun number of segments that a scene can have
	public List<GameObject> segmentsPrefabs; // prefabs of all the segments
    public List<GameObject> currentSeg; // list of segments that are currently present in scene
	public GameObject StartSegment;// starting seg
	public GameObject EndSegment;// ending seg
    public GameObject leaf; // current last segment 
    private GameObject root; // current root segment
    private GameObject temp;
    bool endScene = false;
	
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////
    /// </summary>
    private static SegmentGenerator instance;
    public static SegmentGenerator Instance
    {
        get
        {
            return instance;
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////
    /// </summary>
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {
        SpawnStartSegment(Vector3.zero);// starting segments created
    }
	
    public void SpawnStartSegment(Vector3 position)// start segments at the beging of game
    {
        currActiveSeg++;
        totalSegmentsSpawned++;
        for (int i = 0; i < maxNumberOfActiveSegments / 2; i++)// at the start we create  maxNumberOfActiveSegments/2 segments infront of the player 
        {
            SpawnSegmentsAtNextLevel();
        }
    }
    public void SpawnSegmentsAtNextLevel()// function is called whenever the player enters the new segment
    {
        if (!endScene)
        {
            temp = segmentsPrefabs[Random.Range(0, segmentsPrefabs.Count)];
            leaf = Instantiate(temp, leaf.transform.Find("EndPoint").transform.position, Quaternion.identity) as GameObject; // new segment generated
            currentSeg.Add(leaf); 
            totalSegmentsSpawned++;
            currActiveSeg++;
        }
    }
    
	// Update is called once per frame
	void Update () 
    {
        if (!endScene)
        {
            if (totalSegmentsSpawned >= totalSegmentsTillEnd) // last segment(end)
            {
                endScene = true;
                Instantiate(EndSegment, leaf.transform.Find("EndPoint").transform.position, Quaternion.identity); // end segment
            }
            if (currActiveSeg >= maxNumberOfActiveSegments) // removing segment 
            {
                GameObject tmp = currentSeg[0];
                currentSeg.RemoveAt(0); // segment removed
                Destroy(tmp); // segment destroyed from scene
                currActiveSeg--;
            }
        }
	}
}
