namespace Mirror.Transports.Encryption;

[Token(Token = "0x2000013")]
public class EncryptedConnection
{
	[CompilerGenerated]
	[Token(Token = "0x2000016")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C4")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1286AA0", Offset = "0x1285CA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000102")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000103")]
		public <>c() { }

		[Address(RVA = "0x1284AB0", Offset = "0x1283CB0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AesUtilities), Member = "CreateEngine", ReturnType = typeof(IBlockCipher))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(GcmBlockCipher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBlockCipher)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000104")]
		internal GcmBlockCipher <.cctor>b__47_0() { }

		[Address(RVA = "0x1284B10", Offset = "0x1283D10", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Sha256Digest), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(HkdfBytesGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDigest)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000105")]
		internal HkdfBytesGenerator <.cctor>b__47_1() { }

		[Address(RVA = "0x1284B90", Offset = "0x1283D90", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6000106")]
		internal Byte[] <.cctor>b__47_2() { }

		[Address(RVA = "0x1284BD0", Offset = "0x1283DD0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6000107")]
		internal Byte[] <.cctor>b__47_3() { }

		[Address(RVA = "0x1284C10", Offset = "0x1283E10", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6000108")]
		internal Byte[] <.cctor>b__47_4() { }

	}

	[Token(Token = "0x2000014")]
	private enum OpCodes
	{
		Data = 1,
		HandshakeStart = 2,
		HandshakeAck = 3,
		HandshakeFin = 4,
	}

	[Token(Token = "0x2000015")]
	private enum State
	{
		WaitingHandshake = 0,
		WaitingHandshakeReply = 1,
		Ready = 2,
	}

	[Token(Token = "0x400009E")]
	private const int KeyLength = 32; //Field offset: 0x0
	[Token(Token = "0x400009F")]
	private const int HkdfSaltSize = 64; //Field offset: 0x0
	[Token(Token = "0x40000A0")]
	private static readonly Byte[] HkdfInfo; //Field offset: 0x0
	[Token(Token = "0x40000A1")]
	private const int NonceSize = 12; //Field offset: 0x0
	[Token(Token = "0x40000A2")]
	private const int MacSizeBytes = 16; //Field offset: 0x0
	[Token(Token = "0x40000A3")]
	private const int MacSizeBits = 128; //Field offset: 0x0
	[Token(Token = "0x40000A4")]
	public const int Overhead = 29; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	private const double DurationTimeout = 2; //Field offset: 0x0
	[Token(Token = "0x40000A6")]
	private const double DurationResend = 0.05; //Field offset: 0x0
	[Token(Token = "0x40000A7")]
	private static readonly ThreadLocal<GcmBlockCipher> Cipher; //Field offset: 0x8
	[Token(Token = "0x40000A8")]
	private static readonly ThreadLocal<HkdfBytesGenerator> Hkdf; //Field offset: 0x10
	[Token(Token = "0x40000A9")]
	private static readonly ThreadLocal<Byte[]> ReceiveNonce; //Field offset: 0x18
	[Token(Token = "0x40000AA")]
	private static readonly ThreadLocal<Byte[]> TMPRemoteSaltBuffer; //Field offset: 0x20
	[Token(Token = "0x40000AB")]
	private static ThreadLocal<Byte[]> TMPCryptBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AC")]
	private State state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AD")]
	private readonly Action<ArraySegment`1<Byte>, Int32> send; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AE")]
	private readonly Action<ArraySegment`1<Byte>, Int32> receive; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AF")]
	private readonly Action ready; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B0")]
	private readonly Action<TransportError, String> error; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000B1")]
	private readonly Func<PubKeyInfo, Boolean> validateRemoteKey; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000B2")]
	private EncryptionCredentials credentials; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000B3")]
	private readonly Byte[] hkdfSalt; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B4")]
	private NetworkReader _tmpReader; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B5")]
	private double handshakeTimeout; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000B6")]
	private double nextHandshakeResend; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000B7")]
	private Byte[] nonce; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000B8")]
	private AeadParameters cipherParametersEncrypt; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000B9")]
	private AeadParameters cipherParametersDecrypt; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000BA")]
	private readonly bool sendsFirst; //Field offset: 0x80

	[Token(Token = "0x1700000A")]
	public bool IsReady
	{
		[Address(RVA = "0x1276890", Offset = "0x1275A90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1276300", Offset = "0x1275500", Length = "0x3F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000101")]
	private static EncryptedConnection() { }

	[Address(RVA = "0x1276700", Offset = "0x1275900", Length = "0x18D")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "HandleInnerServerConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "HandleInnerClientConnected", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "HandleInnerServerConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "HandleInnerClientConnected", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncryptedConnection), Member = "GenerateSecureBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000F3")]
	public EncryptedConnection(EncryptionCredentials credentials, bool isClient, Action<ArraySegment`1<Byte>, Int32> sendAction, Action<ArraySegment`1<Byte>, Int32> receiveAction, Action readyAction, Action<TransportError, String> errorAction, Func<PubKeyInfo, Boolean> validateRemoteKey = null) { }

	[Address(RVA = "0x12743F0", Offset = "0x12735F0", Length = "0x657")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "ToByteArrayUnsigned", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(AeadParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyParameter), typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = "GenerateSecureBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(KeyParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HkdfBytesGenerator), Member = "GenerateBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(HkdfBytesGenerator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDerivationParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HkdfParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EncryptionCredentials), Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000FF")]
	private void CompleteExchange(ArraySegment<Byte> remotePubKeyRaw, Byte[] salt) { }

	[Address(RVA = "0x1274A50", Offset = "0x1273C50", Length = "0x499")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "ProcessBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "GetOutputSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000FA")]
	private ArraySegment<Byte> Decrypt(ArraySegment<Byte> ciphertext) { }

	[Address(RVA = "0x1274EF0", Offset = "0x12740F0", Length = "0x480")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "ProcessBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GcmBlockCipher), Member = "GetOutputSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GcmBlockCipher), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F9")]
	private ArraySegment<Byte> Encrypt(ArraySegment<Byte> plaintext) { }

	[Address(RVA = "0x1275380", Offset = "0x1274580", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FC")]
	private static void EnsureSize(ref Byte[] buffer, int size) { }

	[Address(RVA = "0x1275420", Offset = "0x1274620", Length = "0xDB")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionCredentials), typeof(bool), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(Action), typeof(System.Action`2<Mirror.TransportError, System.String>), typeof(System.Func`2<Mirror.Transports.Encryption.PubKeyInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F4")]
	private static Byte[] GenerateSecureBytes(int size) { }

	[Address(RVA = "0x1276890", Offset = "0x1275A90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F2")]
	public bool get_IsReady() { }

	[Address(RVA = "0x1275500", Offset = "0x1274700", Length = "0x57F")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "HandleInnerServerDataReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "HandleInnerClientDataReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "HandleInnerServerDataReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "HandleInnerClientDataReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NetworkReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(EncryptedConnection), Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(NetworkReader), Member = "get_Remaining", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(EncryptedConnection), Member = "SetReady", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EncryptedConnection), Member = "SendHandshakeFin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EncryptedConnection), Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EncryptedConnection), Member = "SendHandshakeAndPubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCodes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F5")]
	public void OnReceiveRaw(ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1275A80", Offset = "0x1274C80", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000F7")]
	private void ResetTimeouts() { }

	[Address(RVA = "0x1275E20", Offset = "0x1275020", Length = "0x287")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = "Encrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F8")]
	public void Send(ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1275AA0", Offset = "0x1274CA0", Length = "0x1FC")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FD")]
	private void SendHandshakeAndPubKey(OpCodes opcode) { }

	[Address(RVA = "0x1275CA0", Offset = "0x1274EA0", Length = "0x171")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FE")]
	private void SendHandshakeFin() { }

	[Address(RVA = "0x12760B0", Offset = "0x12752B0", Length = "0x45")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F6")]
	private void SetReady() { }

	[Address(RVA = "0x1276100", Offset = "0x1275300", Length = "0x19F")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ClientLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ServerLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedClientLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedServerLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EncryptedConnection), Member = "SendHandshakeAndPubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCodes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = "SendHandshakeFin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000100")]
	public void TickNonReady(double time) { }

	[Address(RVA = "0x12762A0", Offset = "0x12754A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000FB")]
	private void UpdateNonce() { }

}

