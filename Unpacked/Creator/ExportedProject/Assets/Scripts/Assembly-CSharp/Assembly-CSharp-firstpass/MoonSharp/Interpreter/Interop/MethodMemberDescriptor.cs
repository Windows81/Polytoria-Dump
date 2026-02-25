namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x2000100")]
public class MethodMemberDescriptor : FunctionMemberDescriptorBase, IOptimizableDescriptor, IWireableDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x2000101")]
	private sealed class <>c
	{
		[Token(Token = "0x40003FF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000400")]
		public static Func<ParameterInfo, ParameterDescriptor> <>9__16_0; //Field offset: 0x8
		[Token(Token = "0x4000401")]
		public static Func<ParameterDescriptor, Boolean> <>9__16_1; //Field offset: 0x10
		[Token(Token = "0x4000402")]
		public static Func<ParameterInfo, Boolean> <>9__18_0; //Field offset: 0x18

		[Address(RVA = "0x34E6A0", Offset = "0x34D8A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60009C9")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CA")]
		public <>c() { }

		[Address(RVA = "0x34D5E0", Offset = "0x34C7E0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ParameterDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009CB")]
		internal ParameterDescriptor <.ctor>b__16_0(ParameterInfo pi) { }

		[Address(RVA = "0x34D5B0", Offset = "0x34C7B0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CC")]
		internal bool <.ctor>b__16_1(ParameterDescriptor p) { }

		[Address(RVA = "0x34CD10", Offset = "0x34BF10", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CD")]
		internal bool <CheckMethodIsCompatible>b__18_0(ParameterInfo p) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003F8")]
	private MethodBase <MethodInfo>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003F9")]
	private InteropAccessMode <AccessMode>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003FA")]
	private bool <IsConstructor>k__BackingField; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003FB")]
	private Func<Object, Object[], Object> m_OptimizedFunc; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003FC")]
	private Action<Object, Object[]> m_OptimizedAction; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003FD")]
	private bool m_IsAction; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40003FE")]
	private bool m_IsArrayCtor; //Field offset: 0x69

	[Token(Token = "0x1700014B")]
	public private InteropAccessMode AccessMode
	{
		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BF")]
		 get { } //Length: 4
		[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C0")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700014C")]
	public private bool IsConstructor
	{
		[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C1")]
		 get { } //Length: 5
		[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C2")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700014A")]
	public private MethodBase MethodInfo
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BD")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BE")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x33DE00", Offset = "0x33D000", Length = "0x777")]
	[CalledBy(Type = typeof(CallbackFunction), Member = "FromDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Delegate), typeof(InteropAccessMode)}, ReturnType = typeof(CallbackFunction))]
	[CalledBy(Type = typeof(CallbackFunction), Member = "FromMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(MethodInfo), typeof(object), typeof(InteropAccessMode)}, ReturnType = typeof(CallbackFunction))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "CreateCallbackDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(MethodInfo), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(MethodMemberDescriptor))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(ParameterDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(bool), typeof(object), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ParameterDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(UserData), Member = "get_DefaultAccessMode", ReturnType = typeof(InteropAccessMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009C3")]
	public MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = 7) { }

	[Address(RVA = "0x33C810", Offset = "0x33BA10", Length = "0x3CC")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "CheckEventIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(MethodMemberDescriptor))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60009C5")]
	public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException) { }

	[Address(RVA = "0x33CBE0", Offset = "0x33BDE0", Length = "0x424")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(MemberDescriptorAccess), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009C6")]
	public virtual DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BF")]
	public InteropAccessMode get_AccessMode() { }

	[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C1")]
	public bool get_IsConstructor() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BD")]
	public MethodBase get_MethodInfo() { }

	[Address(RVA = "0x33D010", Offset = "0x33C210", Length = "0x799")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DefaultExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ParameterExpression[])}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "ArrayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterDescriptor), Member = "get_OriginalType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PerformanceStatistics), Member = "StartGlobalStopwatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerformanceCounter)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009C7")]
	private override void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	[Address(RVA = "0x33D7B0", Offset = "0x33C9B0", Length = "0x56F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsSpecialName", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParameterDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x60009C8")]
	public override void PrepareForWiring(Table t) { }

	[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C0")]
	private void set_AccessMode(InteropAccessMode value) { }

	[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C2")]
	private void set_IsConstructor(bool value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BE")]
	private void set_MethodInfo(MethodBase value) { }

	[Address(RVA = "0x33DD20", Offset = "0x33CF20", Length = "0xD2")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetVisibilityFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009C4")]
	public static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false) { }

}

