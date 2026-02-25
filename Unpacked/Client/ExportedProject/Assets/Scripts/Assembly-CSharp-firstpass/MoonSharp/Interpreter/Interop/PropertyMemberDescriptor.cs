namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x2000107")]
public class PropertyMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000417")]
	private PropertyInfo <PropertyInfo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000418")]
	private InteropAccessMode <AccessMode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000419")]
	private bool <IsStatic>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400041A")]
	private string <Name>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041B")]
	private MethodInfo m_Getter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400041C")]
	private MethodInfo m_Setter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400041D")]
	private Func<Object, Object> m_OptimizedGetter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041E")]
	private Action<Object, Object> m_OptimizedSetter; //Field offset: 0x40

	[Token(Token = "0x17000154")]
	public private InteropAccessMode AccessMode
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F1")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F2")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000157")]
	public bool CanRead
	{
		[Address(RVA = "0x3425A0", Offset = "0x3417A0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60009F7")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000158")]
	public bool CanWrite
	{
		[Address(RVA = "0x3425B0", Offset = "0x3417B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60009F8")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000155")]
	public private override bool IsStatic
	{
		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F3")]
		 get { } //Length: 5
		[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F4")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000159")]
	public override MemberDescriptorAccess MemberAccess
	{
		[Address(RVA = "0x3425C0", Offset = "0x3417C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000A01")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000156")]
	public private override string Name
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F5")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000153")]
	public private PropertyInfo PropertyInfo
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009EF")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F0")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x342350", Offset = "0x341550", Length = "0x247")]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(PropertyMemberDescriptor))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeSetter", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeGetter", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FC")]
	public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter) { }

	[Address(RVA = "0x342200", Offset = "0x341400", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FB")]
	public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F1")]
	public InteropAccessMode get_AccessMode() { }

	[Address(RVA = "0x3425A0", Offset = "0x3417A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F7")]
	public bool get_CanRead() { }

	[Address(RVA = "0x3425B0", Offset = "0x3417B0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F8")]
	public bool get_CanWrite() { }

	[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F3")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x3425C0", Offset = "0x3417C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A01")]
	public override MemberDescriptorAccess get_MemberAccess() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F5")]
	public override string get_Name() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009EF")]
	public PropertyInfo get_PropertyInfo() { }

	[Address(RVA = "0x340A70", Offset = "0x33FC70", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(MemberDescriptorAccess), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeGetter", ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FD")]
	public override DynValue GetValue(Script script, object obj) { }

	[Address(RVA = "0x340C20", Offset = "0x33FE20", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeGetter", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeSetter", ReturnType = typeof(void))]
	[Token(Token = "0x6000A02")]
	private override void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	[Address(RVA = "0x340C40", Offset = "0x33FE40", Length = "0x474")]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ParameterExpression[])}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PerformanceStatistics), Member = "StartGlobalStopwatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerformanceCounter)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FE")]
	internal void OptimizeGetter() { }

	[Address(RVA = "0x3410C0", Offset = "0x3402C0", Length = "0x6BD")]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ParameterExpression[])}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PerformanceStatistics), Member = "StartGlobalStopwatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerformanceCounter)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60009FF")]
	internal void OptimizeSetter() { }

	[Address(RVA = "0x341780", Offset = "0x340980", Length = "0x35E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000A03")]
	public override void PrepareForWiring(Table t) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F2")]
	private void set_AccessMode(InteropAccessMode value) { }

	[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F4")]
	private void set_IsStatic(bool value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F6")]
	private void set_Name(string value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F0")]
	private void set_PropertyInfo(PropertyInfo value) { }

	[Address(RVA = "0x341AE0", Offset = "0x340CE0", Length = "0x40B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "UserDataArgumentTypeMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType), typeof(Type)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeSetter", ReturnType = typeof(void))]
	[Calls(Type = typeof(NumericConversions), Member = "DoubleToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(double)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(MemberDescriptorAccess), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A00")]
	public override void SetValue(Script script, object obj, DynValue v) { }

	[Address(RVA = "0x342140", Offset = "0x341340", Length = "0xB3")]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode)}, ReturnType = typeof(PropertyMemberDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009FA")]
	private static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter) { }

	[Address(RVA = "0x341EF0", Offset = "0x3410F0", Length = "0x246")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetVisibilityFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode), typeof(MethodInfo), typeof(MethodInfo)}, ReturnType = typeof(PropertyMemberDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009F9")]
	public static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode) { }

}

