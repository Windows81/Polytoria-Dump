namespace Mono.Net.Security;

[Token(Token = "0x2000047")]
internal class BufferOffsetSize2 : BufferOffsetSize
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009E")]
	public readonly int InitialSize; //Field offset: 0x28

	[Address(RVA = "0x15EDC20", Offset = "0x15ECE20", Length = "0x113")]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(Stream), typeof(bool), typeof(MonoTlsSettings)}, ReturnType = typeof(MobileAuthenticatedStream))]
	[CalledBy(Type = typeof(UnityTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AF")]
	public BufferOffsetSize2(int size) { }

	[Address(RVA = "0x15ED9D0", Offset = "0x15ECBD0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B2")]
	public void AppendData(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15EDAE0", Offset = "0x15ECCE0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B1")]
	public void MakeRoom(int size) { }

	[Address(RVA = "0x15EDBC0", Offset = "0x15ECDC0", Length = "0x57")]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncProtocolRequest), typeof(BufferOffsetSize2), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim+TimeoutTracker", Member = "get_RemainingMilliseconds", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000B0")]
	public void Reset() { }

}

