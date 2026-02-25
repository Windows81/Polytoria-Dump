namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058E")]
internal struct DepthOrderedDirtyTracking
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013A7")]
	public RenderTree owner; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40013A8")]
	public List<RenderData> heads; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013A9")]
	public List<RenderData> tails; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013AA")]
	public Int32[] minDepths; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013AB")]
	public Int32[] maxDepths; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013AC")]
	public uint dirtyID; //Field offset: 0x28

	[Address(RVA = "0x1B8F970", Offset = "0x1B8EB70", Length = "0x1C3")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "ChildWillBeRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600279C")]
	public void ClearDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypesInverse) { }

	[Address(RVA = "0x1B8FB40", Offset = "0x1B8ED40", Length = "0x14A")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600279A")]
	public void EnsureFits(int maxDepth) { }

	[Address(RVA = "0x1B8FC90", Offset = "0x1B8EE90", Length = "0x1E1")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(float), typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "OnRenderDataTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "OnRenderDataOpacityIdChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "OnRenderDataVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600279B")]
	public void RegisterDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	[Address(RVA = "0x1B8FE80", Offset = "0x1B8F080", Length = "0x74")]
	[CalledBy(Type = typeof(RenderTree), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "GetPooledRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(RenderTree))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600279D")]
	public void Reset() { }

}

