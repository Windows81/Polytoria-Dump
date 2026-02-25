namespace UnityEngine.UIElements;

[Token(Token = "0x20004A0")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UIElementsUtility : IUIElementsUtility
{
	[Token(Token = "0x4000FA8")]
	private static Stack<IMGUIContainer> s_ContainerStack; //Field offset: 0x0
	[Token(Token = "0x4000FA9")]
	private static Dictionary<Int32, Panel> s_UIElementsCache; //Field offset: 0x8
	[Token(Token = "0x4000FAA")]
	private static Event s_EventInstance; //Field offset: 0x10
	[Token(Token = "0x4000FAB")]
	internal static Color editorPlayModeTintColor; //Field offset: 0x18
	[Token(Token = "0x4000FAC")]
	internal static float singleLineHeight; //Field offset: 0x28
	[Token(Token = "0x4000FAD")]
	internal static bool s_EnableOSXContextualMenuEventsOnNonOSXPlatforms; //Field offset: 0x2C
	[Token(Token = "0x4000FAE")]
	private static UIElementsUtility s_Instance; //Field offset: 0x30
	[Token(Token = "0x4000FAF")]
	internal static List<Panel> s_PanelsIterationList; //Field offset: 0x38
	[Token(Token = "0x4000FB0")]
	private static Action testFrameUpdateCallback; //Field offset: 0x40
	[Token(Token = "0x4000FB1")]
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x48
	[Token(Token = "0x4000FB2")]
	internal static readonly string s_EventProfilerMarkerName; //Field offset: 0x50
	[Token(Token = "0x4000FB3")]
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x58
	[Token(Token = "0x4000FB4")]
	private static readonly ProfilerMarker s_EventProfilerMarker; //Field offset: 0x60
	[Token(Token = "0x4000FB5")]
	internal static Char[] s_Modifiers; //Field offset: 0x68

	[Token(Token = "0x17000958")]
	public static bool isOSXContextualMenuPlatform
	{
		[Address(RVA = "0x1B4B7C0", Offset = "0x1B4A9C0", Length = "0x90")]
		[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ContextualMenuPopulateEvent>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "RegisterCallbacksOnTarget", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "UnregisterCallbacksFromTarget", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "IsOSXContextualMenuPlatform", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002337")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x1B4B2E0", Offset = "0x1B4A4E0", Length = "0x413")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600234B")]
	private static UIElementsUtility() { }

	[Address(RVA = "0x1B4B700", Offset = "0x1B4A900", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002338")]
	private UIElementsUtility() { }

	[Address(RVA = "0x1B49910", Offset = "0x1B48B10", Length = "0x25B")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "set_current", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "BeginContainerFromOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "BeginContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "BeginContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ObjectGUIState"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_guiState", ReturnType = "UnityEngine.ObjectGUIState")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIUtility), Member = "ResetGlobalState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002342")]
	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	[Address(RVA = "0x1B49BE0", Offset = "0x1B48DE0", Length = "0xE4")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002345")]
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	[Address(RVA = "0x1B49B70", Offset = "0x1B48D70", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002344")]
	internal static EventBase CreateEvent(Event systemEvent) { }

	[Address(RVA = "0x1B49F90", Offset = "0x1B49190", Length = "0x5AA")]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIElementsUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventType)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002346")]
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1B4A540", Offset = "0x1B49740", Length = "0x234")]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(GUIContent), Member = "ClearStaticCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "EndContainer", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002343")]
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	[Address(RVA = "0x1B4B7C0", Offset = "0x1B4A9C0", Length = "0x90")]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ContextualMenuPopulateEvent>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "RegisterCallbacksOnTarget", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "UnregisterCallbacksFromTarget", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "IsOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002337")]
	public static bool get_isOSXContextualMenuPlatform() { }

	[Address(RVA = "0x1B4A780", Offset = "0x1B49980", Length = "0x172")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetPlayerPanelsByRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002347")]
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	[Address(RVA = "0x1B4A900", Offset = "0x1B49B00", Length = "0xAB")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002348")]
	internal static Enumerator<Int32, Panel> GetPanelsIterator() { }

	[Address(RVA = "0x1B4A9B0", Offset = "0x1B49BB0", Length = "0x134")]
	[CalledBy(Type = typeof(PopupField`1), Member = "GetValueToDisplay", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600234A")]
	internal static string ParseMenuName(string menuName) { }

	[Address(RVA = "0x1B4AAF0", Offset = "0x1B49CF0", Length = "0xC9")]
	[CalledBy(Type = typeof(Image), Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Image), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002349")]
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	[Address(RVA = "0x1B4ABC0", Offset = "0x1B49DC0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600233F")]
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	[Address(RVA = "0x1B4AC50", Offset = "0x1B49E50", Length = "0x77")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002340")]
	public static void RemoveCachedPanel(int instanceID) { }

	[Address(RVA = "0x1B4ACD0", Offset = "0x1B49ED0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002341")]
	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	[Address(RVA = "0x1B4AD60", Offset = "0x1B49F60", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600233D")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	[Address(RVA = "0x1B4AE30", Offset = "0x1B4A030", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "EndContainer", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600233E")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	[Address(RVA = "0x1B4AF10", Offset = "0x1B4A110", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(IMGUIContainer), Member = "MarkDirtyLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002339")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	[Address(RVA = "0x1B4AFD0", Offset = "0x1B4A1D0", Length = "0x241")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "CopyFromPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600233C")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600233B")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	[Address(RVA = "0x1B4B220", Offset = "0x1B4A420", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(MouseCaptureController), Member = "CaptureMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600233A")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

}

