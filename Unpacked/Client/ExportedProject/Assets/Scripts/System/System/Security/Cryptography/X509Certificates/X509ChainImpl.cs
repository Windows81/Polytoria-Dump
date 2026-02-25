namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000135")]
internal abstract class X509ChainImpl : IDisposable
{

	[Token(Token = "0x17000157")]
	public abstract X509ChainElementCollection ChainElements
	{
		[Token(Token = "0x6000779")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000158")]
	public abstract X509ChainPolicy ChainPolicy
	{
		[Token(Token = "0x600077A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000156")]
	public abstract bool IsValid
	{
		[Token(Token = "0x6000777")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000781")]
	protected X509ChainImpl() { }

	[Token(Token = "0x600077C")]
	public abstract void AddStatus(X509ChainStatusFlags errorCode) { }

	[Token(Token = "0x600077B")]
	public abstract bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x178ED20", Offset = "0x178DF20", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077E")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x178ED90", Offset = "0x178DF90", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000780")]
	protected virtual void Finalize() { }

	[Token(Token = "0x6000779")]
	public abstract X509ChainElementCollection get_ChainElements() { }

	[Token(Token = "0x600077A")]
	public abstract X509ChainPolicy get_ChainPolicy() { }

	[Token(Token = "0x6000777")]
	public abstract bool get_IsValid() { }

	[Token(Token = "0x600077D")]
	public abstract void Reset() { }

	[Address(RVA = "0x178EE00", Offset = "0x178E000", Length = "0x4B")]
	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_StoreCtx", ReturnType = typeof(MonoBtlsX509StoreCtx))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000778")]
	protected void ThrowIfContextInvalid() { }

}

