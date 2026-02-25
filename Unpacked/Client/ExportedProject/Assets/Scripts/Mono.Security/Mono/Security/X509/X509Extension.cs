namespace Mono.Security.X509;

[Token(Token = "0x2000016")]
public class X509Extension
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006F")]
	protected string extnOid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000070")]
	protected bool extnCritical; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000071")]
	protected ASN1 extnValue; //Field offset: 0x20

	[Token(Token = "0x1700003F")]
	public bool Critical
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003E")]
	public string Oid
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public ASN1 Value
	{
		[Address(RVA = "0x12BFE00", Offset = "0x12BF000", Length = "0x37")]
		[CalledBy(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x12BF940", Offset = "0x12BEB40", Length = "0x322")]
	[CalledBy(Type = typeof(X509ExtensionCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C5")]
	public X509Extension(ASN1 asn1) { }

	[Address(RVA = "0x12BFC70", Offset = "0x12BEE70", Length = "0x181")]
	[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthorityKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicConstraintsExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Extension), Member = "get_Value", ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000C6")]
	public X509Extension(X509Extension extension) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	protected override void Decode() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C8")]
	protected override void Encode() { }

	[Address(RVA = "0x12BF480", Offset = "0x12BE680", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CA")]
	public bool get_Critical() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C9")]
	public string get_Oid() { }

	[Address(RVA = "0x12BFE00", Offset = "0x12BF000", Length = "0x37")]
	[CalledBy(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	public ASN1 get_Value() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12BF5E0", Offset = "0x12BE7E0", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Extension), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CF")]
	public virtual string ToString() { }

	[Address(RVA = "0x12BF700", Offset = "0x12BE900", Length = "0x231")]
	[CalledBy(Type = typeof(X509Extension), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000CE")]
	private void WriteLine(StringBuilder sb, int n, int pos) { }

}

