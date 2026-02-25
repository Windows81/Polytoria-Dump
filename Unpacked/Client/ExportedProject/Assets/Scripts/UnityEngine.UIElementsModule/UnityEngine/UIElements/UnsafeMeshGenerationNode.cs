namespace UnityEngine.UIElements;

[Token(Token = "0x20002CB")]
internal struct UnsafeMeshGenerationNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B55")]
	private GCHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1C890F0", Offset = "0x1C882F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600136F")]
	internal static void Create(GCHandle handle, out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x1C94090", Offset = "0x1C93290", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001372")]
	internal void DrawGradientsInternal(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x1C942C0", Offset = "0x1C934C0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001370")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null) { }

	[Address(RVA = "0x1C941C0", Offset = "0x1C933C0", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001371")]
	internal void DrawMeshInternal(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x1C943C0", Offset = "0x1C935C0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600136E")]
	private MeshGenerationNodeImpl GetManaged() { }

	[Address(RVA = "0x1C89100", Offset = "0x1C88300", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001373")]
	internal Entry GetParentEntry() { }

}

