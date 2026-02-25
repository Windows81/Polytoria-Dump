namespace UnityEngine;

[Token(Token = "0x2000027")]
internal sealed class GUIScrollGroup : GUILayoutGroup
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000F7")]
	public float calcMinWidth; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40000F8")]
	public float calcMaxWidth; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000F9")]
	public float calcMinHeight; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000FA")]
	public float calcMaxHeight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000FB")]
	public float clientWidth; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40000FC")]
	public float clientHeight; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000FD")]
	public bool allowHorizontalScroll; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x40000FE")]
	public bool allowVerticalScroll; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x40000FF")]
	public bool needsHorizontalScrollbar; //Field offset: 0xAA
	[FieldOffset(Offset = "0xAB")]
	[Token(Token = "0x4000100")]
	public bool needsVerticalScrollbar; //Field offset: 0xAB
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000101")]
	public GUIStyle horizontalScrollbar; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000102")]
	public GUIStyle verticalScrollbar; //Field offset: 0xB8

	[Address(RVA = "0x19BE860", Offset = "0x19BDA60", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000263")]
	public GUIScrollGroup() { }

	[Address(RVA = "0x19BE320", Offset = "0x19BD520", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000266")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x19BE440", Offset = "0x19BD640", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000264")]
	public virtual void CalcWidth() { }

	[Address(RVA = "0x19BE4E0", Offset = "0x19BD6E0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000265")]
	public virtual void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x19BE630", Offset = "0x19BD830", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000267")]
	public virtual void SetVertical(float y, float height) { }

}

