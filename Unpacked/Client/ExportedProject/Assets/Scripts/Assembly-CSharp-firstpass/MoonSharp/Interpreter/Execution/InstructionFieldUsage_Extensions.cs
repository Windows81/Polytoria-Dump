namespace MoonSharp.Interpreter.Execution;

[Extension]
[Token(Token = "0x200013C")]
internal static class InstructionFieldUsage_Extensions
{

	[Address(RVA = "0x356FA0", Offset = "0x3561A0", Length = "0x1C")]
	[CalledBy(Type = typeof(Instruction), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Instruction), Member = "WriteBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int), typeof(System.Collections.Generic.Dictionary`2<MoonSharp.Interpreter.SymbolRef, System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Instruction), Member = "ReadBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef), typeof(BinaryReader), typeof(int), typeof(Table), typeof(SymbolRef[])}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(Instruction), Member = "GetSymbolReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef[]&), typeof(SymbolRef&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	[Extension]
	[Token(Token = "0x6000BC7")]
	internal static InstructionFieldUsage GetFieldUsage(OpCode op) { }

}

