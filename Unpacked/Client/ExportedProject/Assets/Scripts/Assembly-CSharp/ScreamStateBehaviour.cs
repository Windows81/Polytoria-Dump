using UnityEngine;

public class ScreamStateBehaviour : StateMachineBehaviour
{
	public Texture2D face;

	private Texture2D oldFace;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
