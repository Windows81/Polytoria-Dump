namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000041")]
public struct DataSourceContextChanged
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000142")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000143")]
	private readonly BindingId m_BindingId; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000144")]
	private readonly DataSourceContext m_PreviousContext; //Field offset: 0xA0
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000145")]
	private readonly DataSourceContext m_NewContext; //Field offset: 0x138

	[Address(RVA = "0x1AC8030", Offset = "0x1AC7230", Length = "0x1DD")]
	[CalledBy(Type = typeof(BindingData), Member = "set_context", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSourceContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001FE")]
	internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext) { }

}

