namespace Mono;

[Token(Token = "0x2000032")]
internal struct RuntimeRemoteClassHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010E")]
	private RemoteClass* value; //Field offset: 0x0

	[Token(Token = "0x17000006")]
	internal RuntimeClassHandle ProxyClass
	{
		[Address(RVA = "0x12DDFD0", Offset = "0x12DD1D0", Length = "0x1A")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x12DDFD0", Offset = "0x12DD1D0", Length = "0x1A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	internal RuntimeClassHandle get_ProxyClass() { }

}

