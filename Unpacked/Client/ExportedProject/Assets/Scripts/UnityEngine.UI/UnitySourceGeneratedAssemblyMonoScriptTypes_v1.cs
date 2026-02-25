//Type is in global namespace

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[Token(Token = "0x2000002")]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000001")]
		public Byte[] FilePathsData; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000002")]
		public Byte[] TypesData; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000003")]
		public int TotalTypes; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000004")]
		public int TotalFiles; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000005")]
		public bool IsEditorOnly; //Field offset: 0x18

	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1() { }

	[Address(RVA = "0x1A91CB0", Offset = "0x1A90EB0", Length = "0x74E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	private static MonoScriptData Get() { }

}

