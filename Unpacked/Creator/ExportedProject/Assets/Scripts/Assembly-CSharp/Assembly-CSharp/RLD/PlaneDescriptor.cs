namespace RLD;

[Token(Token = "0x2000185")]
public struct PlaneDescriptor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000687")]
	private PlaneId _id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000688")]
	private PlaneQuadrantId _quadrant; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000689")]
	private AxisDescriptor _firstAxisDescriptor; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400068A")]
	private AxisDescriptor _secondAxisDescriptor; //Field offset: 0x10

	[Token(Token = "0x1700058F")]
	public AxisDescriptor FirstAxisDescriptor
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600112E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700058D")]
	public int FirstAxisIndex
	{
		[Address(RVA = "0x563610", Offset = "0x562810", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600112C")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700058B")]
	public AxisSign FirstAxisSign
	{
		[Address(RVA = "0x563630", Offset = "0x562830", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600112A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000589")]
	public PlaneId Id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001128")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700058A")]
	public PlaneQuadrantId Quadrant
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001129")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000590")]
	public AxisDescriptor SecondAxisDescriptor
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600112F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700058E")]
	public int SecondAxisIndex
	{
		[Address(RVA = "0x563650", Offset = "0x562850", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600112D")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700058C")]
	public AxisSign SecondAxisSign
	{
		[Address(RVA = "0x563670", Offset = "0x562870", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600112B")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x563220", Offset = "0x562420", Length = "0x3E5")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "GetPlane3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(Plane))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001130")]
	public PlaneDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600112E")]
	public AxisDescriptor get_FirstAxisDescriptor() { }

	[Address(RVA = "0x563610", Offset = "0x562810", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600112C")]
	public int get_FirstAxisIndex() { }

	[Address(RVA = "0x563630", Offset = "0x562830", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600112A")]
	public AxisSign get_FirstAxisSign() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001128")]
	public PlaneId get_Id() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001129")]
	public PlaneQuadrantId get_Quadrant() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600112F")]
	public AxisDescriptor get_SecondAxisDescriptor() { }

	[Address(RVA = "0x563650", Offset = "0x562850", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600112D")]
	public int get_SecondAxisIndex() { }

	[Address(RVA = "0x563670", Offset = "0x562870", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600112B")]
	public AxisSign get_SecondAxisSign() { }

}

