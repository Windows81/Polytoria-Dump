namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200017B")]
internal sealed class RethrowException : Exception
{

	[Address(RVA = "0x15CCC10", Offset = "0x15CBE10", Length = "0x49")]
	[CalledBy(Type = typeof(ThrowInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000783")]
	public RethrowException() { }

}

