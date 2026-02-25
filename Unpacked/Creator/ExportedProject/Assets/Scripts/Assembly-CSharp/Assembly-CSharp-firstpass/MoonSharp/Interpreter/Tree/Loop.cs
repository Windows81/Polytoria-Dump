namespace MoonSharp.Interpreter.Tree;

[Token(Token = "0x2000086")]
internal class Loop : ILoop
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D3")]
	public RuntimeScopeBlock Scope; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D4")]
	public List<Instruction> BreakJumps; //Field offset: 0x18

	[Address(RVA = "0x326D70", Offset = "0x325F70", Length = "0x77")]
	[CalledBy(Type = typeof(ForEachLoopStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForLoopStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhileStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000705")]
	public Loop() { }

	[Address(RVA = "0x326C80", Offset = "0x325E80", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000703")]
	public override void CompileBreak(ByteCode bc) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000704")]
	public override bool IsBoundary() { }

}

