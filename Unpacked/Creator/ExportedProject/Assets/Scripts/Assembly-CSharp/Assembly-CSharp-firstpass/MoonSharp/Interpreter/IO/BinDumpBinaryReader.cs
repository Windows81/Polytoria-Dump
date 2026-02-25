namespace MoonSharp.Interpreter.IO;

[Token(Token = "0x20000C5")]
public class BinDumpBinaryReader : BinaryReader
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000384")]
	private List<String> m_Strings; //Field offset: 0x48

	[Address(RVA = "0x317980", Offset = "0x316B80", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600084E")]
	public BinDumpBinaryReader(Stream s) { }

	[Address(RVA = "0x317A10", Offset = "0x316C10", Length = "0x98")]
	[CalledBy(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600084F")]
	public BinDumpBinaryReader(Stream s, Encoding e) { }

	[Address(RVA = "0x3177D0", Offset = "0x3169D0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryReader), Member = "ReadSByte", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(BinaryReader), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000850")]
	public virtual int ReadInt32() { }

	[Address(RVA = "0x317820", Offset = "0x316A20", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryReader), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000852")]
	public virtual string ReadString() { }

	[Address(RVA = "0x317930", Offset = "0x316B30", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(BinaryReader), Member = "ReadUInt32", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000851")]
	public virtual uint ReadUInt32() { }

}

