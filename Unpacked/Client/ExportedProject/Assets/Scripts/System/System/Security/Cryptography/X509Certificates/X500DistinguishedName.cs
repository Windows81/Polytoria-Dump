namespace System.Security.Cryptography.X509Certificates;

[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
[Token(Token = "0x2000126")]
public sealed class X500DistinguishedName : AsnEncodedData
{
	[Token(Token = "0x4000575")]
	private const X500DistinguishedNameFlags AllFlags = 29169; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000576")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000577")]
	private Byte[] canonEncoding; //Field offset: 0x28

	[Token(Token = "0x17000115")]
	public string Name
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17824C0", Offset = "0x17816C0", Length = "0x17E")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X500DistinguishedName), Member = "DecodeRawData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60006C8")]
	public X500DistinguishedName(Byte[] encodedDistinguishedName) { }

	[Address(RVA = "0x17820C0", Offset = "0x17812C0", Length = "0xE")]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60006C9")]
	public X500DistinguishedName(string distinguishedName) { }

	[Address(RVA = "0x17820D0", Offset = "0x17812D0", Length = "0x3EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedNameFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(X500DistinguishedName), Member = "DecodeRawData", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(X501), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006CA")]
	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag) { }

	[Address(RVA = "0x1781960", Offset = "0x1780B60", Length = "0x210")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedNameFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(X500DistinguishedName), Member = "Canonize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D1")]
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

	[Address(RVA = "0x1781B80", Offset = "0x1780D80", Length = "0x1CB")]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName), typeof(X500DistinguishedName)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006D0")]
	private static string Canonize(string s) { }

	[Address(RVA = "0x1781E30", Offset = "0x1781030", Length = "0x1AA")]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X500DistinguishedNameFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName), typeof(X500DistinguishedName)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006CC")]
	public string Decode(X500DistinguishedNameFlags flag) { }

	[Address(RVA = "0x1781D50", Offset = "0x1780F50", Length = "0xDE")]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X500DistinguishedNameFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006CF")]
	private void DecodeRawData() { }

	[Address(RVA = "0x1781FE0", Offset = "0x17811E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedNameFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CD")]
	public virtual string Format(bool multiLine) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CB")]
	public string get_Name() { }

	[Address(RVA = "0x1782050", Offset = "0x1781250", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006CE")]
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

}

