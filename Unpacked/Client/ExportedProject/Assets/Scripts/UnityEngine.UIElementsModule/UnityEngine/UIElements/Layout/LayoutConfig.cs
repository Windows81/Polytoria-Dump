namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[Token(Token = "0x20005B7")]
internal struct LayoutConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014C0")]
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014C1")]
	private readonly LayoutHandle m_Handle; //Field offset: 0x28

	[Token(Token = "0x17000A32")]
	public LayoutBaselineFunction Baseline
	{
		[Address(RVA = "0x1BA8710", Offset = "0x1BA7910", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028C2")]
		 get { } //Length: 111
	}

	[Token(Token = "0x17000A2F")]
	public LayoutHandle Handle
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028BE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A31")]
	public LayoutMeasureFunction Measure
	{
		[Address(RVA = "0x1BA8780", Offset = "0x1BA7980", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028C0")]
		 get { } //Length: 111
		[Address(RVA = "0x1BA8830", Offset = "0x1BA7A30", Length = "0xF")]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3670")]
		[Token(Token = "0x60028C1")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000A30")]
	public float PointScaleFactor
	{
		[Address(RVA = "0x1BA87F0", Offset = "0x1BA79F0", Length = "0xC")]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3410")]
		[Token(Token = "0x60028BF")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000A2E")]
	public static LayoutConfig Undefined
	{
		[Address(RVA = "0x1BA8800", Offset = "0x1BA7A00", Length = "0x2C")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028BC")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1BA86F0", Offset = "0x1BA78F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028BD")]
	internal LayoutConfig(LayoutDataAccess access, LayoutHandle handle) { }

	[Address(RVA = "0x1BA8710", Offset = "0x1BA7910", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C2")]
	public LayoutBaselineFunction get_Baseline() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028BE")]
	public LayoutHandle get_Handle() { }

	[Address(RVA = "0x1BA8780", Offset = "0x1BA7980", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C0")]
	public LayoutMeasureFunction get_Measure() { }

	[Address(RVA = "0x1BA87F0", Offset = "0x1BA79F0", Length = "0xC")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3410")]
	[Token(Token = "0x60028BF")]
	public float get_PointScaleFactor() { }

	[Address(RVA = "0x1BA8800", Offset = "0x1BA7A00", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028BC")]
	public static LayoutConfig get_Undefined() { }

	[Address(RVA = "0x1BA8830", Offset = "0x1BA7A30", Length = "0xF")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3670")]
	[Token(Token = "0x60028C1")]
	public void set_Measure(LayoutMeasureFunction value) { }

}

