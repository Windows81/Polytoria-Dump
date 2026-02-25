namespace Mirror;

[Token(Token = "0x200003B")]
public class PredictedRigidbodyPhysicsGhost : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000157")]
	[Tooltip("The predicted rigidbody owner.")]
	public Transform target; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020A")]
	public PredictedRigidbodyPhysicsGhost() { }

}

