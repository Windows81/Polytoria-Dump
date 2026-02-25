namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000142")]
public class KeyParameter : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028E")]
	private readonly Byte[] m_key; //Field offset: 0x10

	[Token(Token = "0x17000173")]
	public int KeyLength
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C27")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x11EF580", Offset = "0x11EE780", Length = "0x106")]
	[CalledBy(Type = typeof(HkdfBytesGenerator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDerivationParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HkdfBytesGenerator), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(KeyParameter))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "E", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", "System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C24")]
	public KeyParameter(Byte[] key) { }

	[Address(RVA = "0x11EF410", Offset = "0x11EE610", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C25")]
	public void CopyTo(Byte[] buf, int off, int len) { }

	[Address(RVA = "0x11EF4A0", Offset = "0x11EE6A0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "FixedTimeEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000C28")]
	internal bool FixedTimeEquals(Byte[] data) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C27")]
	public int get_KeyLength() { }

	[Address(RVA = "0x11EF500", Offset = "0x11EE700", Length = "0x77")]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMac), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AesEngine), Member = "GenerateWorkingKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyParameter), typeof(bool)}, ReturnType = typeof(UInt32[][]))]
	[CalledBy(Type = typeof(Gost28147Engine), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C26")]
	public Byte[] GetKey() { }

}

