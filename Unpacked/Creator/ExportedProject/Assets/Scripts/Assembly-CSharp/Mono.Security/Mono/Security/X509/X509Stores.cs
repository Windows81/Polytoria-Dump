namespace Mono.Security.X509;

[Token(Token = "0x200001A")]
public class X509Stores
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007E")]
	private string _storePath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	private bool _newFormat; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000080")]
	private X509Store _trusted; //Field offset: 0x20

	[Token(Token = "0x1700004B")]
	public X509Store TrustedRoot
	{
		[Address(RVA = "0x12C1450", Offset = "0x12C0650", Length = "0xE3")]
		[CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 227
	}

	[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E5")]
	internal X509Stores(string path, bool newFormat) { }

	[Address(RVA = "0x12C1450", Offset = "0x12C0650", Length = "0xE3")]
	[CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E6")]
	public X509Store get_TrustedRoot() { }

	[Address(RVA = "0x12C1320", Offset = "0x12C0520", Length = "0x123")]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E7")]
	public X509Store Open(string storeName, bool create) { }

}

