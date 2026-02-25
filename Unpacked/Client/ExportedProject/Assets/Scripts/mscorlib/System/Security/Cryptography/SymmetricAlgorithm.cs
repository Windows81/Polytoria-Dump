namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000314")]
public abstract class SymmetricAlgorithm : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D2F")]
	protected int BlockSizeValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D30")]
	protected int FeedbackSizeValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D31")]
	protected Byte[] IVValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D32")]
	protected Byte[] KeyValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D33")]
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D34")]
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D35")]
	protected int KeySizeValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D36")]
	protected CipherMode ModeValue; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D37")]
	protected PaddingMode PaddingValue; //Field offset: 0x40

	[Token(Token = "0x1700028A")]
	public override int BlockSize
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018AE")]
		 get { } //Length: 4
		[Address(RVA = "0x1351550", Offset = "0x1350750", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018AF")]
		 set { } //Length: 325
	}

	[Token(Token = "0x1700028B")]
	public override int FeedbackSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018B0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700028C")]
	public override Byte[] IV
	{
		[Address(RVA = "0x1351390", Offset = "0x1350590", Length = "0x94")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_IV", ReturnType = "System.Byte[]")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60018B1")]
		 get { } //Length: 148
		[Address(RVA = "0x13516A0", Offset = "0x13508A0", Length = "0x16B")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60018B2")]
		 set { } //Length: 363
	}

	[Token(Token = "0x1700028D")]
	public override Byte[] Key
	{
		[Address(RVA = "0x1351430", Offset = "0x1350630", Length = "0x94")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_Key", ReturnType = "System.Byte[]")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60018B3")]
		 get { } //Length: 148
		[Address(RVA = "0x13518B0", Offset = "0x1350AB0", Length = "0x183")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60018B4")]
		 set { } //Length: 387
	}

	[Token(Token = "0x1700028F")]
	public override int KeySize
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018B6")]
		 get { } //Length: 4
		[Address(RVA = "0x1351810", Offset = "0x1350A10", Length = "0x90")]
		[CalledBy(Type = typeof(RC2), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018B7")]
		 set { } //Length: 144
	}

	[Token(Token = "0x1700028E")]
	public override KeySizes[] LegalKeySizes
	{
		[Address(RVA = "0x13514D0", Offset = "0x13506D0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018B5")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000290")]
	public override CipherMode Mode
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018B8")]
		 get { } //Length: 4
		[Address(RVA = "0x1351A40", Offset = "0x1350C40", Length = "0x7D")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018B9")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000291")]
	public override PaddingMode Padding
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018BA")]
		 get { } //Length: 4
		[Address(RVA = "0x1351AC0", Offset = "0x1350CC0", Length = "0x7D")]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018BB")]
		 set { } //Length: 125
	}

	[Address(RVA = "0x1351360", Offset = "0x1350560", Length = "0x24")]
	[CalledBy(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DES), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Rijndael), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018AA")]
	protected SymmetricAlgorithm() { }

	[Address(RVA = "0x1350FE0", Offset = "0x13501E0", Length = "0x3B")]
	[CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", typeof(int), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_LM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x60018AC")]
	public void Clear() { }

	[Address(RVA = "0x1351100", Offset = "0x1350300", Length = "0xC6")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetSymmetricAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", typeof(int)}, ReturnType = typeof(SymmetricAlgorithm))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60018BD")]
	public static SymmetricAlgorithm Create(string algName) { }

	[Token(Token = "0x60018C1")]
	public abstract ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1351020", Offset = "0x1350220", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018C0")]
	public override ICryptoTransform CreateDecryptor() { }

	[Token(Token = "0x60018BF")]
	public abstract ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1351090", Offset = "0x1350290", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018BE")]
	public override ICryptoTransform CreateEncryptor() { }

	[Address(RVA = "0x1351250", Offset = "0x1350450", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018AB")]
	public override void Dispose() { }

	[Address(RVA = "0x13511D0", Offset = "0x13503D0", Length = "0x72")]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60018AD")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x60018C3")]
	public abstract void GenerateIV() { }

	[Token(Token = "0x60018C2")]
	public abstract void GenerateKey() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018AE")]
	public override int get_BlockSize() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018B0")]
	public override int get_FeedbackSize() { }

	[Address(RVA = "0x1351390", Offset = "0x1350590", Length = "0x94")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_IV", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018B1")]
	public override Byte[] get_IV() { }

	[Address(RVA = "0x1351430", Offset = "0x1350630", Length = "0x94")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_Key", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018B3")]
	public override Byte[] get_Key() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018B6")]
	public override int get_KeySize() { }

	[Address(RVA = "0x13514D0", Offset = "0x13506D0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018B5")]
	public override KeySizes[] get_LegalKeySizes() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018B8")]
	public override CipherMode get_Mode() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018BA")]
	public override PaddingMode get_Padding() { }

	[Address(RVA = "0x1351550", Offset = "0x1350750", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018AF")]
	public override void set_BlockSize(int value) { }

	[Address(RVA = "0x13516A0", Offset = "0x13508A0", Length = "0x16B")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60018B2")]
	public override void set_IV(Byte[] value) { }

	[Address(RVA = "0x13518B0", Offset = "0x1350AB0", Length = "0x183")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60018B4")]
	public override void set_Key(Byte[] value) { }

	[Address(RVA = "0x1351810", Offset = "0x1350A10", Length = "0x90")]
	[CalledBy(Type = typeof(RC2), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018B7")]
	public override void set_KeySize(int value) { }

	[Address(RVA = "0x1351A40", Offset = "0x1350C40", Length = "0x7D")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018B9")]
	public override void set_Mode(CipherMode value) { }

	[Address(RVA = "0x1351AC0", Offset = "0x1350CC0", Length = "0x7D")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018BB")]
	public override void set_Padding(PaddingMode value) { }

	[Address(RVA = "0x13512C0", Offset = "0x13504C0", Length = "0x90")]
	[CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018BC")]
	public bool ValidKeySize(int bitLength) { }

}

