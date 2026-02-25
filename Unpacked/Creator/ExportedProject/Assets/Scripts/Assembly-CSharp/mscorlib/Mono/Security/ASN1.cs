namespace Mono.Security;

[DefaultMember("Item")]
[Token(Token = "0x200005E")]
internal class ASN1
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BD")]
	private byte m_nTag; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BE")]
	private Byte[] m_aValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001BF")]
	private ArrayList elist; //Field offset: 0x20

	[Token(Token = "0x17000017")]
	public int Count
	{
		[Address(RVA = "0x12A8880", Offset = "0x12A7A80", Length = "0x22")]
		[CallerCount(Count = 13)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011D")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000018")]
	public Byte[] Value
	{
		[Address(RVA = "0x12D61D0", Offset = "0x12D53D0", Length = "0x94")]
		[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600011E")]
		 get { } //Length: 148
	}

	[Address(RVA = "0x12A8840", Offset = "0x12A7A40", Length = "0x37")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	public ASN1(byte tag) { }

	[Address(RVA = "0x11E1BD0", Offset = "0x11E0DD0", Length = "0x41")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public ASN1(byte tag, Byte[] data) { }

	[Address(RVA = "0x12D6040", Offset = "0x12D5240", Length = "0x18B")]
	[CalledBy(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600011C")]
	public ASN1(Byte[] data) { }

	[Address(RVA = "0x12D5300", Offset = "0x12D4500", Length = "0x9D")]
	[CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011F")]
	public ASN1 Add(ASN1 asn1) { }

	[Address(RVA = "0x12D54C0", Offset = "0x12D46C0", Length = "0x1DD")]
	[CalledBy(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	[Address(RVA = "0x12D53A0", Offset = "0x12D45A0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000122")]
	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	[Address(RVA = "0x12A8880", Offset = "0x12A7A80", Length = "0x22")]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public int get_Count() { }

	[Address(RVA = "0x12D61D0", Offset = "0x12D53D0", Length = "0x94")]
	[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011E")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x12D56A0", Offset = "0x12D48A0", Length = "0x681")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000120")]
	public override Byte[] GetBytes() { }

	[Address(RVA = "0x12D5D30", Offset = "0x12D4F30", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000123")]
	public virtual string ToString() { }

}

