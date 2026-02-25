namespace UnityEngine;

[Token(Token = "0x2000026")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.CoreModule"})]
internal class GUILayoutGroup : GUILayoutEntry
{
	[Token(Token = "0x40000F6")]
	private static readonly GUILayoutEntry none; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000E2")]
	public List<GUILayoutEntry> entries; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000E3")]
	public bool isVertical; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40000E4")]
	public bool resetCoords; //Field offset: 0x51
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000E5")]
	public float spacing; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000E6")]
	public bool sameSize; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40000E7")]
	public bool isWindow; //Field offset: 0x59
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000E8")]
	public int windowID; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000E9")]
	private int m_Cursor; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000EA")]
	protected int m_StretchableCountX; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000EB")]
	protected int m_StretchableCountY; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000EC")]
	protected bool m_UserSpecifiedWidth; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40000ED")]
	protected bool m_UserSpecifiedHeight; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000EE")]
	protected float m_ChildMinWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000EF")]
	protected float m_ChildMaxWidth; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000F0")]
	protected float m_ChildMinHeight; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000F1")]
	protected float m_ChildMaxHeight; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000F2")]
	protected int m_MarginLeft; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40000F3")]
	protected int m_MarginRight; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000F4")]
	protected int m_MarginTop; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40000F5")]
	protected int m_MarginBottom; //Field offset: 0x8C

	[Token(Token = "0x17000085")]
	public virtual int marginBottom
	{
		[Address(RVA = "0xE0C290", Offset = "0xE0B490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000256")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000082")]
	public virtual int marginLeft
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000253")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000083")]
	public virtual int marginRight
	{
		[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000254")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000084")]
	public virtual int marginTop
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000255")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x19BE110", Offset = "0x19BD310", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000262")]
	private static GUILayoutGroup() { }

	[Address(RVA = "0x19BE1F0", Offset = "0x19BD3F0", Length = "0x130")]
	[CalledBy(Type = typeof(LayoutCache), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000257")]
	public GUILayoutGroup() { }

	[Address(RVA = "0x19BBB00", Offset = "0x19BAD00", Length = "0xA9")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[]), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600025C")]
	public void Add(GUILayoutEntry e) { }

	[Address(RVA = "0x19BBBB0", Offset = "0x19BADB0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutEntry), Member = "ApplyOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000258")]
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	[Address(RVA = "0x19BBCD0", Offset = "0x19BAED0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchWidth", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchHeight", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000259")]
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	[Address(RVA = "0x19BBDD0", Offset = "0x19BAFD0", Length = "0x675")]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchHeight", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025F")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x19BC450", Offset = "0x19BB650", Length = "0x6E1")]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchWidth", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginHorizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025D")]
	public virtual void CalcWidth() { }

	[Address(RVA = "0xE0C290", Offset = "0xE0B490", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000256")]
	public virtual int get_marginBottom() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000253")]
	public virtual int get_marginLeft() { }

	[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000254")]
	public virtual int get_marginRight() { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000255")]
	public virtual int get_marginTop() { }

	[Address(RVA = "0x19BCB40", Offset = "0x19BBD40", Length = "0x29E")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[]), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AFE0")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600025B")]
	public GUILayoutEntry GetNext() { }

	[Address(RVA = "0x2E72F0", Offset = "0x2E64F0", Length = "0x8")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025A")]
	public void ResetCursor() { }

	[Address(RVA = "0x19BCDE0", Offset = "0x19BBFE0", Length = "0x7D6")]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginHorizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025E")]
	public virtual void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x19BD5C0", Offset = "0x19BC7C0", Length = "0x7DD")]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginVertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000260")]
	public virtual void SetVertical(float y, float height) { }

	[Address(RVA = "0x19BDDA0", Offset = "0x19BCFA0", Length = "0x361")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000261")]
	public virtual string ToString() { }

}

