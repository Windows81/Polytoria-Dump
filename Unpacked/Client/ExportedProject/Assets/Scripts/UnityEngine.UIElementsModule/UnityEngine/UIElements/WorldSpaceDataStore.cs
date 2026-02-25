namespace UnityEngine.UIElements;

[Token(Token = "0x2000538")]
internal static class WorldSpaceDataStore
{
	[Token(Token = "0x400114C")]
	private static Dictionary<UInt32, WorldSpaceData> m_WorldSpaceData; //Field offset: 0x0

	[Address(RVA = "0x1B7A3C0", Offset = "0x1B795C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60025C9")]
	private static WorldSpaceDataStore() { }

	[Address(RVA = "0x1B79E40", Offset = "0x1B79040", Length = "0x225")]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(WorldSpaceData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025C8")]
	public static void ClearLocalBounds3DData(VisualElement ve) { }

	[Address(RVA = "0x1B7A070", Offset = "0x1B79270", Length = "0x11C")]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_isLocalBounds3DDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_needs3DBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025C7")]
	public static void ClearWorldSpaceData(VisualElement ve) { }

	[Address(RVA = "0x1B7A190", Offset = "0x1B79390", Length = "0x148")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBoxWithoutNested", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBoundsPicking3D", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3DWithoutNested3D", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(WorldSpaceData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025C6")]
	public static WorldSpaceData GetWorldSpaceData(VisualElement ve) { }

	[Address(RVA = "0x1B7A2E0", Offset = "0x1B794E0", Length = "0xD2")]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025C5")]
	public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data) { }

}

