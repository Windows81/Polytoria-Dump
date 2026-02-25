namespace UnityEngine;

[Token(Token = "0x2000025")]
internal sealed class GUIWordWrapSizer : GUILayoutEntry
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000DF")]
	private readonly GUIContent m_Content; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000E0")]
	private readonly float m_ForcedMinHeight; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000E1")]
	private readonly float m_ForcedMaxHeight; //Field offset: 0x54

	[Address(RVA = "0x19C1600", Offset = "0x19C0800", Length = "0xE9")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	[Address(RVA = "0x19C14C0", Offset = "0x19C06C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000252")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x19C1540", Offset = "0x19C0740", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "CalcMinMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000251")]
	public virtual void CalcWidth() { }

}

