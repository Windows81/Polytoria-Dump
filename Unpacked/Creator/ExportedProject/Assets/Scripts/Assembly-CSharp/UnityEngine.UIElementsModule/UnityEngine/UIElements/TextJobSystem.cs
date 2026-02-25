namespace UnityEngine.UIElements;

[Token(Token = "0x2000482")]
internal class TextJobSystem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5B")]
	internal UITKTextJobSystem m_UITKTextJobSystem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5C")]
	private ATGTextJobSystem m_ATGTextJobSystem; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002241")]
	public TextJobSystem() { }

	[Address(RVA = "0x1B40C50", Offset = "0x1B3FE50", Length = "0x381")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ATGTextJobSystem), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002240")]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

}

