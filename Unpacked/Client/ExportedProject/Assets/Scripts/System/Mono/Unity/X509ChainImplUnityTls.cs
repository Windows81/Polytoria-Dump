namespace Mono.Unity;

[Token(Token = "0x2000045")]
internal class X509ChainImplUnityTls : X509ChainImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000093")]
	private X509ChainElementCollection elements; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000094")]
	private unitytls_x509list* ownedList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000095")]
	private unitytls_x509list_ref nativeCertificateChain; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000096")]
	private X509ChainPolicy policy; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000097")]
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000098")]
	private bool reverseOrder; //Field offset: 0x38

	[Token(Token = "0x17000016")]
	public virtual X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x16054A0", Offset = "0x16046A0", Length = "0x361")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 865
	}

	[Token(Token = "0x17000017")]
	public virtual X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000014")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x1605810", Offset = "0x1604A10", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000015")]
	internal unitytls_x509list_ref NativeCertificateChain
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1605400", Offset = "0x1604600", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	internal X509ChainImplUnityTls(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false) { }

	[Address(RVA = "0x1605320", Offset = "0x1604520", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	internal X509ChainImplUnityTls(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder = false) { }

	[Address(RVA = "0x1605110", Offset = "0x1604310", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A6")]
	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x1605250", Offset = "0x1604450", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AA")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x16054A0", Offset = "0x16046A0", Length = "0x361")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60000A5")]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x1605810", Offset = "0x1604A10", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A3")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A4")]
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	[Address(RVA = "0x1605290", Offset = "0x1604490", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	public virtual void Reset() { }

}

