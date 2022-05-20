
using UnityEngine;

public class spikeGenerator : MonoBehaviour
{
    [SerializeField] public float MinSpeed;
    [SerializeField] public float MaxSpeed;
    [SerializeField] public float CurrentSpeed;
    [SerializeField] public float speedMultiplier;
    public GameObject spike;
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateSpike();
    }
    public void Randomizer()
    {
        float randomwait = Random.Range(0.1f, 2.2f);
        Invoke("generateSpike", randomwait);
    }
    void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
        SpikeIns.GetComponent<spikeScript>().spikeGenerator = this;
    }
    // Update is called once per frame
    void Update()
    {
        if(CurrentSpeed < MaxSpeed)
        {
            CurrentSpeed += speedMultiplier;
        }
    }
}
