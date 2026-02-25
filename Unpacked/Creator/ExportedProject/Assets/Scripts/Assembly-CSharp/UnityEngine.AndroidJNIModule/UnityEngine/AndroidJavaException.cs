namespace UnityEngine;

[Token(Token = "0x2000003")]
public sealed class AndroidJavaException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000001")]
	private string mJavaStackTrace; //Field offset: 0x90

	[Token(Token = "0x17000001")]
	public virtual string StackTrace
	{
		[Address(RVA = "0x1909A30", Offset = "0x1908C30", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000004")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x19099B0", Offset = "0x1908BB0", Length = "0x7C")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000003")]
	internal AndroidJavaException(string message, string javaStackTrace) { }

	[Address(RVA = "0x1909A30", Offset = "0x1908C30", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000004")]
	public virtual string get_StackTrace() { }

}

