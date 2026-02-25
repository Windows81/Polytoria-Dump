namespace System.Security.Cryptography;

[Token(Token = "0x2000014")]
public sealed class AesCryptoServiceProvider : Aes
{

	[Token(Token = "0x1700000A")]
	public virtual int FeedbackSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public virtual Byte[] IV
	{
		[Address(RVA = "0x156ADA0", Offset = "0x1569FA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_IV", ReturnType = typeof(Byte[]))]
		[Token(Token = "0x600003D")]
		 get { } //Length: 7
		[Address(RVA = "0x156ADC0", Offset = "0x1569FC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Token(Token = "0x600003E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000008")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x156ADB0", Offset = "0x1569FB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_Key", ReturnType = typeof(Byte[]))]
		[Token(Token = "0x600003F")]
		 get { } //Length: 7
		[Address(RVA = "0x156ADE0", Offset = "0x1569FE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Token(Token = "0x6000040")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000009")]
	public virtual int KeySize
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 get { } //Length: 4
		[Address(RVA = "0x156ADD0", Offset = "0x1569FD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000042")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public virtual CipherMode Mode
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000044")]
		 get { } //Length: 4
		[Address(RVA = "0x156ADF0", Offset = "0x1569FF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000045")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700000C")]
	public virtual PaddingMode Padding
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000046")]
		 get { } //Length: 4
		[Address(RVA = "0x156AE60", Offset = "0x156A060", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000047")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x156AD40", Offset = "0x1569F40", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000038")]
	public AesCryptoServiceProvider() { }

	[Address(RVA = "0x1351020", Offset = "0x1350220", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public virtual ICryptoTransform CreateDecryptor() { }

	[Address(RVA = "0x156AAD0", Offset = "0x1569CD0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600003B")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x1351090", Offset = "0x1350290", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	public virtual ICryptoTransform CreateEncryptor() { }

	[Address(RVA = "0x156ABD0", Offset = "0x1569DD0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600003C")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x156ACD0", Offset = "0x1569ED0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600004A")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x156ACE0", Offset = "0x1569EE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000039")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x156AD10", Offset = "0x1569F10", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600003A")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public virtual int get_FeedbackSize() { }

	[Address(RVA = "0x156ADA0", Offset = "0x1569FA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_IV", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600003D")]
	public virtual Byte[] get_IV() { }

	[Address(RVA = "0x156ADB0", Offset = "0x1569FB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_Key", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600003F")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	public virtual CipherMode get_Mode() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public virtual PaddingMode get_Padding() { }

	[Address(RVA = "0x156ADC0", Offset = "0x1569FC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600003E")]
	public virtual void set_IV(Byte[] value) { }

	[Address(RVA = "0x156ADE0", Offset = "0x1569FE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000040")]
	public virtual void set_Key(Byte[] value) { }

	[Address(RVA = "0x156ADD0", Offset = "0x1569FD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000042")]
	public virtual void set_KeySize(int value) { }

	[Address(RVA = "0x156ADF0", Offset = "0x1569FF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000045")]
	public virtual void set_Mode(CipherMode value) { }

	[Address(RVA = "0x156AE60", Offset = "0x156A060", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000047")]
	public virtual void set_Padding(PaddingMode value) { }

}

