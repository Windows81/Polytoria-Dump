namespace UnityEngine.Playables;

[Token(Token = "0x2000298")]
public struct PlayableBinding
{
	[Token(Token = "0x2000299")]
	[VisibleToOtherModules]
	public sealed class CreateOutputMethod : MulticastDelegate
	{

		[Address(RVA = "0x1980A30", Offset = "0x197FC30", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000D38")]
		public CreateOutputMethod(object object, IntPtr method) { }

		[Address(RVA = "0x19809F0", Offset = "0x197FBF0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D39")]
		public override PlayableOutput Invoke(PlayableGraph graph, string name) { }

	}

	[Token(Token = "0x40006D7")]
	public static readonly PlayableBinding[] None; //Field offset: 0x0
	[Token(Token = "0x40006D8")]
	public static readonly double DefaultDuration; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D3")]
	private string m_StreamName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006D4")]
	private object m_SourceObject; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D5")]
	private Type m_SourceBindingType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006D6")]
	private CreateOutputMethod m_CreateOutputMethod; //Field offset: 0x18

	[Address(RVA = "0x19868B0", Offset = "0x1985AB0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D37")]
	private static PlayableBinding() { }

}

