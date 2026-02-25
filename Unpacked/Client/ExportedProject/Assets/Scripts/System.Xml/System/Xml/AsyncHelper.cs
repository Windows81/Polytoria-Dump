namespace System.Xml;

[Extension]
[Token(Token = "0x2000004")]
internal static class AsyncHelper
{
	[Token(Token = "0x4000002")]
	public static readonly Task DoneTask; //Field offset: 0x0
	[Token(Token = "0x4000003")]
	public static readonly Task<Boolean> DoneTaskTrue; //Field offset: 0x8
	[Token(Token = "0x4000004")]
	public static readonly Task<Boolean> DoneTaskFalse; //Field offset: 0x10
	[Token(Token = "0x4000005")]
	public static readonly Task<Int32> DoneTaskZero; //Field offset: 0x18

	[Address(RVA = "0x162B0C0", Offset = "0x162A2C0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Token(Token = "0x6000003")]
	private static AsyncHelper() { }

}

