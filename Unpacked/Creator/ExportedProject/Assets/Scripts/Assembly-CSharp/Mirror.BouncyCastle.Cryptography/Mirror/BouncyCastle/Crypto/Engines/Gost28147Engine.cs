namespace Mirror.BouncyCastle.Crypto.Engines;

[Token(Token = "0x2000158")]
public class Gost28147Engine : IBlockCipher
{
	[Token(Token = "0x40002E5")]
	private static readonly Byte[] Sbox_Default; //Field offset: 0x0
	[Token(Token = "0x40002E6")]
	private static readonly Byte[] ESbox_Test; //Field offset: 0x8
	[Token(Token = "0x40002E7")]
	private static readonly Byte[] ESbox_A; //Field offset: 0x10
	[Token(Token = "0x40002E8")]
	private static readonly Byte[] ESbox_B; //Field offset: 0x18
	[Token(Token = "0x40002E9")]
	private static readonly Byte[] ESbox_C; //Field offset: 0x20
	[Token(Token = "0x40002EA")]
	private static readonly Byte[] ESbox_D; //Field offset: 0x28
	[Token(Token = "0x40002EB")]
	private static readonly Byte[] DSbox_Test; //Field offset: 0x30
	[Token(Token = "0x40002EC")]
	private static readonly Byte[] DSbox_A; //Field offset: 0x38
	[Token(Token = "0x40002ED")]
	private static readonly Dictionary<String, Byte[]> m_sBoxes; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E2")]
	private Int32[] workingKey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E3")]
	private bool forEncryption; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E4")]
	private Byte[] S; //Field offset: 0x20

	[Address(RVA = "0x11EC840", Offset = "0x11EBA40", Length = "0x860")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAA")]
	private static Gost28147Engine() { }

	[Address(RVA = "0x11ED0B0", Offset = "0x11EC2B0", Length = "0x6A")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411Digest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CAC")]
	public Gost28147Engine() { }

	[Address(RVA = "0x11EBC70", Offset = "0x11EAE70", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAB")]
	private static void AddSBox(string sBoxName, Byte[] sBox) { }

	[Address(RVA = "0x11EBD00", Offset = "0x11EAF00", Length = "0x136")]
	[CalledBy(Type = typeof(Gost28147Engine), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CB0")]
	private Int32[] GenerateWorkingKey(bool forEncryption, Byte[] userKey) { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CAE")]
	public override int GetBlockSize() { }

	[Address(RVA = "0x11EBE40", Offset = "0x11EB040", Length = "0x105")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CB3")]
	public static Byte[] GetSBox(string sBoxName) { }

	[Address(RVA = "0x11EC2C0", Offset = "0x11EB4C0", Length = "0x171")]
	[CalledBy(Type = typeof(Gost28147Engine), Member = "Gost28147Func", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB1")]
	private int Gost28147_mainStep(int n1, int key) { }

	[Address(RVA = "0x11EBF50", Offset = "0x11EB150", Length = "0x36E")]
	[CalledBy(Type = typeof(Gost28147Engine), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gost28147Engine), Member = "Gost28147_mainStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB2")]
	private void Gost28147Func(Int32[] workingKey, Byte[] inBytes, int inOff, Byte[] outBytes, int outOff) { }

	[Address(RVA = "0x11EC440", Offset = "0x11EB640", Length = "0x2C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gost28147Engine), Member = "GenerateWorkingKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Byte[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Platform), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(KeyParameter), Member = "GetKey", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000CAD")]
	public override void Init(bool forEncryption, ICipherParameters parameters) { }

	[Address(RVA = "0x11EC710", Offset = "0x11EB910", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gost28147Engine), Member = "Gost28147Func", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Check), Member = "ThrowOutputLengthException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Check), Member = "ThrowDataLengthException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAF")]
	public override int ProcessBlock(Byte[] input, int inOff, Byte[] output, int outOff) { }

}

