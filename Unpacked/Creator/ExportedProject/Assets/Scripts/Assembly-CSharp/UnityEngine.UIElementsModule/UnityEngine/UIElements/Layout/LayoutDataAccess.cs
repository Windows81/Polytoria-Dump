namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[RequiredByNativeCode]
[Token(Token = "0x20005D1")]
internal struct LayoutDataAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001511")]
	private readonly int m_Manager; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001512")]
	private readonly LayoutDataStore m_Nodes; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001513")]
	private readonly LayoutDataStore m_Configs; //Field offset: 0x18

	[Address(RVA = "0x1BA8C90", Offset = "0x1BA7E90", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002960")]
	internal LayoutDataAccess(int manager, LayoutDataStore nodes, LayoutDataStore configs) { }

	[Address(RVA = "0x1BA8840", Offset = "0x1BA7A40", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296B")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[Address(RVA = "0x1BA88B0", Offset = "0x1BA7AB0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002965")]
	public LayoutComputedData GetComputedData(LayoutHandle handle) { }

	[Address(RVA = "0x1BA8930", Offset = "0x1BA7B30", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002966")]
	public LayoutConfigData GetConfigData(LayoutHandle handle) { }

	[Address(RVA = "0x1BA89B0", Offset = "0x1BA7BB0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002967")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[Address(RVA = "0x1BA8A20", Offset = "0x1BA7C20", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002963")]
	public LayoutNodeData GetNodeData(LayoutHandle handle) { }

	[Address(RVA = "0x1BA8AA0", Offset = "0x1BA7CA0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002969")]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[Address(RVA = "0x1BA8B10", Offset = "0x1BA7D10", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002964")]
	public LayoutStyleData GetStyleData(LayoutHandle handle) { }

	[Address(RVA = "0x6EA7A0", Offset = "0x6E99A0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "GetComponentDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002962")]
	private T GetTypedConfigDataRef(LayoutHandle handle, LayoutConfigDataType type) { }

	[Address(RVA = "0x6EA7D0", Offset = "0x6E99D0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "GetComponentDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002961")]
	private T GetTypedNodeDataRef(LayoutHandle handle, LayoutNodeDataType type) { }

	[Address(RVA = "0x1BA8B90", Offset = "0x1BA7D90", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002968")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[Address(RVA = "0x1BA8C10", Offset = "0x1BA7E10", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296A")]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

}

