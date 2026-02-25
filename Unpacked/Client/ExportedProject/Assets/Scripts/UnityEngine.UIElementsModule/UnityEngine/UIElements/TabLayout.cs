namespace UnityEngine.UIElements;

[Token(Token = "0x2000150")]
internal class TabLayout
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AB")]
	private TabView m_TabView; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006AC")]
	private List<VisualElement> m_TabHeaders; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006AD")]
	private bool m_IsVertical; //Field offset: 0x20

	[Address(RVA = "0x1C29A40", Offset = "0x1C28C40", Length = "0x62")]
	[CalledBy(Type = typeof(TabDragger), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A36")]
	public TabLayout(TabView tabView, bool isVertical) { }

	[Address(RVA = "0x1C29780", Offset = "0x1C28980", Length = "0x28")]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A37")]
	public static float GetHeight(VisualElement t) { }

	[Address(RVA = "0x1C297B0", Offset = "0x1C289B0", Length = "0x120")]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A39")]
	public float GetTabOffset(VisualElement tab) { }

	[Address(RVA = "0x1C298E0", Offset = "0x1C28AE0", Length = "0x28")]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A38")]
	public static float GetWidth(VisualElement t) { }

	[Address(RVA = "0x1C29910", Offset = "0x1C28B10", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A3A")]
	private void InitOrderTabs() { }

	[Address(RVA = "0x1C29990", Offset = "0x1C28B90", Length = "0xA8")]
	[CalledBy(Type = typeof(TabDragger), Member = "EndDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A3B")]
	public void ReorderDisplay(int from, int to) { }

}

