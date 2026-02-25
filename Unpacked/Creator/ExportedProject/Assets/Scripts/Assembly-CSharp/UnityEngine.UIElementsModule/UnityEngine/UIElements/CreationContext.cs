namespace UnityEngine.UIElements;

[Token(Token = "0x20004FC")]
public struct CreationContext : IEquatable<CreationContext>
{
	[Token(Token = "0x20004FD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct AttributeOverrideRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001078")]
		internal readonly VisualTreeAsset sourceAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001079")]
		internal readonly List<AttributeOverride> attributeOverrides; //Field offset: 0x8

		[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
		[CallerCount(Count = 48)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DC")]
		public AttributeOverrideRange(VisualTreeAsset sourceAsset, List<AttributeOverride> attributeOverrides) { }

	}

	[Token(Token = "0x20004FE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct SerializedDataOverrideRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400107A")]
		internal readonly VisualTreeAsset sourceAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400107B")]
		internal readonly int templateId; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400107C")]
		internal readonly List<UxmlSerializedDataOverride> attributeOverrides; //Field offset: 0x10

		[Address(RVA = "0x1B66F80", Offset = "0x1B66180", Length = "0x43")]
		[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60024DD")]
		public SerializedDataOverrideRange(VisualTreeAsset sourceAsset, List<UxmlSerializedDataOverride> attributeOverrides, int templateId) { }

	}

	[Token(Token = "0x4001070")]
	public static readonly CreationContext Default; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001071")]
	private VisualElement <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001072")]
	private List<Int32> <veaIdsPath>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001073")]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001074")]
	private Dictionary<String, VisualElement> <slotInsertionPoints>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001075")]
	private List<AttributeOverrideRange> <attributeOverrides>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001076")]
	private List<SerializedDataOverrideRange> <serializedDataOverrides>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001077")]
	private List<String> <namesPath>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170009A3")]
	internal List<AttributeOverrideRange> attributeOverrides
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024CC")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024CD")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009A6")]
	internal bool hasOverrides
	{
		[Address(RVA = "0x1B62D80", Offset = "0x1B61F80", Length = "0x98")]
		[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60024D2")]
		internal get { } //Length: 152
	}

	[Token(Token = "0x170009A5")]
	internal List<String> namesPath
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024D0")]
		internal get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009A4")]
	internal List<SerializedDataOverrideRange> serializedDataOverrides
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024CE")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024CF")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009A2")]
	public private Dictionary<String, VisualElement> slotInsertionPoints
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024CA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024CB")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700099F")]
	public private VisualElement target
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024C4")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C5")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170009A0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<Int32> veaIdsPath
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024C6")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009A1")]
	public private VisualTreeAsset visualTreeAsset
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60024C8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C9")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1B62A00", Offset = "0x1B61C00", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60024DB")]
	private static CreationContext() { }

	[Address(RVA = "0x1B62CA0", Offset = "0x1B61EA0", Length = "0xDB")]
	[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60024D7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, List<SerializedDataOverrideRange> serializedDataOverrides, VisualTreeAsset vta, VisualElement target, List<Int32> veaIdsPath, List<String> namesPath) { }

	[Address(RVA = "0x1B62B70", Offset = "0x1B61D70", Length = "0x9A")]
	[CalledBy(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(VisualTreeAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024D6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	[Address(RVA = "0x1B62C10", Offset = "0x1B61E10", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024D5")]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	[Address(RVA = "0x1B62A50", Offset = "0x1B61C50", Length = "0x76")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024D4")]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides) { }

	[Address(RVA = "0x1B62AD0", Offset = "0x1B61CD0", Length = "0x99")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectAsset)}, ReturnType = typeof(IBaseUxmlObjectFactory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024D3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(VisualTreeAsset vta) { }

	[Address(RVA = "0x1B626B0", Offset = "0x1B618B0", Length = "0x15F")]
	[CalledBy(Type = typeof(CreationContext), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024D9")]
	public override bool Equals(CreationContext other) { }

	[Address(RVA = "0x1B62810", Offset = "0x1B61A10", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CreationContext), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60024D8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024CC")]
	internal List<AttributeOverrideRange> get_attributeOverrides() { }

	[Address(RVA = "0x1B62D80", Offset = "0x1B61F80", Length = "0x98")]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024D2")]
	internal bool get_hasOverrides() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024D0")]
	internal List<String> get_namesPath() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024CE")]
	internal List<SerializedDataOverrideRange> get_serializedDataOverrides() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024CA")]
	public Dictionary<String, VisualElement> get_slotInsertionPoints() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024C4")]
	public VisualElement get_target() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024C6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<Int32> get_veaIdsPath() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60024C8")]
	public VisualTreeAsset get_visualTreeAsset() { }

	[Address(RVA = "0x1B628E0", Offset = "0x1B61AE0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60024DA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CD")]
	private void set_attributeOverrides(List<AttributeOverrideRange> value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D1")]
	private void set_namesPath(List<String> value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CF")]
	private void set_serializedDataOverrides(List<SerializedDataOverrideRange> value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CB")]
	private void set_slotInsertionPoints(Dictionary<String, VisualElement> value) { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C5")]
	private void set_target(VisualElement value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C7")]
	private void set_veaIdsPath(List<Int32> value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C9")]
	private void set_visualTreeAsset(VisualTreeAsset value) { }

}

