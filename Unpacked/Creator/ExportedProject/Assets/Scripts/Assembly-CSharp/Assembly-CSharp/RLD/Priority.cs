namespace RLD;

[Token(Token = "0x2000152")]
public class Priority
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000620")]
	private int _priority; //Field offset: 0x10

	[Token(Token = "0x1700053E")]
	public static int Highest
	{
		[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F6D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700053D")]
	public static int Lowest
	{
		[Address(RVA = "0x5453B0", Offset = "0x5445B0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000F6C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700053C")]
	public int Value
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F6A")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F6B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F7B")]
	public Priority() { }

	[Address(RVA = "0x545260", Offset = "0x544460", Length = "0x21")]
	[CalledBy(Type = "RLD.RTGizmosEngine+<>c__DisplayClass56_0", Member = "<GetGizmoHandleHoverData>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHandleHoverData), typeof(GizmoHandleHoverData)}, ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.RTGizmosEngine+<>c__DisplayClass58_0", Member = "<SortHandleHoverDataCollection>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHandleHoverData), typeof(GizmoHandleHoverData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F74")]
	public int CompareTo(Priority other) { }

	[Address(RVA = "0x545290", Offset = "0x544490", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F73")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6D")]
	public static int get_Highest() { }

	[Address(RVA = "0x5453B0", Offset = "0x5445B0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000F6C")]
	public static int get_Lowest() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6A")]
	public int get_Value() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F72")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x545340", Offset = "0x544540", Length = "0x1B")]
	[CalledBy(Type = typeof(GizmoCap2DCollection), Member = "Make2DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2DCollection), Member = "Make2DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F71")]
	public void MakeHigherThan(Priority priority) { }

	[Address(RVA = "0x545360", Offset = "0x544560", Length = "0x8")]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000F6F")]
	public void MakeHighest() { }

	[Address(RVA = "0x545370", Offset = "0x544570", Length = "0x1B")]
	[CalledBy(Type = typeof(GizmoCap2DCollection), Member = "Make2DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2DCollection), Member = "Make2DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F70")]
	public void MakeLowerThan(Priority priority) { }

	[Address(RVA = "0x545390", Offset = "0x544590", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000F6E")]
	public void MakeLowest() { }

	[Address(RVA = "0x5453C0", Offset = "0x5445C0", Length = "0x21")]
	[CalledBy(Type = "RLD.RTGizmosEngine+<>c__DisplayClass56_0", Member = "<GetGizmoHandleHoverData>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHandleHoverData), typeof(GizmoHandleHoverData)}, ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.RTGizmosEngine+<>c__DisplayClass58_0", Member = "<SortHandleHoverDataCollection>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHandleHoverData), typeof(GizmoHandleHoverData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F75")]
	public static bool op_Equality(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x545420", Offset = "0x544620", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F77")]
	public static bool op_GreaterThan(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x5453F0", Offset = "0x5445F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F78")]
	public static bool op_GreaterThanOrEqual(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x545450", Offset = "0x544650", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F76")]
	public static bool op_Inequality(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x5454B0", Offset = "0x5446B0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F79")]
	public static bool op_LessThan(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x545480", Offset = "0x544680", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F7A")]
	public static bool op_LessThanOrEqual(Priority firstPriority, Priority secondPriority) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6B")]
	public void set_Value(int value) { }

}

