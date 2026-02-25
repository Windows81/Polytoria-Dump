namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000581")]
internal class NativeList : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001338")]
	private NativeArray<T> m_NativeArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001339")]
	private int m_Count; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133A")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170009EC")]
	public int Count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600274D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170009ED")]
	protected private bool disposed
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600274E")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600274F")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xE1FEE0", Offset = "0xE1F0E0", Length = "0xA8")]
	[CalledBy(Type = typeof(CommandList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IntPtr), typeof(IntPtr), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002748")]
	public NativeList`1(int initialCapacity) { }

	[Address(RVA = "0xE1F660", Offset = "0xE1E860", Length = "0x213")]
	[CalledBy(Type = typeof(CommandList), Member = "DrawRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<System.UInt16>), typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.DrawBufferRange>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "DrawRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<System.UInt16>), typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.DrawBufferRange>), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800E1480")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600274A")]
	public void Add(NativeSlice<T> src) { }

	[Address(RVA = "0xE1F9D0", Offset = "0xE1EBD0", Length = "0x8")]
	[CalledBy(Type = typeof(CommandList), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600274B")]
	public void Clear() { }

	[Address(RVA = "0xE1FA90", Offset = "0xE1EC90", Length = "0x86")]
	[CalledBy(Type = typeof(CommandList), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandList), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002750")]
	public override void Dispose() { }

	[Address(RVA = "0xE1FA50", Offset = "0xE1EC50", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002751")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xE1FCB0", Offset = "0xE1EEB0", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800E1480")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002749")]
	private void Expand(int newLength) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600274D")]
	public int get_Count() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600274E")]
	protected bool get_disposed() { }

	[Address(RVA = "0xE1FE20", Offset = "0xE1F020", Length = "0x54")]
	[CalledBy(Type = typeof(CommandList), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x600274C")]
	public NativeSlice<T> GetSlice(int start, int length) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600274F")]
	private void set_disposed(bool value) { }

}

