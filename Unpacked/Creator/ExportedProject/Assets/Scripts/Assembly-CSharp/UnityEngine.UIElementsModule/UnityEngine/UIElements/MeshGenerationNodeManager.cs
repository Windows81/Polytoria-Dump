namespace UnityEngine.UIElements;

[Token(Token = "0x20002CD")]
internal class MeshGenerationNodeManager : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B5A")]
	private List<MeshGenerationNodeImpl> m_Nodes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B5B")]
	private int m_UsedCounter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B5C")]
	private EntryRecorder m_EntryRecorder; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B5D")]
	private bool <disposed>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170003C4")]
	protected private bool disposed
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001385")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001386")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1C89050", Offset = "0x1C88250", Length = "0x99")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001380")]
	public MeshGenerationNodeManager(EntryRecorder entryRecorder) { }

	[Address(RVA = "0x1C889C0", Offset = "0x1C87BC0", Length = "0x217")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeManager), Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeManager), Member = "CreateUnsafeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001383")]
	private MeshGenerationNodeImpl CreateImpl(Entry parentEntry, bool safe) { }

	[Address(RVA = "0x1C88BE0", Offset = "0x1C87DE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(bool)}, ReturnType = typeof(MeshGenerationNodeImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001381")]
	public void CreateNode(Entry parentEntry, out MeshGenerationNode node) { }

	[Address(RVA = "0x1C88C10", Offset = "0x1C87E10", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(bool)}, ReturnType = typeof(MeshGenerationNodeImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001382")]
	public void CreateUnsafeNode(Entry parentEntry, out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x1C88C40", Offset = "0x1C87E40", Length = "0x188")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001387")]
	public override void Dispose() { }

	[Address(RVA = "0x1C88DD0", Offset = "0x1C87FD0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001388")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001385")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1C88F30", Offset = "0x1C88130", Length = "0x114")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001384")]
	public void ResetAll() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001386")]
	private void set_disposed(bool value) { }

}

