namespace TMPro;

[Token(Token = "0x20000B9")]
public class TMP_UpdateManager
{
	[Token(Token = "0x4000687")]
	private static TMP_UpdateManager s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000690")]
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; //Field offset: 0x8
	[Token(Token = "0x4000691")]
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; //Field offset: 0x10
	[Token(Token = "0x4000692")]
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; //Field offset: 0x18
	[Token(Token = "0x4000693")]
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; //Field offset: 0x20
	[Token(Token = "0x4000694")]
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000688")]
	private readonly HashSet<Int32> m_LayoutQueueLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000689")]
	private readonly List<TMP_Text> m_LayoutRebuildQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400068A")]
	private readonly HashSet<Int32> m_GraphicQueueLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400068B")]
	private readonly List<TMP_Text> m_GraphicRebuildQueue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400068C")]
	private readonly HashSet<Int32> m_InternalUpdateLookup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400068D")]
	private readonly List<TMP_Text> m_InternalUpdateQueue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400068E")]
	private readonly HashSet<Int32> m_CullingUpdateLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400068F")]
	private readonly List<TMP_Text> m_CullingUpdateQueue; //Field offset: 0x48

	[Token(Token = "0x170001A6")]
	private static TMP_UpdateManager instance
	{
		[Address(RVA = "0x18F9E30", Offset = "0x18F9030", Length = "0xDB")]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForCullingUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TMP_UpdateManager), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60006FB")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x18F9AC0", Offset = "0x18F8CC0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600070C")]
	private static TMP_UpdateManager() { }

	[Address(RVA = "0x18F9C10", Offset = "0x18F8E10", Length = "0x217")]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60006FC")]
	private TMP_UpdateManager() { }

	[Address(RVA = "0x18F8C40", Offset = "0x18F7E40", Length = "0x2E4")]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "OnCameraPreCull", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000706")]
	private void DoRebuilds() { }

	[Address(RVA = "0x18F9E30", Offset = "0x18F9030", Length = "0xDB")]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForCullingUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006FB")]
	private static TMP_UpdateManager get_instance() { }

	[Address(RVA = "0x18F8F30", Offset = "0x18F8130", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000704")]
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	[Address(RVA = "0x18F8FF0", Offset = "0x18F81F0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000702")]
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F90B0", Offset = "0x18F82B0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000700")]
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F9170", Offset = "0x18F8370", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006FE")]
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x18F9230", Offset = "0x18F8430", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000709")]
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F92D0", Offset = "0x18F84D0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070A")]
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F9370", Offset = "0x18F8570", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070B")]
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x18F9410", Offset = "0x18F8610", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "DoRebuilds", ReturnType = typeof(void))]
	[Token(Token = "0x6000705")]
	private void OnCameraPreCull() { }

	[Address(RVA = "0x18F9420", Offset = "0x18F8620", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000703")]
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	[Address(RVA = "0x18F9520", Offset = "0x18F8720", Length = "0xFA")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetVerticesDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000701")]
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F9620", Offset = "0x18F8820", Length = "0xFA")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_autoSizeTextContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006FF")]
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F9720", Offset = "0x18F8920", Length = "0xFA")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_isTextObjectScaleStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006FD")]
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x18F9820", Offset = "0x18F8A20", Length = "0x1CE")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000708")]
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	[Address(RVA = "0x18F99F0", Offset = "0x18F8BF0", Length = "0xCE")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_isTextObjectScaleStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000707")]
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

