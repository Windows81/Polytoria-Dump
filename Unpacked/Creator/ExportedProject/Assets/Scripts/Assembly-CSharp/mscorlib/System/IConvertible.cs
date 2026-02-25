namespace System;

[CLSCompliant(False)]
[Token(Token = "0x20000F7")]
public interface IConvertible
{

	[Token(Token = "0x6000793")]
	public TypeCode GetTypeCode() { }

	[Token(Token = "0x6000794")]
	public bool ToBoolean(IFormatProvider provider) { }

	[Token(Token = "0x6000797")]
	public byte ToByte(IFormatProvider provider) { }

	[Token(Token = "0x6000795")]
	public char ToChar(IFormatProvider provider) { }

	[Token(Token = "0x60007A1")]
	public DateTime ToDateTime(IFormatProvider provider) { }

	[Token(Token = "0x60007A0")]
	public decimal ToDecimal(IFormatProvider provider) { }

	[Token(Token = "0x600079F")]
	public double ToDouble(IFormatProvider provider) { }

	[Token(Token = "0x6000798")]
	public short ToInt16(IFormatProvider provider) { }

	[Token(Token = "0x600079A")]
	public int ToInt32(IFormatProvider provider) { }

	[Token(Token = "0x600079C")]
	public long ToInt64(IFormatProvider provider) { }

	[Token(Token = "0x6000796")]
	public sbyte ToSByte(IFormatProvider provider) { }

	[Token(Token = "0x600079E")]
	public float ToSingle(IFormatProvider provider) { }

	[Token(Token = "0x60007A2")]
	public string ToString(IFormatProvider provider) { }

	[Token(Token = "0x60007A3")]
	public object ToType(Type conversionType, IFormatProvider provider) { }

	[Token(Token = "0x6000799")]
	public ushort ToUInt16(IFormatProvider provider) { }

	[Token(Token = "0x600079B")]
	public uint ToUInt32(IFormatProvider provider) { }

	[Token(Token = "0x600079D")]
	public ulong ToUInt64(IFormatProvider provider) { }

}

