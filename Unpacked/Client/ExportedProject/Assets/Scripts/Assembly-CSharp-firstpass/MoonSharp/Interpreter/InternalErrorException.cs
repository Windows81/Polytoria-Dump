namespace MoonSharp.Interpreter;

[Token(Token = "0x200005C")]
public class InternalErrorException : InterpreterException
{

	[Address(RVA = "0x2FDAC0", Offset = "0x2FCCC0", Length = "0x59")]
	[CallerCount(Count = 82)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B7")]
	internal InternalErrorException(string message) { }

	[Address(RVA = "0x2FDB20", Offset = "0x2FCD20", Length = "0x8")]
	[CallerCount(Count = 47)]
	[Calls(Type = typeof(InterpreterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B8")]
	internal InternalErrorException(string format, Object[] args) { }

}

