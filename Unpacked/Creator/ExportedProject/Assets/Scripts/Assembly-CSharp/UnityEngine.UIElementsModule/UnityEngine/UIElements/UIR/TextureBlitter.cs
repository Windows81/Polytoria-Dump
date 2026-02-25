namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A8")]
internal class TextureBlitter : IDisposable
{
	[Token(Token = "0x20005A9")]
	private struct BlitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400146B")]
		public Texture src; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400146C")]
		public RectInt srcRect; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400146D")]
		public Vector2Int dstPos; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400146E")]
		public int border; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400146F")]
		public Color tint; //Field offset: 0x24

	}

	[Token(Token = "0x4001462")]
	private static readonly Int32[] k_TextureIds; //Field offset: 0x0
	[Token(Token = "0x4001463")]
	private static ProfilerMarker s_CommitSampler; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001464")]
	private BlitInfo[] m_SingleBlit; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001465")]
	private Material m_BlitMaterial; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001466")]
	private MaterialPropertyBlock m_Properties; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001467")]
	private RectInt m_Viewport; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001468")]
	private RenderTexture m_PrevRT; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001469")]
	private List<BlitInfo> m_PendingBlits; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400146A")]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x17000A25")]
	protected private bool disposed
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002861")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002862")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1BA1050", Offset = "0x1BA0250", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002865")]
	private static TextureBlitter() { }

	[Address(RVA = "0x1BA1180", Offset = "0x1BA0380", Length = "0xB2")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002866")]
	public TextureBlitter(int capacity = 512) { }

	[Address(RVA = "0x1BA0200", Offset = "0x1B9F400", Length = "0x23A")]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BlitOneNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(Texture), typeof(RectInt), typeof(Vector2Int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "Commit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600286A")]
	private void BeginBlit(RenderTexture dst) { }

	[Address(RVA = "0x1BA0440", Offset = "0x1B9F640", Length = "0x130")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "UpdateAtlasTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextureBlitter), Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureBlitter), Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.UIElements.UIR.TextureBlitter+BlitInfo>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureBlitter), Member = "EndBlit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002868")]
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	[Address(RVA = "0x1BA0580", Offset = "0x1B9F780", Length = "0xF0")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Commit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextureBlitter), Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureBlitter), Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.UIElements.UIR.TextureBlitter+BlitInfo>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureBlitter), Member = "EndBlit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002869")]
	public void Commit(RenderTexture dst) { }

	[Address(RVA = "0x1BA0680", Offset = "0x1B9F880", Length = "0x61")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002863")]
	public override void Dispose() { }

	[Address(RVA = "0x1BA06F0", Offset = "0x1B9F8F0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002864")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1BA0770", Offset = "0x1B9F970", Length = "0x6AA")]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BlitOneNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(Texture), typeof(RectInt), typeof(Vector2Int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "Commit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "Vertex3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "TexCoord3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GL), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "SetPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GL), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600286B")]
	private void DoBlit(IList<BlitInfo> blitInfos, int startIndex) { }

	[Address(RVA = "0x1BA0E20", Offset = "0x1BA0020", Length = "0x9B")]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BlitOneNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(Texture), typeof(RectInt), typeof(Vector2Int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "Commit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Token(Token = "0x600286C")]
	private void EndBlit() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002861")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1BA0EC0", Offset = "0x1BA00C0", Length = "0x187")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.TextureBlitter+BlitInfo>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlitInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002867")]
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002862")]
	private void set_disposed(bool value) { }

}

