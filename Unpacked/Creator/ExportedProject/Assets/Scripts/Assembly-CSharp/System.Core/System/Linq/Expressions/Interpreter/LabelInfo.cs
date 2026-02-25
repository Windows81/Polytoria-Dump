namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000152")]
internal sealed class LabelInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000153")]
	private sealed class <>c
	{
		[Token(Token = "0x4000296")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000297")]
		public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x15CD4C0", Offset = "0x15CC6C0", Length = "0x4F5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000724")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000725")]
		public <>c() { }

		[Address(RVA = "0x5EE1A0", Offset = "0x5ED3A0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000726")]
		internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000291")]
	private readonly LabelTarget _node; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000292")]
	private BranchLabel _label; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000293")]
	private object _definitions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000294")]
	private readonly List<LabelScopeInfo> _references; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000295")]
	private bool _acrossBlockJump; //Field offset: 0x30

	[Token(Token = "0x17000191")]
	private bool HasDefinitions
	{
		[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600071F")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000192")]
	private bool HasMultipleDefinitions
	{
		[Address(RVA = "0x15B82E0", Offset = "0x15B74E0", Length = "0x75")]
		[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000722")]
		private get { } //Length: 117
	}

	[Address(RVA = "0x15B8240", Offset = "0x15B7440", Length = "0x94")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CalledBy(Type = typeof(LightCompiler), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000717")]
	internal LabelInfo(LabelTarget node) { }

	[Address(RVA = "0x15B74F0", Offset = "0x15B66F0", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000721")]
	private void AddDefinition(LabelScopeInfo scope) { }

	[Address(RVA = "0x6E8C00", Offset = "0x6E7E00", Length = "0x24F")]
	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000723")]
	internal static T CommonNode(T first, T second, Func<T, T> parent) { }

	[Address(RVA = "0x15B7630", Offset = "0x15B6830", Length = "0x3E2")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LabelInfo), Member = "get_HasMultipleDefinitions", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "LabelTargetAlreadyDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "AmbiguousJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600071A")]
	internal void Define(LabelScopeInfo block) { }

	[Address(RVA = "0x15B7A20", Offset = "0x15B6C20", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600071E")]
	private bool DefinedIn(LabelScopeInfo scope) { }

	[Address(RVA = "0x15B7AD0", Offset = "0x15B6CD0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071D")]
	private void EnsureLabel(LightCompiler compiler) { }

	[Address(RVA = "0x15B7B20", Offset = "0x15B6D20", Length = "0x1C6")]
	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A12A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000720")]
	private LabelScopeInfo FirstDefinition() { }

	[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600071F")]
	private bool get_HasDefinitions() { }

	[Address(RVA = "0x15B82E0", Offset = "0x15B74E0", Length = "0x75")]
	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000722")]
	private bool get_HasMultipleDefinitions() { }

	[Address(RVA = "0x15B7CF0", Offset = "0x15B6EF0", Length = "0x44")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000718")]
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	[Address(RVA = "0x15B7D40", Offset = "0x15B6F40", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000719")]
	internal void Reference(LabelScopeInfo block) { }

	[Address(RVA = "0x15B7E00", Offset = "0x15B7000", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Error), Member = "LabelTargetUndefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600071C")]
	internal void ValidateFinish() { }

	[Address(RVA = "0x15B7E90", Offset = "0x15B7090", Length = "0x3AD")]
	[CalledBy(Type = typeof(LabelInfo), Member = "Reference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "ReferenceLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Error), Member = "ControlCannotLeaveFinally", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ControlCannotLeaveFilterTest", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NonLocalJumpWithValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "AmbiguousJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(LabelInfo), Member = "CommonNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", "System.Func`2<T, T>"}, ReturnType = "T")]
	[Calls(Type = typeof(LabelInfo), Member = "FirstDefinition", ReturnType = typeof(LabelScopeInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Error), Member = "ControlCannotEnterTry", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(LabelInfo), Member = "get_HasMultipleDefinitions", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Error), Member = "ControlCannotEnterExpression", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600071B")]
	private void ValidateJump(LabelScopeInfo reference) { }

}

