namespace UnityEngine.UIElements;

[Token(Token = "0x20001CA")]
public enum PropagationPhase
{
	None = 0,
	TrickleDown = 1,
	BubbleUp = 3,
	AtTarget = 2,
	DefaultAction = 4,
	DefaultActionAtTarget = 5,
}

