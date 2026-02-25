namespace System;

[Token(Token = "0x20000FD")]
internal interface ISpanFormattable
{

	[Token(Token = "0x60007A9")]
	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

}

