namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053F")]
internal class GCHandlePool : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400115E")]
	private List<GCHandle> m_Handles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400115F")]
	private int m_UsedHandlesCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001160")]
	private readonly int k_AllocBatchSize; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001161")]
	private bool <disposed>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170009C7")]
	internal bool disposed
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60025FD")]
		internal get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60025FE")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B66500", Offset = "0x1B65700", Length = "0x9D")]
	[CalledBy(Type = typeof(MeshGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025F9")]
	public GCHandlePool(int capacity = 256, int allocBatchSize = 64) { }

	[Address(RVA = "0x1B66080", Offset = "0x1B65280", Length = "0x56")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandlePool), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60025FF")]
	public override void Dispose() { }

	[Address(RVA = "0x1B660E0", Offset = "0x1B652E0", Length = "0x156")]
	[CalledBy(Type = typeof(GCHandlePool), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002600")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1B66270", Offset = "0x1B65470", Length = "0x1A8")]
	[CalledBy(Type = typeof(GCHandlePool), Member = "GetIntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030400")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60025FA")]
	public GCHandle Get(object target) { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60025FD")]
	internal bool get_disposed() { }

	[Address(RVA = "0x1B66240", Offset = "0x1B65440", Length = "0x26")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GCHandlePool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025FB")]
	public IntPtr GetIntPtr(object target) { }

	[Address(RVA = "0x1B66420", Offset = "0x1B65620", Length = "0xDB")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "OnMeshGeneration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60025FC")]
	public void ReturnAll() { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60025FE")]
	private void set_disposed(bool value) { }

}

