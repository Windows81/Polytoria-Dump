namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005CA")]
public class ReadOnlyCollection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001835")]
	private IList<T> list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001836")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x17000697")]
	public override int Count
	{
		[Address(RVA = "0xEC2070", Offset = "0xEC1270", Length = "0x46")]
		[CallerCount(Count = 54)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A78")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000698")]
	public override T Item
	{
		[Address(RVA = "0xEC1020", Offset = "0xEC0220", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A79")]
		 get { } //Length: 205
	}

	[Token(Token = "0x17000699")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7E")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700069A")]
	private override T System.Collections.Generic.IList<T>.Item
	{
		[Address(RVA = "0xEC1020", Offset = "0xEC0220", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7F")]
		private get { } //Length: 205
		[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A80")]
		private set { } //Length: 12
	}

	[Token(Token = "0x1700069B")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xEC1950", Offset = "0xEC0B50", Length = "0xD4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A87")]
		private get { } //Length: 212
	}

	[Token(Token = "0x1700069C")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A89")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700069D")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A8A")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700069E")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0xEC1F30", Offset = "0xEC1130", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A8B")]
		private get { } //Length: 229
		[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A8C")]
		private set { } //Length: 12
	}

	[Address(RVA = "0xEC2020", Offset = "0xEC1220", Length = "0x42")]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.CompilerServices.TrueReadOnlyCollection`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.BlockExpression", Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.BlockExpression", typeof(Object&)}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<Expression>")]
	[CalledBy(Type = typeof(List`1), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[CalledBy(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[CalledBy(Type = typeof(Array), Member = "AsReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IList`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IList`1<System.Exception>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CalledBy(Type = "System.Dynamic.Utils.ExpressionUtils", Member = "ReturnReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.IArgumentProvider", typeof(Object&)}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<Expression>")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A77")]
	public ReadOnlyCollection`1(IList<T> list) { }

	[Address(RVA = "0xEC0D30", Offset = "0xEBFF30", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7A")]
	public override bool Contains(T value) { }

	[Address(RVA = "0xEC0E00", Offset = "0xEC0000", Length = "0x6A")]
	[CalledBy(Type = typeof(AggregateException), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7B")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xEC2070", Offset = "0xEC1270", Length = "0x46")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A78")]
	public override int get_Count() { }

	[Address(RVA = "0xEC1020", Offset = "0xEC0220", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A79")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xEC0E70", Offset = "0xEC0070", Length = "0x46")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<MemberBinding>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileListInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<ElementInit>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileRuntimeVariablesExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewArrayExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "TryPushLabelBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings", Member = "SetAllOverridesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.SwitchExpression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileBlockStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.BlockExpression"}, ReturnType = "System.Linq.Expressions.Interpreter.LocalDefinition[]")]
	[CalledBy(Type = "System.Linq.Expressions.ExpressionStringBuilder", Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.BlockExpression"}, ReturnType = "System.Linq.Expressions.Expression")]
	[CalledBy(Type = "System.Linq.Expressions.ExpressionStringBuilder", Member = "VisitExpressions", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.ObjectModel.ReadOnlyCollection`1<T>", typeof(char), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "ValidateTryAndCatchHaveSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Linq.Expressions.Expression", "System.Collections.ObjectModel.ReadOnlyCollection`1<CatchBlock>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", "System.Collections.Generic.IEnumerable`1<Expression>"}, ReturnType = "System.Linq.Expressions.IndexExpression")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.SwitchExpression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings", Member = "GetHash", ReturnType = typeof(int))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7C")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xEC0EC0", Offset = "0xEC00C0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7D")]
	public override int IndexOf(T value) { }

	[Address(RVA = "0xEC0F90", Offset = "0xEC0190", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8F")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A81")]
	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A82")]
	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7E")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xEC1000", Offset = "0xEC0200", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A84")]
	private override bool System.Collections.Generic.ICollection<T>.Remove(T value) { }

	[Address(RVA = "0xEC1020", Offset = "0xEC0220", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7F")]
	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A83")]
	private override void System.Collections.Generic.IList<T>.Insert(int index, T value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A85")]
	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A80")]
	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	[Address(RVA = "0xEC1520", Offset = "0xEC0720", Length = "0x426")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A88")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xEC1950", Offset = "0xEC0B50", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A87")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xEC1B10", Offset = "0xEC0D10", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A86")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEC1BB0", Offset = "0xEC0DB0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8D")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8E")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0xEC1BD0", Offset = "0xEC0DD0", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A90")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A89")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8A")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0xEC1F30", Offset = "0xEC1130", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8B")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0xEC1D80", Offset = "0xEC0F80", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A91")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A92")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A93")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A94")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0xEC0FF0", Offset = "0xEC01F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A8C")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

