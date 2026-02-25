namespace Unity.IntegerTime;

[NativeHeader("Runtime/Input/RationalTime.h")]
[Token(Token = "0x2000019")]
public struct RationalTime
{
	[Token(Token = "0x200001A")]
	internal struct TicksPerSecond : IEquatable<TicksPerSecond>
	{
		[Token(Token = "0x4000027")]
		public static readonly TicksPerSecond DefaultTicksPerSecond; //Field offset: 0x0
		[Token(Token = "0x4000028")]
		public static readonly TicksPerSecond TicksPerSecond24; //Field offset: 0x8
		[Token(Token = "0x4000029")]
		public static readonly TicksPerSecond TicksPerSecond25; //Field offset: 0x10
		[Token(Token = "0x400002A")]
		public static readonly TicksPerSecond TicksPerSecond30; //Field offset: 0x18
		[Token(Token = "0x400002B")]
		public static readonly TicksPerSecond TicksPerSecond50; //Field offset: 0x20
		[Token(Token = "0x400002C")]
		public static readonly TicksPerSecond TicksPerSecond60; //Field offset: 0x28
		[Token(Token = "0x400002D")]
		public static readonly TicksPerSecond TicksPerSecond120; //Field offset: 0x30
		[Token(Token = "0x400002E")]
		public static readonly TicksPerSecond TicksPerSecond2397; //Field offset: 0x38
		[Token(Token = "0x400002F")]
		public static readonly TicksPerSecond TicksPerSecond2425; //Field offset: 0x40
		[Token(Token = "0x4000030")]
		public static readonly TicksPerSecond TicksPerSecond2997; //Field offset: 0x48
		[Token(Token = "0x4000031")]
		public static readonly TicksPerSecond TicksPerSecond5994; //Field offset: 0x50
		[Token(Token = "0x4000032")]
		public static readonly TicksPerSecond TicksPerSecond11988; //Field offset: 0x58
		[Token(Token = "0x4000033")]
		internal static readonly TicksPerSecond DiscreteTimeRate; //Field offset: 0x60
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000025")]
		private uint m_Numerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x4000026")]
		private uint m_Denominator; //Field offset: 0x4

		[Address(RVA = "0x1941500", Offset = "0x1940700", Length = "0x2B2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TicksPerSecond), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000052")]
		private static TicksPerSecond() { }

		[Address(RVA = "0x19417C0", Offset = "0x19409C0", Length = "0xCE")]
		[CalledBy(Type = typeof(TicksPerSecond), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600004C")]
		public TicksPerSecond(uint num, uint den = 1) { }

		[Address(RVA = "0x19412E0", Offset = "0x19404E0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600004D")]
		public override bool Equals(TicksPerSecond rhs) { }

		[Address(RVA = "0x1941300", Offset = "0x1940500", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		[Token(Token = "0x600004E")]
		public virtual bool Equals(object rhs) { }

		[Address(RVA = "0x19413B0", Offset = "0x19405B0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000051")]
		private static uint Gcd(uint a, uint b) { }

		[Address(RVA = "0x19413E0", Offset = "0x19405E0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
		[IsReadOnly]
		[Token(Token = "0x600004F")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1941450", Offset = "0x1940650", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000050")]
		private static void Simplify(ref uint num, ref uint den) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private long m_Count; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private TicksPerSecond m_TicksPerSecond; //Field offset: 0x8

	[Token(Token = "0x17000006")]
	public long Count
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public long get_Count() { }

	[Address(RVA = "0x193A3F0", Offset = "0x19395F0", Length = "0xC0")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	public static DiscreteTime op_Explicit(RationalTime t) { }

}

