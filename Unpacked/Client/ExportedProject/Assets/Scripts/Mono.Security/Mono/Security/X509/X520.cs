namespace Mono.Security.X509;

[Token(Token = "0x200001B")]
public class X520
{
	[Token(Token = "0x200001C")]
	internal abstract class AttributeTypeAndValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000081")]
		private string oid; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000082")]
		private string attrValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000083")]
		private int upperBound; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000084")]
		private byte encoding; //Field offset: 0x24

		[Token(Token = "0x1700004C")]
		public string Value
		{
			[Address(RVA = "0x12A8F60", Offset = "0x12A8160", Length = "0xB7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60000EA")]
			 set { } //Length: 183
		}

		[Address(RVA = "0x12A8EB0", Offset = "0x12A80B0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000E8")]
		protected AttributeTypeAndValue(string oid, int upperBound) { }

		[Address(RVA = "0x12A8F00", Offset = "0x12A8100", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000E9")]
		protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) { }

		[Address(RVA = "0x12A8B10", Offset = "0x12A7D10", Length = "0x321")]
		[CalledBy(Type = typeof(X501), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60000EB")]
		internal ASN1 GetASN1(byte encoding) { }

		[Address(RVA = "0x12A8B00", Offset = "0x12A7D00", Length = "0xC")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60000EC")]
		internal ASN1 GetASN1() { }

		[Address(RVA = "0x12A8E40", Offset = "0x12A8040", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000ED")]
		private byte SelectBestEncoding() { }

		[Address(RVA = "0x12A8F60", Offset = "0x12A8160", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000EA")]
		public void set_Value(string value) { }

	}

	[Token(Token = "0x200001D")]
	internal class CommonName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AC380", Offset = "0x12AB580", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000EE")]
		public CommonName() { }

	}

	[Token(Token = "0x2000028")]
	internal class CountryName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AC920", Offset = "0x12ABB20", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F9")]
		public CountryName() { }

	}

	[Token(Token = "0x2000029")]
	internal class DnQualifier : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD340", Offset = "0x12AC540", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000FA")]
		public DnQualifier() { }

	}

	[Token(Token = "0x2000024")]
	internal class DomainComponent : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD3A0", Offset = "0x12AC5A0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F5")]
		public DomainComponent() { }

	}

	[Token(Token = "0x2000023")]
	internal class EmailAddress : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD400", Offset = "0x12AC600", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F4")]
		public EmailAddress() { }

	}

	[Token(Token = "0x200002B")]
	internal class GivenName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD920", Offset = "0x12ACB20", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000FC")]
		public GivenName() { }

	}

	[Token(Token = "0x200002C")]
	internal class Initial : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD980", Offset = "0x12ACB80", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000FD")]
		public Initial() { }

	}

	[Token(Token = "0x200001F")]
	internal class LocalityName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12AD9F0", Offset = "0x12ACBF0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F0")]
		public LocalityName() { }

	}

	[Token(Token = "0x2000026")]
	internal class Oid : AttributeTypeAndValue
	{

		[Address(RVA = "0x12ADA50", Offset = "0x12ACC50", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F7")]
		public Oid(string oid) { }

	}

	[Token(Token = "0x2000022")]
	internal class OrganizationalUnitName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12ADAF0", Offset = "0x12ACCF0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F3")]
		public OrganizationalUnitName() { }

	}

	[Token(Token = "0x2000021")]
	internal class OrganizationName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12ADA90", Offset = "0x12ACC90", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F2")]
		public OrganizationName() { }

	}

	[Token(Token = "0x200001E")]
	internal class SerialNumber : AttributeTypeAndValue
	{

		[Address(RVA = "0x12B6310", Offset = "0x12B5510", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000EF")]
		public SerialNumber() { }

	}

	[Token(Token = "0x2000020")]
	internal class StateOrProvinceName : AttributeTypeAndValue
	{

		[Address(RVA = "0x12B7430", Offset = "0x12B6630", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F1")]
		public StateOrProvinceName() { }

	}

	[Token(Token = "0x200002A")]
	internal class Surname : AttributeTypeAndValue
	{

		[Address(RVA = "0x12B7490", Offset = "0x12B6690", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000FB")]
		public Surname() { }

	}

	[Token(Token = "0x2000027")]
	internal class Title : AttributeTypeAndValue
	{

		[Address(RVA = "0x12B74F0", Offset = "0x12B66F0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F8")]
		public Title() { }

	}

	[Token(Token = "0x2000025")]
	internal class UserId : AttributeTypeAndValue
	{

		[Address(RVA = "0x12B7550", Offset = "0x12B6750", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F6")]
		public UserId() { }

	}


}

