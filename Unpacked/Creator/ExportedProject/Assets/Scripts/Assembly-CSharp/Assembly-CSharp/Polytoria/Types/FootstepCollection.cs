namespace Polytoria.Types;

[CreateAssetMenu(fileName = "FootstepCollection", menuName = "Polytoria/FootstepCollection")]
[Token(Token = "0x20002F1")]
public class FootstepCollection : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B7A")]
	public FootstepSounds fallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7B")]
	public FootstepMaterial[] sounds; //Field offset: 0x20

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B50")]
	public FootstepCollection() { }

	[Address(RVA = "0x40DAA0", Offset = "0x40CCA0", Length = "0x65")]
	[CalledBy(Type = typeof(Player), Member = "DoFootstep", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B4F")]
	public FootstepSounds GetSounds(PartMaterial partMaterial) { }

}

