namespace UnityEngine.UIElements;

[Token(Token = "0x2000466")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleValueHandle : IEquatable<StyleValueHandle>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000E90")]
	private StyleValueType m_ValueType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000E91")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int valueIndex; //Field offset: 0x4

	[Token(Token = "0x170008CC")]
	public internal StyleValueType valueType
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x60020F9")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60020FA")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 3
	}

	[Address(RVA = "0x19412E0", Offset = "0x19404E0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60020FC")]
	public override bool Equals(StyleValueHandle other) { }

	[Address(RVA = "0x1B2D650", Offset = "0x1B2C850", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020FD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020F9")]
	public StyleValueType get_valueType() { }

	[Address(RVA = "0x1B2D6E0", Offset = "0x1B2C8E0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[Token(Token = "0x60020FE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B2D750", Offset = "0x1B2C950", Length = "0x12")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020FB")]
	public bool IsVarFunction() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020FA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_valueType(StyleValueType value) { }

}

