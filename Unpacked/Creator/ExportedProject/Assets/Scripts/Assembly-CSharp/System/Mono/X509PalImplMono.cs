namespace Mono;

[Token(Token = "0x2000005")]
internal class X509PalImplMono : X509PalImpl
{

	[Address(RVA = "0x1605860", Offset = "0x1604A60", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public X509PalImplMono() { }

	[Address(RVA = "0x1605850", Offset = "0x1604A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[Token(Token = "0x6000013")]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[Address(RVA = "0x1605840", Offset = "0x1604A40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[Token(Token = "0x6000014")]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

