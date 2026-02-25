namespace UnityEngine.UIElements;

[Token(Token = "0x2000278")]
internal class UIDocumentList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009BF")]
	internal List<UIDocument> m_AttachedUIDocuments; //Field offset: 0x10

	[Address(RVA = "0x1C76840", Offset = "0x1C75A40", Length = "0x77")]
	[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001142")]
	public UIDocumentList() { }

	[Address(RVA = "0x1C76440", Offset = "0x1C75640", Length = "0x380")]
	[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "ChildCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001141")]
	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, bool ignoreContentContainer, int firstInsertIndex = 0) { }

	[Address(RVA = "0x1C767D0", Offset = "0x1C759D0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001140")]
	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

}

