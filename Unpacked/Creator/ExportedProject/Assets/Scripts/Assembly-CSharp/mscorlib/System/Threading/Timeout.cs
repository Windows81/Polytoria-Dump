namespace System.Threading;

[Token(Token = "0x20001F9")]
public static class Timeout
{
	[Token(Token = "0x40009A4")]
	public static readonly TimeSpan InfiniteTimeSpan; //Field offset: 0x0

	[Address(RVA = "0x151BCD0", Offset = "0x151AED0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600111A")]
	private static Timeout() { }

}

