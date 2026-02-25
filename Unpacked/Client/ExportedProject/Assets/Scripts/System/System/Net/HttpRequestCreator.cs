namespace System.Net;

[Token(Token = "0x2000287")]
internal class HttpRequestCreator : IWebRequestCreate
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001014")]
	internal HttpRequestCreator() { }

	[Address(RVA = "0x17F4BF0", Offset = "0x17F3DF0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001015")]
	public override WebRequest Create(Uri uri) { }

}

