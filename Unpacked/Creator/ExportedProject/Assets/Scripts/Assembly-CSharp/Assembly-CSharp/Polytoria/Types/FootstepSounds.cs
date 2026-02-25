namespace Polytoria.Types;

[CreateAssetMenu(fileName = "FootstepSounds", menuName = "Polytoria/FootstepSounds")]
[Token(Token = "0x20002F3")]
public class FootstepSounds : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B7E")]
	public AudioClip[] sounds; //Field offset: 0x18

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B51")]
	public FootstepSounds() { }

}

