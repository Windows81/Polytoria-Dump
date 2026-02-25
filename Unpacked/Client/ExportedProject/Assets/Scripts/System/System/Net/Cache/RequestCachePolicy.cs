namespace System.Net.Cache;

[Token(Token = "0x20002DC")]
public class RequestCachePolicy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C86")]
	private RequestCacheLevel m_Level; //Field offset: 0x10

	[Token(Token = "0x170003DD")]
	public RequestCacheLevel Level
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001223")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x17010B0", Offset = "0x17002B0", Length = "0x71")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001222")]
	public RequestCachePolicy(RequestCacheLevel level) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001223")]
	public RequestCacheLevel get_Level() { }

	[Address(RVA = "0x1701030", Offset = "0x1700230", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001224")]
	public virtual string ToString() { }

}

