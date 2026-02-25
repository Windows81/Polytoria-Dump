namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000573")]
internal class LinkedPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D4")]
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D5")]
	private readonly Action<T> m_ResetAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D6")]
	private readonly int m_Limit; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D7")]
	private T m_PoolFirst; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D8")]
	private int <Count>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170009E5")]
	public private int Count
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002700")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002701")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xCF3CC0", Offset = "0xCF2EC0", Length = "0xAC")]
	[CalledBy(Type = typeof(BasicNodePool`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Row), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageRenderInfoPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientRemapPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FF")]
	public LinkedPool`1(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }

	[Address(RVA = "0xCF3BD0", Offset = "0xCF2DD0", Length = "0xA")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002702")]
	public void Clear() { }

	[Address(RVA = "0xCF3BE0", Offset = "0xCF2DE0", Length = "0x7A")]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "SplitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BestFitAllocator+Block", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "TryGetAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture2D), typeof(TextureId&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(ExtraRenderData))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(VectorImageRenderInfo))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002703")]
	public T Get() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002700")]
	public int get_Count() { }

	[Address(RVA = "0xCF3C60", Offset = "0xCF2E60", Length = "0x51")]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "ReturnAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture2D), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "CoalesceBlockWithPrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BestFitAllocator+Block"}, ReturnType = "UnityEngine.UIElements.UIR.BestFitAllocator+Block")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "FreeExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002704")]
	public void Return(T item) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002701")]
	private void set_Count(int value) { }

}

