namespace UnityEngine.Rendering.PostProcessing;

[Extension]
[Token(Token = "0x2000085")]
public static class RuntimeUtilities
{
	[CompilerGenerated]
	[Token(Token = "0x2000086")]
	private sealed class <>c
	{
		[Token(Token = "0x4000265")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000266")]
		public static Func<Assembly, IEnumerable`1<Type>> <>9__95_0; //Field offset: 0x8

		[Address(RVA = "0x18560B0", Offset = "0x18552B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600023D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		public <>c() { }

		[Address(RVA = "0x1855B00", Offset = "0x1854D00", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600023F")]
		internal IEnumerable<Type> <GetAllAssemblyTypes>b__95_0(Assembly t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000087")]
	private sealed class <>c__96
	{
		[Token(Token = "0x4000267")]
		public static readonly <>c__96<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000268")]
		public static Func<Type, Boolean> <>9__96_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000240")]
		private static <>c__96`1() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000241")]
		public <>c__96`1() { }

		[Address(RVA = "0x7FD4E0", Offset = "0x7FC6E0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000242")]
		internal bool <GetAllTypesDerivedFrom>b__96_0(Type t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000088")]
	private sealed class <GetAllSceneObjects>d__88 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000269")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026A")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026B")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026C")]
		private Queue<Transform> <queue>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026D")]
		private GameObject[] <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026E")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026F")]
		private IEnumerator <>7__wrap4; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000247")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700004D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000249")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		public <GetAllSceneObjects>d__88`1(int <>1__state) { }

		[Address(RVA = "0x80F5C0", Offset = "0x80E7C0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x80EF30", Offset = "0x80E130", Length = "0x4C3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Scene), Member = "GetRootGameObjects", ReturnType = typeof(GameObject[]))]
		[Calls(Type = typeof(SceneManager), Member = "GetActiveScene", ReturnType = typeof(Scene))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BAD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000245")]
		private override bool MoveNext() { }

		[Address(RVA = "0x80F400", Offset = "0x80E600", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600024A")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x80F4A0", Offset = "0x80E6A0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600024B")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x80F550", Offset = "0x80E750", Length = "0x62")]
		[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BA70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000244")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000255")]
	private static Texture2D m_WhiteTexture; //Field offset: 0x0
	[Token(Token = "0x4000256")]
	private static Texture3D m_WhiteTexture3D; //Field offset: 0x8
	[Token(Token = "0x4000257")]
	private static Texture2D m_BlackTexture; //Field offset: 0x10
	[Token(Token = "0x4000258")]
	private static Texture3D m_BlackTexture3D; //Field offset: 0x18
	[Token(Token = "0x4000259")]
	private static Texture2D m_TransparentTexture; //Field offset: 0x20
	[Token(Token = "0x400025A")]
	private static Texture3D m_TransparentTexture3D; //Field offset: 0x28
	[Token(Token = "0x400025B")]
	private static Dictionary<Int32, Texture2D> m_LutStrips; //Field offset: 0x30
	[Token(Token = "0x400025C")]
	private static PostProcessResources s_Resources; //Field offset: 0x38
	[Token(Token = "0x400025D")]
	private static Mesh s_FullscreenTriangle; //Field offset: 0x40
	[Token(Token = "0x400025E")]
	private static Material s_CopyStdMaterial; //Field offset: 0x48
	[Token(Token = "0x400025F")]
	private static Material s_CopyStdFromDoubleWideMaterial; //Field offset: 0x50
	[Token(Token = "0x4000260")]
	private static Material s_CopyMaterial; //Field offset: 0x58
	[Token(Token = "0x4000261")]
	private static Material s_CopyFromTexArrayMaterial; //Field offset: 0x60
	[Token(Token = "0x4000262")]
	private static PropertySheet s_CopySheet; //Field offset: 0x68
	[Token(Token = "0x4000263")]
	private static PropertySheet s_CopyFromTexArraySheet; //Field offset: 0x70
	[Token(Token = "0x4000264")]
	private static IEnumerable<Type> m_AssemblyTypes; //Field offset: 0x78

	[Token(Token = "0x17000037")]
	public static Texture2D blackTexture
	{
		[Address(RVA = "0x18520F0", Offset = "0x18512F0", Length = "0x1BC")]
		[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000201")]
		 get { } //Length: 444
	}

	[Token(Token = "0x17000038")]
	public static Texture3D blackTexture3D
	{
		[Address(RVA = "0x1851F00", Offset = "0x1851100", Length = "0x1E3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000202")]
		 get { } //Length: 483
	}

	[Token(Token = "0x1700003F")]
	public static Material copyFromTexArrayMaterial
	{
		[Address(RVA = "0x18522B0", Offset = "0x18514B0", Length = "0x1A2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020A")]
		 get { } //Length: 418
	}

	[Token(Token = "0x17000041")]
	public static PropertySheet copyFromTexArraySheet
	{
		[Address(RVA = "0x1852460", Offset = "0x1851660", Length = "0x27D")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020C")]
		 get { } //Length: 637
	}

	[Token(Token = "0x1700003E")]
	public static Material copyMaterial
	{
		[Address(RVA = "0x18526E0", Offset = "0x18518E0", Length = "0x1A2")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet", ReturnType = typeof(PropertySheet))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000209")]
		 get { } //Length: 418
	}

	[Token(Token = "0x17000040")]
	public static PropertySheet copySheet
	{
		[Address(RVA = "0x1852890", Offset = "0x1851A90", Length = "0x107")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600020B")]
		 get { } //Length: 263
	}

	[Token(Token = "0x1700003D")]
	public static Material copyStdFromDoubleWideMaterial
	{
		[Address(RVA = "0x18529A0", Offset = "0x1851BA0", Length = "0x1A2")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000208")]
		 get { } //Length: 418
	}

	[Token(Token = "0x1700003C")]
	public static Material copyStdMaterial
	{
		[Address(RVA = "0x1852B50", Offset = "0x1851D50", Length = "0x1A2")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000207")]
		 get { } //Length: 418
	}

	[Token(Token = "0x1700004A")]
	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000226")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700003B")]
	public static Mesh fullscreenTriangle
	{
		[Address(RVA = "0x1852D00", Offset = "0x1851F00", Length = "0x423")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000206")]
		 get { } //Length: 1059
	}

	[Token(Token = "0x17000047")]
	public static bool isAndroidOpenGL
	{
		[Address(RVA = "0x1853130", Offset = "0x1852330", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000223")]
		 get { } //Length: 90
	}

	[Token(Token = "0x1700004B")]
	public static bool isLinearColorSpace
	{
		[Address(RVA = "0x1853190", Offset = "0x1852390", Length = "0x16")]
		[CalledBy(Type = typeof(Fog), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600022A")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000048")]
	public static bool isOpenGLES
	{
		[Address(RVA = "0x18531B0", Offset = "0x18523B0", Length = "0x16")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000224")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000045")]
	public static bool isSinglePassStereoEnabled
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000221")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000046")]
	public static bool isVREnabled
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000222")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000049")]
	public static bool isWebNonWebGPU
	{
		[Address(RVA = "0x18531D0", Offset = "0x18523D0", Length = "0x5A")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000225")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000042")]
	public static bool scriptableRenderPipelineActive
	{
		[Address(RVA = "0x1853230", Offset = "0x1852430", Length = "0x74")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDeferredShading", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDepthNormals", ReturnType = typeof(bool))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600021E")]
		 get { } //Length: 116
	}

	[Token(Token = "0x17000043")]
	public static bool supportsDeferredShading
	{
		[Address(RVA = "0x18532B0", Offset = "0x18524B0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetShaderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderType)}, ReturnType = typeof(BuiltinShaderMode))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600021F")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000044")]
	public static bool supportsDepthNormals
	{
		[Address(RVA = "0x1853330", Offset = "0x1852530", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetShaderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderType)}, ReturnType = typeof(BuiltinShaderMode))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000220")]
		 get { } //Length: 126
	}

	[Token(Token = "0x17000039")]
	public static Texture2D transparentTexture
	{
		[Address(RVA = "0x1853590", Offset = "0x1852790", Length = "0x1B7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000203")]
		 get { } //Length: 439
	}

	[Token(Token = "0x1700003A")]
	public static Texture3D transparentTexture3D
	{
		[Address(RVA = "0x18533B0", Offset = "0x18525B0", Length = "0x1DE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000204")]
		 get { } //Length: 478
	}

	[Token(Token = "0x17000035")]
	public static Texture2D whiteTexture
	{
		[Address(RVA = "0x1853940", Offset = "0x1852B40", Length = "0x1B3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 435
	}

	[Token(Token = "0x17000036")]
	public static Texture3D whiteTexture3D
	{
		[Address(RVA = "0x1853750", Offset = "0x1852950", Length = "0x1E3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000200")]
		 get { } //Length: 483
	}

	[Address(RVA = "0x1851E70", Offset = "0x1851070", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600023C")]
	private static RuntimeUtilities() { }

	[Address(RVA = "0x18502A0", Offset = "0x184F4A0", Length = "0x221")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "CompositeAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "CompositeAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x600021A")]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null) { }

	[Address(RVA = "0x184FE80", Offset = "0x184F080", Length = "0x2EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000219")]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null) { }

	[Address(RVA = "0x1850170", Offset = "0x184F370", Length = "0x129")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Fog), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Extension]
	[Token(Token = "0x6000214")]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Address(RVA = "0x184FBE0", Offset = "0x184EDE0", Length = "0x29E")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000213")]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Address(RVA = "0x18504D0", Offset = "0x184F6D0", Length = "0x2B8")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PostProcessRenderContext)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000212")]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Address(RVA = "0x184F3A0", Offset = "0x184E5A0", Length = "0x1E8")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000215")]
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[Address(RVA = "0x184F590", Offset = "0x184E790", Length = "0x211")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000217")]
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Address(RVA = "0x184F7B0", Offset = "0x184E9B0", Length = "0x214")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000216")]
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[Address(RVA = "0x184F9D0", Offset = "0x184EBD0", Length = "0x204")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000218")]
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Address(RVA = "0x1850790", Offset = "0x184F990", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600021C")]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	[Address(RVA = "0x18508C0", Offset = "0x184FAC0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600021B")]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[Address(RVA = "0x18509D0", Offset = "0x184FBD0", Length = "0x168")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021D")]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[Address(RVA = "0x758320", Offset = "0x757520", Length = "0x4B")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessResources)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000232")]
	public static void CreateIfNull(ref T obj) { }

	[Address(RVA = "0x1850E60", Offset = "0x1850060", Length = "0x75")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000229")]
	public static void Destroy(object obj) { }

	[Address(RVA = "0x1850B40", Offset = "0x184FD40", Length = "0x232")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600022C")]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	[Address(RVA = "0x1850D80", Offset = "0x184FF80", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef", ReturnType = typeof(PostProcessProfile))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "DestroyProfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessProfile), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600022D")]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false) { }

	[Address(RVA = "0x1850EE0", Offset = "0x18500E0", Length = "0xD")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderExternalPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
	[Token(Token = "0x6000233")]
	public static float Exp2(float x) { }

	[Address(RVA = "0x1850EF0", Offset = "0x18500F0", Length = "0x1A0")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_decomposeProjection", ReturnType = typeof(FrustumPlanes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Matrix4x4), Member = "Frustum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FrustumPlanes)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000236")]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	[Address(RVA = "0x18520F0", Offset = "0x18512F0", Length = "0x1BC")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000201")]
	public static Texture2D get_blackTexture() { }

	[Address(RVA = "0x1851F00", Offset = "0x1851100", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000202")]
	public static Texture3D get_blackTexture3D() { }

	[Address(RVA = "0x18522B0", Offset = "0x18514B0", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020A")]
	public static Material get_copyFromTexArrayMaterial() { }

	[Address(RVA = "0x1852460", Offset = "0x1851660", Length = "0x27D")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertySheet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020C")]
	public static PropertySheet get_copyFromTexArraySheet() { }

	[Address(RVA = "0x18526E0", Offset = "0x18518E0", Length = "0x1A2")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet", ReturnType = typeof(PropertySheet))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000209")]
	public static Material get_copyMaterial() { }

	[Address(RVA = "0x1852890", Offset = "0x1851A90", Length = "0x107")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertySheet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600020B")]
	public static PropertySheet get_copySheet() { }

	[Address(RVA = "0x18529A0", Offset = "0x1851BA0", Length = "0x1A2")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000208")]
	public static Material get_copyStdFromDoubleWideMaterial() { }

	[Address(RVA = "0x1852B50", Offset = "0x1851D50", Length = "0x1A2")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000207")]
	public static Material get_copyStdMaterial() { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000226")]
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	[Address(RVA = "0x1852D00", Offset = "0x1851F00", Length = "0x423")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000206")]
	public static Mesh get_fullscreenTriangle() { }

	[Address(RVA = "0x1853130", Offset = "0x1852330", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000223")]
	public static bool get_isAndroidOpenGL() { }

	[Address(RVA = "0x1853190", Offset = "0x1852390", Length = "0x16")]
	[CalledBy(Type = typeof(Fog), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600022A")]
	public static bool get_isLinearColorSpace() { }

	[Address(RVA = "0x18531B0", Offset = "0x18523B0", Length = "0x16")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000224")]
	public static bool get_isOpenGLES() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000221")]
	public static bool get_isSinglePassStereoEnabled() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000222")]
	public static bool get_isVREnabled() { }

	[Address(RVA = "0x18531D0", Offset = "0x18523D0", Length = "0x5A")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000225")]
	public static bool get_isWebNonWebGPU() { }

	[Address(RVA = "0x1853230", Offset = "0x1852430", Length = "0x74")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDepthNormals", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDeferredShading", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Token(Token = "0x600021E")]
	public static bool get_scriptableRenderPipelineActive() { }

	[Address(RVA = "0x18532B0", Offset = "0x18524B0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetShaderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderType)}, ReturnType = typeof(BuiltinShaderMode))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021F")]
	public static bool get_supportsDeferredShading() { }

	[Address(RVA = "0x1853330", Offset = "0x1852530", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetShaderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderType)}, ReturnType = typeof(BuiltinShaderMode))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000220")]
	public static bool get_supportsDepthNormals() { }

	[Address(RVA = "0x1853590", Offset = "0x1852790", Length = "0x1B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000203")]
	public static Texture2D get_transparentTexture() { }

	[Address(RVA = "0x18533B0", Offset = "0x18525B0", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000204")]
	public static Texture3D get_transparentTexture3D() { }

	[Address(RVA = "0x1853940", Offset = "0x1852B40", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FF")]
	public static Texture2D get_whiteTexture() { }

	[Address(RVA = "0x1853750", Offset = "0x1852950", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Texture3D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000200")]
	public static Texture3D get_whiteTexture3D() { }

	[Address(RVA = "0x18510A0", Offset = "0x18502A0", Length = "0x1E0")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "GetAllTypesDerivedFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "SelectMany", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Collections.Generic.IEnumerable`1<System.Object>>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000237")]
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[Address(RVA = "0x758370", Offset = "0x757570", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetAllSceneObjects>d__88`1))]
	[Token(Token = "0x6000231")]
	public static IEnumerable<T> GetAllSceneObjects() { }

	[Address(RVA = "0x7583D0", Offset = "0x7575D0", Length = "0x1AF")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000238")]
	public static IEnumerable<Type> GetAllTypesDerivedFrom() { }

	[Address(RVA = "0x758580", Offset = "0x757780", Length = "0xD7")]
	[CalledBy(Type = typeof(PostProcessBundle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEffectSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000239")]
	public static T GetAttribute(Type type) { }

	[Address(RVA = "0x758660", Offset = "0x757860", Length = "0x32E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023B")]
	public static string GetFieldPath(Expression<Func`2<TType, TValue>> expr) { }

	[Address(RVA = "0x1851290", Offset = "0x1850490", Length = "0x16B")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_aspect", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000235")]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	[Address(RVA = "0x1851400", Offset = "0x1850600", Length = "0x19D")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
	[Calls(Type = typeof(Camera), Member = "get_aspect", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000234")]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	[Address(RVA = "0x18515A0", Offset = "0x18507A0", Length = "0x352")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000205")]
	public static Texture2D GetLutStrip(int size) { }

	[Address(RVA = "0x758990", Offset = "0x757B90", Length = "0x1FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023A")]
	public static Attribute[] GetMemberAttributes(Expression<Func`2<TType, TValue>> expr) { }

	[Address(RVA = "0x1853B00", Offset = "0x1852D00", Length = "0x53")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "HasAlphaChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000228")]
	internal static bool hasAlpha(RenderTextureFormat format) { }

	[Address(RVA = "0x1851900", Offset = "0x1850B00", Length = "0xA6")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000230")]
	public static bool IsDynamicResolutionEnabled(Camera camera) { }

	[Address(RVA = "0x1853B60", Offset = "0x1852D60", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000227")]
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	[Address(RVA = "0x18519B0", Offset = "0x1850BB0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600022E")]
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	[Address(RVA = "0x1851A20", Offset = "0x1850C20", Length = "0x69")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath", ReturnType = typeof(RenderingPath))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600022B")]
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	[Address(RVA = "0x1851A90", Offset = "0x1850C90", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600022F")]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[Address(RVA = "0x1853B80", Offset = "0x1852D80", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600020D")]
	internal static bool isValidResources() { }

	[Address(RVA = "0x1851C40", Offset = "0x1850E40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600020F")]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Address(RVA = "0x1851BB0", Offset = "0x1850DB0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000211")]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x1851B50", Offset = "0x1850D50", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000210")]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x1851C90", Offset = "0x1850E90", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600020E")]
	internal static void UpdateResources(PostProcessResources resources) { }

}

