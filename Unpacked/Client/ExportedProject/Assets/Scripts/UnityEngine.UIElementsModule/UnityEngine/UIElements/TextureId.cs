namespace UnityEngine.UIElements;

[Token(Token = "0x20002D4")]
internal struct TextureId
{
	[Token(Token = "0x4000B78")]
	public static readonly TextureId invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B77")]
	private readonly int m_Index; //Field offset: 0x0

	[Token(Token = "0x170003CE")]
	public int index
	{
		[Address(RVA = "0x1C8E250", Offset = "0x1C8D450", Length = "0x5")]
		[CalledBy(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60013B8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1C8E200", Offset = "0x1C8D400", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60013BF")]
	private static TextureId() { }

	[Address(RVA = "0x1C8E240", Offset = "0x1C8D440", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013B7")]
	public TextureId(int index) { }

	[Address(RVA = "0x1C8E100", Offset = "0x1C8D300", Length = "0x4B")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60013BA")]
	public float ConvertToGpu() { }

	[Address(RVA = "0x1C8E150", Offset = "0x1C8D350", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1C8E250", Offset = "0x1C8D450", Length = "0x5")]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60013B8")]
	public int get_index() { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013BC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1C8E1F0", Offset = "0x1C8D3F0", Length = "0x9")]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "AssignTextureIds_DepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B9")]
	public bool IsValid() { }

	[Address(RVA = "0x196BCA0", Offset = "0x196AEA0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60013BD")]
	public static bool op_Equality(TextureId left, TextureId right) { }

	[Address(RVA = "0x1C8E260", Offset = "0x1C8D460", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BE")]
	public static bool op_Inequality(TextureId left, TextureId right) { }

}

