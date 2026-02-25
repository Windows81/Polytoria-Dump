namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x200017E")]
internal struct InterpretedFrameInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F3")]
	private readonly string _methodName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002F4")]
	private readonly DebugInfo _debugInfo; //Field offset: 0x8

	[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600078A")]
	public InterpretedFrameInfo(string methodName, DebugInfo info) { }

	[Address(RVA = "0x15B5FE0", Offset = "0x15B51E0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600078B")]
	public virtual string ToString() { }

}

