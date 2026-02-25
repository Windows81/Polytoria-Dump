namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x2000003")]
public static class Arrays
{
	[Token(Token = "0x4000001")]
	public static readonly Byte[] EmptyBytes; //Field offset: 0x0
	[Token(Token = "0x4000002")]
	public static readonly Int32[] EmptyInts; //Field offset: 0x8

	[Address(RVA = "0x10AB4B0", Offset = "0x10AA6B0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600001B")]
	private static Arrays() { }

	[Address(RVA = "0x10AA630", Offset = "0x10A9830", Length = "0xAE")]
	[CalledBy(Type = typeof(GF2Polynomial), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "CheckFieldElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(F2mFieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000006")]
	public static bool AreEqual(Int32[] a, Int32[] b) { }

	[Address(RVA = "0x10AA6E0", Offset = "0x10A98E0", Length = "0xA1")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000004")]
	public static bool AreEqual(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x10AA790", Offset = "0x10A9990", Length = "0x76")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(LongArray), Member = "Copy", ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dstu7564Digest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6000011")]
	public static UInt64[] Clone(UInt64[] data) { }

	[Address(RVA = "0x10AA890", Offset = "0x10A9A90", Length = "0x76")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6000010")]
	public static UInt32[] Clone(UInt32[] data) { }

	[Address(RVA = "0x10AA810", Offset = "0x10A9A10", Length = "0x76")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public static Byte[] Clone(Byte[] data) { }

	[Address(RVA = "0x10AA910", Offset = "0x10A9B10", Length = "0x76")]
	[CalledBy(Type = typeof(FiniteFields), Member = "GetBinaryExtensionField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(IPolynomialExtensionField))]
	[CalledBy(Type = typeof(GF2Polynomial), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GF2Polynomial), Member = "GetExponentsPresent", ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public static Int32[] Clone(Int32[] data) { }

	[Address(RVA = "0x10AA990", Offset = "0x10A9B90", Length = "0x1A5")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "Branch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DerObjectIdentifier))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000017")]
	public static Byte[] Concatenate(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x10AACA0", Offset = "0x10A9EA0", Length = "0xA9")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "AdjustStack", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000014")]
	public static UInt32[] CopyOf(UInt32[] data, int newLength) { }

	[Address(RVA = "0x10AAB40", Offset = "0x10A9D40", Length = "0x155")]
	[CalledBy(Type = typeof(DerBitString), Member = "GetOctets", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerBitString), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000015")]
	public static Byte[] CopyOfRange(Byte[] data, int from, int to) { }

	[Address(RVA = "0x10AADA0", Offset = "0x10A9FA0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000013")]
	public static void Fill(Byte[] buf, int from, int to, byte b) { }

	[Address(RVA = "0x10AAD50", Offset = "0x10A9F50", Length = "0x45")]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "OutputFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "InitSponge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000012")]
	public static void Fill(Byte[] buf, byte b) { }

	[Address(RVA = "0x10AADE0", Offset = "0x10A9FE0", Length = "0x1EA")]
	[CalledBy(Type = typeof(KeyParameter), Member = "FixedTimeEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Token(Token = "0x6000005")]
	public static bool FixedTimeEquals(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x10AAFD0", Offset = "0x10AA1D0", Length = "0x6D")]
	[CalledBy(Type = typeof(DerBitString), Member = "Asn1GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600000A")]
	public static int GetHashCode(Byte[] data, int off, int len) { }

	[Address(RVA = "0x10AB130", Offset = "0x10AA330", Length = "0x52")]
	[CalledBy(Type = typeof(GF2Polynomial), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600000B")]
	public static int GetHashCode(Int32[] data) { }

	[Address(RVA = "0x10AB190", Offset = "0x10AA390", Length = "0x53")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000009")]
	public static int GetHashCode(Byte[] data) { }

	[Address(RVA = "0x10AB0B0", Offset = "0x10AA2B0", Length = "0x72")]
	[CalledBy(Type = typeof(LongArray), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT193FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecT571FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[Token(Token = "0x600000D")]
	public static int GetHashCode(UInt64[] data, int off, int len) { }

	[Address(RVA = "0x10AB040", Offset = "0x10AA240", Length = "0x61")]
	[CalledBy(Type = typeof(SecP224K1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SM2P256V1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP160R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP160R2FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP224R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP256K1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP256R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP384R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SecP521R1FieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[Token(Token = "0x600000C")]
	public static int GetHashCode(UInt32[] data, int off, int len) { }

	[Address(RVA = "0x10AB1F0", Offset = "0x10AA3F0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000016")]
	private static int GetLength(int from, int to) { }

	[Address(RVA = "0x10AB300", Offset = "0x10AA500", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000008")]
	private static bool HaveSameContents(Int32[] a, Int32[] b) { }

	[Address(RVA = "0x10AB2A0", Offset = "0x10AA4A0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000007")]
	private static bool HaveSameContents(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x10AB380", Offset = "0x10AA580", Length = "0x4C")]
	[CalledBy(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000019")]
	public static bool IsNullOrContainsNull(Object[] array) { }

	[Address(RVA = "0x10AB3D0", Offset = "0x10AA5D0", Length = "0x10")]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "AddSeedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001A")]
	public static bool IsNullOrEmpty(Byte[] array) { }

	[Address(RVA = "0x10AB3E0", Offset = "0x10AA5E0", Length = "0xCB")]
	[CalledBy(Type = typeof(DerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000018")]
	public static Byte[] Prepend(Byte[] a, byte b) { }

}

