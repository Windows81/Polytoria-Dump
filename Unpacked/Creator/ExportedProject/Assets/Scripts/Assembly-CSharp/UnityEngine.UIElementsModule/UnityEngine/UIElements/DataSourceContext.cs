namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000040")]
public struct DataSourceContext
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000140")]
	private readonly object <dataSource>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000141")]
	private readonly PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700003D")]
	public object dataSource
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700003E")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x1AC82B0", Offset = "0x1AC74B0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60001FC")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x1AC8210", Offset = "0x1AC7410", Length = "0x9C")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001FD")]
	public DataSourceContext(object dataSource, in PropertyPath dataSourcePath) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FB")]
	public object get_dataSource() { }

	[Address(RVA = "0x1AC82B0", Offset = "0x1AC74B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60001FC")]
	public PropertyPath get_dataSourcePath() { }

}

