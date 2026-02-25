namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001A6")]
public class Asn1RelativeOid : Asn1Object
{
	[Token(Token = "0x4000430")]
	private static readonly Asn1RelativeOid[] Cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000431")]
	private readonly Byte[] m_contents; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000432")]
	private string m_identifier; //Field offset: 0x18

	[Address(RVA = "0x10E9B30", Offset = "0x10E8D30", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F9B")]
	private static Asn1RelativeOid() { }

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F89")]
	private Asn1RelativeOid(Byte[] contents, string identifier) { }

	[Address(RVA = "0x10E8B20", Offset = "0x10E7D20", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000F8C")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x10E8BD0", Offset = "0x10E7DD0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[Token(Token = "0x6000F8D")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x10E8C20", Offset = "0x10E7E20", Length = "0x63")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "CreatePrimitiveDerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefiniteLengthInputStream), typeof(Byte[][])}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F92")]
	internal static void CheckContentsLength(int contentsLength) { }

	[Address(RVA = "0x10E8C90", Offset = "0x10E7E90", Length = "0x1DF")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "Branch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DerObjectIdentifier))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F93")]
	internal static void CheckIdentifier(string identifier) { }

	[Address(RVA = "0x10E8E70", Offset = "0x10E8070", Length = "0x33A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F94")]
	internal static Asn1RelativeOid CreatePrimitive(Byte[] contents, bool clone) { }

	[Address(RVA = "0x10E9320", Offset = "0x10E8520", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F8E")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x10E9230", Offset = "0x10E8430", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F90")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x10E91B0", Offset = "0x10E83B0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F91")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x10E92A0", Offset = "0x10E84A0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F8F")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x10E9390", Offset = "0x10E8590", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8A")]
	public string GetID() { }

	[Address(RVA = "0x10E9430", Offset = "0x10E8630", Length = "0x5B")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "CreatePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(DerObjectIdentifier))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F95")]
	internal static bool IsValidContents(Byte[] contents) { }

	[Address(RVA = "0x10E9490", Offset = "0x10E8690", Length = "0xB7")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "IsValidIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F96")]
	internal static bool IsValidIdentifier(string identifier, int from) { }

	[Address(RVA = "0x10E9550", Offset = "0x10E8750", Length = "0x218")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BigInteger), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F97")]
	internal static string ParseContents(Byte[] contents) { }

	[Address(RVA = "0x10E9770", Offset = "0x10E8970", Length = "0x170")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "Branch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DerObjectIdentifier))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OidTokenizer), Member = "NextToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OidTokenizer), Member = "get_HasMoreTokens", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1RelativeOid), Member = "WriteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Asn1RelativeOid), Member = "WriteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F98")]
	internal static Byte[] ParseIdentifier(string identifier) { }

	[Address(RVA = "0x10E9390", Offset = "0x10E8590", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8B")]
	public virtual string ToString() { }

	[Address(RVA = "0x10E99D0", Offset = "0x10E8BD0", Length = "0x15E")]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F9A")]
	internal static void WriteField(Stream outputStream, BigInteger fieldValue) { }

	[Address(RVA = "0x10E98F0", Offset = "0x10E8AF0", Length = "0xD8")]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F99")]
	internal static void WriteField(Stream outputStream, long fieldValue) { }

}

