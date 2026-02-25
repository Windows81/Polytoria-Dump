namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000548")]
internal class DetachedAllocator : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400118C")]
	private TempAllocator<Vertex> m_VertsPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400118D")]
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400118E")]
	private List<MeshWriteData> m_MeshWriteDataPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400118F")]
	private int m_MeshWriteDataCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001190")]
	private bool m_Disposed; //Field offset: 0x2C

	[Address(RVA = "0x1B656B0", Offset = "0x1B648B0", Length = "0x13B")]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002621")]
	public DetachedAllocator() { }

	[Address(RVA = "0x1B65570", Offset = "0x1B64770", Length = "0xAA")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002622")]
	public override void Dispose() { }

	[Address(RVA = "0x1B65620", Offset = "0x1B64820", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002623")]
	protected void Dispose(bool disposing) { }

}

