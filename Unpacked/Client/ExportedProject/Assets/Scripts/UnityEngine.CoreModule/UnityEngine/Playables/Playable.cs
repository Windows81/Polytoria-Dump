namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x2000295")]
public struct Playable : IEquatable<Playable>
{
	[Token(Token = "0x40006D2")]
	private static readonly Playable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D1")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x17000213")]
	public static Playable Null
	{
		[Address(RVA = "0x19872D0", Offset = "0x19864D0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000D22")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1987230", Offset = "0x1986430", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D26")]
	private static Playable() { }

	[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D23")]
	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle) { }

	[Address(RVA = "0x1987150", Offset = "0x1986350", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D25")]
	public override bool Equals(Playable other) { }

	[Address(RVA = "0x19872D0", Offset = "0x19864D0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D22")]
	public static Playable get_Null() { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D24")]
	public override PlayableHandle GetHandle() { }

}

