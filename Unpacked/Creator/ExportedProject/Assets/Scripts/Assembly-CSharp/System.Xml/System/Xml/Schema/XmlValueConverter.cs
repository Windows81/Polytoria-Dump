namespace System.Xml.Schema;

[Token(Token = "0x2000167")]
internal abstract class XmlValueConverter
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD0")]
	protected XmlValueConverter() { }

	[Token(Token = "0x6000BCE")]
	public abstract object ChangeType(object value, Type destinationType) { }

	[Token(Token = "0x6000BCD")]
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x6000BCC")]
	public abstract object ChangeType(DateTime value, Type destinationType) { }

	[Token(Token = "0x6000BCB")]
	public abstract object ChangeType(double value, Type destinationType) { }

	[Token(Token = "0x6000BCA")]
	public abstract object ChangeType(decimal value, Type destinationType) { }

	[Token(Token = "0x6000BC9")]
	public abstract object ChangeType(long value, Type destinationType) { }

	[Token(Token = "0x6000BC8")]
	public abstract object ChangeType(int value, Type destinationType) { }

	[Token(Token = "0x6000BC7")]
	public abstract object ChangeType(bool value, Type destinationType) { }

	[Token(Token = "0x6000BCF")]
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x6000B96")]
	public abstract bool ToBoolean(long value) { }

	[Token(Token = "0x6000B97")]
	public abstract bool ToBoolean(int value) { }

	[Token(Token = "0x6000B98")]
	public abstract bool ToBoolean(double value) { }

	[Token(Token = "0x6000B99")]
	public abstract bool ToBoolean(DateTime value) { }

	[Token(Token = "0x6000B9A")]
	public abstract bool ToBoolean(string value) { }

	[Token(Token = "0x6000B9B")]
	public abstract bool ToBoolean(object value) { }

	[Token(Token = "0x6000BB8")]
	public abstract DateTime ToDateTime(string value) { }

	[Token(Token = "0x6000BB9")]
	public abstract DateTime ToDateTime(object value) { }

	[Token(Token = "0x6000BB7")]
	public abstract DateTime ToDateTime(DateTimeOffset value) { }

	[Token(Token = "0x6000BB6")]
	public abstract DateTime ToDateTime(double value) { }

	[Token(Token = "0x6000BB5")]
	public abstract DateTime ToDateTime(long value) { }

	[Token(Token = "0x6000BB4")]
	public abstract DateTime ToDateTime(int value) { }

	[Token(Token = "0x6000BB3")]
	public abstract DateTime ToDateTime(bool value) { }

	[Token(Token = "0x6000BBC")]
	public abstract DateTimeOffset ToDateTimeOffset(object value) { }

	[Token(Token = "0x6000BBB")]
	public abstract DateTimeOffset ToDateTimeOffset(string value) { }

	[Token(Token = "0x6000BBA")]
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[Token(Token = "0x6000BA9")]
	public abstract decimal ToDecimal(object value) { }

	[Token(Token = "0x6000BA8")]
	public abstract decimal ToDecimal(string value) { }

	[Token(Token = "0x6000BAD")]
	public abstract double ToDouble(DateTime value) { }

	[Token(Token = "0x6000BAE")]
	public abstract double ToDouble(string value) { }

	[Token(Token = "0x6000BAF")]
	public abstract double ToDouble(object value) { }

	[Token(Token = "0x6000BAC")]
	public abstract double ToDouble(long value) { }

	[Token(Token = "0x6000BAB")]
	public abstract double ToDouble(int value) { }

	[Token(Token = "0x6000BAA")]
	public abstract double ToDouble(bool value) { }

	[Token(Token = "0x6000B9C")]
	public abstract int ToInt32(bool value) { }

	[Token(Token = "0x6000B9D")]
	public abstract int ToInt32(long value) { }

	[Token(Token = "0x6000B9E")]
	public abstract int ToInt32(double value) { }

	[Token(Token = "0x6000BA1")]
	public abstract int ToInt32(object value) { }

	[Token(Token = "0x6000BA0")]
	public abstract int ToInt32(string value) { }

	[Token(Token = "0x6000B9F")]
	public abstract int ToInt32(DateTime value) { }

	[Token(Token = "0x6000BA2")]
	public abstract long ToInt64(bool value) { }

	[Token(Token = "0x6000BA3")]
	public abstract long ToInt64(int value) { }

	[Token(Token = "0x6000BA4")]
	public abstract long ToInt64(double value) { }

	[Token(Token = "0x6000BA5")]
	public abstract long ToInt64(DateTime value) { }

	[Token(Token = "0x6000BA6")]
	public abstract long ToInt64(string value) { }

	[Token(Token = "0x6000BA7")]
	public abstract long ToInt64(object value) { }

	[Token(Token = "0x6000BB0")]
	public abstract float ToSingle(double value) { }

	[Token(Token = "0x6000BB1")]
	public abstract float ToSingle(string value) { }

	[Token(Token = "0x6000BB2")]
	public abstract float ToSingle(object value) { }

	[Token(Token = "0x6000BC6")]
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x6000BC4")]
	public abstract string ToString(DateTimeOffset value) { }

	[Token(Token = "0x6000BC3")]
	public abstract string ToString(DateTime value) { }

	[Token(Token = "0x6000BC2")]
	public abstract string ToString(double value) { }

	[Token(Token = "0x6000BC1")]
	public abstract string ToString(float value) { }

	[Token(Token = "0x6000BC0")]
	public abstract string ToString(decimal value) { }

	[Token(Token = "0x6000BBF")]
	public abstract string ToString(long value) { }

	[Token(Token = "0x6000BBD")]
	public abstract string ToString(bool value) { }

	[Token(Token = "0x6000BC5")]
	public abstract string ToString(object value) { }

	[Token(Token = "0x6000BBE")]
	public abstract string ToString(int value) { }

}

