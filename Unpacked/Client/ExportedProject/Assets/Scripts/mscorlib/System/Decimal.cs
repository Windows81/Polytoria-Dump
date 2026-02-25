namespace System;

[IsReadOnly]
[Token(Token = "0x20001E3")]
public struct decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable
{
	[Token(Token = "0x20001E4")]
	private struct DecCalc
	{
		[Token(Token = "0x20001E7")]
		private struct Buf24
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000981")]
			public uint U0; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000987")]
			private ulong ulo64LE; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000982")]
			public uint U1; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000983")]
			public uint U2; //Field offset: 0x8
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000988")]
			private ulong umid64LE; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000984")]
			public uint U3; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000985")]
			public uint U4; //Field offset: 0x10
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000989")]
			private ulong uhigh64LE; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000986")]
			public uint U5; //Field offset: 0x14

			[Token(Token = "0x1700018D")]
			public ulong High64
			{
				[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				[Token(Token = "0x60010FA")]
				 set { } //Length: 5
			}

			[Token(Token = "0x1700018B")]
			public ulong Low64
			{
				[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
				[CallerCount(Count = 95)]
				[DeduplicatedMethod]
				[Token(Token = "0x60010F7")]
				 get { } //Length: 6
				[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x60010F8")]
				 set { } //Length: 4
			}

			[Token(Token = "0x1700018C")]
			public ulong Mid64
			{
				[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x60010F9")]
				 set { } //Length: 5
			}

			[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
			[CallerCount(Count = 95)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010F7")]
			public ulong get_Low64() { }

			[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010FA")]
			public void set_High64(ulong value) { }

			[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010F8")]
			public void set_Low64(ulong value) { }

			[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010F9")]
			public void set_Mid64(ulong value) { }

		}

		[Token(Token = "0x20001E6")]
		private struct PowerOvfl
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400097F")]
			public readonly uint Hi; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000980")]
			public readonly ulong MidLo; //Field offset: 0x8

			[Address(RVA = "0x1516230", Offset = "0x1515430", Length = "0x14")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60010F6")]
			public PowerOvfl(uint hi, uint mid, uint lo) { }

		}

		[Token(Token = "0x20001E5")]
		public enum RoundingMode
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4,
		}

		[Token(Token = "0x4000975")]
		private static readonly UInt32[] s_powers10; //Field offset: 0x0
		[Token(Token = "0x4000976")]
		private static readonly UInt64[] s_ulongPowers10; //Field offset: 0x8
		[Token(Token = "0x4000977")]
		private static readonly Double[] s_doublePowers10; //Field offset: 0x10
		[Token(Token = "0x4000978")]
		private static readonly PowerOvfl[] PowerOvflValues; //Field offset: 0x18
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000970")]
		private uint uflags; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000971")]
		private uint uhi; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000972")]
		private uint ulo; //Field offset: 0x8
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000974")]
		private ulong ulomidLE; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000973")]
		private uint umid; //Field offset: 0xC

		[Token(Token = "0x17000186")]
		private uint High
		{
			[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010D8")]
			private get { } //Length: 4
			[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010D9")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000189")]
		private bool IsNegative
		{
			[Address(RVA = "0x150E200", Offset = "0x150D400", Length = "0x6")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DE")]
			private get { } //Length: 6
		}

		[Token(Token = "0x17000187")]
		private uint Low
		{
			[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DA")]
			private get { } //Length: 4
			[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DB")]
			private set { } //Length: 4
		}

		[Token(Token = "0x1700018A")]
		private ulong Low64
		{
			[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
			[CallerCount(Count = 25)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DF")]
			private get { } //Length: 7
			[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010E0")]
			private set { } //Length: 5
		}

		[Token(Token = "0x17000188")]
		private uint Mid
		{
			[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DC")]
			private get { } //Length: 4
			[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010DD")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x150DEF0", Offset = "0x150D0F0", Length = "0x307")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60010F5")]
		private static DecCalc() { }

		[Address(RVA = "0x150B490", Offset = "0x150A690", Length = "0x72E")]
		[CalledBy(Type = typeof(Decimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "ScaleResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf24*), typeof(uint), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010EA")]
		internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign) { }

		[Address(RVA = "0x150BBC0", Offset = "0x150ADC0", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010F4")]
		internal static uint DecDivMod1E9(ref DecCalc value) { }

		[Address(RVA = "0x150BC40", Offset = "0x150AE40", Length = "0x59")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010E5")]
		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

		[Address(RVA = "0x150BCA0", Offset = "0x150AEA0", Length = "0x72")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010E8")]
		private static uint DivByConst(UInt32* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D8")]
		private uint get_High() { }

		[Address(RVA = "0x150E200", Offset = "0x150D400", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DE")]
		private bool get_IsNegative() { }

		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DA")]
		private uint get_Low() { }

		[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DF")]
		private ulong get_Low64() { }

		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DC")]
		private uint get_Mid() { }

		[Address(RVA = "0x150BD30", Offset = "0x150AF30", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010E1")]
		private static uint GetExponent(float f) { }

		[Address(RVA = "0x150BD20", Offset = "0x150AF20", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010E2")]
		private static uint GetExponent(double d) { }

		[Address(RVA = "0x150BD40", Offset = "0x150AF40", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815083F0")]
		[Token(Token = "0x60010F2")]
		internal static int GetHashCode(in decimal d) { }

		[Address(RVA = "0x150BE90", Offset = "0x150B090", Length = "0x309")]
		[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010F3")]
		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode) { }

		[Address(RVA = "0x150C1A0", Offset = "0x150B3A0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010E9")]
		private static int LeadingZeroCount(uint value) { }

		[Address(RVA = "0x150C200", Offset = "0x150B400", Length = "0x7B8")]
		[CalledBy(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010E7")]
		private static int ScaleResult(Buf24* bufRes, uint hiRes, int scale) { }

		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D9")]
		private void set_High(uint value) { }

		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DB")]
		private void set_Low(uint value) { }

		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E0")]
		private void set_Low64(ulong value) { }

		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DD")]
		private void set_Mid(uint value) { }

		[Address(RVA = "0x145EAF0", Offset = "0x145DCF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E3")]
		private static ulong UInt32x32To64(uint a, uint b) { }

		[Address(RVA = "0x150C9E0", Offset = "0x150BBE0", Length = "0x161")]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecFromR4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecFromR8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60010E4")]
		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result) { }

		[Address(RVA = "0x150CB50", Offset = "0x150BD50", Length = "0x1FF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010E6")]
		private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

		[Address(RVA = "0x150CF60", Offset = "0x150C160", Length = "0x10C")]
		[CalledBy(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "VarDecCmpSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
		[Token(Token = "0x60010EB")]
		internal static int VarDecCmp(in decimal d1, in decimal d2) { }

		[Address(RVA = "0x150CD50", Offset = "0x150BF50", Length = "0x209")]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010EC")]
		private static int VarDecCmpSub(in decimal d1, in decimal d2) { }

		[Address(RVA = "0x150D070", Offset = "0x150C270", Length = "0x3FA")]
		[CalledBy(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "UInt64x64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010EE")]
		internal static void VarDecFromR4(float input, out DecCalc result) { }

		[Address(RVA = "0x150D470", Offset = "0x150C670", Length = "0x3E8")]
		[CalledBy(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "UInt64x64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010EF")]
		internal static void VarDecFromR8(double input, out DecCalc result) { }

		[Address(RVA = "0x150D860", Offset = "0x150CA60", Length = "0x523")]
		[CalledBy(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "ScaleResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf24*), typeof(uint), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010ED")]
		internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2) { }

		[Address(RVA = "0x150DD90", Offset = "0x150CF90", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010F0")]
		internal static float VarR4FromDec(in decimal value) { }

		[Address(RVA = "0x150DDE0", Offset = "0x150CFE0", Length = "0x10F")]
		[CalledBy(Type = typeof(DecCalc), Member = "VarR4FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
		[CalledBy(Type = typeof(Decimal), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010F1")]
		internal static double VarR8FromDec(in decimal value) { }

	}

	[DecimalConstant(0, 0, 0, 0, 0)]
	[Token(Token = "0x4000966")]
	public static readonly decimal Zero; //Field offset: 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	[Token(Token = "0x4000967")]
	public static readonly decimal One; //Field offset: 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	[Token(Token = "0x4000968")]
	public static readonly decimal MinusOne; //Field offset: 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	[Token(Token = "0x4000969")]
	public static readonly decimal MaxValue; //Field offset: 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	[Token(Token = "0x400096A")]
	public static readonly decimal MinValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096B")]
	private readonly int flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400096C")]
	private readonly int hi; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096D")]
	private readonly int lo; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096F")]
	private readonly ulong ulomidLE; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400096E")]
	private readonly int mid; //Field offset: 0xC

	[Token(Token = "0x17000180")]
	internal uint High
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001080")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000183")]
	internal bool IsNegative
	{
		[Address(RVA = "0x150E200", Offset = "0x150D400", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001083")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000181")]
	internal uint Low
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001081")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000185")]
	private ulong Low64
	{
		[Address(RVA = "0x1510560", Offset = "0x150F760", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001085")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000182")]
	internal uint Mid
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001082")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000184")]
	internal int Scale
	{
		[Address(RVA = "0x15105A0", Offset = "0x150F7A0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001084")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x15100F0", Offset = "0x150F2F0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60010D7")]
	private static Decimal() { }

	[Address(RVA = "0x15102B0", Offset = "0x150F4B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001092")]
	private Decimal(in decimal d, int flags) { }

	[Address(RVA = "0x1510270", Offset = "0x150F470", Length = "0x21")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_int", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_short", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_byte", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedShort", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedByte", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6001088")]
	public Decimal(int value) { }

	[Address(RVA = "0x15101E0", Offset = "0x150F3E0", Length = "0xC")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedInt", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6001089")]
	public Decimal(uint value) { }

	[Address(RVA = "0x1510360", Offset = "0x150F560", Length = "0x2E")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_long", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x600108A")]
	public Decimal(long value) { }

	[Address(RVA = "0x15102A0", Offset = "0x150F4A0", Length = "0x10")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[Token(Token = "0x600108B")]
	public Decimal(ulong value) { }

	[Address(RVA = "0x15104E0", Offset = "0x150F6E0", Length = "0x7B")]
	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecFromR4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(DecCalc&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600108C")]
	public Decimal(float value) { }

	[Address(RVA = "0x15101F0", Offset = "0x150F3F0", Length = "0x7B")]
	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecFromR8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(DecCalc&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600108D")]
	public Decimal(double value) { }

	[Address(RVA = "0x15102C0", Offset = "0x150F4C0", Length = "0x9E")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_positiveInteger", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "NumberBufferToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecimalConstantAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_decimal", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_nonPositiveInteger", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_negativeInteger", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_nonNegativeInteger", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaContentProcessing"}, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6001090")]
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[Address(RVA = "0x1510390", Offset = "0x150F590", Length = "0x143")]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryReader), Member = "ReadDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600108F")]
	public Decimal(Int32[] bits) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001086")]
	private static DecCalc AsMutable(ref decimal d) { }

	[Address(RVA = "0x150E320", Offset = "0x150D520", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6001094")]
	public override int CompareTo(decimal value) { }

	[Address(RVA = "0x150E220", Offset = "0x150D420", Length = "0xFD")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_decimal", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001093")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x150E380", Offset = "0x150D580", Length = "0xD7")]
	[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001087")]
	internal static uint DecDivMod1E9(ref decimal value) { }

	[Address(RVA = "0x150E460", Offset = "0x150D660", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001096")]
	public override bool Equals(decimal value) { }

	[Address(RVA = "0x150E4C0", Offset = "0x150D6C0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001095")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001080")]
	internal uint get_High() { }

	[Address(RVA = "0x150E200", Offset = "0x150D400", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001083")]
	internal bool get_IsNegative() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001081")]
	internal uint get_Low() { }

	[Address(RVA = "0x1510560", Offset = "0x150F760", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001085")]
	private ulong get_Low64() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001082")]
	internal uint get_Mid() { }

	[Address(RVA = "0x15105A0", Offset = "0x150F7A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001084")]
	internal int get_Scale() { }

	[Address(RVA = "0x150E580", Offset = "0x150D780", Length = "0x81")]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600109F")]
	public static Int32[] GetBits(decimal d) { }

	[Address(RVA = "0x150E610", Offset = "0x150D810", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815083F0")]
	[Token(Token = "0x6001097")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x150E790", Offset = "0x150D990", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C7")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x150E7A0", Offset = "0x150D9A0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600108E")]
	private static bool IsValid(int flags) { }

	[Address(RVA = "0x150E7C0", Offset = "0x150D9C0", Length = "0x13")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60010A0")]
	public static decimal Negate(decimal d) { }

	[Address(RVA = "0x15105B0", Offset = "0x150F7B0", Length = "0x94")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010BE")]
	public static decimal op_Addition(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510650", Offset = "0x150F850", Length = "0x5F")]
	[CalledBy(Type = "System.Xml.Schema.SequenceNode", Member = "get_IsNullable", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(ArrayList), "System.Xml.Schema.XmlValueConverter"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaContentProcessing"}, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C1")]
	public static bool op_Equality(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510840", Offset = "0x150FA40", Length = "0x20")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Half", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half"}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010B7")]
	public static decimal op_Explicit(float value) { }

	[Address(RVA = "0x1510A80", Offset = "0x150FC80", Length = "0x20")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010B8")]
	public static decimal op_Explicit(double value) { }

	[Address(RVA = "0x1510AA0", Offset = "0x150FCA0", Length = "0x54")]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010B9")]
	public static int op_Explicit(decimal value) { }

	[Address(RVA = "0x15106B0", Offset = "0x150F8B0", Length = "0x18D")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "UnboxToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010BA")]
	public static long op_Explicit(decimal value) { }

	[Address(RVA = "0x1510860", Offset = "0x150FA60", Length = "0x185")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "ToUnsigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010BB")]
	public static ulong op_Explicit(decimal value) { }

	[Address(RVA = "0x1510B00", Offset = "0x150FD00", Length = "0xBA")]
	[CalledBy(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Half", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = "System.Half")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010BC")]
	public static float op_Explicit(decimal value) { }

	[Address(RVA = "0x15109F0", Offset = "0x150FBF0", Length = "0x85")]
	[CalledBy(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[Token(Token = "0x60010BD")]
	public static double op_Explicit(decimal value) { }

	[Address(RVA = "0x1510C20", Offset = "0x150FE20", Length = "0x5F")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "IsPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C5")]
	public static bool op_GreaterThan(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510BC0", Offset = "0x150FDC0", Length = "0x5F")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "IsPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010C6")]
	public static bool op_GreaterThanOrEqual(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510CC0", Offset = "0x150FEC0", Length = "0x13")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlNameTable", "System.Xml.IXmlNamespaceResolver", typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), "System.Xml.IXmlNamespaceResolver"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), "System.Xml.IXmlNamespaceResolver"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B6")]
	public static decimal op_Implicit(ulong value) { }

	[Address(RVA = "0x1510C80", Offset = "0x150FE80", Length = "0x31")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x60010B5")]
	public static decimal op_Implicit(long value) { }

	[Address(RVA = "0x1510D40", Offset = "0x150FF40", Length = "0x24")]
	[CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x60010B3")]
	public static decimal op_Implicit(int value) { }

	[Address(RVA = "0x1510CF0", Offset = "0x150FEF0", Length = "0x14")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B2")]
	public static decimal op_Implicit(ushort value) { }

	[Address(RVA = "0x1510D70", Offset = "0x150FF70", Length = "0x2D")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60010B1")]
	public static decimal op_Implicit(short value) { }

	[Address(RVA = "0x1510D10", Offset = "0x150FF10", Length = "0x2C")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B0")]
	public static decimal op_Implicit(sbyte value) { }

	[Address(RVA = "0x1510DA0", Offset = "0x150FFA0", Length = "0x14")]
	[CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60010AF")]
	public static decimal op_Implicit(byte value) { }

	[Address(RVA = "0x1510CE0", Offset = "0x150FEE0", Length = "0xF")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B4")]
	public static decimal op_Implicit(uint value) { }

	[Address(RVA = "0x1510DC0", Offset = "0x150FFC0", Length = "0x5F")]
	[CalledBy(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.BitSet", "System.Xml.Schema.BitSet[]", "System.Xml.Schema.BitSet&"}, ReturnType = "System.Xml.Schema.BitSet[]")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaContentProcessing"}, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C2")]
	public static bool op_Inequality(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510E80", Offset = "0x1510080", Length = "0x5D")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaContentProcessing"}, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010C3")]
	public static bool op_LessThan(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510E20", Offset = "0x1510020", Length = "0x5F")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C4")]
	public static bool op_LessThanOrEqual(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510EE0", Offset = "0x15100E0", Length = "0x91")]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarDecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010C0")]
	public static decimal op_Multiply(decimal d1, decimal d2) { }

	[Address(RVA = "0x1510F80", Offset = "0x1510180", Length = "0x94")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010BF")]
	public static decimal op_Subtraction(decimal d1, decimal d2) { }

	[Address(RVA = "0x150E900", Offset = "0x150DB00", Length = "0xFA")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x600109C")]
	public static decimal Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x150E7E0", Offset = "0x150D9E0", Length = "0x111")]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x600109D")]
	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x150EA00", Offset = "0x150DC00", Length = "0x14D")]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "UnboxToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(long))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010A1")]
	public static decimal Round(decimal d, int decimals) { }

	[Address(RVA = "0x150EB50", Offset = "0x150DD50", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010A2")]
	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode) { }

	[Address(RVA = "0x150ED10", Offset = "0x150DF10", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60010C8")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x150ED70", Offset = "0x150DF70", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[Token(Token = "0x60010CB")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x150EDD0", Offset = "0x150DFD0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010C9")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x150EE60", Offset = "0x150E060", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010D5")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D4")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x150EEF0", Offset = "0x150E0F0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[Token(Token = "0x60010D3")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x150EF50", Offset = "0x150E150", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[Token(Token = "0x60010CC")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x150EFB0", Offset = "0x150E1B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010CE")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x150F010", Offset = "0x150E210", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Token(Token = "0x60010D0")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x150F070", Offset = "0x150E270", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x60010CA")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x150F0D0", Offset = "0x150E2D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	[Token(Token = "0x60010D2")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x150F130", Offset = "0x150E330", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x60010D6")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x150F1D0", Offset = "0x150E3D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x60010CD")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x150F230", Offset = "0x150E430", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60010CF")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x150F290", Offset = "0x150E490", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60010D1")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x150F2F0", Offset = "0x150E4F0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001091")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x150F3A0", Offset = "0x150E5A0", Length = "0x10E")]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010A3")]
	public static byte ToByte(decimal value) { }

	[Address(RVA = "0x150F4B0", Offset = "0x150E6B0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[Token(Token = "0x60010A6")]
	public static double ToDouble(decimal d) { }

	[Address(RVA = "0x150F500", Offset = "0x150E700", Length = "0x10E")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010A5")]
	public static short ToInt16(decimal value) { }

	[Address(RVA = "0x150F610", Offset = "0x150E810", Length = "0xCC")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Decimal), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815085F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010A7")]
	public static int ToInt32(decimal d) { }

	[Address(RVA = "0x150F6E0", Offset = "0x150E8E0", Length = "0xDF")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815085F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010A8")]
	public static long ToInt64(decimal d) { }

	[Address(RVA = "0x150F7C0", Offset = "0x150E9C0", Length = "0x10E")]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x60010A4")]
	public static sbyte ToSByte(decimal value) { }

	[Address(RVA = "0x150F8D0", Offset = "0x150EAD0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010AC")]
	public static float ToSingle(decimal d) { }

	[Address(RVA = "0x150FAF0", Offset = "0x150ECF0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001098")]
	public virtual string ToString() { }

	[Address(RVA = "0x150F950", Offset = "0x150EB50", Length = "0xAB")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001099")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x150FA00", Offset = "0x150EC00", Length = "0xE7")]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x600109A")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x150FB90", Offset = "0x150ED90", Length = "0x10E")]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x60010A9")]
	public static ushort ToUInt16(decimal value) { }

	[Address(RVA = "0x150FCA0", Offset = "0x150EEA0", Length = "0xBA")]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Decimal), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815085F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010AA")]
	public static uint ToUInt32(decimal d) { }

	[Address(RVA = "0x150FD60", Offset = "0x150EF60", Length = "0xD7")]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815085F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010AB")]
	public static ulong ToUInt64(decimal d) { }

	[Address(RVA = "0x150FE40", Offset = "0x150F040", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010AE")]
	private static void Truncate(ref decimal d) { }

	[Address(RVA = "0x150FED0", Offset = "0x150F0D0", Length = "0x5F")]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaContentProcessing"}, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815085F0")]
	[Token(Token = "0x60010AD")]
	public static decimal Truncate(decimal d) { }

	[Address(RVA = "0x150FF30", Offset = "0x150F130", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600109B")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x1510000", Offset = "0x150F200", Length = "0xEE")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600109E")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) { }

}

