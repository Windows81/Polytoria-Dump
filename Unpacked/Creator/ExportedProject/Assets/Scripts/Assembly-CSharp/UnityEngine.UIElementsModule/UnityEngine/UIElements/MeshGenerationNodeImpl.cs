namespace UnityEngine.UIElements;

[Token(Token = "0x20002CC")]
internal class MeshGenerationNodeImpl : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B56")]
	private GCHandle m_SelfHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B57")]
	private Entry m_ParentEntry; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B58")]
	private EntryRecorder m_EntryRecorder; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B59")]
	private bool <disposed>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170003C3")]
	protected private bool disposed
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137C")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137D")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1C88990", Offset = "0x1C87B90", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001374")]
	public MeshGenerationNodeImpl() { }

	[Address(RVA = "0x1C885F0", Offset = "0x1C877F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600137E")]
	public override void Dispose() { }

	[Address(RVA = "0x1C885B0", Offset = "0x1C877B0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Token(Token = "0x600137F")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x1C88660", Offset = "0x1C87860", Length = "0xF5")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600137B")]
	public void DrawGradients(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x1C88760", Offset = "0x1C87960", Length = "0xD0")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600137A")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137C")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1C88840", Offset = "0x1C87A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001377")]
	public void GetNode(out MeshGenerationNode node) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001379")]
	public Entry GetParentEntry() { }

	[Address(RVA = "0x1C88840", Offset = "0x1C87A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001378")]
	public void GetUnsafeNode(out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x1C88850", Offset = "0x1C87A50", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001375")]
	public void Init(Entry parentEntry, EntryRecorder entryRecorder, bool safe) { }

	[Address(RVA = "0x1C88900", Offset = "0x1C87B00", Length = "0x88")]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001376")]
	public void Reset() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137D")]
	private void set_disposed(bool value) { }

}

