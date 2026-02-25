namespace UnityEngine.UIElements.UIR;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
[Token(Token = "0x200053B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal class Utility
{
	[Token(Token = "0x200053D")]
	internal class GPUBuffer : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400115B")]
		private IntPtr buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400115C")]
		private int elemCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400115D")]
		private int elemStride; //Field offset: 0x0

		[Token(Token = "0x170009C6")]
		internal IntPtr BufferPointer
		{
			[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
			[CallerCount(Count = 196)]
			[DeduplicatedMethod]
			[Token(Token = "0x60025F2")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x170009C5")]
		public int ElementStride
		{
			[Address(RVA = "0xC4A020", Offset = "0xC49220", Length = "0x6")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60025F1")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xC49F80", Offset = "0xC49180", Length = "0x85")]
		[CalledBy(Type = typeof(DataSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Utility), Member = "AllocateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60025EE")]
		public GPUBuffer`1(int elementCount, GPUBufferType type) { }

		[Address(RVA = "0xC49B50", Offset = "0xC48D50", Length = "0x4D")]
		[CalledBy(Type = typeof(DataSet`1), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Utility), Member = "FreeBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60025EF")]
		public override void Dispose() { }

		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025F2")]
		internal IntPtr get_BufferPointer() { }

		[Address(RVA = "0xC4A020", Offset = "0xC49220", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025F1")]
		public int get_ElementStride() { }

		[Address(RVA = "0xC49D60", Offset = "0xC48F60", Length = "0xD9")]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendFullRange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendPartialRanges", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Utility), Member = "UpdateBufferRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025F0")]
		public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	}

	[Token(Token = "0x200053C")]
	public enum GPUBufferType
	{
		Vertex = 0,
		Index = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001154")]
	private static Action<Boolean> GraphicsResourcesRecreate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001155")]
	private static Action EngineUpdate; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001156")]
	private static Action FlushPendingResources; //Field offset: 0x10
	[Token(Token = "0x4001157")]
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; //Field offset: 0x18

	[Token(Token = "0x14000032")]
	public static event Action EngineUpdate
	{
		[Address(RVA = "0x1B70720", Offset = "0x1B6F920", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CC")]
		 add { } //Length: 242
		[Address(RVA = "0x1B70A30", Offset = "0x1B6FC30", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CD")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x14000033")]
	public static event Action FlushPendingResources
	{
		[Address(RVA = "0x1B70820", Offset = "0x1B6FA20", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CE")]
		 add { } //Length: 242
		[Address(RVA = "0x1B70B30", Offset = "0x1B6FD30", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CF")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x14000031")]
	public static event Action<Boolean> GraphicsResourcesRecreate
	{
		[Address(RVA = "0x1B70920", Offset = "0x1B6FB20", Length = "0x101")]
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CA")]
		 add { } //Length: 257
		[Address(RVA = "0x1B70C30", Offset = "0x1B6FE30", Length = "0x101")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025CB")]
		 remove { } //Length: 257
	}

	[Address(RVA = "0x1B706C0", Offset = "0x1B6F8C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60025E7")]
	private static Utility() { }

	[Address(RVA = "0x1B70720", Offset = "0x1B6F920", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CC")]
	public static void add_EngineUpdate(Action value) { }

	[Address(RVA = "0x1B70820", Offset = "0x1B6FA20", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CE")]
	public static void add_FlushPendingResources(Action value) { }

	[Address(RVA = "0x1B70920", Offset = "0x1B6FB20", Length = "0x101")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CA")]
	public static void add_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[Address(RVA = "0x1B6FD20", Offset = "0x1B6EF20", Length = "0x50")]
	[CalledBy(Type = typeof(GPUBuffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GPUBufferType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D3")]
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[Address(RVA = "0x1B6FD70", Offset = "0x1B6EF70", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DF")]
	public static bool CPUFencePassed(uint fence) { }

	[Address(RVA = "0x1B6FDF0", Offset = "0x1B6EFF0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DB")]
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	[Address(RVA = "0x1B6FDB0", Offset = "0x1B6EFB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025EB")]
	private static IntPtr CreateStencilState_Injected(in StencilState stencilState) { }

	[Address(RVA = "0x1B6FE60", Offset = "0x1B6F060", Length = "0x2A")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DA")]
	public static void DisableScissor() { }

	[Address(RVA = "0x1B6FE90", Offset = "0x1B6F090", Length = "0x62")]
	[CalledBy(Type = typeof(CommandList), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D7")]
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[Address(RVA = "0x1B6FF00", Offset = "0x1B6F100", Length = "0x33")]
	[CalledBy(Type = typeof(GPUBuffer`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D4")]
	private static void FreeBuffer(IntPtr buffer) { }

	[Address(RVA = "0x1B6FF80", Offset = "0x1B6F180", Length = "0x6D")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "RectPointsToPixelsAndFlipYAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float)}, ReturnType = typeof(RectInt))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E2")]
	public static RectInt GetActiveViewport() { }

	[Address(RVA = "0x1B6FF40", Offset = "0x1B6F140", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025EC")]
	private static void GetActiveViewport_Injected(out RectInt ret) { }

	[Address(RVA = "0x1B70030", Offset = "0x1B6F230", Length = "0x79")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E6")]
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	[Address(RVA = "0x1B6FFF0", Offset = "0x1B6F1F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025ED")]
	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }

	[Address(RVA = "0x1B700F0", Offset = "0x1B6F2F0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D6")]
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	[Address(RVA = "0x1B700B0", Offset = "0x1B6F2B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025E8")]
	private static IntPtr GetVertexDeclaration_Injected(ref ManagedSpanWrapper vertexAttributes) { }

	[Address(RVA = "0x1B701D0", Offset = "0x1B6F3D0", Length = "0x2A")]
	[CalledBy(Type = typeof(DataSet`1), Member = "HasMappedBufferRange", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DD")]
	public static bool HasMappedBufferRange() { }

	[Address(RVA = "0x1B70200", Offset = "0x1B6F400", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DE")]
	public static uint InsertCPUFence() { }

	[Address(RVA = "0x1B70230", Offset = "0x1B6F430", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025E5")]
	public static void NotifyOfUIREvents(bool subscribe) { }

	[Address(RVA = "0x1B70270", Offset = "0x1B6F470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E3")]
	public static void ProfileDrawChainBegin() { }

	[Address(RVA = "0x1B702A0", Offset = "0x1B6F4A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E4")]
	public static void ProfileDrawChainEnd() { }

	[Address(RVA = "0x1B702D0", Offset = "0x1B6F4D0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60025D1")]
	internal static void RaiseEngineUpdate() { }

	[Address(RVA = "0x1B70360", Offset = "0x1B6F560", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60025D2")]
	internal static void RaiseFlushPendingResources() { }

	[Address(RVA = "0x1B703D0", Offset = "0x1B6F5D0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60025D0")]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[Address(RVA = "0x1B70A30", Offset = "0x1B6FC30", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CD")]
	public static void remove_EngineUpdate(Action value) { }

	[Address(RVA = "0x1B70B30", Offset = "0x1B6FD30", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CF")]
	public static void remove_FlushPendingResources(Action value) { }

	[Address(RVA = "0x1B70C30", Offset = "0x1B6FE30", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025CB")]
	public static void remove_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[Address(RVA = "0x1B70480", Offset = "0x1B6F680", Length = "0x6F")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.UIElements.UIR.TextureBlitter+BlitInfo>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D8")]
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[Address(RVA = "0x1B70440", Offset = "0x1B6F640", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025E9")]
	private static void SetPropertyBlock_Injected(IntPtr props) { }

	[Address(RVA = "0x1B70530", Offset = "0x1B6F730", Length = "0x64")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D9")]
	public static void SetScissorRect(RectInt scissorRect) { }

	[Address(RVA = "0x1B704F0", Offset = "0x1B6F6F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025EA")]
	private static void SetScissorRect_Injected(in RectInt scissorRect) { }

	[Address(RVA = "0x1B705A0", Offset = "0x1B6F7A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025DC")]
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[Address(RVA = "0x1B705E0", Offset = "0x1B6F7E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E1")]
	public static void SyncRenderThread() { }

	[Address(RVA = "0x1B70610", Offset = "0x1B6F810", Length = "0x62")]
	[CalledBy(Type = typeof(GPUBuffer`1), Member = "UpdateRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025D5")]
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[Address(RVA = "0x1B70680", Offset = "0x1B6F880", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60025E0")]
	public static void WaitForCPUFencePassed(uint fence) { }

}

