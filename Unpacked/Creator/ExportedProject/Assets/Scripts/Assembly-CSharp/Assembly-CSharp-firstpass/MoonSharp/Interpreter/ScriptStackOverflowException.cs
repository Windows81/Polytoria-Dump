namespace MoonSharp.Interpreter;

[Token(Token = "0x2000060")]
public class ScriptStackOverflowException : ScriptRuntimeException
{

	[Address(RVA = "0x30C180", Offset = "0x30B380", Length = "0x79")]
	[CalledBy(Type = typeof(FastStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(FastStack`1), Member = "System.Collections.Generic.ICollection<T>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600060D")]
	public ScriptStackOverflowException() { }

}

