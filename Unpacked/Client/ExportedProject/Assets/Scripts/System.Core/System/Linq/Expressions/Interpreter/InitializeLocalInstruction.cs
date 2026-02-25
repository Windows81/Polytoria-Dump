namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000198")]
internal abstract class InitializeLocalInstruction : LocalAccessInstruction
{
	[Token(Token = "0x200019B")]
	public sealed class ImmutableBox : InitializeLocalInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400031F")]
		private readonly object _defaultValue; //Field offset: 0x18

		[Token(Token = "0x170001BD")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15D41F0", Offset = "0x15D33F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600089D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x15D41B0", Offset = "0x15D33B0", Length = "0x40")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600089B")]
		internal ImmutableBox(int index, object defaultValue) { }

		[Address(RVA = "0x15D41F0", Offset = "0x15D33F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600089D")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15D40C0", Offset = "0x15D32C0", Length = "0xE1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600089C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200019C")]
	public sealed class ImmutableRefBox : InitializeLocalInstruction
	{

		[Token(Token = "0x170001BE")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15D4300", Offset = "0x15D3500", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60008A0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600089E")]
		internal ImmutableRefBox(int index) { }

		[Address(RVA = "0x15D4300", Offset = "0x15D3500", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60008A0")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15D4220", Offset = "0x15D3420", Length = "0xD0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600089F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200019A")]
	public sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400031E")]
		private readonly object _defaultValue; //Field offset: 0x18

		[Token(Token = "0x170001BC")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15D4450", Offset = "0x15D3650", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600089A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x15D41B0", Offset = "0x15D33B0", Length = "0x40")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000897")]
		internal ImmutableValue(int index, object defaultValue) { }

		[Address(RVA = "0x15D4330", Offset = "0x15D3530", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000899")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x15D4450", Offset = "0x15D3650", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600089A")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15D43C0", Offset = "0x15D35C0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000898")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001A0")]
	public sealed class MutableBox : InitializeLocalInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000321")]
		private readonly Type _type; //Field offset: 0x18

		[Token(Token = "0x170001C2")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15DB080", Offset = "0x15DA280", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60008AE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x15D41B0", Offset = "0x15D33B0", Length = "0x40")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AC")]
		internal MutableBox(int index, Type type) { }

		[Address(RVA = "0x15DB080", Offset = "0x15DA280", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60008AE")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15DAF40", Offset = "0x15DA140", Length = "0x133")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008AD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200019F")]
	public sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000320")]
		private readonly Type _type; //Field offset: 0x18

		[Token(Token = "0x170001C1")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15DB220", Offset = "0x15DA420", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60008AB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x15D41B0", Offset = "0x15D33B0", Length = "0x40")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A8")]
		internal MutableValue(int index, Type type) { }

		[Address(RVA = "0x15DB0B0", Offset = "0x15DA2B0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008AA")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x15DB220", Offset = "0x15DA420", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60008AB")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15DB140", Offset = "0x15DA340", Length = "0xDD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
		[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60008A9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200019E")]
	public sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
	{

		[Token(Token = "0x170001C0")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15E07D0", Offset = "0x15DF9D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60008A7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A4")]
		internal Parameter(int index) { }

		[Address(RVA = "0x15E0760", Offset = "0x15DF960", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InstructionList), Member = "ParameterBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		[Token(Token = "0x60008A6")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x15E07D0", Offset = "0x15DF9D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60008A7")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200019D")]
	public sealed class ParameterBox : InitializeLocalInstruction
	{

		[Token(Token = "0x170001BF")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15E0530", Offset = "0x15DF730", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60008A3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A1")]
		public ParameterBox(int index) { }

		[Address(RVA = "0x15E0530", Offset = "0x15DF730", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60008A3")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15E0430", Offset = "0x15DF630", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008A2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000199")]
	public sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
	{

		[Token(Token = "0x170001BB")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x15E2AA0", Offset = "0x15E1CA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000896")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000893")]
		internal Reference(int index) { }

		[Address(RVA = "0x15E29E0", Offset = "0x15E1BE0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InstructionList), Member = "InitImmutableRefBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		[Token(Token = "0x6000895")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x15E2AA0", Offset = "0x15E1CA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000896")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x15E2A50", Offset = "0x15E1C50", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000894")]
		public virtual int Run(InterpretedFrame frame) { }

	}


	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000892")]
	internal InitializeLocalInstruction(int index) { }

}

