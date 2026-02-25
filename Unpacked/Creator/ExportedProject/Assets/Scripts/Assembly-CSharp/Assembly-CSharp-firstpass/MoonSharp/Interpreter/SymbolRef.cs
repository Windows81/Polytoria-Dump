namespace MoonSharp.Interpreter;

[Token(Token = "0x2000050")]
public class SymbolRef
{
	[Token(Token = "0x40001E7")]
	private static SymbolRef s_DefaultEnv; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E8")]
	internal SymbolRefType i_Type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E9")]
	internal SymbolRef i_Env; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EA")]
	internal int i_Index; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001EB")]
	internal string i_Name; //Field offset: 0x28

	[Token(Token = "0x170000AB")]
	public static SymbolRef DefaultEnv
	{
		[Address(RVA = "0x30FF10", Offset = "0x30F110", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600053A")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000AA")]
	public SymbolRef Environment
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000539")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000A8")]
	public int Index
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000537")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000A9")]
	public string Name
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000538")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000A7")]
	public SymbolRefType Type
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000536")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x30FE90", Offset = "0x30F090", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000544")]
	private static SymbolRef() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000543")]
	public SymbolRef() { }

	[Address(RVA = "0x30FF10", Offset = "0x30F110", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600053A")]
	public static SymbolRef get_DefaultEnv() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	public SymbolRef get_Environment() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000537")]
	public int get_Index() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000538")]
	public string get_Name() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000536")]
	public SymbolRefType get_Type() { }

	[Address(RVA = "0x30F950", Offset = "0x30EB50", Length = "0x95")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "CreateGlobalReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053B")]
	public static SymbolRef Global(string name, SymbolRef envSymbol) { }

	[Address(RVA = "0x30F9F0", Offset = "0x30EBF0", Length = "0x80")]
	[CalledBy(Type = typeof(BuildTimeScopeBlock), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053C")]
	internal static SymbolRef Local(string name, int index) { }

	[Address(RVA = "0x30FAF0", Offset = "0x30ECF0", Length = "0xBB")]
	[CalledBy(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000540")]
	internal static SymbolRef ReadBinary(BinaryReader br) { }

	[Address(RVA = "0x30FA80", Offset = "0x30EC80", Length = "0x66")]
	[CalledBy(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000542")]
	internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs) { }

	[Address(RVA = "0x30FBB0", Offset = "0x30EDB0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600053E")]
	public virtual string ToString() { }

	[Address(RVA = "0x30FCC0", Offset = "0x30EEC0", Length = "0x80")]
	[CalledBy(Type = typeof(ChunkStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "CreateUpvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScope), typeof(SymbolRef)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "CompileBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053D")]
	internal static SymbolRef Upvalue(string name, int index) { }

	[Address(RVA = "0x30FE10", Offset = "0x30F010", Length = "0x72")]
	[CalledBy(Type = typeof(Processor), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600053F")]
	internal void WriteBinary(BinaryWriter bw) { }

	[Address(RVA = "0x30FD50", Offset = "0x30EF50", Length = "0xB5")]
	[CalledBy(Type = typeof(Processor), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000541")]
	internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, Int32> symbolMap) { }

}

