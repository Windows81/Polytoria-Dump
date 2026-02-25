namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x200029C")]
public struct PlayableOutput : IEquatable<PlayableOutput>
{
	[Token(Token = "0x40006DF")]
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DE")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x19870B0", Offset = "0x19862B0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D47")]
	private static PlayableOutput() { }

	[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D44")]
	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x1986FD0", Offset = "0x19861D0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D46")]
	public override bool Equals(PlayableOutput other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D45")]
	public override PlayableOutputHandle GetHandle() { }

}

