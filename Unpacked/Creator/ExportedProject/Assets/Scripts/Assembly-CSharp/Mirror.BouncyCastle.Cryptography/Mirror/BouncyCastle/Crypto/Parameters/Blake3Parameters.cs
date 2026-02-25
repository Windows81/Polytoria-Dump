namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000121")]
public sealed class Blake3Parameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000246")]
	private Byte[] m_theKey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000247")]
	private Byte[] m_theContext; //Field offset: 0x18

	[Address(RVA = "0x11DDEB0", Offset = "0x11DD0B0", Length = "0x4D")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000B6D")]
	public Byte[] GetContext() { }

	[Address(RVA = "0x11DDF00", Offset = "0x11DD100", Length = "0x4D")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000B6C")]
	public Byte[] GetKey() { }

}

