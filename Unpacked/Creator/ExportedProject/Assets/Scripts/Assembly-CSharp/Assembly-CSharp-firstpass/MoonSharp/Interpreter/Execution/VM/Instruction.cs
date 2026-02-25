namespace MoonSharp.Interpreter.Execution.VM;

[Token(Token = "0x200014B")]
internal class Instruction
{
	[CompilerGenerated]
	[Token(Token = "0x200014C")]
	private sealed class <>c
	{
		[Token(Token = "0x400050E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400050F")]
		public static Func<SymbolRef, String> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x371AF0", Offset = "0x370CF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C39")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C3A")]
		public <>c() { }

		[Address(RVA = "0x313D20", Offset = "0x312F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C3B")]
		internal string <ToString>b__9_0(SymbolRef s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000506")]
	internal OpCode OpCode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000507")]
	internal SymbolRef Symbol; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000508")]
	internal SymbolRef[] SymbolList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000509")]
	internal string Name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400050A")]
	internal DynValue Value; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400050B")]
	internal int NumVal; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400050C")]
	internal int NumVal2; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400050D")]
	internal SourceRef SourceCodeRef; //Field offset: 0x40

	[Address(RVA = "0x358330", Offset = "0x357530", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2E")]
	internal Instruction(SourceRef sourceref) { }

	[Address(RVA = "0x357150", Offset = "0x356350", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynValue), Member = "get_Boolean", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000C37")]
	private void DumpValue(BinaryWriter wr, DynValue value) { }

	[Address(RVA = "0x357310", Offset = "0x356510", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C31")]
	private string GenSpaces() { }

	[Address(RVA = "0x357390", Offset = "0x356590", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionFieldUsage_Extensions), Member = "GetFieldUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(InstructionFieldUsage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000C38")]
	internal void GetSymbolReferences(out SymbolRef[] symbolList, out SymbolRef symbol) { }

	[Address(RVA = "0x357420", Offset = "0x356620", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C30")]
	private string PurifyFromNewLines(DynValue Value) { }

	[Address(RVA = "0x3574B0", Offset = "0x3566B0", Length = "0x2C7")]
	[CalledBy(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Instruction), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InstructionFieldUsage_Extensions), Member = "GetFieldUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(InstructionFieldUsage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000C35")]
	internal static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, SymbolRef[] deserializedSymbols) { }

	[Address(RVA = "0x357780", Offset = "0x356980", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C34")]
	private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols) { }

	[Address(RVA = "0x3577D0", Offset = "0x3569D0", Length = "0x80")]
	[CalledBy(Type = typeof(Instruction), Member = "ReadBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef), typeof(BinaryReader), typeof(int), typeof(Table), typeof(SymbolRef[])}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000C36")]
	private static DynValue ReadValue(BinaryReader rd, Table envTable) { }

	[Address(RVA = "0x357A50", Offset = "0x356C50", Length = "0x44A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InstructionFieldUsage_Extensions), Member = "GetFieldUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(InstructionFieldUsage))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000C2F")]
	public virtual string ToString() { }

	[Address(RVA = "0x357EA0", Offset = "0x3570A0", Length = "0x168")]
	[CalledBy(Type = typeof(Processor), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionFieldUsage_Extensions), Member = "GetFieldUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(InstructionFieldUsage))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000C32")]
	internal void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, Int32> symbolMap) { }

	[Address(RVA = "0x3582A0", Offset = "0x3574A0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C33")]
	private static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, Int32> symbolMap) { }

}

