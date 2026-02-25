namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FF")]
internal abstract class EqualInstruction : Instruction
{
	[Token(Token = "0x2000100")]
	private sealed class EqualBoolean : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C1")]
		public EqualBoolean() { }

		[Address(RVA = "0x1597B10", Offset = "0x1596D10", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005C0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010D")]
	private sealed class EqualBooleanLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DB")]
		public EqualBooleanLiftedToNull() { }

		[Address(RVA = "0x1597A40", Offset = "0x1596C40", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005DA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000106")]
	private sealed class EqualByte : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CD")]
		public EqualByte() { }

		[Address(RVA = "0x1597CA0", Offset = "0x1596EA0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005CC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000113")]
	private sealed class EqualByteLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E7")]
		public EqualByteLiftedToNull() { }

		[Address(RVA = "0x1597BD0", Offset = "0x1596DD0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000103")]
	private sealed class EqualChar : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C7")]
		public EqualChar() { }

		[Address(RVA = "0x1597E30", Offset = "0x1597030", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005C6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000110")]
	private sealed class EqualCharLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E1")]
		public EqualCharLiftedToNull() { }

		[Address(RVA = "0x1597D60", Offset = "0x1596F60", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010B")]
	private sealed class EqualDouble : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D7")]
		public EqualDouble() { }

		[Address(RVA = "0x1597FD0", Offset = "0x15971D0", Length = "0xC9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005D6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000118")]
	private sealed class EqualDoubleLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F1")]
		public EqualDoubleLiftedToNull() { }

		[Address(RVA = "0x1597EF0", Offset = "0x15970F0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005F0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000102")]
	private sealed class EqualInt16 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C5")]
		public EqualInt16() { }

		[Address(RVA = "0x1598DA0", Offset = "0x1597FA0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005C4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010F")]
	private sealed class EqualInt16LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DF")]
		public EqualInt16LiftedToNull() { }

		[Address(RVA = "0x1598CD0", Offset = "0x1597ED0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005DE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000104")]
	private sealed class EqualInt32 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C9")]
		public EqualInt32() { }

		[Address(RVA = "0x1598F20", Offset = "0x1598120", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005C8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000111")]
	private sealed class EqualInt32LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E3")]
		public EqualInt32LiftedToNull() { }

		[Address(RVA = "0x1598E60", Offset = "0x1598060", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000105")]
	private sealed class EqualInt64 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CB")]
		public EqualInt64() { }

		[Address(RVA = "0x15990B0", Offset = "0x15982B0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005CA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000112")]
	private sealed class EqualInt64LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E5")]
		public EqualInt64LiftedToNull() { }

		[Address(RVA = "0x1598FE0", Offset = "0x15981E0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010C")]
	private sealed class EqualReference : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D9")]
		public EqualReference() { }

		[Address(RVA = "0x1599170", Offset = "0x1598370", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005D8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000101")]
	private sealed class EqualSByte : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C3")]
		public EqualSByte() { }

		[Address(RVA = "0x15992A0", Offset = "0x15984A0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005C2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010E")]
	private sealed class EqualSByteLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DD")]
		public EqualSByteLiftedToNull() { }

		[Address(RVA = "0x15991D0", Offset = "0x15983D0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005DC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010A")]
	private sealed class EqualSingle : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D5")]
		public EqualSingle() { }

		[Address(RVA = "0x1599440", Offset = "0x1598640", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005D4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000117")]
	private sealed class EqualSingleLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005EF")]
		public EqualSingleLiftedToNull() { }

		[Address(RVA = "0x1599360", Offset = "0x1598560", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005EE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000107")]
	private sealed class EqualUInt16 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CF")]
		public EqualUInt16() { }

		[Address(RVA = "0x15995E0", Offset = "0x15987E0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005CE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000114")]
	private sealed class EqualUInt16LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E9")]
		public EqualUInt16LiftedToNull() { }

		[Address(RVA = "0x1599510", Offset = "0x1598710", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000108")]
	private sealed class EqualUInt32 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D1")]
		public EqualUInt32() { }

		[Address(RVA = "0x1599760", Offset = "0x1598960", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005D0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000115")]
	private sealed class EqualUInt32LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005EB")]
		public EqualUInt32LiftedToNull() { }

		[Address(RVA = "0x15996A0", Offset = "0x15988A0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005EA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000109")]
	private sealed class EqualUInt64 : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D3")]
		public EqualUInt64() { }

		[Address(RVA = "0x15998F0", Offset = "0x1598AF0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005D2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000116")]
	private sealed class EqualUInt64LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005ED")]
		public EqualUInt64LiftedToNull() { }

		[Address(RVA = "0x1599820", Offset = "0x1598A20", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005EC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40001FB")]
	private static Instruction s_reference; //Field offset: 0x0
	[Token(Token = "0x40001FC")]
	private static Instruction s_Boolean; //Field offset: 0x8
	[Token(Token = "0x40001FD")]
	private static Instruction s_SByte; //Field offset: 0x10
	[Token(Token = "0x40001FE")]
	private static Instruction s_Int16; //Field offset: 0x18
	[Token(Token = "0x40001FF")]
	private static Instruction s_Char; //Field offset: 0x20
	[Token(Token = "0x4000200")]
	private static Instruction s_Int32; //Field offset: 0x28
	[Token(Token = "0x4000201")]
	private static Instruction s_Int64; //Field offset: 0x30
	[Token(Token = "0x4000202")]
	private static Instruction s_Byte; //Field offset: 0x38
	[Token(Token = "0x4000203")]
	private static Instruction s_UInt16; //Field offset: 0x40
	[Token(Token = "0x4000204")]
	private static Instruction s_UInt32; //Field offset: 0x48
	[Token(Token = "0x4000205")]
	private static Instruction s_UInt64; //Field offset: 0x50
	[Token(Token = "0x4000206")]
	private static Instruction s_Single; //Field offset: 0x58
	[Token(Token = "0x4000207")]
	private static Instruction s_Double; //Field offset: 0x60
	[Token(Token = "0x4000208")]
	private static Instruction s_BooleanLiftedToNull; //Field offset: 0x68
	[Token(Token = "0x4000209")]
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x70
	[Token(Token = "0x400020A")]
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x78
	[Token(Token = "0x400020B")]
	private static Instruction s_CharLiftedToNull; //Field offset: 0x80
	[Token(Token = "0x400020C")]
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x88
	[Token(Token = "0x400020D")]
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x90
	[Token(Token = "0x400020E")]
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x98
	[Token(Token = "0x400020F")]
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0xA0
	[Token(Token = "0x4000210")]
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0xA8
	[Token(Token = "0x4000211")]
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0xB0
	[Token(Token = "0x4000212")]
	private static Instruction s_SingleLiftedToNull; //Field offset: 0xB8
	[Token(Token = "0x4000213")]
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0xC0

	[Token(Token = "0x17000166")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000168")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1598CA0", Offset = "0x1597EA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60005BD")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000167")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BC")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BE")]
	private EqualInstruction() { }

	[Address(RVA = "0x15980A0", Offset = "0x15972A0", Length = "0x6E4")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181598C2B")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60005BF")]
	public static Instruction Create(Type type, bool liftedToNull) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BB")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x1598CA0", Offset = "0x1597EA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60005BD")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BC")]
	public virtual int get_ProducedStack() { }

}

