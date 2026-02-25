namespace Discord;

[Token(Token = "0x20001F6")]
public class ResultException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000721")]
	public readonly Result Result; //Field offset: 0x90

	[Address(RVA = "0x3A0E30", Offset = "0x3A0030", Length = "0x8D")]
	[CallerCount(Count = 121)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FF4")]
	public ResultException(Result result) { }

}

