namespace UnityEngine.Rendering;

[Token(Token = "0x2000300")]
public struct StencilState : IEquatable<StencilState>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094F")]
	private byte m_Enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000950")]
	private byte m_ReadMask; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000951")]
	private byte m_WriteMask; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000952")]
	private byte m_Padding; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000953")]
	private byte m_CompareFunctionFront; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000954")]
	private byte m_PassOperationFront; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000955")]
	private byte m_FailOperationFront; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000956")]
	private byte m_ZFailOperationFront; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000957")]
	private byte m_CompareFunctionBack; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000958")]
	private byte m_PassOperationBack; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000959")]
	private byte m_FailOperationBack; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x400095A")]
	private byte m_ZFailOperationBack; //Field offset: 0xB

	[Token(Token = "0x17000252")]
	public CompareFunction compareFunctionBack
	{
		[Address(RVA = "0x198FAD0", Offset = "0x198ECD0", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E96")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024E")]
	public CompareFunction compareFunctionFront
	{
		[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E92")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024B")]
	public bool enabled
	{
		[Address(RVA = "0x198FAE0", Offset = "0x198ECE0", Length = "0x58")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E8F")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000254")]
	public StencilOp failOperationBack
	{
		[Address(RVA = "0x198FB40", Offset = "0x198ED40", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E98")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000250")]
	public StencilOp failOperationFront
	{
		[Address(RVA = "0x198FB50", Offset = "0x198ED50", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E94")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000253")]
	public StencilOp passOperationBack
	{
		[Address(RVA = "0x198FB60", Offset = "0x198ED60", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E97")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024F")]
	public StencilOp passOperationFront
	{
		[Address(RVA = "0x198FB70", Offset = "0x198ED70", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E93")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024C")]
	public byte readMask
	{
		[Address(RVA = "0x198FB80", Offset = "0x198ED80", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E90")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024D")]
	public byte writeMask
	{
		[Address(RVA = "0x198FB90", Offset = "0x198ED90", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E91")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000255")]
	public StencilOp zFailOperationBack
	{
		[Address(RVA = "0x198FBA0", Offset = "0x198EDA0", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E99")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000251")]
	public StencilOp zFailOperationFront
	{
		[Address(RVA = "0x198FBB0", Offset = "0x198EDB0", Length = "0x4")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000E95")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x198F810", Offset = "0x198EA10", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E9A")]
	public override bool Equals(StencilState other) { }

	[Address(RVA = "0x198F880", Offset = "0x198EA80", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E9B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x198F9D0", Offset = "0x198EBD0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x6000E9C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x198FAD0", Offset = "0x198ECD0", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E96")]
	public void set_compareFunctionBack(CompareFunction value) { }

	[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E92")]
	public void set_compareFunctionFront(CompareFunction value) { }

	[Address(RVA = "0x198FAE0", Offset = "0x198ECE0", Length = "0x58")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E8F")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x198FB40", Offset = "0x198ED40", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E98")]
	public void set_failOperationBack(StencilOp value) { }

	[Address(RVA = "0x198FB50", Offset = "0x198ED50", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E94")]
	public void set_failOperationFront(StencilOp value) { }

	[Address(RVA = "0x198FB60", Offset = "0x198ED60", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E97")]
	public void set_passOperationBack(StencilOp value) { }

	[Address(RVA = "0x198FB70", Offset = "0x198ED70", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E93")]
	public void set_passOperationFront(StencilOp value) { }

	[Address(RVA = "0x198FB80", Offset = "0x198ED80", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E90")]
	public void set_readMask(byte value) { }

	[Address(RVA = "0x198FB90", Offset = "0x198ED90", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E91")]
	public void set_writeMask(byte value) { }

	[Address(RVA = "0x198FBA0", Offset = "0x198EDA0", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E99")]
	public void set_zFailOperationBack(StencilOp value) { }

	[Address(RVA = "0x198FBB0", Offset = "0x198EDB0", Length = "0x4")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E95")]
	public void set_zFailOperationFront(StencilOp value) { }

}

