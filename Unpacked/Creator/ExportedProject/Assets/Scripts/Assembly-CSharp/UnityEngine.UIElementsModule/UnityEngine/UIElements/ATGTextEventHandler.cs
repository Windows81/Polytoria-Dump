namespace UnityEngine.UIElements;

[Token(Token = "0x2000475")]
internal class ATGTextEventHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ECB")]
	private TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ECC")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ECD")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000ECE")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ECF")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000ED0")]
	private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000ED1")]
	private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000ED2")]
	private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ED3")]
	private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ED4")]
	internal bool isOverridingCursor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000ED5")]
	internal int currentLinkIDHash; //Field offset: 0x5C

	[Address(RVA = "0x1B250C0", Offset = "0x1B242C0", Length = "0xA1")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002139")]
	public ATGTextEventHandler(TextElement textElement) { }

	[Address(RVA = "0x1B23930", Offset = "0x1B22B30", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600213E")]
	private void AllocateHyperlinkCallbacks() { }

	[Address(RVA = "0x1B23AA0", Offset = "0x1B22CA0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600213C")]
	private void AllocateLinkCallbacks() { }

	[Address(RVA = "0x1B23C10", Offset = "0x1B22E10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600213D")]
	private bool HasAllocatedHyperlinkCallbacks() { }

	[Address(RVA = "0x1B23C20", Offset = "0x1B22E20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600213B")]
	private bool HasAllocatedLinkCallbacks() { }

	[Address(RVA = "0x1B23C30", Offset = "0x1B22E30", Length = "0x234")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D0F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002141")]
	private void HyperlinkOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x1B23E70", Offset = "0x1B23070", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002142")]
	private void HyperlinkOnPointerOut(PointerOutEvent evt) { }

	[Address(RVA = "0x1B23E70", Offset = "0x1B23070", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002140")]
	private void HyperlinkOnPointerOver(PointerOverEvent _) { }

	[Address(RVA = "0x1B23E80", Offset = "0x1B23080", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600213F")]
	private void HyperlinkOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x1B23FD0", Offset = "0x1B231D0", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDownLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerDownLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002143")]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[Address(RVA = "0x1B241E0", Offset = "0x1B233E0", Length = "0x440")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerMoveLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerMoveLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PointerOverLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerOverLinkTagEvent))]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002145")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x1B24630", Offset = "0x1B23830", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002146")]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[Address(RVA = "0x1B24780", Offset = "0x1B23980", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerUpLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerUpLinkTagEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002144")]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x1B24990", Offset = "0x1B23B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x600213A")]
	public void OnDestroy() { }

	[Address(RVA = "0x1B249B0", Offset = "0x1B23BB0", Length = "0x286")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002149")]
	internal void RegisterHyperlinkCallbacks() { }

	[Address(RVA = "0x1B24C40", Offset = "0x1B23E40", Length = "0x247")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002147")]
	internal void RegisterLinkTagCallbacks() { }

	[Address(RVA = "0x1B24E90", Offset = "0x1B24090", Length = "0x13C")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600214A")]
	internal void UnRegisterHyperlinkCallbacks() { }

	[Address(RVA = "0x1B24FD0", Offset = "0x1B241D0", Length = "0xE0")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002148")]
	internal void UnRegisterLinkTagCallbacks() { }

}

