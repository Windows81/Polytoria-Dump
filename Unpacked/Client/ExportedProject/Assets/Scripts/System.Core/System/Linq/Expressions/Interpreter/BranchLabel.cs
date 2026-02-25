namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D4")]
internal sealed class BranchLabel
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BF")]
	private int _targetIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001C0")]
	private int _stackDepth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C1")]
	private int _continuationStackDepth; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C2")]
	private List<Int32> _forwardBranchFixups; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C3")]
	private int <LabelIndex>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000123")]
	internal bool HasRuntimeLabel
	{
		[Address(RVA = "0x15933D0", Offset = "0x15925D0", Length = "0xB")]
		[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
		[CalledBy(Type = typeof(InstructionList), Member = "EnsureLabelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(EnterTryFaultInstruction))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004FC")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000122")]
	internal int LabelIndex
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FA")]
		internal get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000124")]
	internal int TargetIndex
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FD")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x15933A0", Offset = "0x15925A0", Length = "0x23")]
	[CalledBy(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000502")]
	public BranchLabel() { }

	[Address(RVA = "0x15930C0", Offset = "0x15922C0", Length = "0x12D")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OffsetInstruction), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitCoalescingBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranchTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranchFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000500")]
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	[Address(RVA = "0x15931F0", Offset = "0x15923F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000501")]
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	[Address(RVA = "0x15933D0", Offset = "0x15925D0", Length = "0xB")]
	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CalledBy(Type = typeof(InstructionList), Member = "EnsureLabelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(EnterTryFaultInstruction))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004FC")]
	internal bool get_HasRuntimeLabel() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FA")]
	internal int get_LabelIndex() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FD")]
	internal int get_TargetIndex() { }

	[Address(RVA = "0x1593220", Offset = "0x1592420", Length = "0x15F")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004FF")]
	internal void Mark(InstructionList instructions) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FB")]
	internal void set_LabelIndex(int value) { }

	[Address(RVA = "0x1593380", Offset = "0x1592580", Length = "0x15")]
	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60004FE")]
	internal RuntimeLabel ToRuntimeLabel() { }

}

