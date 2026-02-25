namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000591")]
internal class RenderTreeCompositor : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000594")]
	private sealed class <>c
	{
		[Token(Token = "0x40013DC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40013DD")]
		public static Func<DrawOperation> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x1BA22B0", Offset = "0x1BA14B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60027C9")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027CA")]
		public <>c() { }

		[Address(RVA = "0x1BA2110", Offset = "0x1BA1310", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60027CB")]
		internal DrawOperation <.ctor>b__7_0() { }

	}

	[Token(Token = "0x2000593")]
	private class DrawOperation
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013CD")]
		private DrawOperationType m_Type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40013CE")]
		private VisualElement m_VisualElement; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013CF")]
		private RenderTree m_RenderTree; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40013D0")]
		private PostProcessingPass m_Effect; //Field offset: 0x28
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40013D1")]
		private FilterFunction m_Filter; //Field offset: 0x78
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x40013D2")]
		public RectInt bounds; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x40013D3")]
		public RectInt drawSourceBounds; //Field offset: 0xF8
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40013D4")]
		public Vector4 drawSourceTexOffsets; //Field offset: 0x108
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x40013D5")]
		public RenderTexture dstTexture; //Field offset: 0x118
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x40013D6")]
		public TextureId dstTextureId; //Field offset: 0x120
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x40013D7")]
		public DrawOperation parent; //Field offset: 0x128
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x40013D8")]
		public DrawOperation firstChild; //Field offset: 0x130
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x40013D9")]
		public DrawOperation lastChild; //Field offset: 0x138
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x40013DA")]
		public DrawOperation prevSibling; //Field offset: 0x140
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x40013DB")]
		public DrawOperation nextSibling; //Field offset: 0x148

		[Token(Token = "0x17000A03")]
		public PostProcessingPass effect
		{
			[Address(RVA = "0x1B90150", Offset = "0x1B8F350", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60027C3")]
			 get { } //Length: 43
		}

		[Token(Token = "0x17000A04")]
		public FilterFunction filter
		{
			[Address(RVA = "0x1B90180", Offset = "0x1B8F380", Length = "0x4D")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60027C4")]
			 get { } //Length: 77
		}

		[Token(Token = "0x17000A02")]
		public RenderTree renderTree
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x60027C2")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000A00")]
		public DrawOperationType type
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x60027C0")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000A01")]
		public VisualElement visualElement
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x60027C1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C8")]
		public DrawOperation() { }

		[Address(RVA = "0x1B90150", Offset = "0x1B8F350", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60027C3")]
		public PostProcessingPass get_effect() { }

		[Address(RVA = "0x1B90180", Offset = "0x1B8F380", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60027C4")]
		public FilterFunction get_filter() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C2")]
		public RenderTree get_renderTree() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C0")]
		public DrawOperationType get_type() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C1")]
		public VisualElement get_visualElement() { }

		[Address(RVA = "0x1B8FF90", Offset = "0x1B8F190", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027C5")]
		public void Init(RenderTree renderTree) { }

		[Address(RVA = "0x1B8FF00", Offset = "0x1B8F100", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60027C6")]
		private void InitPointers() { }

		[Address(RVA = "0x1B90060", Offset = "0x1B8F260", Length = "0xE1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60027C7")]
		public void Reset() { }

	}

	[Token(Token = "0x2000592")]
	private enum DrawOperationType
	{
		Undefined = 0,
		RenderTree = 1,
		Effect = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013C3")]
	private readonly RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013C4")]
	private DrawOperation m_RootOperation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013C5")]
	private List<RenderTexture> m_AllocatedRenderTextures; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013C6")]
	private MaterialPropertyBlock m_Block; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013C7")]
	private ObjectPool<DrawOperation> m_DrawOperationPool; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013C8")]
	private bool <disposed>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170009FF")]
	protected private bool disposed
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027BC")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027BD")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B98F40", Offset = "0x1B98140", Length = "0x1E0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60027B0")]
	public RenderTreeCompositor(RenderTreeManager owner) { }

	[Address(RVA = "0x1B96CF0", Offset = "0x1B95EF0", Length = "0x247")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027B9")]
	private void ApplyEffectParameters(PostProcessingPass effect, FilterFunction filter, VisualElement source) { }

	[Address(RVA = "0x1B96F40", Offset = "0x1B96140", Length = "0x1B1")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "AssignTextureIds_DepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureRegistry), Member = "AllocAndAcquireDynamic", ReturnType = typeof(TextureId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B8F4E0")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "AssignTextureIds_DepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B6")]
	private void AssignTextureIds_DepthFirst(DrawOperation op) { }

	[Address(RVA = "0x1B97100", Offset = "0x1B96300", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B2")]
	private void BuildDrawOperationTree(RenderTree rootRenderTree) { }

	[Address(RVA = "0x1B97310", Offset = "0x1B96510", Length = "0x202")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureRegistry), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BB")]
	private void CleanupOperation_PostOrder(DrawOperation op) { }

	[Address(RVA = "0x1B97220", Offset = "0x1B96420", Length = "0xE2")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027BA")]
	private void CleanupOperationTree() { }

	[Address(RVA = "0x1B97520", Offset = "0x1B96720", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027BE")]
	public override void Dispose() { }

	[Address(RVA = "0x1B97580", Offset = "0x1B96780", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[Token(Token = "0x60027BF")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x1B975B0", Offset = "0x1B967B0", Length = "0xB47")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "RenderNestedPasses", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderNestedTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProjectionUtils), Member = "Ortho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "LoadProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "set_modelview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "TexCoord2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Vertex3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "SetPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(GL), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "ApplyEffectParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessingPass), typeof(FilterFunction), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureId), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureRegistry), Member = "UpdateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(RenderTexture))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027B8")]
	private void ExecuteDrawOperation_PostOrder(DrawOperation op) { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027BC")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B98100", Offset = "0x1B97300", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027B3")]
	private static PostProcessingMargins GetReadMargins(PostProcessingPass effect, FilterFunction func) { }

	[Address(RVA = "0x1B981B0", Offset = "0x1B973B0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027B4")]
	private static PostProcessingMargins GetWriteMargins(PostProcessingPass effect, FilterFunction func) { }

	[Address(RVA = "0x1B98260", Offset = "0x1B97460", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027B7")]
	public void RenderNestedPasses() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027BD")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1B98C70", Offset = "0x1B97E70", Length = "0x2C1")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureRegistry), Member = "AllocAndAcquireDynamic", ReturnType = typeof(TextureId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B8F4E0")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "AssignTextureIds_DepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B1")]
	public void Update(RenderTree rootRenderTree) { }

	[Address(RVA = "0x1B98270", Offset = "0x1B97470", Length = "0x9F7")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIRUtility), Member = "CastToRectInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(UIRUtility), Member = "CastToRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027B5")]
	private static void UpdateDrawBounds_PostOrder(DrawOperation op) { }

}

