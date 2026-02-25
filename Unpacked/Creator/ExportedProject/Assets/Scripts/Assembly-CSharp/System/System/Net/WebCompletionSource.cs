namespace System.Net;

[Token(Token = "0x20002A6")]
internal class WebCompletionSource : WebCompletionSource<Object>
{

	[Address(RVA = "0x170E700", Offset = "0x170D900", Length = "0x3B")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebCompletionSource`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600111C")]
	public WebCompletionSource() { }

}

