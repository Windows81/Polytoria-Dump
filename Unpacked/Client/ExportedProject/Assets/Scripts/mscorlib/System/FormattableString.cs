namespace System;

[Token(Token = "0x20000DA")]
public abstract class FormattableString : IFormattable
{

	[Token(Token = "0x17000084")]
	public abstract int ArgumentCount
	{
		[Token(Token = "0x60006B0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000083")]
	public abstract string Format
	{
		[Token(Token = "0x60006AE")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B5")]
	protected FormattableString() { }

	[Token(Token = "0x60006B0")]
	public abstract int get_ArgumentCount() { }

	[Token(Token = "0x60006AE")]
	public abstract string get_Format() { }

	[Token(Token = "0x60006B1")]
	public abstract object GetArgument(int index) { }

	[Token(Token = "0x60006AF")]
	public abstract Object[] GetArguments() { }

	[Address(RVA = "0x149A1A0", Offset = "0x14993A0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B3")]
	private override string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	[Token(Token = "0x60006B2")]
	public abstract string ToString(IFormatProvider formatProvider) { }

	[Address(RVA = "0x149A1C0", Offset = "0x14993C0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B4")]
	public virtual string ToString() { }

}

