namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001EF")]
public class OidTokenizer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400049F")]
	private string oid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A0")]
	private int index; //Field offset: 0x18

	[Token(Token = "0x17000195")]
	public bool HasMoreTokens
	{
		[Address(RVA = "0x110F780", Offset = "0x110E980", Length = "0x8")]
		[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600118B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600118A")]
	public OidTokenizer(string oid) { }

	[Address(RVA = "0x110F780", Offset = "0x110E980", Length = "0x8")]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600118B")]
	public bool get_HasMoreTokens() { }

	[Address(RVA = "0x110F6F0", Offset = "0x110E8F0", Length = "0x87")]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600118C")]
	public string NextToken() { }

}

