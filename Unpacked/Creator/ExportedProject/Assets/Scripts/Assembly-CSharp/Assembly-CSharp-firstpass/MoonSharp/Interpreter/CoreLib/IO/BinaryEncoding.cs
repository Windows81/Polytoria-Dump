namespace MoonSharp.Interpreter.CoreLib.IO;

[Token(Token = "0x200018F")]
internal class BinaryEncoding : Encoding
{

	[Address(RVA = "0x3910A0", Offset = "0x3902A0", Length = "0x7")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB9")]
	public BinaryEncoding() { }

	[Address(RVA = "0x390F70", Offset = "0x390170", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBA")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x390F80", Offset = "0x390180", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EBB")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x390F70", Offset = "0x390170", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBC")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x391010", Offset = "0x390210", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EBD")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x32B1B0", Offset = "0x32A3B0", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBE")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x32B1B0", Offset = "0x32A3B0", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBF")]
	public virtual int GetMaxCharCount(int byteCount) { }

}

