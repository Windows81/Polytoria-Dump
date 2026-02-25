namespace System.Net;

[Token(Token = "0x2000227")]
public abstract class EndPoint
{

	[Token(Token = "0x170002C1")]
	public override AddressFamily AddressFamily
	{
		[Address(RVA = "0x17D30B0", Offset = "0x17D22B0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000DFB")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFE")]
	protected EndPoint() { }

	[Address(RVA = "0x17D3050", Offset = "0x17D2250", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DFD")]
	public override EndPoint Create(SocketAddress socketAddress) { }

	[Address(RVA = "0x17D30B0", Offset = "0x17D22B0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DFB")]
	public override AddressFamily get_AddressFamily() { }

	[Address(RVA = "0x17D3080", Offset = "0x17D2280", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DFC")]
	public override SocketAddress Serialize() { }

}

