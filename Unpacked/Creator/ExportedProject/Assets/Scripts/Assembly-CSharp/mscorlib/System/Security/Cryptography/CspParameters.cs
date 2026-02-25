namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002E6")]
public sealed class CspParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CBD")]
	public int ProviderType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CBE")]
	public string ProviderName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CBF")]
	public string KeyContainerName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CC0")]
	public int KeyNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000CC1")]
	private int m_flags; //Field offset: 0x2C

	[Token(Token = "0x1700026D")]
	public CspProviderFlags Flags
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017AC")]
		 get { } //Length: 4
		[Address(RVA = "0x1322960", Offset = "0x1321B60", Length = "0xDF")]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(CspParameters))]
		[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Token(Token = "0x60017AD")]
		 set { } //Length: 223
	}

	[Address(RVA = "0x1322750", Offset = "0x1321950", Length = "0x51")]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017AE")]
	public CspParameters() { }

	[Address(RVA = "0x1322700", Offset = "0x1321900", Length = "0x4E")]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017AF")]
	public CspParameters(int dwTypeIn) { }

	[Address(RVA = "0x13228F0", Offset = "0x1321AF0", Length = "0x6C")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(CspParameters))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017B0")]
	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	[Address(RVA = "0x13227B0", Offset = "0x13219B0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017B1")]
	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017AC")]
	public CspProviderFlags get_Flags() { }

	[Address(RVA = "0x1322960", Offset = "0x1321B60", Length = "0xDF")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(CspParameters))]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Token(Token = "0x60017AD")]
	public void set_Flags(CspProviderFlags value) { }

}

