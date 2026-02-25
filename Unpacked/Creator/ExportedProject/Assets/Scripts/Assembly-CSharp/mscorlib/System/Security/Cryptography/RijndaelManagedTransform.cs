namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FF")]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	[Token(Token = "0x4000CFE")]
	private static readonly Byte[] s_Sbox; //Field offset: 0x0
	[Token(Token = "0x4000CFF")]
	private static readonly Int32[] s_Rcon; //Field offset: 0x8
	[Token(Token = "0x4000D00")]
	private static readonly Int32[] s_T; //Field offset: 0x10
	[Token(Token = "0x4000D01")]
	private static readonly Int32[] s_TF; //Field offset: 0x18
	[Token(Token = "0x4000D02")]
	private static readonly Int32[] s_iT; //Field offset: 0x20
	[Token(Token = "0x4000D03")]
	private static readonly Int32[] s_iTF; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CEC")]
	private CipherMode m_cipherMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CED")]
	private PaddingMode m_paddingValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CEE")]
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000CEF")]
	private int m_blockSizeBits; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CF0")]
	private int m_blockSizeBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000CF1")]
	private int m_inputBlockSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CF2")]
	private int m_outputBlockSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CF3")]
	private Int32[] m_encryptKeyExpansion; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CF4")]
	private Int32[] m_decryptKeyExpansion; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CF5")]
	private int m_Nr; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000CF6")]
	private int m_Nb; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CF7")]
	private int m_Nk; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CF8")]
	private Int32[] m_encryptindex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000CF9")]
	private Int32[] m_decryptindex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CFA")]
	private Int32[] m_IV; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CFB")]
	private Int32[] m_lastBlockBuffer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000CFC")]
	private Byte[] m_depadBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000CFD")]
	private Byte[] m_shiftRegister; //Field offset: 0x78

	[Token(Token = "0x17000282")]
	public override bool CanTransformMultipleBlocks
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001825")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000280")]
	public override int InputBlockSize
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001823")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000281")]
	public override int OutputBlockSize
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001824")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1340400", Offset = "0x133F600", Length = "0x26E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001833")]
	private static RijndaelManagedTransform() { }

	[Address(RVA = "0x1340670", Offset = "0x133F870", Length = "0x6CB")]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001820")]
	internal RijndaelManagedTransform(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	[Address(RVA = "0x133D210", Offset = "0x133C410", Length = "0x22E")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600182C")]
	private void Dec(Int32* decryptindex, Int32* decryptKeyExpansion, Int32* iT, Int32* iTF, Int32* work, Int32* temp) { }

	[Address(RVA = "0x133D440", Offset = "0x133C640", Length = "0xEEA")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Dec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600182A")]
	private int DecryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[Address(RVA = "0x133E330", Offset = "0x133D530", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001821")]
	public override void Dispose() { }

	[Address(RVA = "0x133E450", Offset = "0x133D650", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001822")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x133E580", Offset = "0x133D780", Length = "0x204")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600182B")]
	private void Enc(Int32* encryptindex, Int32* encryptKeyExpansion, Int32* T, Int32* TF, Int32* work, Int32* temp) { }

	[Address(RVA = "0x133E790", Offset = "0x133D990", Length = "0xCA2")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001829")]
	private int EncryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[Address(RVA = "0x133F440", Offset = "0x133E640", Length = "0x623")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(int), typeof(PaddingMode), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "SubWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600182D")]
	private void GenerateKeyExpansion(Byte[] rgbKey) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001825")]
	public override bool get_CanTransformMultipleBlocks() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001823")]
	public override int get_InputBlockSize() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001824")]
	public override int get_OutputBlockSize() { }

	[Address(RVA = "0x133FA70", Offset = "0x133EC70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001832")]
	private static int MulX(int x) { }

	[Address(RVA = "0x133FAA0", Offset = "0x133ECA0", Length = "0x75")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001828")]
	public void Reset() { }

	[Address(RVA = "0x1340D40", Offset = "0x133FF40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600182E")]
	private static int rot1(int val) { }

	[Address(RVA = "0x1340D50", Offset = "0x133FF50", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600182F")]
	private static int rot2(int val) { }

	[Address(RVA = "0x1340D60", Offset = "0x133FF60", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001830")]
	private static int rot3(int val) { }

	[Address(RVA = "0x133FB20", Offset = "0x133ED20", Length = "0xE7")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001831")]
	private static int SubWord(int a) { }

	[Address(RVA = "0x133FC10", Offset = "0x133EE10", Length = "0x41F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001826")]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x1340030", Offset = "0x133F230", Length = "0x3C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001827")]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

