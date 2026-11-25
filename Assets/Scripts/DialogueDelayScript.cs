using UnityEngine;
using Yarn.Unity;

public class DialogueDelayScript : MonoBehaviour
{
    [YarnCommand("dialogue_delay")]
    static async YarnTask DialogueDelay()
    {
        // wait for 1,5 seconds
        await YarnTask.Delay(1500);
    }

}
