namespace UnityEngine.VFX;

[Token(Token = "0x200000D")]
public struct VFXOutputEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000019")]
	private readonly int <nameId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001A")]
	private readonly VFXEventAttribute <eventAttribute>k__BackingField; //Field offset: 0x8

	[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute) { }

}

