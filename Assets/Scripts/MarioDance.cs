using System.Collections.Generic;
using UnityEngine;

public class MarioDance : MonoBehaviour
{
    [SerializeField] Animator animator=null;

    List<string> animations=new List<string>{
        "Idle",
        "Dance1",
        "Dance2",
        "Dance3",
        "Dance4"
    };
    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime>1 && 
                                !animator.IsInTransition(0))
            {
                PlayAnimation();
            }
    }
    
    void PlayAnimation(){
        int randomInt=Random.Range(0,4);
        print(randomInt);
        animator.Play(animations[randomInt]);
    }
}
