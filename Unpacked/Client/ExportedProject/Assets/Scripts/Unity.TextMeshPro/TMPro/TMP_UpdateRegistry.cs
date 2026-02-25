namespace TMPro;

[Token(Token = "0x20000BA")]
public class TMP_UpdateRegistry
{
	[Token(Token = "0x4000695")]
	private static TMP_UpdateRegistry s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000696")]
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000697")]
	private HashSet<Int32> m_LayoutQueueLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000698")]
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000699")]
	private HashSet<Int32> m_GraphicQueueLookup; //Field offset: 0x28

	[Token(Token = "0x170001A7")]
	public static TMP_UpdateRegistry instance
	{
		[Address(RVA = "0x18FAC50", Offset = "0x18F9E50", Length = "0x1D9")]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "PerformUpdateForCanvasRendererObjects", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x600070D")]
		 get { } //Length: 473
	}

	[Address(RVA = "0x18FAAF0", Offset = "0x18F9CF0", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600070E")]
	protected TMP_UpdateRegistry() { }

	[Address(RVA = "0x18FAC50", Offset = "0x18F9E50", Length = "0x1D9")]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "PerformUpdateForCanvasRendererObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600070D")]
	public static TMP_UpdateRegistry get_instance() { }

	[Address(RVA = "0x18F9F10", Offset = "0x18F9110", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000712")]
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA040", Offset = "0x18F9240", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000710")]
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA170", Offset = "0x18F9370", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000717")]
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA270", Offset = "0x18F9470", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000716")]
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA370", Offset = "0x18F9570", Length = "0x2BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000713")]
	private void PerformUpdateForCanvasRendererObjects() { }

	[Address(RVA = "0x18FA630", Offset = "0x18F9830", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000714")]
	private void PerformUpdateForMeshRendererObjects() { }

	[Address(RVA = "0x18FA690", Offset = "0x18F9890", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000711")]
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA7C0", Offset = "0x18F99C0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600070F")]
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x18FA8F0", Offset = "0x18F9AF0", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateRegistry), Member = "get_instance", ReturnType = typeof(TMP_UpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000715")]
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

}

