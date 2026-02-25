namespace System.Linq.Expressions.Interpreter;

[DefaultMember("Item")]
[Token(Token = "0x2000234")]
internal class HybridReferenceDictionary
{
	[CompilerGenerated]
	[Token(Token = "0x2000235")]
	private sealed class <GetEnumeratorWorker>d__7 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C0")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C1")]
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C2")]
		public HybridReferenceDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C3")]
		private int <i>5__2; //Field offset: 0x0

		[Token(Token = "0x17000219")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A55")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700021A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x811E50", Offset = "0x811050", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A57")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A52")]
		public <GetEnumeratorWorker>d__7(int <>1__state) { }

		[Address(RVA = "0x811A10", Offset = "0x810C10", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A54")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A55")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[Address(RVA = "0x811E50", Offset = "0x811050", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A57")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A56")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A53")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BE")]
	private KeyValuePair<TKey, TValue>[] _keysAndValues; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BF")]
	private Dictionary<TKey, TValue> _dict; //Field offset: 0x0

	[Token(Token = "0x17000218")]
	public TValue Item
	{
		[Address(RVA = "0xC86FB0", Offset = "0xC861B0", Length = "0x12F")]
		[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A4F")]
		 get { } //Length: 303
		[Address(RVA = "0xC870E0", Offset = "0xC862E0", Length = "0x30A")]
		[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LabelScopeInfo), Member = "AddLabelInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(LabelInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
		[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalVariables), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(int)}, ReturnType = typeof(LocalDefinition))]
		[CalledBy(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A50")]
		 set { } //Length: 778
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A51")]
	public HybridReferenceDictionary`2() { }

	[Address(RVA = "0xC865D0", Offset = "0xC857D0", Length = "0x72")]
	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelScopeInfo), Member = "ContainsTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4C")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0xC86FB0", Offset = "0xC861B0", Length = "0x12F")]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4F")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0xC86890", Offset = "0xC85A90", Length = "0x122")]
	[CalledBy(Type = typeof(LightCompiler), Member = "MakeInterpreter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Interpreter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4D")]
	public IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0xC86720", Offset = "0xC85920", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumeratorWorker>d__7))]
	[Token(Token = "0x6000A4E")]
	private IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumeratorWorker() { }

	[Address(RVA = "0xC86B20", Offset = "0xC85D20", Length = "0x7C")]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4B")]
	public void Remove(TKey key) { }

	[Address(RVA = "0xC870E0", Offset = "0xC862E0", Length = "0x30A")]
	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelScopeInfo), Member = "AddLabelInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(LabelInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(int)}, ReturnType = typeof(LocalDefinition))]
	[CalledBy(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A50")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xC86BA0", Offset = "0xC85DA0", Length = "0x8C")]
	[CalledBy(Type = typeof(LabelScopeInfo), Member = "TryGetLabelInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(LabelInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CalledBy(Type = typeof(LocalVariables), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(int)}, ReturnType = typeof(LocalDefinition))]
	[CalledBy(Type = typeof(LocalVariables), Member = "TryGetLocalOrClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(LocalVariable&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4A")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

