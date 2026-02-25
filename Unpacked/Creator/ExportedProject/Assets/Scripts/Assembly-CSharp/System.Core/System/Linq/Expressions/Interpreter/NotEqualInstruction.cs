namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001CB")]
internal abstract class NotEqualInstruction : Instruction
{
	[Token(Token = "0x20001CC")]
	private sealed class NotEqualBoolean : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092C")]
		public NotEqualBoolean() { }

		[Address(RVA = "0x15DC4E0", Offset = "0x15DB6E0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600092B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D2")]
	private sealed class NotEqualByte : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000938")]
		public NotEqualByte() { }

		[Address(RVA = "0x15DC670", Offset = "0x15DB870", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000937")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DE")]
	private sealed class NotEqualByteLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000950")]
		public NotEqualByteLiftedToNull() { }

		[Address(RVA = "0x15DC5A0", Offset = "0x15DB7A0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600094F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CF")]
	private sealed class NotEqualChar : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000932")]
		public NotEqualChar() { }

		[Address(RVA = "0x15DC800", Offset = "0x15DBA00", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000931")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DB")]
	private sealed class NotEqualCharLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094A")]
		public NotEqualCharLiftedToNull() { }

		[Address(RVA = "0x15DC730", Offset = "0x15DB930", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000949")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D7")]
	private sealed class NotEqualDouble : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000942")]
		public NotEqualDouble() { }

		[Address(RVA = "0x15DC9A0", Offset = "0x15DBBA0", Length = "0xC9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000941")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E3")]
	private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600095A")]
		public NotEqualDoubleLiftedToNull() { }

		[Address(RVA = "0x15DC8C0", Offset = "0x15DBAC0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000959")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CE")]
	private sealed class NotEqualInt16 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000930")]
		public NotEqualInt16() { }

		[Address(RVA = "0x15DD820", Offset = "0x15DCA20", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600092F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DA")]
	private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000948")]
		public NotEqualInt16LiftedToNull() { }

		[Address(RVA = "0x15DD750", Offset = "0x15DC950", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000947")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D0")]
	private sealed class NotEqualInt32 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000934")]
		public NotEqualInt32() { }

		[Address(RVA = "0x15DD9A0", Offset = "0x15DCBA0", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000933")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DC")]
	private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094C")]
		public NotEqualInt32LiftedToNull() { }

		[Address(RVA = "0x15DD8E0", Offset = "0x15DCAE0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600094B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D1")]
	private sealed class NotEqualInt64 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000936")]
		public NotEqualInt64() { }

		[Address(RVA = "0x15DDB30", Offset = "0x15DCD30", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000935")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DD")]
	private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094E")]
		public NotEqualInt64LiftedToNull() { }

		[Address(RVA = "0x15DDA60", Offset = "0x15DCC60", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600094D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D8")]
	private sealed class NotEqualReference : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000944")]
		public NotEqualReference() { }

		[Address(RVA = "0x15DDBF0", Offset = "0x15DCDF0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000943")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CD")]
	private sealed class NotEqualSByte : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092E")]
		public NotEqualSByte() { }

		[Address(RVA = "0x15DDD20", Offset = "0x15DCF20", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600092D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D9")]
	private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000946")]
		public NotEqualSByteLiftedToNull() { }

		[Address(RVA = "0x15DDC50", Offset = "0x15DCE50", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000945")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D6")]
	private sealed class NotEqualSingle : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000940")]
		public NotEqualSingle() { }

		[Address(RVA = "0x15DDEC0", Offset = "0x15DD0C0", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600093F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E2")]
	private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000958")]
		public NotEqualSingleLiftedToNull() { }

		[Address(RVA = "0x15DDDE0", Offset = "0x15DCFE0", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000957")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D3")]
	private sealed class NotEqualUInt16 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600093A")]
		public NotEqualUInt16() { }

		[Address(RVA = "0x15DE060", Offset = "0x15DD260", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000939")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DF")]
	private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000952")]
		public NotEqualUInt16LiftedToNull() { }

		[Address(RVA = "0x15DDF90", Offset = "0x15DD190", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000951")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D4")]
	private sealed class NotEqualUInt32 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600093C")]
		public NotEqualUInt32() { }

		[Address(RVA = "0x15DE1E0", Offset = "0x15DD3E0", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600093B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E0")]
	private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000954")]
		public NotEqualUInt32LiftedToNull() { }

		[Address(RVA = "0x15DE120", Offset = "0x15DD320", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000953")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D5")]
	private sealed class NotEqualUInt64 : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600093E")]
		public NotEqualUInt64() { }

		[Address(RVA = "0x15DE370", Offset = "0x15DD570", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600093D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E1")]
	private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000956")]
		public NotEqualUInt64LiftedToNull() { }

		[Address(RVA = "0x15DE2A0", Offset = "0x15DD4A0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000955")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000351")]
	private static Instruction s_reference; //Field offset: 0x0
	[Token(Token = "0x4000352")]
	private static Instruction s_Boolean; //Field offset: 0x8
	[Token(Token = "0x4000353")]
	private static Instruction s_SByte; //Field offset: 0x10
	[Token(Token = "0x4000354")]
	private static Instruction s_Int16; //Field offset: 0x18
	[Token(Token = "0x4000355")]
	private static Instruction s_Char; //Field offset: 0x20
	[Token(Token = "0x4000356")]
	private static Instruction s_Int32; //Field offset: 0x28
	[Token(Token = "0x4000357")]
	private static Instruction s_Int64; //Field offset: 0x30
	[Token(Token = "0x4000358")]
	private static Instruction s_Byte; //Field offset: 0x38
	[Token(Token = "0x4000359")]
	private static Instruction s_UInt16; //Field offset: 0x40
	[Token(Token = "0x400035A")]
	private static Instruction s_UInt32; //Field offset: 0x48
	[Token(Token = "0x400035B")]
	private static Instruction s_UInt64; //Field offset: 0x50
	[Token(Token = "0x400035C")]
	private static Instruction s_Single; //Field offset: 0x58
	[Token(Token = "0x400035D")]
	private static Instruction s_Double; //Field offset: 0x60
	[Token(Token = "0x400035E")]
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x68
	[Token(Token = "0x400035F")]
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x70
	[Token(Token = "0x4000360")]
	private static Instruction s_CharLiftedToNull; //Field offset: 0x78
	[Token(Token = "0x4000361")]
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x80
	[Token(Token = "0x4000362")]
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x88
	[Token(Token = "0x4000363")]
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x90
	[Token(Token = "0x4000364")]
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0x98
	[Token(Token = "0x4000365")]
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0xA0
	[Token(Token = "0x4000366")]
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0xA8
	[Token(Token = "0x4000367")]
	private static Instruction s_SingleLiftedToNull; //Field offset: 0xB0
	[Token(Token = "0x4000368")]
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0xB8

	[Token(Token = "0x170001DF")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000926")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001E1")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15DD720", Offset = "0x15DC920", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000928")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001E0")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000927")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000929")]
	private NotEqualInstruction() { }

	[Address(RVA = "0x15DCA70", Offset = "0x15DBC70", Length = "0xC50")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ExclusiveOrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600092A")]
	public static Instruction Create(Type type, bool liftedToNull) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000926")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15DD720", Offset = "0x15DC920", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000928")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000927")]
	public virtual int get_ProducedStack() { }

}

