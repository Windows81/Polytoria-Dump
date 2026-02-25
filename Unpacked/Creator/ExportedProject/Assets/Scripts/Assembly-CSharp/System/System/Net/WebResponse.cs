namespace System.Net;

[Token(Token = "0x2000247")]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400096F")]
	private bool m_IsFromCache; //Field offset: 0x18

	[Token(Token = "0x170002EB")]
	public override WebHeaderCollection Headers
	{
		[Address(RVA = "0x17E81A0", Offset = "0x17E73A0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000EAF")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170002E9")]
	public override bool IsFromCache
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002EA")]
	public override Uri ResponseUri
	{
		[Address(RVA = "0x17E81D0", Offset = "0x17E73D0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000EAE")]
		 get { } //Length: 119
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA5")]
	protected WebResponse() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA6")]
	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA9")]
	public override void Close() { }

	[Address(RVA = "0x17E80D0", Offset = "0x17E72D0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EAA")]
	public override void Dispose() { }

	[Address(RVA = "0x17E80A0", Offset = "0x17E72A0", Length = "0x23")]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EAB")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x17E81A0", Offset = "0x17E73A0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EAF")]
	public override WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAC")]
	public override bool get_IsFromCache() { }

	[Address(RVA = "0x17E81D0", Offset = "0x17E73D0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EAE")]
	public override Uri get_ResponseUri() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA8")]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17E8140", Offset = "0x17E7340", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EAD")]
	public override Stream GetResponseStream() { }

	[Address(RVA = "0x17E8170", Offset = "0x17E7370", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA7")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

