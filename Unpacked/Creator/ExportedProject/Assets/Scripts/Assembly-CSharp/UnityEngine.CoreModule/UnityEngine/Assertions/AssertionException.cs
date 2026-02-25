namespace UnityEngine.Assertions;

[Token(Token = "0x20002A0")]
public class AssertionException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40006E5")]
	private string m_UserMessage; //Field offset: 0x90

	[Token(Token = "0x17000218")]
	public virtual string Message
	{
		[Address(RVA = "0x197A780", Offset = "0x1979980", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000D64")]
		 get { } //Length: 88
	}

	[Address(RVA = "0x197A700", Offset = "0x1979900", Length = "0x7C")]
	[CalledBy(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D63")]
	public AssertionException(string message, string userMessage) { }

	[Address(RVA = "0x197A780", Offset = "0x1979980", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D64")]
	public virtual string get_Message() { }

}

