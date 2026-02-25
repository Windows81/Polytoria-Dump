namespace Mirror.BouncyCastle.Crypto.Engines;

[Token(Token = "0x2000157")]
public sealed class AesEngine : IBlockCipher
{
	[Token(Token = "0x40002D9")]
	private static readonly Byte[] S; //Field offset: 0x0
	[Token(Token = "0x40002DA")]
	private static readonly Byte[] Si; //Field offset: 0x8
	[Token(Token = "0x40002DB")]
	private static readonly Byte[] rcon; //Field offset: 0x10
	[Token(Token = "0x40002DC")]
	private static readonly UInt32[] T0; //Field offset: 0x18
	[Token(Token = "0x40002DD")]
	private static readonly UInt32[] Tinv0; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DE")]
	private int ROUNDS; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DF")]
	private UInt32[][] WorkingKey; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E0")]
	private bool forEncryption; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E1")]
	private Byte[] s; //Field offset: 0x28

	[Address(RVA = "0x11DD810", Offset = "0x11DCA10", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000CA9")]
	private static AesEngine() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA3")]
	public AesEngine() { }

	[Address(RVA = "0x11D9E10", Offset = "0x11D9010", Length = "0x10FB")]
	[CalledBy(Type = typeof(AesEngine), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA8")]
	private void DecryptBlock(Byte[] input, int inOff, Byte[] output, int outOff, UInt32[][] KW) { }

	[Address(RVA = "0x11DAF10", Offset = "0x11DA110", Length = "0x111E")]
	[CalledBy(Type = typeof(AesEngine), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA7")]
	private void EncryptBlock(Byte[] input, int inOff, Byte[] output, int outOff, UInt32[][] KW) { }

	[Address(RVA = "0x11DC060", Offset = "0x11DB260", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C9E")]
	private static uint FFmulX(uint x) { }

	[Address(RVA = "0x11DC030", Offset = "0x11DB230", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C9F")]
	private static uint FFmulX2(uint x) { }

	[Address(RVA = "0x11DC080", Offset = "0x11DB280", Length = "0x12F7")]
	[CalledBy(Type = typeof(AesEngine), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AesEngine), Member = "Inv_Mcol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KeyParameter), Member = "GetKey", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AesEngine), Member = "SubWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000CA2")]
	private UInt32[][] GenerateWorkingKey(KeyParameter keyParameter, bool forEncryption) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA5")]
	public override int GetBlockSize() { }

	[Address(RVA = "0x11DD380", Offset = "0x11DC580", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AesEngine), Member = "GenerateWorkingKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyParameter), typeof(bool)}, ReturnType = typeof(UInt32[][]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Platform), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CA4")]
	public override void Init(bool forEncryption, ICipherParameters parameters) { }

	[Address(RVA = "0x11DD540", Offset = "0x11DC740", Length = "0xAA")]
	[CalledBy(Type = typeof(AesEngine), Member = "GenerateWorkingKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyParameter), typeof(bool)}, ReturnType = typeof(UInt32[][]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000CA0")]
	private static uint Inv_Mcol(uint x) { }

	[Address(RVA = "0x11DD5F0", Offset = "0x11DC7F0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AesEngine), Member = "DecryptBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int), typeof(UInt32[][])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AesEngine), Member = "EncryptBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int), typeof(UInt32[][])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Check), Member = "ThrowOutputLengthException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Check), Member = "ThrowDataLengthException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CA6")]
	public override int ProcessBlock(Byte[] input, int inOff, Byte[] output, int outOff) { }

	[Address(RVA = "0x10BD170", Offset = "0x10BC370", Length = "0x19")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C9D")]
	private static uint Shift(uint r, int shift) { }

	[Address(RVA = "0x11DD730", Offset = "0x11DC930", Length = "0xD9")]
	[CalledBy(Type = typeof(AesEngine), Member = "GenerateWorkingKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyParameter), typeof(bool)}, ReturnType = typeof(UInt32[][]))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA1")]
	private static uint SubWord(uint x) { }

}

