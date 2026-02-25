namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[Token(Token = "0x200014C")]
internal sealed class InstructionList
{
	[Token(Token = "0x200014D")]
	public sealed class DebugView
	{
		[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
		[IsReadOnly]
		[Token(Token = "0x200014E")]
		public struct InstructionView
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000274")]
			private readonly int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000275")]
			private readonly int _stackDepth; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000276")]
			private readonly int _continuationsDepth; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000277")]
			private readonly string _name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000278")]
			private readonly Instruction _instruction; //Field offset: 0x18

			[Address(RVA = "0x15B5E80", Offset = "0x15B5080", Length = "0x55")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x60006EB")]
			public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }

			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60006EA")]
			internal string GetValue() { }

		}


		[Address(RVA = "0x15AD140", Offset = "0x15AC340", Length = "0x410")]
		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D87C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A1360")]
		[Calls(Type = typeof(Instruction), Member = "get_ContinuationsBalance", ReturnType = typeof(int))]
		[Calls(Type = typeof(Instruction), Member = "get_StackBalance", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006E9")]
		internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<Object> objects, Func<Int32, Int32> labelIndexer, IReadOnlyList<KeyValuePair`2<Int32, Object>> debugCookies) { }

	}

	[Token(Token = "0x4000264")]
	private static Instruction s_null; //Field offset: 0x0
	[Token(Token = "0x4000265")]
	private static Instruction s_true; //Field offset: 0x8
	[Token(Token = "0x4000266")]
	private static Instruction s_false; //Field offset: 0x10
	[Token(Token = "0x4000267")]
	private static Instruction[] s_Ints; //Field offset: 0x18
	[Token(Token = "0x4000268")]
	private static Instruction[] s_loadObjectCached; //Field offset: 0x20
	[Token(Token = "0x4000269")]
	private static Instruction[] s_loadLocal; //Field offset: 0x28
	[Token(Token = "0x400026A")]
	private static Instruction[] s_loadLocalBoxed; //Field offset: 0x30
	[Token(Token = "0x400026B")]
	private static Instruction[] s_loadLocalFromClosure; //Field offset: 0x38
	[Token(Token = "0x400026C")]
	private static Instruction[] s_loadLocalFromClosureBoxed; //Field offset: 0x40
	[Token(Token = "0x400026D")]
	private static Instruction[] s_assignLocal; //Field offset: 0x48
	[Token(Token = "0x400026E")]
	private static Instruction[] s_storeLocal; //Field offset: 0x50
	[Token(Token = "0x400026F")]
	private static Instruction[] s_assignLocalBoxed; //Field offset: 0x58
	[Token(Token = "0x4000270")]
	private static Instruction[] s_storeLocalBoxed; //Field offset: 0x60
	[Token(Token = "0x4000271")]
	private static Instruction[] s_assignLocalToClosure; //Field offset: 0x68
	[Token(Token = "0x4000272")]
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; //Field offset: 0x70
	[Token(Token = "0x4000273")]
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; //Field offset: 0x78
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400025B")]
	private readonly List<Instruction> _instructions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400025C")]
	private List<Object> _objects; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400025D")]
	private int _currentStackDepth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400025E")]
	private int _maxStackDepth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400025F")]
	private int _currentContinuationsDepth; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000260")]
	private int _maxContinuationDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000261")]
	private int _runtimeLabelCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000262")]
	private List<BranchLabel> _labels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000263")]
	private List<KeyValuePair`2<Int32, Object>> _debugCookies; //Field offset: 0x40

	[Token(Token = "0x17000185")]
	public int Count
	{
		[Address(RVA = "0x15B5E40", Offset = "0x15B5040", Length = "0x3C")]
		[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
		[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067A")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000187")]
	public int CurrentContinuationsDepth
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000186")]
	public int CurrentStackDepth
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x15B5C90", Offset = "0x15B4E90", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006E8")]
	private static InstructionList() { }

	[Address(RVA = "0x15B5DC0", Offset = "0x15B4FC0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006E7")]
	public InstructionList() { }

	[Address(RVA = "0x15B1260", Offset = "0x15B0460", Length = "0x207")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitAssignLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssignLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600068D")]
	internal static Instruction AssignLocalBoxed(int index) { }

	[Address(RVA = "0x15B1470", Offset = "0x15B0670", Length = "0x250")]
	[CalledBy(Type = typeof(InstructionList), Member = "ToArray", ReturnType = typeof(InstructionArray))]
	[CalledBy(Type = typeof(LightCompiler), Member = "MakeInterpreter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Interpreter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BranchLabel), Member = "ToRuntimeLabel", ReturnType = typeof(RuntimeLabel))]
	[Calls(Type = typeof(RuntimeLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006C8")]
	private RuntimeLabel[] BuildRuntimeLabels() { }

	[Address(RVA = "0x15B4C60", Offset = "0x15B3E60", Length = "0x145")]
	[CallerCount(Count = 147)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000677")]
	public void Emit(Instruction instruction) { }

	[Address(RVA = "0x15B16D0", Offset = "0x15B08D0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(AddInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069E")]
	public void EmitAdd(Type type, bool checked) { }

	[Address(RVA = "0x15B1710", Offset = "0x15B0910", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A4")]
	public void EmitAnd(Type type) { }

	[Address(RVA = "0x15B1740", Offset = "0x15B0940", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BA")]
	public void EmitArrayLength() { }

	[Address(RVA = "0x15B1A30", Offset = "0x15B0C30", Length = "0x214")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600068A")]
	public void EmitAssignLocal(int index) { }

	[Address(RVA = "0x15B17A0", Offset = "0x15B09A0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "AssignLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x600068C")]
	public void EmitAssignLocalBoxed(int index) { }

	[Address(RVA = "0x15B1810", Offset = "0x15B0A10", Length = "0x214")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitStoreLocalToClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000690")]
	public void EmitAssignLocalToClosure(int index) { }

	[Address(RVA = "0x15B1E60", Offset = "0x15B1060", Length = "0xD2")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BranchInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D1")]
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	[Address(RVA = "0x15B1DB0", Offset = "0x15B0FB0", Length = "0xAB")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BranchInstruction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D0")]
	public void EmitBranch(BranchLabel label) { }

	[Address(RVA = "0x15B1F40", Offset = "0x15B1140", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CF")]
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	[Address(RVA = "0x15B1C50", Offset = "0x15B0E50", Length = "0xAB")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006D4")]
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	[Address(RVA = "0x15B1D00", Offset = "0x15B0F00", Length = "0xAB")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006D3")]
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	[Address(RVA = "0x15B1FB0", Offset = "0x15B11B0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006C6")]
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x15B2070", Offset = "0x15B1270", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B7")]
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	[Address(RVA = "0x15B2110", Offset = "0x15B1310", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(CallInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C5")]
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	[Address(RVA = "0x15B2140", Offset = "0x15B1340", Length = "0x71")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileListInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(CallInstruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60006C4")]
	public void EmitCall(MethodInfo method) { }

	[Address(RVA = "0x15B22A0", Offset = "0x15B14A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CastInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006B1")]
	public void EmitCast(Type toType) { }

	[Address(RVA = "0x15B21C0", Offset = "0x15B13C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B3")]
	public void EmitCastReferenceToEnum(Type toType) { }

	[Address(RVA = "0x15B2230", Offset = "0x15B1430", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B2")]
	public void EmitCastToEnum(Type toType) { }

	[Address(RVA = "0x15B22D0", Offset = "0x15B14D0", Length = "0xAB")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006D2")]
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	[Address(RVA = "0x15B2380", Offset = "0x15B1580", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ToUnderlying), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006B0")]
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x15B2400", Offset = "0x15B1600", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B8")]
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	[Address(RVA = "0x15B2470", Offset = "0x15B1670", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BE")]
	public void EmitDecrement(Type type) { }

	[Address(RVA = "0x15B24A0", Offset = "0x15B16A0", Length = "0x6B")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B5")]
	public void EmitDefaultValue(Type type) { }

	[Address(RVA = "0x15B2510", Offset = "0x15B1710", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DivInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A1")]
	public void EmitDiv(Type type) { }

	[Address(RVA = "0x15B2540", Offset = "0x15B1740", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000682")]
	public void EmitDup() { }

	[Address(RVA = "0x15B25A0", Offset = "0x15B17A0", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E0")]
	public void EmitEnterExceptionFilter() { }

	[Address(RVA = "0x15B2600", Offset = "0x15B1800", Length = "0x5F")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E2")]
	public void EmitEnterExceptionHandlerNonVoid() { }

	[Address(RVA = "0x15B2660", Offset = "0x15B1860", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E3")]
	public void EmitEnterExceptionHandlerVoid() { }

	[Address(RVA = "0x15B26C0", Offset = "0x15B18C0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EnterFaultInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterFaultInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DE")]
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	[Address(RVA = "0x15B2750", Offset = "0x15B1950", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EnterFinallyInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DC")]
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	[Address(RVA = "0x15B27E0", Offset = "0x15B19E0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnterTryCatchFinallyInstruction), Member = "CreateTryCatch", ReturnType = typeof(EnterTryCatchFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006DA")]
	public void EmitEnterTryCatch() { }

	[Address(RVA = "0x15B2810", Offset = "0x15B1A10", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006DB")]
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	[Address(RVA = "0x15B28B0", Offset = "0x15B1AB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnterTryCatchFinallyInstruction), Member = "CreateTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterTryCatchFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D9")]
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	[Address(RVA = "0x15B2910", Offset = "0x15B1B10", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A8")]
	public void EmitEqual(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x15B2950", Offset = "0x15B1B50", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExclusiveOrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A3")]
	public void EmitExclusiveOr(Type type) { }

	[Address(RVA = "0x15B2980", Offset = "0x15B1B80", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000699")]
	public void EmitGetArrayItem() { }

	[Address(RVA = "0x15B29E0", Offset = "0x15B1BE0", Length = "0xB7")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GotoInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GotoInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CE")]
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x15B2AE0", Offset = "0x15B1CE0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GreaterThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AC")]
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	[Address(RVA = "0x15B2AA0", Offset = "0x15B1CA0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GreaterThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AD")]
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	[Address(RVA = "0x15B2B20", Offset = "0x15B1D20", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IncrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BD")]
	public void EmitIncrement(Type type) { }

	[Address(RVA = "0x15B2B50", Offset = "0x15B1D50", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "GetPrimitiveDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000692")]
	public void EmitInitializeLocal(int index, Type type) { }

	[Address(RVA = "0x15B2C90", Offset = "0x15B1E90", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000693")]
	internal void EmitInitializeParameter(int index) { }

	[Address(RVA = "0x6E8360", Offset = "0x6E7560", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E5")]
	public void EmitIntSwitch(Dictionary<T, Int32> cases) { }

	[Address(RVA = "0x15B2D30", Offset = "0x15B1F30", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E1")]
	public void EmitLeaveExceptionFilter() { }

	[Address(RVA = "0x15B2D90", Offset = "0x15B1F90", Length = "0x98")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeaveExceptionHandlerInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LeaveExceptionHandlerInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006E4")]
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	[Address(RVA = "0x15B2E30", Offset = "0x15B2030", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006DF")]
	public void EmitLeaveFault() { }

	[Address(RVA = "0x15B2E90", Offset = "0x15B2090", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006DD")]
	public void EmitLeaveFinally() { }

	[Address(RVA = "0x15B2EF0", Offset = "0x15B20F0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeftShiftInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A6")]
	public void EmitLeftShift(Type type) { }

	[Address(RVA = "0x15B2F60", Offset = "0x15B2160", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LessThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AA")]
	public void EmitLessThan(Type type, bool liftedToNull) { }

	[Address(RVA = "0x15B2F20", Offset = "0x15B2120", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LessThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AB")]
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	[Address(RVA = "0x15B36A0", Offset = "0x15B28A0", Length = "0x609")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConstantExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeEqualExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000681")]
	public void EmitLoad(object value, Type type) { }

	[Address(RVA = "0x15B3CB0", Offset = "0x15B2EB0", Length = "0x1E7")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000680")]
	public void EmitLoad(bool value) { }

	[Address(RVA = "0x15B3EA0", Offset = "0x15B30A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x600067F")]
	public void EmitLoad(object value) { }

	[Address(RVA = "0x15B2FA0", Offset = "0x15B21A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C1")]
	public void EmitLoadField(FieldInfo field) { }

	[Address(RVA = "0x15B3480", Offset = "0x15B2680", Length = "0x214")]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000685")]
	public void EmitLoadLocal(int index) { }

	[Address(RVA = "0x15B2FD0", Offset = "0x15B21D0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "LoadLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000686")]
	public void EmitLoadLocalBoxed(int index) { }

	[Address(RVA = "0x15B3260", Offset = "0x15B2460", Length = "0x214")]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000688")]
	public void EmitLoadLocalFromClosure(int index) { }

	[Address(RVA = "0x15B3040", Offset = "0x15B2240", Length = "0x214")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000689")]
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	[Address(RVA = "0x15B3EB0", Offset = "0x15B30B0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModuloInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A2")]
	public void EmitModulo(Type type) { }

	[Address(RVA = "0x15B3EE0", Offset = "0x15B30E0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MulOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(MulInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A0")]
	public void EmitMul(Type type, bool checked) { }

	[Address(RVA = "0x15B3F50", Offset = "0x15B3150", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NegateInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BB")]
	public void EmitNegate(Type type) { }

	[Address(RVA = "0x15B3F20", Offset = "0x15B3120", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NegateCheckedInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BC")]
	public void EmitNegateChecked(Type type) { }

	[Address(RVA = "0x15B4160", Offset = "0x15B3360", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B6")]
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	[Address(RVA = "0x15B4080", Offset = "0x15B3280", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069B")]
	public void EmitNewArray(Type elementType) { }

	[Address(RVA = "0x15B3F80", Offset = "0x15B3180", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069C")]
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	[Address(RVA = "0x15B4000", Offset = "0x15B3200", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069D")]
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	[Address(RVA = "0x15B40F0", Offset = "0x15B32F0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000698")]
	public void EmitNewRuntimeVariables(int count) { }

	[Address(RVA = "0x15B4230", Offset = "0x15B3430", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006B4")]
	public void EmitNot(Type type) { }

	[Address(RVA = "0x15B41F0", Offset = "0x15B33F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A9")]
	public void EmitNotEqual(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x15B4260", Offset = "0x15B3460", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NullableMethodCallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(MethodInfo)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006C7")]
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	[Address(RVA = "0x15B42D0", Offset = "0x15B34D0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006AE")]
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x15B4370", Offset = "0x15B3570", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006AF")]
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x15B4410", Offset = "0x15B3610", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A5")]
	public void EmitOr(Type type) { }

	[Address(RVA = "0x15B4440", Offset = "0x15B3640", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileListInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAsVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000683")]
	public void EmitPop() { }

	[Address(RVA = "0x15B4500", Offset = "0x15B3700", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D7")]
	public void EmitRethrow() { }

	[Address(RVA = "0x15B44A0", Offset = "0x15B36A0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D8")]
	public void EmitRethrowVoid() { }

	[Address(RVA = "0x15B4560", Offset = "0x15B3760", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RightShiftInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A7")]
	public void EmitRightShift(Type type) { }

	[Address(RVA = "0x15B4590", Offset = "0x15B3790", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x600069A")]
	public void EmitSetArrayItem() { }

	[Address(RVA = "0x15B45F0", Offset = "0x15B37F0", Length = "0xAE")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006C3")]
	public void EmitStoreField(FieldInfo field) { }

	[Address(RVA = "0x15B4780", Offset = "0x15B3980", Length = "0x214")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600068B")]
	public void EmitStoreLocal(int index) { }

	[Address(RVA = "0x15B46A0", Offset = "0x15B38A0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "StoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x600068E")]
	public void EmitStoreLocalBoxed(int index) { }

	[Address(RVA = "0x15B4710", Offset = "0x15B3910", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "EmitAssignLocalToClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000691")]
	public void EmitStoreLocalToClosure(int index) { }

	[Address(RVA = "0x15B49A0", Offset = "0x15B3BA0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006E6")]
	public void EmitStringSwitch(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	[Address(RVA = "0x15B4A20", Offset = "0x15B3C20", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(SubInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069F")]
	public void EmitSub(Type type, bool checked) { }

	[Address(RVA = "0x15B4AC0", Offset = "0x15B3CC0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D5")]
	public void EmitThrow() { }

	[Address(RVA = "0x15B4A60", Offset = "0x15B3C60", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D6")]
	public void EmitThrowVoid() { }

	[Address(RVA = "0x15B4B20", Offset = "0x15B3D20", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006C0")]
	public void EmitTypeAs(Type type) { }

	[Address(RVA = "0x15B4B90", Offset = "0x15B3D90", Length = "0x5E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006B9")]
	public void EmitTypeEquals() { }

	[Address(RVA = "0x15B4BF0", Offset = "0x15B3DF0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60006BF")]
	public void EmitTypeIs(Type type) { }

	[Address(RVA = "0x15B4DB0", Offset = "0x15B3FB0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CB")]
	private int EnsureLabelIndex(BranchLabel label) { }

	[Address(RVA = "0x15B4DF0", Offset = "0x15B3FF0", Length = "0xDE")]
	[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BranchLabel), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OffsetInstruction), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006CA")]
	internal void FixupBranch(int branchIndex, int offset) { }

	[Address(RVA = "0x15B5E40", Offset = "0x15B5040", Length = "0x3C")]
	[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067A")]
	public int get_Count() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067C")]
	public int get_CurrentContinuationsDepth() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067B")]
	public int get_CurrentStackDepth() { }

	[Address(RVA = "0x15B4ED0", Offset = "0x15B40D0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600067D")]
	internal Instruction GetInstruction(int index) { }

	[Address(RVA = "0x15B4F30", Offset = "0x15B4130", Length = "0x223")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006C2")]
	private Instruction GetLoadField(FieldInfo field) { }

	[Address(RVA = "0x15B5160", Offset = "0x15B4360", Length = "0x52")]
	[CalledBy(Type = typeof(Reference), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000697")]
	internal static Instruction InitImmutableRefBox(int index) { }

	[Address(RVA = "0x15B51C0", Offset = "0x15B43C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000696")]
	internal static Instruction InitReference(int index) { }

	[Address(RVA = "0x15B5220", Offset = "0x15B4420", Length = "0x207")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoadLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000687")]
	internal static Instruction LoadLocalBoxed(int index) { }

	[Address(RVA = "0x15B5430", Offset = "0x15B4630", Length = "0x123")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightCompiler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "GetLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightCompiler)}, ReturnType = typeof(BranchLabel))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BranchLabel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006C9")]
	public BranchLabel MakeLabel() { }

	[Address(RVA = "0x15B5560", Offset = "0x15B4760", Length = "0x23")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CD")]
	public void MarkLabel(BranchLabel label) { }

	[Address(RVA = "0x15B5590", Offset = "0x15B4790", Length = "0x54")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[Calls(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CC")]
	public int MarkRuntimeLabel() { }

	[Address(RVA = "0x15B5650", Offset = "0x15B4850", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000694")]
	internal static Instruction Parameter(int index) { }

	[Address(RVA = "0x15B55F0", Offset = "0x15B47F0", Length = "0x52")]
	[CalledBy(Type = typeof(Parameter), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000695")]
	internal static Instruction ParameterBox(int index) { }

	[Address(RVA = "0x15B56B0", Offset = "0x15B48B0", Length = "0x207")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitStoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StoreLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600068F")]
	internal static Instruction StoreLocalBoxed(int index) { }

	[Address(RVA = "0x15B58C0", Offset = "0x15B4AC0", Length = "0xBE")]
	[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000684")]
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	[Address(RVA = "0x15B5980", Offset = "0x15B4B80", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067E")]
	public InstructionArray ToArray() { }

	[Address(RVA = "0x15B5AB0", Offset = "0x15B4CB0", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000679")]
	public void UnEmit() { }

	[Address(RVA = "0x15B5BD0", Offset = "0x15B4DD0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000678")]
	private void UpdateStackDepth(Instruction instruction) { }

}

