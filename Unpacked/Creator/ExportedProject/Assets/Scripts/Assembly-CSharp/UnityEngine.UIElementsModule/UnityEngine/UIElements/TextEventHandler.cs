namespace UnityEngine.UIElements;

[Token(Token = "0x2000481")]
internal class TextEventHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F4E")]
	private TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F4F")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F50")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F51")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F52")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F53")]
	private EventCallback<PointerUpEvent> m_ATagOnPointerUp; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F54")]
	private EventCallback<PointerMoveEvent> m_ATagOnPointerMove; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F55")]
	private EventCallback<PointerOverEvent> m_ATagOnPointerOver; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F56")]
	private EventCallback<PointerOutEvent> m_ATagOnPointerOut; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F57")]
	internal bool isOverridingCursor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000F58")]
	internal int currentLinkIDHash; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F59")]
	internal bool hasLinkTag; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000F5A")]
	internal bool hasATag; //Field offset: 0x61

	[Token(Token = "0x17000924")]
	private TextInfo textInfo
	{
		[Address(RVA = "0x1B40C20", Offset = "0x1B3FE20", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600222E")]
		private get { } //Length: 41
	}

	[Address(RVA = "0x1B40BE0", Offset = "0x1B3FDE0", Length = "0x38")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600222F")]
	public TextEventHandler(TextElement textElement) { }

	[Address(RVA = "0x1B3F1E0", Offset = "0x1B3E3E0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002234")]
	private void AllocateATagCallbacks() { }

	[Address(RVA = "0x1B3F350", Offset = "0x1B3E550", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002232")]
	private void AllocateLinkCallbacks() { }

	[Address(RVA = "0x1B3ED10", Offset = "0x1B3DF10", Length = "0x2A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D0F70")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002237")]
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x1B23E70", Offset = "0x1B23070", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002238")]
	private void ATagOnPointerOut(PointerOutEvent evt) { }

	[Address(RVA = "0x1B23E70", Offset = "0x1B23070", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002236")]
	private void ATagOnPointerOver(PointerOverEvent _) { }

	[Address(RVA = "0x1B3EFC0", Offset = "0x1B3E1C0", Length = "0x219")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002235")]
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x1B40C20", Offset = "0x1B3FE20", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600222E")]
	private TextInfo get_textInfo() { }

	[Address(RVA = "0x1B3F4C0", Offset = "0x1B3E6C0", Length = "0x12C")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "HandleATag", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600223F")]
	internal void HandleATag() { }

	[Address(RVA = "0x1B3F5F0", Offset = "0x1B3E7F0", Length = "0x630")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x600223D")]
	internal void HandleLinkAndATagCallbacks() { }

	[Address(RVA = "0x1B3FC30", Offset = "0x1B3EE30", Length = "0x12C")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "HandleLinkTag", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600223E")]
	internal void HandleLinkTag() { }

	[Address(RVA = "0x1B23C10", Offset = "0x1B22E10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002233")]
	private bool HasAllocatedATagCallbacks() { }

	[Address(RVA = "0x1B23C20", Offset = "0x1B22E20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002231")]
	private bool HasAllocatedLinkCallbacks() { }

	[Address(RVA = "0x1B3FD60", Offset = "0x1B3EF60", Length = "0x31C")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDownLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerDownLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002239")]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[Address(RVA = "0x1B40080", Offset = "0x1B3F280", Length = "0x559")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[Calls(Type = typeof(PointerOverLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerOverLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerMoveLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerMoveLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600223B")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x1B405E0", Offset = "0x1B3F7E0", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600223C")]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[Address(RVA = "0x1B40730", Offset = "0x1B3F930", Length = "0x31C")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerUpLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerUpLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600223A")]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x1B40A50", Offset = "0x1B3FC50", Length = "0x183")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6002230")]
	public void OnDestroy() { }

}

