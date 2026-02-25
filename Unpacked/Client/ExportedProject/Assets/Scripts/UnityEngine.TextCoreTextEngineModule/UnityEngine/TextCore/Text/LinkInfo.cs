namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000022")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct LinkInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AE")]
	public int hashCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000AF")]
	public int linkIdFirstCharacterIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B0")]
	public int linkIdLength; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000B1")]
	public int linkTextfirstCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B2")]
	public int linkTextLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Char[] linkId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B4")]
	private string m_LinkIdString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B5")]
	private string m_LinkTextString; //Field offset: 0x28

	[Address(RVA = "0x1A33870", Offset = "0x1A32A70", Length = "0x4D")]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600004C")]
	public string GetLinkId() { }

	[Address(RVA = "0x1A338C0", Offset = "0x1A32AC0", Length = "0xF8")]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	public string GetLinkText(TextInfo textInfo) { }

	[Address(RVA = "0x1A339C0", Offset = "0x1A32BC0", Length = "0xFB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600004A")]
	internal void SetLinkId(Char[] text, int startIndex, int length) { }

}

