namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056A")]
internal class GradientSettingsAtlas : IDisposable
{
	[Token(Token = "0x200056B")]
	private struct RawTexture
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129F")]
		public Color32[] rgba; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40012A0")]
		public int width; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40012A1")]
		public int height; //Field offset: 0xC

		[Address(RVA = "0x1B8A2C0", Offset = "0x1B894C0", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc), typeof(GradientSettings[]), typeof(GradientRemap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60026E8")]
		public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }

		[Address(RVA = "0x1B8A370", Offset = "0x1B89570", Length = "0x90")]
		[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc), typeof(GradientSettings[]), typeof(GradientRemap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60026E7")]
		public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	}

	[Token(Token = "0x4001295")]
	private static ProfilerMarker s_MarkerWrite; //Field offset: 0x0
	[Token(Token = "0x4001296")]
	private static ProfilerMarker s_MarkerCommit; //Field offset: 0x8
	[Token(Token = "0x400129C")]
	private static int s_TextureCounter; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001297")]
	private readonly int m_Length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001298")]
	private readonly int m_ElemWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001299")]
	private BestFitAllocator m_Allocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400129A")]
	private Texture2D m_Atlas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400129B")]
	private RawTexture m_RawAtlas; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400129D")]
	private bool <disposed>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400129E")]
	private bool <MustCommit>k__BackingField; //Field offset: 0x39

	[Token(Token = "0x170009E1")]
	public Texture2D atlas
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026DF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170009E0")]
	protected private bool disposed
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026D9")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026DA")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170009DF")]
	internal int length
	{
		[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026D8")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170009E2")]
	public private bool MustCommit
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E2")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E3")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B82CC0", Offset = "0x1B81EC0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60026E6")]
	private static GradientSettingsAtlas() { }

	[Address(RVA = "0x1B82D60", Offset = "0x1B81F60", Length = "0xD5")]
	[CalledBy(Type = typeof(VectorImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026DD")]
	public GradientSettingsAtlas(int length = 4096) { }

	[Address(RVA = "0x1B82250", Offset = "0x1B81450", Length = "0xDC")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(VectorImageRenderInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026E0")]
	public Alloc Add(int count) { }

	[Address(RVA = "0x1B82330", Offset = "0x1B81530", Length = "0x1BD")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Commit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x60026E4")]
	public void Commit() { }

	[Address(RVA = "0x1B824F0", Offset = "0x1B816F0", Length = "0x61")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60026DB")]
	public override void Dispose() { }

	[Address(RVA = "0x1B82560", Offset = "0x1B81760", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60026DC")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026DF")]
	public Texture2D get_atlas() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026D9")]
	protected bool get_disposed() { }

	[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026D8")]
	internal int get_length() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E2")]
	public bool get_MustCommit() { }

	[Address(RVA = "0x1B825D0", Offset = "0x1B817D0", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E5")]
	private void PrepareAtlas() { }

	[Address(RVA = "0x1B82740", Offset = "0x1B81940", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Token(Token = "0x60026DE")]
	public void Reset() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026DA")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E3")]
	private void set_MustCommit(bool value) { }

	[Address(RVA = "0x1B82800", Offset = "0x1B81A00", Length = "0x4BB")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(VectorImageRenderInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RawTexture), Member = "WriteRawFloat4Packed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400330")]
	[Calls(Type = typeof(RawTexture), Member = "WriteRawInt2Packed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026E1")]
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

}

