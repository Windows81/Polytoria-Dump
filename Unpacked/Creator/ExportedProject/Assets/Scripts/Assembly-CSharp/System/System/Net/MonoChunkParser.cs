namespace System.Net;

[Token(Token = "0x2000292")]
internal class MonoChunkParser
{
	[Token(Token = "0x2000294")]
	private class Chunk
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE0")]
		public Byte[] Bytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AE1")]
		public int Offset; //Field offset: 0x18

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010A6")]
		public Chunk(Byte[] chunk) { }

		[Address(RVA = "0x17E9C30", Offset = "0x17E8E30", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010A7")]
		public int Read(Byte[] buffer, int offset, int size) { }

	}

	[Token(Token = "0x2000293")]
	private enum State
	{
		None = 0,
		PartialSize = 1,
		Body = 2,
		BodyFinished = 3,
		Trailer = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AD0")]
	private WebHeaderCollection headers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AD1")]
	private int chunkSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000AD2")]
	private int chunkRead; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AD3")]
	private int totalWritten; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000AD4")]
	private State state; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AD5")]
	private StringBuilder saved; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AD6")]
	private bool sawCR; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000AD7")]
	private bool gotit; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000AD8")]
	private int trailerState; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AD9")]
	private ArrayList chunks; //Field offset: 0x38

	[Token(Token = "0x1700037B")]
	public int ChunkLeft
	{
		[Address(RVA = "0x17FB1E0", Offset = "0x17FA3E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600109F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700037A")]
	public bool DataAvailable
	{
		[Address(RVA = "0x17FB1F0", Offset = "0x17FA3F0", Length = "0x10D")]
		[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600109E")]
		 get { } //Length: 269
	}

	[Token(Token = "0x17000379")]
	public bool WantMore
	{
		[Address(RVA = "0x17FB300", Offset = "0x17FA500", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600109D")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x17FB120", Offset = "0x17FA320", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001098")]
	public MonoChunkParser(WebHeaderCollection headers) { }

	[Address(RVA = "0x17FB1E0", Offset = "0x17FA3E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600109F")]
	public int get_ChunkLeft() { }

	[Address(RVA = "0x17FB1F0", Offset = "0x17FA3F0", Length = "0x10D")]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600109E")]
	public bool get_DataAvailable() { }

	[Address(RVA = "0x17FB300", Offset = "0x17FA500", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600109D")]
	public bool get_WantMore() { }

	[Address(RVA = "0x17FA300", Offset = "0x17F9500", Length = "0x2E1")]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60010A1")]
	private State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x17FA5F0", Offset = "0x17F97F0", Length = "0x2C0")]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600109C")]
	private void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x17FB030", Offset = "0x17FA230", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6001099")]
	public int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17FA8C0", Offset = "0x17F9AC0", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010A0")]
	private State ReadBody(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x17FAA00", Offset = "0x17F9C00", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010A3")]
	private State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x17FAAE0", Offset = "0x17F9CE0", Length = "0x2E5")]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600109A")]
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17FADD0", Offset = "0x17F9FD0", Length = "0x25E")]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60010A4")]
	private State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x17FB040", Offset = "0x17FA240", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010A2")]
	private static string RemoveChunkExtension(string input) { }

	[Address(RVA = "0x17FB090", Offset = "0x17FA290", Length = "0x5B")]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "ReadCRLF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010A5")]
	private static void ThrowProtocolViolation(string message) { }

	[Address(RVA = "0x17FB0F0", Offset = "0x17FA2F0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600109B")]
	public void Write(Byte[] buffer, int offset, int size) { }

}

