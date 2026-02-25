namespace System.Xml.XPath;

[Token(Token = "0x20000C0")]
public abstract class XPathItem
{

	[Token(Token = "0x170001DA")]
	public abstract object TypedValue
	{
		[Token(Token = "0x600083F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001D9")]
	public abstract string Value
	{
		[Token(Token = "0x600083E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DC")]
	public abstract bool ValueAsBoolean
	{
		[Token(Token = "0x6000841")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DD")]
	public abstract DateTime ValueAsDateTime
	{
		[Token(Token = "0x6000842")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DE")]
	public abstract double ValueAsDouble
	{
		[Token(Token = "0x6000843")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DF")]
	public abstract int ValueAsInt
	{
		[Token(Token = "0x6000844")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001E0")]
	public abstract long ValueAsLong
	{
		[Token(Token = "0x6000845")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DB")]
	public abstract Type ValueType
	{
		[Token(Token = "0x6000840")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001D8")]
	public abstract XmlSchemaType XmlType
	{
		[Token(Token = "0x600083D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000848")]
	protected XPathItem() { }

	[Token(Token = "0x600083F")]
	public abstract object get_TypedValue() { }

	[Token(Token = "0x600083E")]
	public abstract string get_Value() { }

	[Token(Token = "0x6000841")]
	public abstract bool get_ValueAsBoolean() { }

	[Token(Token = "0x6000842")]
	public abstract DateTime get_ValueAsDateTime() { }

	[Token(Token = "0x6000843")]
	public abstract double get_ValueAsDouble() { }

	[Token(Token = "0x6000844")]
	public abstract int get_ValueAsInt() { }

	[Token(Token = "0x6000845")]
	public abstract long get_ValueAsLong() { }

	[Token(Token = "0x6000840")]
	public abstract Type get_ValueType() { }

	[Token(Token = "0x600083D")]
	public abstract XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x16B5B40", Offset = "0x16B4D40", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000846")]
	public override object ValueAs(Type returnType) { }

	[Token(Token = "0x6000847")]
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

